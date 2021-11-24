using System.Security.Cryptography;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    [Table("Person")]
    public class Person
    {   
       
        public int ID { get; set; }
        public string PersonCode{ get; set; }
        public string FullName{ get; set; }
       
        
    }
}