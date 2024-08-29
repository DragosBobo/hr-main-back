using HrAppDataAcces.Entities.Revisal_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.DTOs.Employees
{
    public class ContractStareDto
    {
        public DateTime? DataIncetareDetasare { get; set; }
        public DateTime? DataIncetareSuspendare { get; set; }
        public ContractStareEntity? StarePrecedenta { get; set; }
        public ContractStareEntity ToModel()
        {
            return new ContractStareEntity()
            {
                DataIncetareDetasare = DataIncetareDetasare,
                DataIncetareSuspendare = DataIncetareSuspendare,
                StarePrecedenta = StarePrecedenta,
                Id = Guid.NewGuid(),
            };
        }
    }
}
