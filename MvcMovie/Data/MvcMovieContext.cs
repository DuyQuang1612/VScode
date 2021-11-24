using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
         public DbSet<Person> Person { get; set; }
         public DbSet<Student> Student { get; set; }
         public DbSet<MvcMovie.Models.KhachHang> KhachHang { get; set; }
         public DbSet<MvcMovie.Models.HoaDon> HoaDon { get; set; }
    }
