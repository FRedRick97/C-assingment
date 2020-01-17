using System;

namespace assingment
{
    class Vehicle
    {
        private String _make;
        private int _yearOfManufacture;
        private String _model;
        private float _speed;

        protected Vehicle()
        {
            Console.WriteLine("Default constructor called");
        }
        protected Vehicle(String make, String model, int year, float speed)
        {
            this._make = make;
            this._model = model;
            this._yearOfManufacture = year;
            this._speed = speed;
        }

        protected String Make
        {
            get => _make;
            set => _make = value;
        }

        protected int YearOfManufacture
        {
            get => _yearOfManufacture;
            set => _yearOfManufacture = value;
        }

        protected String Model
        {
            get => _model;
            set => _model = value;
        }

        protected float Speed
        {
            get => _speed;
            set => _speed = value;
        }

        protected virtual void Accelerate(int change)
        {
            Console.WriteLine("Accelerate() called from Vehicle");
        }

        protected virtual void Deaccelerate(int change)
        {
            Console.WriteLine("Deaccelerate() called from Vehicle");
        }

        protected virtual void Stop()
        {
            Console.WriteLine("Stop() called from Vehicle");
        }

        protected Boolean isMoving()
        {
            if(Speed == 0) { return true; }

            return false;
        }

        public static void EntryPoint()
        {
            Vehicle v = new Vehicle();
            v = new Bike("Yamaha", "Kawasaki", 2016, (float)240.99, "Black");
            v.Accelerate(174);
            v.Stop();
            ((Bike) v).State();

            v = new Car("Honda", "City", 2018, (float)175.99, 5);
            v.Accelerate(80);
            v.Stop();
            ((Car) v).State();
        }
    }

    class Bike : Vehicle
    {
        private String _color;

        protected String Color
        {
            get => _color;
            set => _color = value;
        }
        public Bike(String make, String model, int year, float speed, String color) : base(make, model, year, speed)
        {
            this._color = color;
        }
        protected override void Accelerate(int change)
        {
            Console.WriteLine("Accelerate() called from bike!!");
            Speed += change;
        }

        protected override void Deaccelerate(int change)
        {
            Console.WriteLine("Deaccelerate() called from bike!!");
            if((Speed - change) > 0) { Speed -= change; }
        }

        protected override void Stop()
        {
            Console.WriteLine("Stop() called from bike!!");
            Speed = 0;
        }

        public void State()
        {
            if(isMoving()) { Console.WriteLine("Bike is moving!!"); }
            else { Console.WriteLine("Bike is stopped"); }
        }
    }

    class Bicycle : Vehicle
    {
        private bool _hasGear;
        public Bicycle(String make, String model, int year, float speed, bool hasGear) : base(make, model, year, speed)
        {
            this._hasGear = hasGear;
        }

        protected bool hasGear
        {
            get => _hasGear;
            set => _hasGear = value;
        }
        protected override void Accelerate(int change)
        {
            Console.WriteLine("Accelerate() called from Bicycle!!");
            Speed += change;
        }

        protected override void Deaccelerate(int change)
        {
            Console.WriteLine("Deaccelerate() called from Bicycle!!");
            if((Speed - change) > 0) { Speed -= change; }
        }

        protected override void Stop()
        {
            Console.WriteLine("Stop() called from Bicycle!!");
            Speed = 0;
        }

        public void State()
        {
            if(isMoving()) { Console.WriteLine("Bicycle is moving!!"); }
            else { Console.WriteLine("Bicycle is stopped"); }
        }
    }

    class Car : Vehicle
    {
        private int _seats;
        public Car (String make, String model, int year, float speed, int seats) : base(make, model, year, speed)
        {
            this._seats = seats;
        }

        protected int Seats
        {
            get => _seats;
            set => _seats = value;
        }
        protected override void Accelerate(int change)
        {
            Console.WriteLine("Accelerate() called from Car!!");
            Speed += change;
        }

        protected override void Deaccelerate(int change)
        {
            Console.WriteLine("Deaccelerate() called from Car!!");
            if((Speed - change) > 0) { Speed -= change; }
        }

        protected override void Stop()
        {
            Console.WriteLine("Stop() called from Car!!");
            Speed = 0;
        }

        public void State()
        {
            if(isMoving()) { Console.WriteLine("Car is moving!!"); }
            else { Console.WriteLine("Car is stopped"); }
        }
    }

    class Truck : Vehicle
    {
        private bool _hasPayload;
        public Truck (String make, String model, int year, float speed, bool hasPayload) : base(make, model, year, speed)
        {
            this._hasPayload = hasPayload;
        }

        protected bool Seats
        {
            get => _hasPayload;
            set => _hasPayload = value;
        }
        protected override void Accelerate(int change)
        {
            Console.WriteLine("Accelerate() called from Truck!!");
            Speed += change;
        }

        protected override void Deaccelerate(int change)
        {
            Console.WriteLine("Deaccelerate() called from Truck!!");
            if((Speed - change) > 0) { Speed -= change; }
        }

        protected override void Stop()
        {
            Console.WriteLine("Stop() called from Truck!!");
            Speed = 0;
        }

        public void State()
        {
            if(isMoving()) { Console.WriteLine("Truck is moving!!"); }
            else { Console.WriteLine("Truck is stopped"); }
        }
    }
}
