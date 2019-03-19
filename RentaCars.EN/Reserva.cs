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
    public class Reserva
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int ReservaID { get; set; }
        [Display(Name = "Id Vehiculo")]
        public int VehiculoID { get; set; }
        [Display(Name = "Fecha de Entrega")]
        [DataType(DataType.Date)]
        public DateTime FechaEn { get; set; }
        [Display(Name = "Fecha de devolucion")]
        [DataType(DataType.Date)]
        public DateTime FechaDev { get; set; }
        [Display(Name = "Hora de devolucion")]
        [DataType(DataType.Time)]
        public string HoraDev { get; set; }
        [Display(Name = "Estado id")]
        public int EstadoID { get; set; }

        public Vehiculo Vehiculo { get; set; }
        public Estado Estado { get; set; }
        public ICollection<Renta> Renta { get; set; }
    }
}
