using CarLookUp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLookUp.Data
{
    public interface IData
    {
        void CreateCar(CarClass car);

        void DeleteCar(Guid Id);

        CarClass GetCarById(Guid id);

        IEnumerable<CarClass> GetCars();

        void UpdateCar(Guid Id, CarClass car);
    }
}
