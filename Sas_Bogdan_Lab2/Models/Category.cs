﻿namespace Sas_Bogdan_Lab2.Models
{
    public class Category
    {

        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
