# MindboxTest
Решение тестового задания для Mindbox
* Доступно создание треугольников и кругов;
* Возможна проверка треугольника на прямоугольность;
* Просто наследуйтесь от IShape и реализуйте GetArea, чтобы получить новую фигуру;
* Реализована защита от создания недействительных фигур;
* Написаны тесты.

# Применение

```csharp
using AreaCalc;

var circle = new Circle(3);
var triangle = new Triangle(2, 1, 2.6);

PrintArea(circle);
PrintArea(triangle);

void PrintArea(IShape shape)
{
    Console.WriteLine($"Area of {nameof(shape)} is {shape.GetArea():F2}");
}
```

# Ответ на задачу с MS SQL Server

Запрос для получения списка "Имя продукта - Имя категории" выглядит следующим образом:

```sql
SELECT 
    p.Name AS Product_name,
    c.Name AS Category_name
FROM 
    Products p
LEFT JOIN 
    ProductsCategories pc ON p.Product_Id = pc.Product_Id
LEFT JOIN 
    Categories c ON pc.Category_Id = c.Category_Id;
```

##### ProductsCategories это связующая таблица, необходимая для разрешения связи М:М
##### Left Join обеспечит присутствие названия продукта в результатирующей таблице, даже если у продукта нет категории
