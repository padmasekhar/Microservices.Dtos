namespace Microservices.Dtos
{
    public class EmployeeSkillReadDto
    {
        public int EmployeeId { get; set; }
        public int SkillId { get; set; }

        public string EmployeeName { get; set; } = null!;
        public string SkillName { get; set; } = null!;
        public string SkillSubCategoryName { get; set; } = null!;
        public string SkillCategoryName { get; set; } = null!;
    }
}
