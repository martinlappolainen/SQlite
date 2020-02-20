using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SQliteLappolainen
{
    [Table("Friends")]
    public class Friend
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Opis { get; set; }
        public string Phone { get; set; }
        //private DateTime date;
        //public DateTime Date
        //{
        //    get
        //    { return date; }
        //    set
        //    {
        //        date = value;
        //        Age = (DateTime.Now.Year - value.Year);
        //        if (Age <= 7)
        //        {
        //            Status = "Молодой";
        //        }
        //        else if (Age > 7 && Age <= 18)
        //        {
        //            Status = "Панк";
        //        }
        //        else if (Age > 18 && Age <= 100)
        //        {
        //            Status = "Пора на пенсию";
        //        }
        //    }
        //}
        //public bool sswitch { get; set; }
        public int Dleft { get; set; }
        //public int Age { get; set; }
        //public string Sex { get; set; }
        //public string Nazi { get; set; }
        //public string Status { get; set; }
       
    }
}
