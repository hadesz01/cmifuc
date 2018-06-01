using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
   public class PCGDDADAL:KetNoi
    {
       
            public DataTable LoadData(string sql)
            {
                Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            public DataTable HienThiDS()
            {
                string sql = "select * from PhanCongGiangDay";
                return LoadData(sql);
            }
        }
    }

