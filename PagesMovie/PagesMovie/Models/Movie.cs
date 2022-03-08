using System;
using System.ComponentModel.DataAnnotations;

namespace PagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }//主键
        public string Title { get; set; }

        [DataType(DataType.Date)]//指定数据的类型 (Date)
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
