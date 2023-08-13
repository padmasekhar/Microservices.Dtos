﻿namespace Microservices.Dtos
{
    public class EmployeeUpdateDto
    {
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public int? ManagerId { get; set; }
    }
}
