using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Elvys.Models
{
    [Table("LopHoc")]
    public class LopHoc
    {
        [Key]
        public int MaLop { get; set; }
        [StringLength(maximumLength: 5, ErrorMessage = "Tối đa 5 kí tự")]
        public string TenLop { get; set; }
    }
}