using Controller.DTO;
using ENTITY.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Controller
{

    public class HocSinhController
    {
        private QLGDEntity connect = null;
        public HocSinhController()
        {
            connect = new QLGDEntity();
        }
        public List<HocSinh> getAllHocSinh()
        {
            List<HocSinh> result = new List<HocSinh>();
            result = connect.HocSinhs.ToList();
            return result;
        }
        public List<HocSinhDtoList> getAllHocSinhDTO()
        {


            List<HocSinhDtoList> result = new List<HocSinhDtoList>();
            var temp = connect.HocSinhs.ToList();
            foreach(var item in temp)
            {
                HocSinhDtoList data = new HocSinhDtoList();
                data = new ConvertEntityToModel().ConvertHocSinhToDtoList(item);
                var lop = connect.Lops.Where(x => x.Id == item.IdLop).FirstOrDefault();
                data.Lop = lop !=null ? lop.TenLop : "";
                result.Add(data);
            }
            return result;
        }

        public Result<HocSinh> addHocSinh(HocSinh instance)
        {
            var result = new Result<HocSinh>();
            var temp = connect.HocSinhs.Where(x => x.id == instance.id).FirstOrDefault();
            if (temp == null)
            {
                try
                {
                    connect.HocSinhs.Add(instance);
                    connect.SaveChanges();
                    result.Success = true;
                    result.Message = "Thành công!";
                    result.Data = instance;
                }
                catch (Exception e)
                {
                    result.Success = false;
                    result.Message = "Đã xảy ra lỗi khi thêm bản ghi! ";
                    result.Data = instance;
                }
                return result;
            }
            else
            {
                result.Success = false;
                result.Message = "Đã tồn tại bản ghi";
                result.Data = instance;
                return result;
            }
        }
        public Result<HocSinh> updateHocSinh(HocSinh instance)
        {
            //var a = AutoMapper.Mapper.Map<TblTTNVCoBan, NhanVienDTO>(instance);
            var result = new Result<HocSinh>();
            var temp = connect.HocSinhs.Where(x => x.id == instance.id).FirstOrDefault();
            if (temp != null)
            {
                try
                {
                    temp = instance;
                    connect.HocSinhs.Attach(temp);
                    connect.Entry(temp).State = EntityState.Modified;
                    connect.SaveChanges();
                    result.Success = true;
                    result.Message = "Thành công!";
                    result.Data = instance;
                }
                catch (Exception e)
                {
                    result.Success = false;
                    result.Message = "Đã xảy ra lỗi khi thêm bản ghi! ";
                    result.Data = instance;
                }
                return result;
            }
            else
            {
                result.Success = false;
                result.Message = "Không tìm thấy bản ghi";
                return result;
            }
        }
        public Result<HocSinh> deleteHocSinh(int id)
        {
            var result = new Result<HocSinh>();
            var temp = connect.HocSinhs.Where(x => x.id == id).FirstOrDefault();
            if (temp != null)
            {
                    try
                    {
                        connect.HocSinhs.Remove(temp);
                        connect.SaveChanges();
                        result.Success = true;
                        result.Data = temp;
                        result.Message = "Thành công!";
                    }
                    catch (Exception e)
                    {
                        result.Data = temp;
                        result.Success = false;
                        result.Message = "Đã xảy ra lỗi khi thêm bản ghi! ";
                    }
                    return result;
            }
            else
            {
                result.Success = false;
                result.Message = "Không tìm thấy bản ghi";
                return result;
            }
        }
    }
}
