<Query Kind="Expression">
  <Connection>
    <ID>c3f4fe64-2e4b-4f5f-bba0-0412d39447d3</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//from row in Bills
//orderby row.BillDate descending
//select row.BillDate
Bills.Max(row => row.BillDate)
// Among the bills, get the max (largest) row such that I look at/use the row's BillDate