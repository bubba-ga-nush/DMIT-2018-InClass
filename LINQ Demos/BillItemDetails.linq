<Query Kind="Expression">
  <Connection>
    <ID>c3f4fe64-2e4b-4f5f-bba0-0412d39447d3</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// Select the bill items for aspecific bill (in this case, the unpaid bill)
from data in Bills
where data.BillID == 10975 // This would be the billId that they ask for
select new //Order()
{
	BillID = data.BillID,
	Items = (from info in data.BillItems
			select new //OrderItems()
			{
				ItemName = info.Item.Description,
				Price = info.SalePrice,
				Quantity = info.Quantity
			}).ToList()
}