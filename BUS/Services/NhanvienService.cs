using BUS.Repositories;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    // sửa internal class => public class
    public class NhanvienService
    {
        NhanvienRepository repos;
        public NhanvienService()
        {
            repos = new NhanvienRepository();
        }
        public List<NhanVien> GetNhanViens()
        {
            return repos.GetAll();
        }
        // thêm sửa xóa sẽ trả về string
        public string ThemNV(NhanVien nv)
        {
            if (repos.Add_NV(nv))
            {
                return "Thêm Thành công";
            }
            return "Thêm thất bại";
        }
        //Sửa: dữ liệu trong table sẽ bị ghim => ko thể sửa trực tiếp
        // => tạo clone để thay thế
        public string SuaNV(NhanVien nv)
        {
            if (repos.Update_NV(nv))
            {
                return "Cập nhật thành công";
            }
            return "Cập nhật thất bại";
        }

        public string XoaNV(string ma)
        {
            var nv = repos.GetAll().Find(x => x.MaNv == ma);
            if (repos.Remove_NV(nv))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }
    }
}
