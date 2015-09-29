<Query Kind="Expression">
  <Connection>
    <ID>3cc90a6f-0494-46c9-aef7-1e5f36b4a9ec</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// Anonymous Types 1.linq
from food in Items
where food.MenuCategory.Description == "Entree" &&  food.Active
orderby food.CurrentPrice descending
select new 
{
	Description = food.Description,
	Price = food.CurrentPrice,
	Calories = food.Calories
}