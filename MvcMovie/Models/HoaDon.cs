using System.Security.Cryptography;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    [Table("HoaDons")]
    public class HoaDon
    {   
       
        public int HoaDonID { get; set; }
        public int KhachHangID {get ;set;}
        public DateTime NgayTao  { get; set; }
        public KhachHang KhachHang {get; set;}
        
    }
}