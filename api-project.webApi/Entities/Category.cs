﻿namespace api_project.webApi.Entities
{
    public class Category
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public List<Product> Products { get; set; }
    }
}
