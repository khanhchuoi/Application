using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FarmManagement.Common;

namespace FarmManagement.Core.Models
{
    /// <summary>
    /// Nhan vien
    /// </summary>
  public  class Staff
    {
        [Key]
        public int StaffId { get; set; }

        [Index(IsUnique = true)]
        [Required]
        [MaxLength(50)]
        [MinLength(8)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FullName { get; set; }

        [MaxLength(13)]
        [MinLength(10)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public string Note { get; set; }
    }

    
}
