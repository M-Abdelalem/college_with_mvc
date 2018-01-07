using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAl
{
    [MetadataType(typeof( student_metadatatype))]
    public partial class Student
    {    }
   public class student_metadatatype
   {
       [Required]
       public int Id { get; set; }
        [Required]
       public string Name { get; set; }
        [Required, DataType(DataType.PhoneNumber)]
       public int Phone_number { get; set; }
        [Required]
       public int FK_Id_Department { get; set; }
        [Required]
       public int FK_Id_Registration { get; set; }
    }
}
