using CarLookUp.Core;
using CarLookUp.Services;
using CarLookUp.ViewModels;
using Postal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarLookUp.Controllers
{
    public class CarController : Controller
    {
        private ICarService _carService;
        private IEmailService _emailService;

        public CarController(ICarService carService, IEmailService emailService)
        {
            _carService = carService;
            _emailService = emailService;// new EmailService();
        }

        // GET: Car/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Car/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarClassVM model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _carService.CreateCar(Transform.FromViewModelToModelCar(model));

            DetailsEmailVM email = new DetailsEmailVM(Constants.DETAILS_EMAIL)
            {
                Subject = "subject",
                ToAddress = "rob@rnwood.co.uk",
                Id = int.Parse(model._Year),
                FirstName = model._maker,
                LastName = model._model
            };
            try
            {
                _emailService.Send(email);
            }
            catch (Exception e)
            {
                return View();
            }

            return RedirectToAction("Index");
        }

        // GET: Car/Delete/5
        public ActionResult Delete(Guid id)
        {
            _carService.DeleteCar(id);
            return View();
        }

        // POST: Car/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, CarClassVM collection)
        {
            try
            {
                // TODO: Add delete logic here
                _carService.DeleteCar(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Car/Details/5
        public ActionResult Details(Guid id)
        {
            return View(
                Transform.FromModelToViewModelCar(_carService.GetCarById(id))
                );
        }

        // GET: Car/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(Transform.FromModelToViewModelCar(_carService.GetCarById(id)));
        }

        // POST: Car/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, CarClassVM collection)
        {
            try
            {
                // TODO: Add update logic here
                _carService.UpdateCar(id, Transform.FromViewModelToModelCar(collection));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Car
        public ActionResult Index()
        {
            return View(
                Transform.FromModelListToViewModelListCar(_carService.GetCars())
                );
        }
    }
}
