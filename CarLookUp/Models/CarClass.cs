using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarLookUp.Models
{
    public class CarClass
    {
        //private ICollection<CarClass> carList;

        public CarClass(
            //String maker, String model, String year
            )
        {
            //_Id = new Guid();
            //maker = _maker;
            //model = _model;
            //year = _Year;
        }

        public Guid _Id { get; set; }
        public String _maker { get; set; }
        public String _model { get; set; }
        public String _Year { get; set; }

        //public void DeleteCar(Guid Id)
        //{
        //    var car = _carList.Where(c => c._Id == Id).SingleOrDefault();
        //    _carList.Remove(car);
        //}

        //public CarClass GetCarById(Guid id)
        //{
        //    var car = _carList.Where(c => c._Id == id).SingleOrDefault();
        //    return car;
        //}

        //public IEnumerable<CarClass> GetCars()
        //{
        //    return _carList;
        //}

        //public void UpdateCar(Guid Id, String updateMaker, String updateModel, String updateYear)
        //{
        //    var car = _carList.Where(c => c._Id == Id).Single();

        //    if (updateMaker != null)
        //    {
        //        car._maker = updateMaker;
        //    }

        //    if (updateModel != null)
        //    {
        //        car._model = updateModel;
        //    }

        //    if (updateYear != null)
        //    {
        //        car._Year = updateYear;
        //    }
        //}
    }
}
