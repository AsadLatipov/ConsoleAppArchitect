using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppArchitect.Domains.Models
{
    [Table("employee")]
    public class Employee
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("fname")]
        public string FName { get; set; }
        [Column("lname")]
        public string LName { get; set; }
        [Column("birthday")]
        public string Birthday { get; set; }
        [Column("cardnumber")]
        public string CardNumber { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("phonenumber")]
        public string PhoneNumber { get; set; }
    }
}
