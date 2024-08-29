using HrAppDataAcces.DTOs.Firm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppBusiness.FirmRepository
{
    public interface IFirmRepository
    {
        Task<FirmPostDto> CreateFirm(FirmPostDto firmPost);
        Task<List<FirmDto>> GetFirms();

    }
}
