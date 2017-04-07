using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Web.Models;

namespace Capstone.Web.DAL
{
    public interface IPotholeDAL
    {
        bool ReportPothole(PotholeModel newPothole);
        List<PotholeModel> GetAllPotholes();
        PotholeModel GetOnePothole(string id);
        bool UpdatePothole(PotholeModel existingPothole, int enployeeId);
    }
}
