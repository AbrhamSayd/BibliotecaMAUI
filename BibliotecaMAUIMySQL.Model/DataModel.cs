using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMAUIMySQL.Model
{
    public class Book
    {
        public int BookId { get; set; }         //primary key, autoincrement,notnull,
        public int ISBN { get; set; }           //INT
        public string Author { get; set; }      //VARCHAR(45)
        public int Published_Year { get; set; } //YEAR (Equvalente a un INT(4))
        public string Color { get; set; }       //VARCHAR(12)
        public string Category { get; set; }    //VARCHAR(45)
        public string Remarks { get; set; }     //VARCHAR(100)
    }

    public class Category
    {
        public int Category_ID { get; set; }    //primarykey, not null, VARCAHR(45)
        public string Description { get; set; } //VARCHAR(45)
    }

    public class Lending
    {
        public int Lending_ID { get; set; }             //INT 
        public int Book_ID { get; set; }                //INT
        public int Member_ID { get; set; }              //INT
        public string Date_Time_Barrowed { get; set; }  //Convert.ToDateTime(txtDate.Text).ToString("yyyy-MM-dd")
        public string Username_Lent { get; set; }       //VARCHAR(45)
        public string Date_Time_Returned { get; set; }  //Convert.ToDateTime(txtDate.Text).ToString("yyyy-MM-dd"
        public string Username_Returned { get; set; }   //VARCHAR(45)
        public string Fined_Aumount { get; set; }       //INT
        public string Remarks { get; set; }             //VARCHAR(100)
    }
    
     public class User {

        public int Username_ID { get; set; }    //INT
        public string Username { get; set; }    //VARCHAR(45)
        public string Password { get; set; }    //VARCHAR(45)
        public string First_Name { get; set; }  //VARCHAR(45)
        public string Last_Name { get; set; }   //VARCHAR(45)
        public string User_Type { get; set; }   //VARCHAR(45)
    }
    
    public class Member
    {
        public int Member_ID { get; set; }      //primarykey, not null
        public string First_Name { get; set; }  //VARCHAR(45)
        public string Last_Name { get; set; }   //VARCHAR(45)
        public string Carrera { get; set; }     //VARCHAR(45)
        public string Email { get; set; }       //VARCHAR(75)
        public int Deudas { get; set; }        //INT, NON-NULL
        public int Prestamos { get; set; }      //INT
    }
    
}

