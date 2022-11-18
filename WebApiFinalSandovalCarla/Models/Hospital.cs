using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiFinalSandovalCarla.Models
{
    public class Hospital
    {
             
        [Key]
        public int Hospital_Cod{ get; set; }

        
        [StringLength(50)]
        public string Nombre { get; set; }
        
        [StringLength(50)]
        public string Direccion { get; set; }
        
        [StringLength(50)]
        public string Telefono { get; set; }
        public int Num_Cama { get; set; }


    }
}
