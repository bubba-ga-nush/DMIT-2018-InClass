<Query Kind="Expression">
  <Connection>
    <ID>3cc90a6f-0494-46c9-aef7-1e5f36b4a9ec</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// List all the menu items that are Entrees in order from most to least expensive
from food in Items

where food.MenuCategory.Description == "Entree"
	|| food.MenuCategory.Description == "Beverage"
	
orderby food.CurrentPrice descending

group food by food.MenuCategoryID into result

select result