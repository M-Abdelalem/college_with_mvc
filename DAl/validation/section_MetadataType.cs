using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAl
{
    public partial class Section
    { }


   public class section_MetadataType
   {
       [Required]
       public int Id { get; set; }
        [Required]
       public System.DateTime Time { get; set; }
        [Required]
       public int FK_Id_Professor { get; set; }
        [Required]
       public int FK_ID_Course { get; set; }


    }
}
