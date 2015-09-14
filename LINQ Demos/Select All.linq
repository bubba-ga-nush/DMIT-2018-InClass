<Query Kind="Expression">
  <Connection>
    <ID>fc57471c-2d2c-4df9-b42a-2f569a0dc47c</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

 from data in Waiters
 where data.ReleaseDate == null
 select data