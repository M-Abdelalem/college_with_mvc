using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAl
{
    [MetadataType(typeof(Department_MetadataType))]
    public partial class Department
    { 
    }
    class Department_MetadataType
    {
        [Required]
        public int Id { get; set; }
         [Required]
        public string name { get; set; }
         [Required]
        public int FK_Id_coullege { get; set; }
         [Required]
        public int FK_Id_professser { get; set; }
    
    }
}
