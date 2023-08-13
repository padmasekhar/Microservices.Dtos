using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.Dtos
{
    public class EmployeeSkillCreateDto
    {
        public int EmployeeId { get; set; }
        public int SkillId { get; set; }
    }
}
