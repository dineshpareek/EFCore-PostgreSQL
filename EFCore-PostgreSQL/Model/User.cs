using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace EFCore_PostgreSQL.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual UserGroup Group { get; set; }
        public int GroupId { get; set; }
    }
}
