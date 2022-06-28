using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ChessAcademy.Entities;

namespace ChessAcademy.DataLayer
{
    class StudentDAO
    {
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-5KJ3JSSN\SQLEXPRESS;Database=chess_academy;Trusted_Connection=true");

    }
}
