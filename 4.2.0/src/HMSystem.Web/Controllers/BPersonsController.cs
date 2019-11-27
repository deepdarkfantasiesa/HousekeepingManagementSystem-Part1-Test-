using HMSystem.Web.Models.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMSystem.Web.Controllers
{
    public class BPersonsController: HMSystemControllerBase
    {
        private readonly IBPersons _bPersons;
        public BPersonsController(IBPersons bPersons)
        {
            _bPersons = bPersons;
        }

        public async Task<ActionResult> Index(GetAllSPBI input)
        {
            var output = await _bPersons.GetAll(input);
            var model = new IndexViewModel(output.Items);
            return View(model);
        }
    }
}
