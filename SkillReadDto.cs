namespace Microservices.Dtos
{
    public class SkillReadDto
    {
        public int SkillId { get; set; }
        public string Name { get; set; }
        public string SubCategory { get; set; }
        public string Category { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
