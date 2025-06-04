//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace webPage.Service
//{
//    public class oldDatabaseService
//    {
//        public IReadOnlyList<RegisterForm> getAllUsers()
//        {
//            List<RegisterForm> registedUser = new List<RegisterForm>();



//            NpgsqlConnection conn = new NpgsqlConnection(_connectionString);



//            conn.Open();
//            NpgsqlCommand comm = new NpgsqlCommand();
//            comm.Connection = conn;
//            comm.CommandType = CommandType.Text;
//            comm.CommandText = "select * from \"register\"";
//            NpgsqlDataReader dr = comm.ExecuteReader();
//            while (dr.Read())
//            {
//                RegisterForm register = new RegisterForm()
//                {
//                    Name = dr["name"].ToString(),
//                    Gender = dr["gender"].ToString(),
//                    Province = dr["province"].ToString()
//                };
//                registedUser.Add(register);
//            }
//            comm.Dispose();
//            conn.Close();



//            return registedUser;
//        }

//        //Add below method on DatabaseService.cs public IReadOnlyList<RegisterForm> getAllUsers() { List<RegisterForm> registedUser = new List<RegisterForm>(); NpgsqlConnection conn = new NpgsqlConnection(_connectionString); conn.Open(); NpgsqlCommand comm = new NpgsqlCommand(); comm.Connection = conn; comm.CommandType = CommandType.Text; comm.CommandText = "select * from \"register\""; NpgsqlDataReader dr = comm.ExecuteReader(); while (dr.Read()) { RegisterForm register = new RegisterForm() { Name = dr["name"].ToString(), Gender = dr["gender"].ToString(), Province = dr["province"].ToString() }; registedUser.Add(register); } comm.Dispose(); conn.Close(); return registedUser; }



//    }
//}
