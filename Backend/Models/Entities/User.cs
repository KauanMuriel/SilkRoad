﻿namespace Backend.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public bool Admin { get; set; }

        public User()
        {

        }
    }
}
