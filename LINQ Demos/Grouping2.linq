<Query Kind="Expression">
  <Connection>
    <ID>3cc90a6f-0494-46c9-aef7-1e5f36b4a9ec</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from food in Items
group food by new {food.MenuCategoryID, food.CurrentPrice}
// No need for the select clause if all you want is grouping