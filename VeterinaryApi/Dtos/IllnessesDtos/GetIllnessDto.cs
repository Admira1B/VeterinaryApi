namespace VeterinaryApi.Dtos.IllnessesDto
{
    public class GetIllnessDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
