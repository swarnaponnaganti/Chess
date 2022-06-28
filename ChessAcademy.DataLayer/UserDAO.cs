using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ChessAcademy.Entities;

namespace ChessAcademy.DataLayer
{
    public class UserDAO
    {
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-5KJ3JSSN\SQLEXPRESS;Database=chess_academy;Trusted_Connection=true");
        public void AddUser(Users user)
        {
            try {
                string qry = "INSERT INTO USERS VALUES (@email,@password,@username,@mobileNumber,@userRole)";
                SqlCommand command = new SqlCommand(qry, connection);
                command.Parameters.AddWithValue("@mail", user.email);
                command.Parameters.AddWithValue("@pwd", user.password);
                command.Parameters.AddWithValue("@user", user.username);
                command.Parameters.AddWithValue("@mobile", user.mobileNumber);
                command.Parameters.AddWithValue("@role", user.userRole);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public void EditUser(Users user)
        {
            try
            {
                string qry = " UPDATE USERS SET email=@email,mobileNumber=@mobileNumber, where username=@username)";
                SqlCommand command = new SqlCommand(qry, connection);
                command.Parameters.AddWithValue("@mail", user.email);
                
                command.Parameters.AddWithValue("@user", user.username);
                command.Parameters.AddWithValue("@mobile", user.mobileNumber);
               
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        
    }
        

}

