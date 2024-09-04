# Mindbox-Test
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

