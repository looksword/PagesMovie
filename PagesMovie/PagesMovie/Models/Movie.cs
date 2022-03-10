using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PagesMovie.Models
{
    public class Movie
    {
        /*
         * 将验证规则添加到电影模型
         * 让 ASP.NET Core 强制自动执行验证规则有助于：
         *      提升应用的可靠性;
         *      减少将无效数据保存到数据库的几率
        */


        public int ID { get; set; }//主键

        [StringLength(60, MinimumLength = 3), Required, Display(Name = "电影名")]
        public string Title { get; set; }

        [DataType(DataType.Date), Display(Name = "发布日期")]//指定数据的类型 (Date)
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30), Display(Name = "电影类型")]
        public string Genre { get; set; }

        [Range(1, 100), DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)"), Display(Name = "价格")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5), Required, Display(Name = "分级")]
        public string Rating { get; set; }
    }
}
