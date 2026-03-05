using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraCore
{
    public class SanPhamServices
    {
       private readonly List<SanPham> sanPhams = new List<SanPham>();

        public SanPhamServices()
        {
           sanPhams.Add(new SanPham() { MaSanPham = "SP001",Name = "B", Gia = 20});
        }

        public SanPham? LayDuLieuBangMa(string MaSP)
        {
            return sanPhams.FirstOrDefault(x => x.MaSanPham == MaSP);
        }
        public bool Add(SanPham sp)
        {
            try
            {


                if (sp.Gia < 0) return false;

                if(sanPhams.Exists(x => x.MaSanPham == sp.MaSanPham)) 
                    return false; 
                sanPhams.Add(sp);
                return true;
            }
            catch (Exception ex) { return false; }
        }

        public bool Edit(SanPham sp)
        {
            
                var existsSP = sanPhams.FirstOrDefault(x => x.MaSanPham == sp.MaSanPham);
                if (existsSP != null)
                {
                    if (sp.Gia < 0)
                        return false;
                    existsSP.Gia = sp.Gia;
                    existsSP.Name = sp.Name;
                    return true;
                }
                return false;
            
            }
    }
}

