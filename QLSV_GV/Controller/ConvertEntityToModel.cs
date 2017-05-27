using Controller.DTO;
using ENTITY.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ConvertEntityToModel
    {
        public HocSinhDto ConvertHocSinhToDto(HocSinh hocsinh)
        {
            HocSinhDto result = new HocSinhDto();
            result.id = hocsinh.id;
            result.MaHocSinh = hocsinh.MaHocSinh;
            result.TenHocSinh = hocsinh.TenHocSinh;
            result.NgaySinh = hocsinh.NgaySinh;
            result.DiaChi = hocsinh.DiaChi;
            result.NamBatDau = hocsinh.NamBatDau;
            result.GhiChu = hocsinh.GhiChu;
            result.IdLop = hocsinh.IdLop;
            if (hocsinh.GioiTinh == (int)GlobalParam.GioiTinh.NAM)
            {
                result.GioiTinh = GlobalParam.GioiTinhString.Nam.ToString();
            }
            else if (hocsinh.GioiTinh == (int)GlobalParam.GioiTinh.NU)
            {
                result.GioiTinh = GlobalParam.GioiTinhString.Nữ.ToString();
            }
            return result;
        }
        public HocSinhDtoList ConvertHocSinhToDtoList(HocSinh hocsinh)
        {
            HocSinhDtoList result = new HocSinhDtoList();
            result.MaHocSinh = hocsinh.MaHocSinh;
            result.TenHocSinh = hocsinh.TenHocSinh;
            result.NgaySinh = hocsinh.NgaySinh;
            result.DiaChi = hocsinh.DiaChi;
            result.NamBatDau = hocsinh.NamBatDau;
            result.GhiChu = hocsinh.GhiChu;
            if (hocsinh.GioiTinh == (int)GlobalParam.GioiTinh.NAM)
            {
                result.GioiTinh = GlobalParam.GioiTinhString.Nam.ToString();
            }
            else if (hocsinh.GioiTinh == (int)GlobalParam.GioiTinh.NU)
            {
                result.GioiTinh = GlobalParam.GioiTinhString.Nữ.ToString();
            }
            return result;
        }
    }
}
