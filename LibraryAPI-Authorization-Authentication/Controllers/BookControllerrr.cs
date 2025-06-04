using LibraryAPI.Data;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace LibraryAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BooksControllerrr : ControllerBase
    {
        private readonly LibraryContext _context;

        public BooksControllerrr(LibraryContext context)
        {
            _context = context;
        }

        // GET: api/Books
        // Allow Users, Library, and Admin roles to view books
        [HttpGet]
        [Authorize(Roles = "User,Librarian,Admin")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await _context.Books.ToListAsync();
        }

        // GET: api/Books/5
        // Allow Users, Library, and Admin roles to view a book
        [HttpGet("{id}")]
        [Authorize(Roles = "User,Librarian,Admin")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }

        // POST: api/Books
        // Only Library role can add new books
        [HttpPost]
        [Authorize(Roles = "Librarian")]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }

        // PUT: api/Books/5
        // Only Library role can update books
        [HttpPut("{id}")]
        [Authorize(Roles = "Librarian")]
        public async Task<IActionResult> PutBook(int id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // PATCH: api/Books/5
        // Only Library role can partially update books
        [HttpPatch("{id}")]
        [Authorize(Roles = "Librarian")]
        public async Task<IActionResult> PatchBook(int id, [FromBody] BookUpdateRequest updateRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            try
            {
                switch (updateRequest.Field.ToLower())
                {
                    case "title":
                        try
                        {
                            book.Title = Convert.ToString(updateRequest.Value) ?? string.Empty;
                        }
                        catch
                        {
                            return BadRequest("Value for 'title' must be a string.");
                        }
                        break;
                    case "author":
                        try
                        {
                            book.Author = Convert.ToString(updateRequest.Value) ?? string.Empty;
                        }
                        catch
                        {
                            return BadRequest("Value for 'author' must be a string.");
                        }
                        break;
                    case "publicationyear":
                        try
                        {
                            book.PublicationYear = Convert.ToInt32(updateRequest.Value);
                        }
                        catch
                        {
                            return BadRequest("Value for 'publicationYear' must be an integer.");
                        }
                        break;
                    case "isbn":
                        try
                        {
                            book.ISBN = Convert.ToString(updateRequest.Value) ?? string.Empty;
                        }
                        catch
                        {
                            return BadRequest("Value for 'isbn' must be a string.");
                        }
                        break;
                    default:
                        return BadRequest("Invalid field name.");
                }

                TryValidateModel(book);

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // DELETE: api/Books/5
        // Only Admin role can delete books
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.Id == id);
        }
    }
}
