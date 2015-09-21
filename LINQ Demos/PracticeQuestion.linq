<Query Kind="Expression">
  <Connection>
    <ID>b525ed59-41e4-4508-9f24-13fefe535175</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from info in Bills
where info.BillDate.Year == 2014
	&& info.BillDate.Month == 5
// 1
from info in Reservations
where info.ReservationDate.Year == 2014
	&& info.ReservationDate.Month == 5
	&& info.ReservationDate.Day == 19
	|| info.ReservationDate.Year == 2014
	&& info.ReservationDate.Month == 9
	&& info.ReservationDate.Day == 20
	&& info.ReservationStatus.Equals("C")
group info by info.ReservationDate.Hour

// 2 

from info in Bills
where info.PaidStatus == false
select new
{
	Waiter = info.Waiter.FirstName + " " + info.Waiter.LastName
}
	
// 3 
/*
from info in Bills
where info.OrderReady != null
	&& info.OrderServed == null
select new
{
	Table Number = info.Tables.TableNumber,
}
*/
from info in BillItems
where info.Bill.OrderReady != null
	&& info.Bill.OrderServed == null
group info by info.Bill.Table.TableNumber into result
select new
{
	Items = result.Item.Description
}

// 4
from info in Bills
where info.Table. 