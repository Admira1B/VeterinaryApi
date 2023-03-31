namespace VeterinaryApi.Models
{
    public class TypeOfAnimal
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Pet> Pets { get; set; }
    }
}
