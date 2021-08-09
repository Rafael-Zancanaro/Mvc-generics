using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppGenerics.Models;
using WebAppGenerics.Models.Repository;

namespace WebAppGenerics.Controllers
{
    public class BaseController<M,R> : Controller where M : BaseModel where R : BaseRepository<M>
    {
        R repository;
        public BaseController(R repository)
        {
            this.repository = repository;  
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {

            return View(repository.Read(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Create(M model)
        {
            try
            {
                repository.Create(model);  
                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Edit(int id)
        {
            return View(repository.Read(id));
        }

        
        [HttpPost]
        public ActionResult Edit(M model)
        {
            try
            {
                repository.Update(model);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Delete(int id)
        {
            
            return View(repository.Read(id));
        }

        
        [HttpPost]
        public ActionResult Delete( M model )
        {
            try
            {
                repository.Delete(model.Id);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult List() 
        { 
            return View(repository.Read());
        }
    }
}
