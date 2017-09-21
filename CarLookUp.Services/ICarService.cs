using CarLookUp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLookUp.Services
{
    public interface ICarService
    {
        void CreateCar(CarClass car);

        void DeleteCar(Guid Id);

        CarClass GetCarById(Guid id);

        IEnumerable<CarClass> GetCars();

        void UpdateCar(Guid Id, CarClass value);
    }
}
