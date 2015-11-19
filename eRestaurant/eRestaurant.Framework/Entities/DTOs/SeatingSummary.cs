using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Framework.Entities.DTOs
{
    public class SeatingSummary
    {
        public byte Table { get; set; } // the tables tableNumber
        public int Seating { get; set; } // the seating capacity - Table capacity
        public bool Taken { get; set; } // calculated
        public int? BillID { get; set; } // Bills.BillID (nullable)
        public decimal? BillTotal { get; set; } // calculated - total bill (nullable)
        public string Waiter { get; set; } // Waiters' name
        public string ReservationName { get; set; } // reservations.ContactName (nullable)

        /*
         Table = data.Table,
				Seating = data.Seating,
				Taken = data.Taken,
				// use a ternary expression to conidtionally get the bill id (if it exists)
				BillID = data.Taken ?				// if(data.Taken)
						 data.CommonBilling.BillID  // value to use if true
					   : (int?) null,				// value to use if false
				BillTotal = data.Taken ?
							data.CommonBilling.BillTotal : (decimal?) null,
				Waiter = data.Taken ? data.CommonBilling.Waiter : (string) null,
				ReservationName = data.Taken ?
								  (data.CommonBilling.Reservation != null?
								  data.CommonBilling.Reservation.CustomerName :
								  (string) null)
								:  (string) null
         */
    }
}
