using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Elvys.Models
{
    public partial class ElvysDbContext : DbContext
    {
        public ElvysDbContext() : base("name=elvysDbContext")
        {
        }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
    }
}