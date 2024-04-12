using System;

public class Triangle
{
  private double side1;
  private double side2;
  private double side3;

  public Triangle(double side1 = 3, double side2 = 4, double side3 = 5)
  {
	this.side1 = side1;
	this.side2 = side2;
	this.side3 = side3;
  }

  public Triangle(Triangle triangle)
  {
	this.side1 = triangle.side1;
	this.side2 = triangle.side2;
	this.side3 = triangle.side3;
  }

  public void PrintSides()
  {
	Console.WriteLine($"Сторона 1: {this.side1}");
	Console.WriteLine($"Сторона 2: {this.side2}");
	Console.WriteLine($"Сторона 3: {this.side3}");
  }

  public double CalculatePerimeter()
  {
	return this.side1 + this.side2 + this.side3;
  }

  public double CalculateArea()
  {
	double perimeter = this.CalculatePerimeter() / 2;
	return Math.Sqrt(perimeter *(perimeter - this.side1) *
					(perimeter - this.side2) *(perimeter - this.side3));
  }

  public bool Exists()
  {
	return this.side1 + this.side2 > this.side3 && this.side1 + this.side3 > this.side2
	  && this.side2 + this.side3 > this.side1;
  }

  public bool IsRightAngled()
  {
	return this.side1 * this.side1 + this.side2 * this.side2 == this.side3 * this.side3 ||
	  this.side1 * this.side1 + this.side3 * this.side3 == this.side2 * this.side2 ||
	  this.side2 * this.side2 + this.side3 * this.side3 == this.side1 * this.side1;
  }

  public bool IsAcuteAngled()
  {
	return this.side1 * this.side1 + this.side2 * this.side2 > this.side3 * this.side3 &&
	  this.side1 * this.side1 + this.side3 * this.side3 > this.side2 * this.side2 &&
	  this.side2 * this.side2 + this.side3 * this.side3 > this.side1 * this.side1;
  }

  public bool IsObtuseAngled()
  {
	return this.side1 * this.side1 + this.side2 * this.side2 < this.side3 * this.side3 ||
	  this.side1 * this.side1 + this.side3 * this.side3 < this.side2 * this.side2 ||
	  this.side2 * this.side2 + this.side3 * this.side3 < this.side1 * this.side1;
  }

  public bool IsIsosceles()
  {
	return side1 == side2 || side1 == side3 || side2 == side3;
  }

  public double Side1
  {
	get { return this.side1; }
	set { this.side1 = value; }
  }

  public double Side2
  {
	get { return this.side2; }
	set { this.side2 = value; }
  }
  
  public double Side3
  {
	get { return this.side3; }
	set { this.side3 = value; }
  }

  public bool IsTriangleValid
  {
	get { return this.Exists(); }
  }

  public static Triangle operator *(Triangle t1, Triangle t2)
  {
	double newSide1 = t1.side1 + t2.side1;
	double newSide2 = t1.side2 + t2.side2;
	double newSide3 = t1.side3 + t2.side3;
	return new Triangle(newSide1, newSide2, newSide3);
  }

  public static Triangle operator ~(Triangle t)
  {
	double newSide = t.side1 + t.side2 + t.side3;
	return new Triangle(newSide, newSide, newSide);
  }

  public static Triangle operator --(Triangle t)
  {
	if(t.side1 >= t.side2 && t.side1 >= t.side3)
	  {
		t.side1--;
	  }
	else if(t.side2 >= t.side1 && t.side2 >= t.side3)
	  {
		t.side2--;
	  }
	else
	  {
		t.side3--;
	  }
	return t;
  }

  public static double operator +(Triangle t1, Triangle t2)
  {
	double area1 = t1.CalculateArea();
	double area2 = t2.CalculateArea();
	return area1 + area2;
  }

  public static Triangle operator &(Triangle t1, Triangle t2)
  {
	double perimeter1 = t1.CalculatePerimeter();
	double perimeter2 = t2.CalculatePerimeter();
	return perimeter1 > perimeter2 ? t1 : t2;
  }

