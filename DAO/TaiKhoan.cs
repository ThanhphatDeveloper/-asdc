//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaiKhoan
    {
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string NVSoHuu { get; set; }
        public string MaQuyen { get; set; }
        public bool TrangThai { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
        public virtual PhanQuyen PhanQuyen { get; set; }
    }
}