<Query Kind="Expression">
  <Connection>
    <ID>c3f4fe64-2e4b-4f5f-bba0-0412d39447d3</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from cat in MenuCategories
orderby cat.Description
select new
{
	Description = cat.Description,
	MenuItems = from item in cat.Items
				where item.Active
				orderby item.Description
				select new
				{
					Description = item.Description,
					Price = item.CurrentPrice,
					Calories = item.Calories,
					Comment = item.Comment
				}
}