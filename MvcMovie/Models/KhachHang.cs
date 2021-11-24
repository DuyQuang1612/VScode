using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Security.Cryptography;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {   [Key]
       
        public int KhachHangID { get; set; }
        public string TenKhachHang{ get; set; }
        public ICollection<HoaDon> HoaDons {get; set;}
        
    }
}