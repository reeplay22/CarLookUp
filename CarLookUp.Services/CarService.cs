using CarLookUp.Core;
using CarLookUp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLookUp.Services
{
    public class CarService : ICarService
    {
        private IData _data;

        public CarService(IData data)
        {
            _data = data;
        }

        public void CreateCar(CarClass car)
        {
            if (car != null) _data.CreateCar(car);
        }

        public void DeleteCar(Guid Id)
        {
            if (Id != null) _data.DeleteCar(Id);
        }

        public CarClass GetCarById(Guid id)
        {
            //if (id != null)
            return _data.GetCarById(id);
        }

        public IEnumerable<CarClass> GetCars()
        {
            return _data.GetCars();
        }

        public void UpdateCar(Guid Id, CarClass value)
        {
            _data.UpdateCar(Id, value);
            //var car = _carList.Where(c => c._Id == Id).Single();

            //if (updateMaker != null)
            //{
            //    car._maker = updateMaker;
            //}

            //if (updateModel != null)
            //{
            //    car._model = updateModel;
            //}

            //if (updateYear != null)
            //{
            //    car._Year = updateYear;
            //}
        }
    }
}
