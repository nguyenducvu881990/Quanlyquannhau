﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanBeer.DTO
{
    public class LoaiKhoDTO
    {
        public LoaiKhoDTO(string id,string tenLoaiKho)
        {
            this.Id = id;
            this.TenLoaiKho = tenLoaiKho;
        }
        public LoaiKhoDTO(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.TenLoaiKho = row["tenLoaiKho"].ToString();
        }

        private string id;
        private string tenLoaiKho;

        public string Id { get => id; set => id = value; }
        public string TenLoaiKho { get => tenLoaiKho; set => tenLoaiKho = value; }
    }
}