﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSKwinform.Admin.Phong
{
    public class Phong
    {
        [DisplayName("Mã phòng")]
        public string maPhong { get; set; }
        [DisplayName("Tên phòng")]

        public string tenPhong { get; set; }
        [DisplayName("Sức chứa tối đa phòng")]
        public string diaDiem { get; set; }
        [DisplayName("Mô tả chi tiết phòng")]
        public int sucChuaToiDa { get; set; }
        [DisplayName("Địa điểm")]


        public string moTaChiTiet { get; set; }
        [DisplayName("Mô tả vắn tắt")]

        public string moTaVanTat { get; set; }
        public Phong() { }
    }

}