  public static Triangle operator *(Triangle t, double factor)
  {
	double newSide1 = t.side1 * factor;
	double newSide2 = t.side2 * factor;

	double newSide3 = t.side3 * factor;
	return new Triangle(newSide1, newSide2, newSide3);
  }

  public static bool operator ==(Triangle t1, Triangle t2)
  {
	double perimeter1 = t1.CalculatePerimeter();
	double perimeter2 = t2.CalculatePerimeter();
	return perimeter1 == perimeter2;
  }

  public static bool operator !=(Triangle t1, Triangle t2)
  {
	double perimeter1 = t1.CalculatePerimeter();
	double perimeter2 = t2.CalculatePerimeter();
	return perimeter1 != perimeter2;
  }

  public static explicit operator string(Triangle t)
  {
	return $"Сторона 1: {t.side1}, Сторона 2: {t.side2}, Сторона 3: {t.side3}";
  }

  public static implicit operator Triangle(string sides)
  {
	string[] sideValues = sides.Split(' ');
	double side1 = Double.Parse(sideValues[0]);
	double side2 = Double.Parse(sideValues[1]);
	double side3 = Double.Parse(sideValues[2]);
	return new Triangle(side1, side2, side3);
  }

  public override string ToString()
  {
	return $"Сторона 1: {this.side1}, Сторона 2: {this.side2}, Сторона 3: {this.side3}";
  }
}

class Program
{
  static void Main()
  {
	Triangle triangle1 = new Triangle(3, 4, 5);
	Triangle triangle2 = new Triangle(2, 3, 4);
	// 	Triangle triangleFromTriangle = new Triangle(triangle1);
    triangle1.PrintSides();
    
    double perimeter = triangle1.CalculatePerimeter(); // Расчет периметра треугольника
    Console.WriteLine("Периметр: " + perimeter);
    
    double area = triangle1.CalculateArea(); // Расчет площади треугольника
    Console.WriteLine("Площадь: " + area);
    
    bool exists = triangle1.Exists(); // Проверка существования треугольника
    Console.WriteLine("Такой треугольник существует: " + exists);
    
    bool isRightAngled = triangle1.IsRightAngled(); // Проверка, является ли треугольник прямоугольным
    Console.WriteLine("Треугольник прямоугольный: " + isRightAngled);
    
    triangle1.Side1 = 6; // Установка новой длины стороны треугольника
    bool isValidTriangle = triangle1.IsTriangleValid; // Проверка, является ли треугольник с заданными сторонами допустимым
    Console.WriteLine("Треугольник допустимый: " + isValidTriangle);
    
    double sum = triangle1 + triangle2; // Сумма площадей двух треугольников
    Console.WriteLine("Сумма площадей двух треугольников: " + sum);
    
    Triangle biggerTriangle = triangle1 & triangle2; // Выбирает треугольник с большим периметром
    Console.WriteLine("Выбирает треугольник с большим периметром: " + biggerTriangle.ToString());
    
    Triangle scaledTriangle = triangle1 * 2; // Увеличивает все стороны треугольника в два раза
    Console.WriteLine("Увеличивает все стороны треугольника в два раза: " + scaledTriangle.ToString());
    
    bool arePerimetersEqual = triangle1 == triangle2; // Сравнивает два треугольника по периметрам
    Console.WriteLine("Сравнивает два треугольника по периметрам: " + arePerimetersEqual);
    
    bool arePerimetersDifferent = triangle1 != triangle2; // Проверяем, что периметры двух треугольников не равны
    Console.WriteLine("Проверяем, что периметры двух треугольников не равны: " + arePerimetersDifferent);
    
    string triangleAsString =(string)triangle1; // Явное преобразование в строку
    Console.WriteLine("Явное преобразование в строку: " + triangleAsString);
    
    Triangle triangleFromString = "9 9 9"; // Неявное преобразование из строки
    Console.WriteLine("Явное преобразование в строку: " + triangleFromString.ToString());
  }
}
