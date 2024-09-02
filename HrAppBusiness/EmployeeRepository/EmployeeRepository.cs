using HrAppDataAcces;
using HrAppDataAcces.DTOs.Employees;
using HrAppDataAcces.DTOs.Firm;
using HrAppDataAcces.Entities.Revisal_entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppBusiness.EmployeeRepository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataBaseContext _context;
        public EmployeeRepository(DataBaseContext context)
        {
            _context=context;
        }
        public Task<SalariatPostDto> CreateEmployee(SalariatPostDto employee)
        {
            var entity = employee.ToModel();
            _context.Employees.Add(entity);
            _context.SaveChanges();
            return Task.FromResult(employee);
            
        }

        public Task<List<SalariatDto>> GetEmployees()
        {
            var result = _context.Employees.Select(e=>new SalariatDto()
            {
                Adresa = e.Adresa,
                Nume = e.Nume,
                Prenume = e.Prenume,
                Cnp = e.Cnp,
                Contracte = e.Contracte.Select(c=>new ContractDto()
                {
                    NumarContract = c.NumarContract,
                    DataInceputContract = c.DataInceputContract,
                    DataSfarsitContract = c.DataSfarsitContract,
                    Salariu = c.Salariu,
                    TipContract = c.TipContract,
                    TipDurata = c.TipDurata,
                    TipNorma = c.TipNorma,
                    Cor = new CorDto()
                    {
                        Cod = c.Cor.Cod,
                        Versiune = c.Cor.Versiune
                    },
                    StareCurenta = new ContractStareDto()
                    {
                        DataIncetareDetasare = c.StareCurenta.DataIncetareDetasare,
                        DataIncetareSuspendare = c.StareCurenta.DataIncetareSuspendare,
                        StarePrecedenta = c.StareCurenta.StarePrecedenta
                    }

                }).ToList(),
               DetaliiSalariatStrain = new DetaliiSalariatStrainDto()
               {
                   DataInceputAutorizatie = e.DetaliiSalariatStrain.DataInceputAutorizatie,
                   DataSfarsitAutorizatie = e.DetaliiSalariatStrain.DataSfarsitAutorizatie,
                   TipAutorizatie = e.DetaliiSalariatStrain.TipAutorizatie

               },
               Localitate = new LocalitateDto(){
                   Judet = new JudetDto()
                   {
                       Nume = e.Localitate.Judet.Nume,
                       CodJudet = e.Localitate.Judet.CodJudet
                   },
                   CodSiruta = e.Localitate.CodSiruta,
                   },
               Nationalitate = new NationalitateDto()
               {
                   Nume = e.Nationalitate.Nume
               },
            }).ToList();
            return Task.FromResult(result);
        }
    }
}
