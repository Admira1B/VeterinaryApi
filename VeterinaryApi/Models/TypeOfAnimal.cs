﻿namespace VeterinaryApi.Models
{
    public class TypeOfAnimal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Pet> Pets { get; set; }
    }
}
