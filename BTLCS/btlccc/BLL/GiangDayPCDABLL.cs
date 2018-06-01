using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
   public class GiangDayPCDABLL
    {
        PCGDDADAL pcgd = new PCGDDADAL();
        public DataTable HienThiDS()
        {
            return pcgd.HienThiDS();
        }

    }
}
