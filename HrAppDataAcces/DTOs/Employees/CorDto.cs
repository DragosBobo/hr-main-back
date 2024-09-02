using HrAppDataAcces.Entities.Revisal_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.DTOs.Employees
{
    public class CorDto
    {
        public int Cod { get; set; }
        public int Versiune { get; set; }
        public CorEntity ToModel()
        {
            return new CorEntity
            {
                Cod = Cod,
                Versiune = Versiune,
                Id = Guid.NewGuid(),
            };
        }
    }
}
