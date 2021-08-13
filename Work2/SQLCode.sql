SELECT Product.Name as "Название продукта", STRING_AGG(Category.Name, ',') as "Категории" FROM Product 
INNER JOIN Category ON Product.Id_Сategory = Category.Id
GROUP BY Product.Name;