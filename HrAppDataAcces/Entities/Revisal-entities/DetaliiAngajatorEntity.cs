using System;
using System.Collections.Generic;

namespace HrAppDataAcces.Entities.Revisal_entities
{public class DetaliiAngajatorEntity
    {
        public Guid Id { get; set; }
        public DomeniuActivitateEntity DomeniuActivitate { get; set; }
        public string Nume { get; set; }
    }
}
