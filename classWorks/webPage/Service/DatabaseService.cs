using Microsoft.Win32;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webPage.Models;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace webPage.Service
{
    public class DatabaseService
    {
        private readonly string _connectionString;
        public DatabaseService() {
            this._connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=root;Database=dotNetLab";
        }

        public string load_register(RegisterForm register)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    using (var cmd = new NpgsqlCommand(
                        @"INSERT INTO register (name, age, gender, province, district)
                        VALUES (@name, @age, @gender, @province, @district)", connection))
                    {
                        cmd.Parameters.AddWithValue("@name", register.Name ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@age", register.Age ?? (object)DBNull.Value);
                        //cmd.Parameters.AddWithValue("@gender", register.Gender ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@province", register.Province ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@district", register.District ?? (object)DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "Registration successful.";
            }
            catch (NpgsqlException ex)
            {
                return $"Database error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.Message}";
            }

        }

        public IReadOnlyList<RegisterForm> getAllUsers()
        {
            List<RegisterForm> registedUser = new List<RegisterForm>();

            NpgsqlConnection conn = new NpgsqlConnection(_connectionString);

            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from \"register\"";
            NpgsqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                RegisterForm register = new RegisterForm()
                {
                    Name = dr["name"].ToString(),
                    //Gender = dr["gender"].ToString(),
                    Province = dr["province"].ToString()                    
                };
                registedUser.Add(register);
            }
            comm.Dispose();
            conn.Close();

            return registedUser;
        }

        //public string AddNewUser(UserInfo userInfo )
        //{
        //    try
        //    {
        //        using (var connection = new NpgsqlConnection(_connectionString))
        //        {
        //            connection.Open();
        //            using (var cmd = new NpgsqlCommand(
        //                @"INSERT INTO users (usr_id, usr_name, usr_ph_no,usr_email) VALUES (@id, @name, @contactNo, @email)", connection))
        //            {
        //                cmd.Parameters.AddWithValue("@id", userInfo.Id);
        //                cmd.Parameters.AddWithValue("@name", userInfo.Name);
        //                cmd.Parameters.AddWithValue("@contactNo", userInfo.ContactNo);
        //                cmd.Parameters.AddWithValue("@email", userInfo.Email);
        //                cmd.ExecuteNonQuery();
        //            }
        //        }
        //        return "User added successfully.";
        //    }
        //    catch (NpgsqlException ex)
        //    {
        //        return $"Database error: {ex.Message}";
        //    }
        //    catch (Exception ex)
        //    {
        //        return $"An error occurred: {ex.Message}";
        //    }
        //}

        //public IReadOnlyList<UserInfo> getUsers()
        //{
        //    List<UserInfo> users = new List<UserInfo>();
        //    NpgsqlConnection conn = new NpgsqlConnection(_connectionString);
        //    conn.Open();
        //    NpgsqlCommand comm = new NpgsqlCommand();
        //    comm.Connection = conn;
        //    comm.CommandType = CommandType.Text;
        //    comm.CommandText = "select * from \"users\"";
        //    NpgsqlDataReader dr = comm.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        UserInfo user = new UserInfo()
        //        {
        //            Id = Convert.ToInt32(dr["usr_id"]),
        //            Name = dr["usr_name"].ToString(),
        //            ContactNo = Convert.ToInt32(dr["usr_ph_no"]),
        //            Email = dr["usr_email"].ToString()
        //        };
        //        users.Add(user);
        //    }
        //    comm.Dispose();
        //    conn.Close();
        //    return users;
        //}

        //public IReadOnlyList<UserInfo> getUserById(int id)
        //{
        //    List<UserInfo> users = new List<UserInfo>();
        //    NpgsqlConnection conn = new NpgsqlConnection(_connectionString);
        //    conn.Open();
        //    NpgsqlCommand comm = new NpgsqlCommand();
        //    comm.Parameters.AddWithValue("@id", id);
        //    comm.Connection = conn;
        //    comm.CommandType = CommandType.Text;
        //    comm.CommandText = "select * from \"users\" where @id=0 or usr_id=@id";
        //    NpgsqlDataReader dr = comm.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        UserInfo user = new UserInfo()
        //        {
        //            Id = Convert.ToInt32(dr["usr_id"]),
        //            Name = dr["usr_name"].ToString(),
        //            ContactNo = Convert.ToInt32(dr["usr_ph_no"]),
        //            Email = dr["usr_email"].ToString()
        //        };
        //        users.Add(user);
        //    }
        //    comm.Dispose();
        //    conn.Close();
        //    return users;
        //}

        //public string UpdateUser(UserInfo userInfo)
        //{
        //    if (userInfo == null) {
        //        return "User information cannot be null.";
        //    }
        //    try
        //    {
        //        using (var connection = new NpgsqlConnection(_connectionString))
        //        {
        //            connection.Open();
        //            using (var cmd = new NpgsqlCommand(
        //                @"UPDATE users SET usr_name = @name, usr_ph_no = @contactNo, usr_email = @email WHERE usr_id = @id", connection))
        //            {
        //                cmd.Parameters.AddWithValue("@id", userInfo.Id);
        //                cmd.Parameters.AddWithValue("@name", userInfo.Name);
        //                cmd.Parameters.AddWithValue("@contactNo", userInfo.ContactNo);
        //                cmd.Parameters.AddWithValue("@email", userInfo.Email);
        //                int rowsAffected = cmd.ExecuteNonQuery();
        //                if (rowsAffected > 0)
        //                {
        //                    return "User updated successfully.";
        //                }
        //                else
        //                {
        //                    return "User not found.";
        //                }
        //            }
        //        }
        //    }
        //    catch (NpgsqlException ex)
        //    {
        //        return $"Database error: {ex.Message}";
        //    }
        //    catch (Exception ex)
        //    {
        //        return $"An error occurred: {ex.Message}";
        //    }

        //}

        //public string DeleteUserById(int id)
        //{
        //    try
        //    {
        //        using (var connection = new NpgsqlConnection(_connectionString))
        //        {
        //            connection.Open();
        //            using (var cmd = new NpgsqlCommand(
        //                @"DELETE FROM users WHERE usr_id = @id", connection))
        //            {
        //                cmd.Parameters.AddWithValue("@id", id);
        //                int rowsAffected = cmd.ExecuteNonQuery();
        //                if (rowsAffected > 0)
        //                {
        //                    return "User deleted successfully.";
        //                }
        //                else
        //                {
        //                    return "User not found.";
        //                }
        //            }
        //        }
        //    }
        //    catch (NpgsqlException ex)
        //    {
        //        return $"Database error: {ex.Message}";
        //    }
        //    catch (Exception ex)
        //    {
        //        return $"An error occurred: {ex.Message}";
        //    }
        //}
    }
}
