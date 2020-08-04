using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using timmoweltNew3.Models;

namespace timmoweltNew3.Controllers
{
    public class HomeController : Controller
    {


        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }




        [HttpPost]
        public ActionResult Index(HaeuserViewModel haeuserviewmodel, FormCollection formcollection)
        {


            HaeuserRepo repo = new HaeuserRepo();

            //var varMietpreis = haeuserviewmodel.Mietpreis;
            //var varWohnflaeche = haeuserviewmodel.Wohnflaeche;
            //var varZimmer = haeuserviewmodel.Zimmer;


            //////////////////////////////////////////////////////////

            //HaeuserViewModel model = new HaeuserViewModel();

            //model.Ort = formcollection["Ort"];
            //model.Wohnungmieten = formcollection["Wohnungmieten"];

            //ViewBag.Ort = haeuserviewmodel.Ort;
            //ViewBag.Wohnungmieten = haeuserviewmodel.Wohnungmieten;




            /////////////////////////////////////////////////////////////empty list to take over the list elements filtered

            //List<Haeuser> haeuserModel = new List<Haeuser>();

            //foreach (var item in repo.localList)                                  //OK
            //{
            //    if (item.Ort == haeuserviewmodel.Ort || item.Zimmer == haeuserviewmodel.Zimmer || item.Wohnflaeche == haeuserviewmodel.Wohnflaeche)
            //    {
            //        haeuserModel.Add(item);
            //    }

            //};


            ///////////////////////////////////////////////

            var model = new List<Haeuser>();

            //ViewBag.Count = "Suchen";


            //////Nur Mietpreis changed
            if (haeuserviewmodel.Ort == null && haeuserviewmodel.Mietpreis != "   Mietpreis" && haeuserviewmodel.Wohnflaeche == "   Wohnflaeche" && haeuserviewmodel.Zimmer == "     Zimmer")
            {


                model = (from s in repo.LocalList

                         where s.Mietpreis == haeuserviewmodel.Mietpreis


                         select new Haeuser()
                         {

                             Ort = s.Ort,
                             Wohnflaeche = s.Wohnflaeche,
                             Mietpreis = s.Mietpreis,
                             Wohnungmieten = s.Wohnungmieten,
                             Zimmer = s.Zimmer,
                             Bilder = s.Bilder

                         }).ToList<Haeuser>();


                if (model.Count != 0)
                {
                    ViewBag.Count = model.Count + " Treffer";

                    //ViewBag.Mietpreis = varMietpreis.ToString();
                    //ViewBag.Wohnflaeche = varWohnflaeche.ToString() ;
                    //ViewBag.Zimmer = varZimmer.ToString(); 

                    return View("Index", model);
                }

                else
                {
                    ViewBag.Count = model.Count + " Treffer";

                    //ViewBag.Mietpreis = varMietpreis.ToString();
                    //ViewBag.Wohnflaeche = varWohnflaeche.ToString();
                    //ViewBag.Zimmer = varZimmer.ToString();

                    ViewBag.ErrorModel1 = "We found no suitable data";
                    ViewBag.ErrorModel1a = "Sorry, we have only three rooms option.";



                    return View("Index", model);
                }


            }





            //////Nur Wohnfleche changed
            if (haeuserviewmodel.Ort == null && haeuserviewmodel.Mietpreis == "   Mietpreis" && haeuserviewmodel.Wohnflaeche != "   Wohnflaeche" && haeuserviewmodel.Zimmer == "     Zimmer")
            {


                model = (from s in repo.LocalList

                         where s.Wohnflaeche == haeuserviewmodel.Wohnflaeche


                         select new Haeuser()
                         {

                             Ort = s.Ort,
                             Wohnflaeche = s.Wohnflaeche,
                             Mietpreis = s.Mietpreis,
                             Wohnungmieten = s.Wohnungmieten,
                             Zimmer = s.Zimmer,
                             Bilder = s.Bilder

                         }).ToList<Haeuser>();


                if (model.Count != 0)
                {
                    ViewBag.Count = model.Count + " Treffer";

                    //ViewBag.Mietpreis = varMietpreis.ToString();
                    //ViewBag.Wohnflaeche = varWohnflaeche.ToString();
                    //ViewBag.Zimmer = varZimmer.ToString();

                    //ViewBag.Wohnflaeche = haeuserviewmodel.Wohnflaeche;


                    return View("Index", model);
                }

                else
                {
                    ViewBag.Count = model.Count + " Treffer";

                    //ViewBag.Mietpreis = varMietpreis.ToString();
                    //ViewBag.Wohnflaeche = varWohnflaeche.ToString();
                    //ViewBag.Zimmer = varZimmer.ToString();

                    ViewBag.ErrorModel1 = "We found no suitable data";
                    ViewBag.ErrorModel1a = "Sorry, we have only three rooms option.";



                    return View("Index", model);
                }


            }



            //////Nur Zimmer changed
            if (haeuserviewmodel.Ort == null && haeuserviewmodel.Mietpreis == "   Mietpreis" && haeuserviewmodel.Wohnflaeche == "   Wohnflaeche" && haeuserviewmodel.Zimmer != "     Zimmer")
            {


                model = (from s in repo.LocalList

                         where s.Zimmer == haeuserviewmodel.Zimmer


                         select new Haeuser()
                         {

                             Ort = s.Ort,
                             Wohnflaeche = s.Wohnflaeche,
                             Mietpreis = s.Mietpreis,
                             Wohnungmieten = s.Wohnungmieten,
                             Zimmer = s.Zimmer,
                             Bilder = s.Bilder

                         }).ToList<Haeuser>();


                if (model.Count != 0)
                {
                    ViewBag.Count = model.Count + " Treffer";

                    //ViewBag.Mietpreis = varMietpreis.ToString();
                    //ViewBag.Wohnflaeche = varWohnflaeche.ToString();
                    //ViewBag.Zimmer = varZimmer.ToString();

                    return View("Index", model);
                }

                else
                {
                    ViewBag.Count = model.Count + " Treffer";

                    //ViewBag.Mietpreis = varMietpreis.ToString();
                    //ViewBag.Wohnflaeche = varWohnflaeche.ToString();
                    //ViewBag.Zimmer = varZimmer.ToString();

                    ViewBag.ErrorModel1 = "We found no suitable data";
                    ViewBag.ErrorModel1a = "Sorry, we have only three rooms option.";



                    return View("Index", model);
                }


            }




            // wenn Input Box Ort eingegeben ist und the anderen geaendert wurden
            if (haeuserviewmodel.Ort != null && haeuserviewmodel.Mietpreis != "   Mietpreis" && haeuserviewmodel.Wohnflaeche != "   Wohnflaeche" && haeuserviewmodel.Zimmer != "     Zimmer")
            {



                model = (from s in repo.LocalList

                         where s.Ort == haeuserviewmodel.Ort.ToLower() &&
                         s.Mietpreis == haeuserviewmodel.Mietpreis &&
                         s.Wohnungmieten == haeuserviewmodel.Wohnungmieten &&
                         s.Wohnflaeche == haeuserviewmodel.Wohnflaeche &&
                         s.Zimmer == haeuserviewmodel.Zimmer


                         select new Haeuser()
                         {

                             Ort = s.Ort,
                             Wohnflaeche = s.Wohnflaeche,
                             Mietpreis = s.Mietpreis,
                             Wohnungmieten = s.Wohnungmieten,
                             Zimmer = s.Zimmer,
                             Bilder = s.Bilder

                         }).ToList<Haeuser>();

                if (model.Count != 0)
                {
                    ViewBag.Count = model.Count + " Treffer";
                    return View("Index", model);
                }

                else {

                    ViewBag.count = model.Count + " Treffer";

                    ViewBag.ErrorModel1 = "We found no suitable data";
                    ViewBag.ErrorModel1a = "Sorry, we have only three rooms option.";

                    ViewBag.Count = model.Count + "Treffer";

                    return View("Index", model);
                }
            }




            if (haeuserviewmodel.Ort == null && haeuserviewmodel.Mietpreis != "   Mietpreis" && haeuserviewmodel.Wohnflaeche != "   Wohnflaeche" && haeuserviewmodel.Zimmer != "     Zimmer")
            {



                model = (from s in repo.LocalList


                         where s.Mietpreis == haeuserviewmodel.Mietpreis &&
                         s.Wohnungmieten == haeuserviewmodel.Wohnungmieten &&
                         s.Wohnflaeche == haeuserviewmodel.Wohnflaeche &&
                         s.Zimmer == haeuserviewmodel.Zimmer


                         select new Haeuser()
                         {

                             Ort = s.Ort,
                             Wohnflaeche = s.Wohnflaeche,
                             Mietpreis = s.Mietpreis,
                             Wohnungmieten = s.Wohnungmieten,
                             Zimmer = s.Zimmer,
                             Bilder = s.Bilder

                         }).ToList<Haeuser>();

                if (model.Count != 0)
                {
                    ViewBag.Count = model.Count + " Treffer";
                    return View("Index", model);
                }

                else
                {

                    ViewBag.count = model.Count + " Treffer";

                    ViewBag.ErrorModel1 = "We found no suitable data";
                    ViewBag.ErrorModel1a = "Sorry, we have only three rooms option.";

                    ViewBag.Count = model.Count + "Treffer";

                    return View("Index", model);
                }
            }




            //// wenn nur Input Box Ort eingegeben ist the anderen nicht geaendert wurden
            if (haeuserviewmodel.Ort != null && haeuserviewmodel.Mietpreis == "   Mietpreis" && haeuserviewmodel.Wohnflaeche == "   Wohnflaeche" && haeuserviewmodel.Zimmer == "     Zimmer")
            {

                model = (from s in repo.LocalList

                         where s.Ort == haeuserviewmodel.Ort.ToLower()


                         select new Haeuser()
                         {

                             Ort = s.Ort,
                             Wohnflaeche = s.Wohnflaeche,
                             Mietpreis = s.Mietpreis,
                             Wohnungmieten = s.Wohnungmieten,
                             Zimmer = s.Zimmer,
                             Bilder = s.Bilder

                         }).ToList<Haeuser>();


                if (model.Count != 0)
                {
                    ViewBag.count = model.Count + " Treffer";

                    return View("Index", model);
                }

                else
                {
                    ViewBag.Count = model.Count + " Treffer";

                    ViewBag.ErrorModel1 = "We found no suitable data";
                    ViewBag.ErrorModel1a = "Sorry, we have only three rooms option.";

                   

                    return View("Index", model);
                }

            }



            if (haeuserviewmodel.Ort != null && haeuserviewmodel.Mietpreis != "   Mietpreis" && haeuserviewmodel.Wohnflaeche == "   Wohnflaeche" && haeuserviewmodel.Zimmer == "     Zimmer")
            {

                model = (from s in repo.LocalList

                         where s.Ort == haeuserviewmodel.Ort.ToLower() &&
                         s.Mietpreis == haeuserviewmodel.Mietpreis


                         select new Haeuser()
                         {

                             Ort = s.Ort,
                             Wohnflaeche = s.Wohnflaeche,
                             Mietpreis = s.Mietpreis,
                             Wohnungmieten = s.Wohnungmieten,
                             Zimmer = s.Zimmer,
                             Bilder = s.Bilder

                         }).ToList<Haeuser>();


                if (model.Count != 0)
                {
                    ViewBag.count = model.Count + " Treffer";

                    return View("Index", model);
                }

                else
                {
                    ViewBag.Count = model.Count + " Treffer";

                    ViewBag.ErrorModel1 = "We found no suitable data";
                    ViewBag.ErrorModel1a = "Sorry, we have only three rooms option.";



                    return View("Index", model);
                }

            }




            if (haeuserviewmodel.Ort != null && haeuserviewmodel.Mietpreis == "   Mietpreis" && haeuserviewmodel.Wohnflaeche != "   Wohnflaeche" && haeuserviewmodel.Zimmer == "     Zimmer")
            {

                model = (from s in repo.LocalList

                         where s.Ort == haeuserviewmodel.Ort.ToLower() &&
                         s.Wohnflaeche == haeuserviewmodel.Wohnflaeche


                         select new Haeuser()
                         {

                             Ort = s.Ort,
                             Wohnflaeche = s.Wohnflaeche,
                             Mietpreis = s.Mietpreis,
                             Wohnungmieten = s.Wohnungmieten,
                             Zimmer = s.Zimmer,
                             Bilder = s.Bilder

                         }).ToList<Haeuser>();


                if (model.Count != 0)
                {
                    ViewBag.count = model.Count + " Treffer";

                    return View("Index", model);
                }

                else
                {
                    ViewBag.Count = model.Count + " Treffer";

                    ViewBag.ErrorModel1 = "We found no suitable data";
                    ViewBag.ErrorModel1a = "Sorry, we have only three rooms option.";



                    return View("Index", model);
                }

            }





            if (haeuserviewmodel.Ort != null && haeuserviewmodel.Mietpreis == "   Mietpreis" && haeuserviewmodel.Wohnflaeche == "   Wohnflaeche" && haeuserviewmodel.Zimmer != "     Zimmer")
            {

                model = (from s in repo.LocalList

                         where s.Ort == haeuserviewmodel.Ort.ToLower() &&
                         s.Zimmer == haeuserviewmodel.Zimmer


                         select new Haeuser()
                         {

                             Ort = s.Ort,
                             Wohnflaeche = s.Wohnflaeche,
                             Mietpreis = s.Mietpreis,
                             Wohnungmieten = s.Wohnungmieten,
                             Zimmer = s.Zimmer,
                             Bilder = s.Bilder

                         }).ToList<Haeuser>();


                if (model.Count != 0)
                {
                    ViewBag.count = model.Count + " Treffer";

                    return View("Index", model);
                }

                else
                {
                    ViewBag.Count = model.Count + " Treffer";

                    ViewBag.ErrorModel1 = "We found no suitable data";
                    ViewBag.ErrorModel1a = "Sorry, we have only three rooms option.";



                    return View("Index", model);
                }

            }



            //// wenn nur Input Box Ort und mietpreis eingegeben  ist the anderen nicht geaendert wurden
            //if (haeuserviewmodel.Ort != null && haeuserviewmodel.Mietpreis != "   Mietpreis" || haeuserviewmodel.Wohnflaeche != "   Wohnflaeche" && haeuserviewmodel.Zimmer == "     Zimmer")
            //{

            //    model = (from s in repo.LocalList

            //             where s.Ort == haeuserviewmodel.Ort.ToLower()


            //             select new Haeuser()
            //             {

            //                 Ort = s.Ort,
            //                 Wohnflaeche = s.Wohnflaeche,
            //                 Mietpreis = s.Mietpreis,
            //                 Wohnungmieten = s.Wohnungmieten,
            //                 Zimmer = s.Zimmer,
            //                 Bilder = s.Bilder

            //             }).ToList<Haeuser>();


            //    ViewBag.Count = model.Count + " Treffer";

            //    return View("Index", model);
            //}



            // wenn  Input Box  Ort nicht eingegeben ist the anderen nicht geaendert wurde
            //if(haeuserviewmodel.Ort == null  && haeuserviewmodel.Mietpreis == "   Mietpreis" && haeuserviewmodel.Wohnflaeche == "   Wohnflaeche" && haeuserviewmodel.Zimmer == "     Zimmer")
            //{

            //   

            //    return View("Index");
            //}


            /////////////////////////////////////////////////////
            //model.Any(x => (String.Equals(x.Ort, haeuserviewmodel.Ort, StringComparison.OrdinalIgnoreCase)));
            /////////////////////////////////////////////////////
            // var model2 = repo.localList.Where(m => m.Ort == haeuserviewmodel.Ort).Select(x => new Haeuser() { Ort = x.Ort, Mietpreis=x.Mietpreis, Wohnflaeche=x.Wohnflaeche, Wohnungmieten=x.Wohnungmieten, Zimmer=x.Zimmer, Bilder=x.Bilder});
            if (haeuserviewmodel.Ort == null && haeuserviewmodel.Mietpreis == "   Mietpreis" && haeuserviewmodel.Wohnflaeche == "   Wohnflaeche" && haeuserviewmodel.Zimmer == "     Zimmer")
            {
                {
                    ViewBag.Count = model.Count + " Treffer";

                    ViewBag.ErrorModel = "No data found, please enter data";

                    return View("Index", model);
                }
            }



            return View("Index");

        } // end of Index



    } // End of Controller
} // End of Namespace