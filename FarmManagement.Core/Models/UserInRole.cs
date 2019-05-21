using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FarmManagement.Common;

namespace FarmManagement.Core.Models
{
    /// <summary>
    /// Quyen nguoi dung
    /// </summary>
   public class UserInRole
    {
        public int StaffId { get; set; }

        [Index(IsUnique = true)]
        [Required]
        public string UserName { get; set; }

        public Role Role { get; set; }
        public int RoleId { get; set; }

        public RoleState RoleState { get; set; }
    }
}
