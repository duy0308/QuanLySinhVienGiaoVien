using ENTITY.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.DTO
{
    public class HocSinhDto
    {
        public string MaHocSinh { get; set; }

        public string TenHocSinh { get; set; }

        public DateTime NgaySinh { get; set; }

        public string DiaChi { get; set; }

        public decimal NamBatDau { get; set; }

        public int id { get; set; }

        public string GioiTinh { get; set; }

        public string GhiChu { get; set; }

        public int IdLop { get; set; }
        public HocSinh toEntity()
        {
            HocSinh result = new HocSinh();
            result.id = id;
            result.MaHocSinh = MaHocSinh;
            result.TenHocSinh =  TenHocSinh ;
            result.NgaySinh =  NgaySinh ;
            result.DiaChi = DiaChi;
            result.NamBatDau= NamBatDau;
            result.GhiChu =  GhiChu;
            result.IdLop =  IdLop;
            if(GioiTinh == GlobalParam.GioiTinhString.Nam.ToString())
            {
               result.GioiTinh = (int)GlobalParam.GioiTinh.NAM;
            }
            else if(GioiTinh == GlobalParam.GioiTinhString.Nữ.ToString())
            {
                result.GioiTinh = (int)GlobalParam.GioiTinh.NU;
            }
            return result;
        }
    }

    public class HocSinhDtoList
    {
        public string MaHocSinh { get; set; }

        public string TenHocSinh { get; set; }

        public DateTime NgaySinh { get; set; }


        public string GioiTinh { get; set; }
        public string Lop { get; set; }

        public string DiaChi { get; set; }

        public decimal NamBatDau { get; set; }
        public string GhiChu { get; set; }

    }

}
