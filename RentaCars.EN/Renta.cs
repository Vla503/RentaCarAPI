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
  public class Renta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int RentaID { get; set; }
        [Display(Name = "Usuario id")]
        [Required(ErrorMessage = "Campo no puede estar vacio")]
        public int UsuarioID { get; set; }
        [Display(Name = "Reserva id")]
        [Required(ErrorMessage = "Campo no puede estar vacio")]
        public int ReservaID { get; set; }
        [Display(Name = "Estado id")]
        public int EstadoID { get; set; }

        public  Usuario Usuario { get; set;}
        public  Reserva Reserva { get; set; }
        public  Estado Estado { get; set; }


    }
}
