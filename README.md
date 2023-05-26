# MindBoxTestTask

## Задание 1
### Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

* Юнит-тесты
* Легкость добавления других фигур
* Вычисление площади фигуры без знания типа фигуры
* Проверку на то, является ли треугольник прямоугольным

### Пояснение к заданию 1

В обоих проектах используется .NET 6, для юнит-тестов используется библиотека MSTest

* Для легкости добавления фигур реализуем интерфейс IFigure
* Для вычисления площади без знания типа фигуры вызываем метод GetSquare через интерфейс IFigure
* Написаны необходимые юнит-тесты
* Добавлен метод проверки является ли треугольник прямоугольным

## Задание 2
### В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

### Пояснение к заданию 2

Файл с запросом к БД (_TestTask2.sql_) расположен в корневой папке
