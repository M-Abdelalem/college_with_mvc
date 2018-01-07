using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAl
{
    [MetadataType(typeof(course_MetadataType))]
    public partial class Course { }


    class course_MetadataType
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int FK_Id_Department { get; set; }
    }
}
