select p.Name as ProductName, c.Name as CategoryName from PRODUCTS as p
full join CATEGORIES_AND_PRODUCTS as cp on cp.ProductId = p.Id
left join CATEGORIES as c on c.Id = cp.CategoryId