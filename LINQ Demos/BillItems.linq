<Query Kind="Expression">
  <Connection>
    <ID>c3f4fe64-2e4b-4f5f-bba0-0412d39447d3</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// What Bills are not yet paid?
from data in Bills
where !data.PaidStatus
	&& data.BillItems.Count() > 0
select new //UnpaidBill()
{
	DisplayText = "Bill " + data.BillID.ToString(),
	KeyValue = data.BillID,
	TotalAmount = data.BillItems.Sum(bi=>bi.SalePrice * bi.Quantity),
	Table = data.Table,
	Reservation = data.Reservation
}