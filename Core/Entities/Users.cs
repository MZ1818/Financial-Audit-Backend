using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.Core.Entities
{
    //User Class to store the login details of admins
    //[Table("Users")]
    public class Users
    {
        [Key] // for initialising as PK
        [Column(TypeName = "int")]
        public int Id { get; set; } //properties for ID

        //Username for admin login
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Username { get; set; }


        //passowrd for admin login
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Password { get; set; }

        //Name for admin login
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        //Role for admin login
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Role { get; set; }
    }
}
