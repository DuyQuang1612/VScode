using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Elvys.Models
{
    [Table("SinhVien")]
    public class SinhVien
    {
        [Key]
        [StringLength(maximumLength: 20, ErrorMessage = "Tối đa 20 kí tự")]
        public string MaSinhVien { get; set; }
        [StringLength(maximumLength: 50, ErrorMessage = "Tối đa 50 kí tự")]
        public string HoTen { get; set; }
    }
}