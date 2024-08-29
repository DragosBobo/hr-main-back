using System;
using System.Collections.Generic;

namespace HrAppDataAcces.Entities.Revisal_entities
{public class DetaliiAngajatorAuditEntity : AuditEntity
    {
        public DomeniuActivitateEntity DomeniuActivitate { get; set; }
        public string Nume { get; set; }
    }
}
