namespace VeterinaryApi.Models
{
    public class Illness // Нигде не используется в коде, пока не появится мед. карта.
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}