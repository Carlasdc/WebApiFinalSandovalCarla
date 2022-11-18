using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiFinalSandovalCarla.Models
{
    public class Doctor
    {
     
        [Key]
        public int Doctor_No { get; set; }
       
        [StringLength(50)]
        public string Apellido { get; set; }

        
        [StringLength(50)]
        public string Especialidad { get; set; }

        public int Hospital_Cod { get; set; }
        #region
        [ForeignKey("Hospital_Cod")]
        public Hospital Hospital { get; set; }
        #endregion  
    }
}
