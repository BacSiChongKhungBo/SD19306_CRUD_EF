using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repositories
{
    internal class NhanvienRepository
    {
        DBContext context;
        public NhanvienRepository()
        {
            context = new DBContext();
        }
        //CRUD : CREATE | READ | UPDATE | DELETE
        // READ == SELECT
        public List<NhanVien> GetAll()
        {
            return context.NhanViens.ToList();
            //context: vào db, NhanViens : lấy DL trong nhanvien
            //ToList: chuyển thành danh sách
        }
        //Thêm sửa xóa: Hoạt động y hệt nhau trong repos
        public bool Add_NV(NhanVien nv)
        {
            if(nv == null)
            {
                return false;
            }
            context.NhanViens.Add(nv); //thêm vào bảng nv
            context.SaveChanges(); // lưu thay đổi
            return true;
        }

        public bool Update_NV(NhanVien nv)
        {
            if (nv == null)
            {
                return false;
            }
            context.NhanViens.Update(nv); 
            context.SaveChanges(); // lưu thay đổi
            return true;
        }

        public bool Remove_NV(NhanVien nv)
        {
            if (nv == null)
            {
                return false;
            }
            context.NhanViens.Remove(nv);
            context.SaveChanges(); // lưu thay đổi
            return true;
        }
    }
}
