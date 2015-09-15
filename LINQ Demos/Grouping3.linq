<Query Kind="Expression" />

from food in Items
group food by food.MenuCategoryID into result
select result