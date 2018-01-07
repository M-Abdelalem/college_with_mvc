using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAl
{
    [MetadataType(typeof(registration_MetadataType))]
    public partial class registration
    {
    
    
    }



    class registration_MetadataType
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int FK_Id_Section { get; set; }
        [Required]
        public int FK_Id_Student { get; set; }
    
    }
}
