using Lesson_8__Constructor.Models;

namespace Lesson_8__Constructor.Services
{
    public class CarService
    {
        private List<Car> cars;
        public CarService()
        {
            cars = new List<Car>();
            DataSeed();
        }
        public Car AddCar(Car car)
        {
            car.Id = Guid.NewGuid();
            cars.Add(car);
            return car;
        }
        public bool DeleteCar(Guid carId)
        {
            var exists = false;
            foreach (var car in cars)
            {
                if (car.Id == carId)
                {
                    exists = true;
                    break;
                }
            }
            return exists;
        }
        public bool UpdateCar(Car updateCar)
        {
            for (var i = 0; i < cars.Count; i++)
            {
                if (cars[i].Id == updateCar.Id)
                {
                    cars[i] = updateCar;
                    return true;

                }
            }
            return false;
        }
        public Car GetById(Guid carId)
        {
            foreach (var car in cars)
            {
                if (car.Id == carId)
                {
                    return car;
                }
            }
            return null;
        }
        public List<Car> GetCars()
        {
            return cars;
        }

        public void DataSeed()
        {
            Car firstCar = new Car()
            {
                Id = Guid.NewGuid(),
                Name = "Nexia 2",
                Brand = " Chevrolet ",
                ManufacturedYear = 2015,
                Color = "White",
                HorsePower = 105,
                Price = 6000,
            };
            Car secondCar = new Car()
            {
                Id = Guid.NewGuid(),
                Name = "Gentra",
                Brand = " Chevrolet ",
                ManufacturedYear = 2022,
                Color = "Black",
                HorsePower = 104,
                Price = 13000,
            };


            cars.Add(firstCar);
            cars.Add(secondCar);
        }
    }
}
