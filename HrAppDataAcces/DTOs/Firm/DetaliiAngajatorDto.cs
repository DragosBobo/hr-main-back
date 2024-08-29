using HrAppDataAcces.Entities.Revisal_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.DTOs.Firm
{
    public class DetaliiAngajatorDto
    {
        public DomeniuActivitateDto DomeniuActivitate { get; set; }
        public string Nume { get; set; }
        public DetaliiAngajatorEntity ToModel()
        {
            return new DetaliiAngajatorEntity()
            {
                DomeniuActivitate = DomeniuActivitate.ToModel(),
                Nume = Nume,
                Id = Guid.NewGuid()
            };
        }
    }
}
