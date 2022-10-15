using System;
using System.Data;
using System.IO;
using LumenWorks.Framework.IO.Csv;
using System.Diagnostics;
// id, heirarchy, room_type, min_doorway, max_doorway, min_occur, max_occur, must_connect_to, can_connect_to, lighting
namespace Game_v1._4 {
    class Program
    {
        static string ReadCSVdata(int row, int col)
        {
            string csvpath = @"C:\Users\joe-p\Dropbox\Utility\Projects\code\Game v1.4\Resources\Area_data.csv";
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(csvpath)), true))
            {
                csvTable.Load(csvReader);
            }
            //DataTable myTable = new System.Data.DataTable();
            string Column1 = csvTable.Columns[0].ToString(); //access header values
            string Row1 = csvTable.Rows[col][row].ToString(); //access rows
            return Row1;
        }

        static void FindCSVbounds(string csvpath, int max_row, int max_col)
        {

            bool error_code = false;

            do //find number of rows in file
            {
                try
                {
                    ReadCSVdata( 0, max_row);
                    max_row += 1;
                }
                catch (System.IndexOutOfRangeException)
                {
                    error_code = true;
                }
            } while (error_code == false);

            //find number of columns

            error_code = false;
            do
            {
                try
                {
                    ReadCSVdata(max_col, 0);
                    max_col += 1;
                }
                catch (System.IndexOutOfRangeException)
                {
                    error_code = true;
                }
            } while (error_code == false);
        }

        static string CSVtoArray()
        {
            int max_row = 0;
            int max_col = 0;
            return "peppe";
        }

        static void Main(string[] args)
        {
            int id_col = 0,
                heirarchy = 1,
                room_type = 2,
                min_doorway = 3,
                max_doorway = 4,
                min_occur = 5,
                max_occur = 6,
                must_connect_to = 7,
                can_connect_to = 8,
                lighting = 9;
            int x = 2;
            int y = 0;
            int id = 24;
     



            //import csv data to array
           // string[,] CSVarray = new string[max_row, 10];
            //for (col = 0; col < max_col; col++)
            //{
              //  for (row = 0; row < max_row; row++)
                //{
                    //CSVarray[row, col] = ReadCSVdata(csvpath, col, row);
                  //  Debug.Print(CSVarray[row, col]);
                //}
            //}

//            string[,] rooms = new string[];
            //read each item in rooms_array
            //foreach (int i in )
            //{
              //  System.Console.Write("{0} ", i);
            //}

            Console.WriteLine(ReadCSVdata(0, 0));
            Console.ReadLine();


        }
    }
}




