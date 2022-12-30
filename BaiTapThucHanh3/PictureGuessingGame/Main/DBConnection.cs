using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class DBConnection
    {
        private string con;
        public string myConnection()
        {
            con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\EnglishVocabGame.mdf;Integrated Security=True;Connect Timeout=30";
            return con;
        }
    }
}
