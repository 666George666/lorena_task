using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace lorena_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeBD();
        }
        private void InitializeBD() {

            //###########################################################################################
            //1 - ПОДГОТОВКА ДАННЫХ ДЛЯ ВСТАВКИ ПО УМОЛЧАНИЮ
            List<DB_Node> dB_Nodes = new List<DB_Node>();
            dB_Nodes.Add(   new DB_Node( 1, "Миасс",  4,  false, 0, "Это описание  Миасскаого подразделения") );
            dB_Nodes.Add(   new DB_Node( 2, "Амелия", 5,  true,  1, "Это описание  подразделения Амелия"));
            dB_Nodes.Add(   new DB_Node( 3, "Тест1",  2,  true,  2, "Это описание  подразделения Тест1"));
            dB_Nodes.Add(   new DB_Node( 4, "Тест2",  0,  true,  1, "Это описание  подразделения Тест2"));
            dB_Nodes.Add(   new DB_Node( 5, "Курган", 11, false, 0, "Это описание  подразделения Курган"));
            //###########################################################################################
            // 2 -  УСТАНОВЛЕНИЕ СОЕДИНЕНИЯ С БД
            string dbPath = "lorena_data.db";//путь к базе данных в папке с проектом
            
            //3 - СОЗДАНИЕ И ОТКРЫТИЕ БД
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source = {dbPath};Version = 3")){

                connection.Open();
             
                //3 СОЗДАНИЕ ТАБЛИЦЫ
                using (SQLiteCommand command = new SQLiteCommand(
                    "CREATE TABLE IF NOT EXISTS DillerTree(" +
                        "Id             INTEGER PRIMARY KEY NOT NULL UNIQUE," +
                        "Name           TEXT NOT NULL," +
                        "Discount       REAL NOT NULL," +
                        "Dependence     INTEGER NOT NULL," +
                        "Parent_id      INTEGER NOT NULL," +
                        "Discription    TEXT NOT NULL  ," +
                        "FOREIGN KEY(Parent_id) REFERENCES DillerTree(Id) )" ,
                        connection)) {

                    command.ExecuteNonQuery();
                }
                //4 -  ДОБАВЛЕНИЕ НАЧАЛЬНЫХ ДАННЫХ В ТАБЛИЦУ
                foreach (DB_Node el in dB_Nodes) {
                    using (SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO DillerTree(Id,Name,Discount,Dependence,Parent_id,Discription) VALUES (@Id, @Name, @Discount, @Dependence , @Parent_id,  @Discription)", connection)) {

                        insertCommand.Parameters.AddWithValue("@Id",         el.Id);
                        insertCommand.Parameters.AddWithValue("@Name",       el.Name);
                        insertCommand.Parameters.AddWithValue("@Discount",   el.Discount);
                        insertCommand.Parameters.AddWithValue("@Dependence", el.Dependence);
                        insertCommand.Parameters.AddWithValue("@Parent_id",  el.Parent_id);
                        insertCommand.Parameters.AddWithValue("@Discription",el.Discription);
                        insertCommand.ExecuteNonQuery();
                    } 
                }

            }
            //###########################################################################################
        }

    }
}


//5 чтение данных из таблицы
//using (SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM Nodes", connection))
//{

//    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
//    {
//        while (reader.Read())
//        {
//            Console.WriteLine($"   Id:{reader["Id"]} , Name:{reader["Name"]},  Value:{reader["Value"]}");
//        }
//    }