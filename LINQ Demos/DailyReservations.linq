<Query Kind="Expression">
  <Connection>
    <ID>c3f4fe64-2e4b-4f5f-bba0-0412d39447d3</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from eachRow in Reservations
where eachRow.ReservationStatus == 'B' // use "B" in Visual Studio
		// TBA - && eachRow has the correct EventCode
orderby eachRow.ReservationDate
// select eachRow
group eachRow by new { eachRow.ReservationDate.Month, eachRow.ReservationDate.Day }
into dailyReservation
select new // DailyReservation() Create a class called DailyReservation
{
	Month = dailyReservation.Key.Month,
	Day = dailyReservation.Key.Day,
	Reservations =  from booking in dailyReservation
					select new // Booking() Create a Booking DTO class
					{
						Name = booking.CustomerName,
						Time = booking.ReservationDate.TimeOfDay,
						NumberInParty = booking.NumberInParty,
						Phone = booking.ContactPhone,
						Event = booking.SpecialEvents.Description
					}
}