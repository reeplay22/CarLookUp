using CarLookUp.Core;
using CarLookUp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarLookUp
{
    public static class Transform
    {
        public static IEnumerable<CarClassVM> FromModelListToViewModelListCar(IEnumerable<CarClass> carModel)
        {
            return carModel.Select(c => FromModelToViewModelCar(c));
        }

        public static CarClassVM FromModelToViewModelCar(CarClass carModel)
        {
            return new CarClassVM()
            {
                _Id = carModel._Id,
                _model = carModel._model,
                _maker = carModel._maker,
                _Year = carModel._Year
            };
        }

        public static CarClass FromViewModelToModelCar(CarClassVM carModel)
        {
            return new CarClass()
            {
                _Id = carModel._Id,
                _model = carModel._model,
                _maker = carModel._maker,
                _Year = carModel._Year
            };
        }
    }
}
