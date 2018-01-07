using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAl
{
    [MetadataType(typeof(professor_MetadataType))]
   public partial class professor
    {}

    class professor_MetadataType
    {
        [Required]
        public int Id { get; set; }
           [Required]
        public string Name { get; set; }
           [Required,DataType(DataType.PhoneNumber)]
        public int Phone_Number { get; set; }
           [Required]
        public int FK_Id_Department { get; set; }
           [Required]
        public string Address { get; set; }
        [Required,DataType(DataType.EmailAddress)]
           public string Email { get; set; }
        [Required,DataType(DataType.Password)]
           public string password { get; set; }
    }
}
