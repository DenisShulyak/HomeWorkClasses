using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClasses
{
    class Car
    {
        private double _engineСapacity; // Объем двигателя
        private string _classCar;// класс автомобиля(легковой, внедорожный , универсал и тд
        private string _color;// Цвет автомобиля
        private int _age;// Возраст
        private int _countCylinders;// Кол-во цилндров в двигателе


      public double GetEngineCapacity()
        {
            return _engineСapacity;
        }
        public void SetEngineCapacity(double engineCapacity)
        {
            _engineСapacity = engineCapacity;
        }

        public string GetColor()
        {
            return _color;
        }
        public void SetColor(string color)
        {
            _color = color;
        }

        public string GetClassCar()
        {
            return _classCar;
        }
        public void SetClassCar(string classCar)
        {
            _classCar = classCar;
        }

        public int GetAge()
        {
            return _age;
        }
        public void SetAge(int age)
        {
            _age = age;
        }

        public int GetCountCylinders()
        {
            return _countCylinders;
        }
        public void SetCountCylinders(int countCylinders)
        {
            _countCylinders = countCylinders;
        }


        private static void MethodRef(ref Car argumentRef)
        {
            argumentRef._age = 12;
        }

        // Статические поля представляющие общие характеристики об объектов класса Car
        private static string _brend; // Марка автомобиля
        private static int _horsepower; // Мощность двигателя

        public Car()// Конструктор по умолчанию
        {
            _brend = "BMW";
            _horsepower = 150;
            _age = 5;
            _classCar = "Легковой автомобиль";
            _color = "Black";
            _countCylinders = 8;
            _engineСapacity = 399 * _countCylinders; // 1 цилиндр = 399 см^3
        }
        public Car(double engineCapacity, int countCylinders, string color, int age, string classCar)
        {
            SetAge(age);
            SetClassCar(classCar);
            SetCountCylinders(countCylinders);
            SetColor(color);
            SetEngineCapacity(engineСapacity);
        }
        public Car(bool on)
        {
            GetAge();
            GetClassCar();
            GetColor();
            GetCountCylinders();
            GetEngineCapacity();
    
                
        }
        static Car()
        {
            _brend = "Audi";
        }
    }
}
