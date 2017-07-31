using Microsoft.AspNetCore.Mvc;
using System;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {
      [Route("/form")]
        public ActionResult Form()
        {
          return View();
        }

      [Route("/form")]
        public ActionResult Calculate_Shipping()
        {
            Parcel myParcel = new Parcel();
            myParcel.SetLength(Int32.Parse(Request.Query["length"]));
            myParcel.SetHeight(Int32.Parse(Request.Query["height"]));
            myParcel.SetWidth(Int32.Parse(Request.Query["width"]));
            myParcel.CalculateWeight();
            return View(myParcel);
        }


  }
}
