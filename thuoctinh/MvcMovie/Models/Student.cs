using System.IO.Enumeration;
using System.IO;
using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    public class Student
    {
        public int ID { get; set; }

    
    [Required(ErrorMessage ="Không được bỏ trống")]
        public string StudentID { get; set; }
        
    public string TenHocSinh { get; set; }

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime NamSinh { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]
    public string HocLuc { get; set; }

    public string XepHang { get; set; }
    public string Rate { get; set; }
    }
}