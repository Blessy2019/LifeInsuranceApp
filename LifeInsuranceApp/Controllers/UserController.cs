using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LifeInsuranceApp.Models;

namespace LifeInsuranceApp.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            UserModel user = new UserModel();
            try
            {
                user.OccupationList = GetOccupationList();
                return View(user);
            }
            catch (Exception ex)
            { throw ex; }

        }

        //Get the occupation list for dropdown
        public List<SelectListItem> GetOccupationList()
        {
            try
            {
                List<SelectListItem> occupation = new List<SelectListItem>();
                occupation.Add(new SelectListItem { Value = "Select", Text = "-- Please Select --" });
                occupation.Add(new SelectListItem { Value = "Cleaner", Text = "Cleaner" });
                occupation.Add(new SelectListItem { Value = "Author", Text = "Author" });
                occupation.Add(new SelectListItem { Value = "Farmer", Text = "Farmer" });
                occupation.Add(new SelectListItem { Value = "Mechanic", Text = "Mechanic" });
                occupation.Add(new SelectListItem { Value = "Florist", Text = "Florist" });

                return occupation;
            }
            catch (Exception ex) { throw ex; }
        }

        // Get the Occupation Rating based on Occupation Name
        public string OccupationRating(string occupation_name)
        {
            try
            {
                ArrayList arrList = new ArrayList();
                arrList.Add(new UserModel { Occupation = "Cleaner", Rating = "LightManual" });
                arrList.Add(new UserModel { Occupation = "Doctor", Rating = "Professional" });
                arrList.Add(new UserModel { Occupation = "Author", Rating = "WhiteCollar" });
                arrList.Add(new UserModel { Occupation = "Farmer", Rating = "HeavyManual" });
                arrList.Add(new UserModel { Occupation = "Mechanic", Rating = "HeavyManual" });
                arrList.Add(new UserModel { Occupation = "Florist", Rating = "LightManual" });

                var query = (from UserModel user in arrList
                             where user.Occupation == occupation_name
                             select user.Rating).FirstOrDefault();

                return query.ToString();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public decimal RatingFactor(string rating)
        {
            try
            {
                ArrayList arrList = new ArrayList();
                arrList.Add(new UserModel { Rating = "Professional", RatingFactor = 1.0 });
                arrList.Add(new UserModel { Rating = "WhiteCollar", RatingFactor = 1.25 });
                arrList.Add(new UserModel { Rating = "LightManual", RatingFactor = 1.50 });
                arrList.Add(new UserModel { Rating = "HeavyManual", RatingFactor = 1.75 });

                var query = (from UserModel user in arrList
                             where user.Rating == rating
                             select user.RatingFactor).FirstOrDefault();

                return Convert.ToDecimal(query);
            }
            catch (Exception ex) { throw ex; }
        }

        // Calculate the Premium Amount
        public string CalculatePremium(int age, int death_amt, decimal rating_factor)
        {
            UserModel user = new UserModel();
            try
            {
                user.Total = (death_amt * rating_factor * age) / 1000 * 12;
                var model = "Total Premium = $" + user.Total.ToString("0.00");

                return model;
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}