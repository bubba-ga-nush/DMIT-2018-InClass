using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Framework.Entities
{
    public class ReservationTable
    {
        [Key]
        public int TableID { get; set; }
        public int ReservationID { get; set; }

        // Navigation Property
        public virtual Table Table { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
