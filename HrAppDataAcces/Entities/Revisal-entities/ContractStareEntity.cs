using HrAppDataAcces.DTOs.Employees;
using System;
using System.Collections.Generic;

namespace HrAppDataAcces.Entities.Revisal_entities
{public class ContractStareEntity : AuditableEntity
    {
        public DateTime? DataIncetareDetasare { get; set; }
        public DateTime? DataIncetareSuspendare { get; set; }
        public ContractStareEntity? StarePrecedenta { get; set; }

       
    }
}
