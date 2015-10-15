<Query Kind="Program">
  <Connection>
    <ID>c3f4fe64-2e4b-4f5f-bba0-0412d39447d3</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

void Main()
{
	var data = from cat in MenuCategories
	orderby cat.Description
	select new CategoryDTO() // use the DTO
	{
		Description = cat.Description,
		MenuItems = from item in cat.Items
					where item.Active
					orderby item.Description
					select new MenuItemDTO
					{
						Description = item.Description,
						Price = item.CurrentPrice,
						Calories = item.Calories,
						Comment = item.Comment
					}
	};
	data.Dump();
}

// Define other methods and classes here
public class CategoryDTO // Data Transter Object
{
	public string Description { get;set; }
	public IEnumerable<MenuItemDTO> MenuItems { get;set; }
}
public class MenuItemDTO
{
	public string Description { get;set; }
	public decimal Price { get;set; }
	public int? Calories { get;set; }
	public string Comment { get;set; }
}
