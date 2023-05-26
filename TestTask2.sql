SELECT p.Name as 'Имя продукта', c.Name as 'Имя категории'
FROM Products p
LEFT JOIN ProductCategories pc
		ON p.Id = pc.ProductId
LEFT JOIN Categories c
		ON c.Id = pc.CategoryId