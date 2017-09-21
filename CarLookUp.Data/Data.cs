using CarLookUp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLookUp.Data
{
    public class Data : IData
    {
        private static List<CarClass> _carList = new List<CarClass>()
            {
                new CarClass(){_Id = Guid.NewGuid(), _maker = "Lexus", _model = "LS 400", _Year = "1990" },
                new CarClass(){_Id = Guid.NewGuid(), _maker = "Nissan", _model = "Altima", _Year = "2015" },
                new CarClass(){_Id = Guid.NewGuid(), _maker = "Chevy", _model = "OldsMobile", _Year = "2004" }
            };// = new List<CarClass>();

        public static List<CarClass> AllCars()
        {
            if (_carList == null)
            {
                _carList = StartList();
            }

            return _carList;
        }

        public static List<CarClass> StartList()
        {
            //Guid.NewGuid();
            return new List<CarClass>()
            {
                new CarClass(){_Id = Guid.NewGuid(), _maker = "Lexus", _model = "LS 400", _Year = "1990" },
                new CarClass(){_Id = Guid.NewGuid(), _maker = "Nissan", _model = "Altima", _Year = "2015" },
                new CarClass(){_Id = Guid.NewGuid(), _maker = "Chevy", _model = "OldsMobile", _Year = "2004" }
            };
        }

        public void CreateCar(CarClass car)
        {
            _carList.Add(car);
        }

        public void DeleteCar(Guid Id)
        {
            var car = _carList.Where(c => c._Id == Id).SingleOrDefault();
            _carList.Remove(car);
        }

        public CarClass GetCarById(Guid id)
        {
            var car = _carList.Where(c => c._Id == id).SingleOrDefault();
            return car;
        }

        public IEnumerable<CarClass> GetCars()
        {
            return _carList;
        }

        public void UpdateCar(Guid Id, CarClass value)
        {
            var car = _carList.Where(c => c._Id == Id).Single();

            if (value._maker != null) car._maker = value._maker;
            if (value._model != null) car._model = value._model;
            if (value._Year != null) car._Year = value._Year;
        }
    }
}
