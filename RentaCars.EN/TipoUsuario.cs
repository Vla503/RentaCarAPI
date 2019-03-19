using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentaCars.EN
{
    public class TipoUsuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int TipoUsuarioID { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Display(Name = "Estado id")]
        public int EstadoID { get; set; }


        public  ICollection<Usuario> Usuario { get; set; }
        public  Estado Estado { get; set; } 

    }
}
