<Query Kind="Expression">
  <Connection>
    <ID>c10dc1af-16a5-40e7-99b5-1cb522fbef37</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//Price of over 5 dollars
from x in Items
where x.CurrentPrice > 5.00m
select new
		{
			x.Description,
			x.Calories
		}

