﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;
using ShoppingCart.Data;

namespace ShoppingCart.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult DisplayProduct()
        {
            //create product list to store items details
            List<Product> productlists = ProductData.GetAllProducts();

            //to get top selling based on past purchases and code implementation
            List<Purchases> topsellingproduct = ProductData.GetTopSellingProduct();
            ViewData["topsellingproduct"] = topsellingproduct;

            //to get list of top 3 unique quantity values
            List<int> topthreeqty = thirdLargest(topsellingproduct);
            ViewData["topthreeqty"] = topthreeqty;

            //check if there is any pre-existing item in cart
            int count = CartData.CheckLastInCart(HttpContext.Session.GetString("userid"));

            //get WishList if logged in
            List<Wish> wishlist = new List<Wish>();
            if (HttpContext.Session.GetString("name") != null)
            {
                wishlist = WishData.GetWishList(HttpContext.Session.GetString("userid"));
            }

            //send data to View
            ViewData["wishlist"] = wishlist;
            ViewData["count"] = count;
            ViewData["productlists"] = productlists;
            ViewBag.a = 1; //indicator to display all products

            //pass name, if any, to HTML
            ViewData["name"] = HttpContext.Session.GetString("name");

            // to highlight "Shopping" as the selected menu-item
            ViewData["Is_Shopping"] = "menu_hilite";

            return View();
        }

        [HttpPost]
        public IActionResult Search(string search)
        {
            //list of searched products from db based on description
            List<Product> searchedproductlists = ProductData.GetProductSearch(search);

            if (searchedproductlists.Count == 0)
            {
                //check if there is any pre-existing item in cart
                int count = CartData.CheckLastInCart(HttpContext.Session.GetString("userid"));

                //send data to View
                ViewData["count"] = count;
                ViewData["search"] = search;
                ViewBag.a = 3; //indicator if search product not found

                //pass username, if any, to HTML
                ViewData["name"] = HttpContext.Session.GetString("name");

                // to highlight "Shopping" as the selected menu-item
                ViewData["Is_Shopping"] = "menu_hilite";
            }
            else
            {
                //to get top selling based on past purchases and code implementation
                List<Purchases> topsellingproduct = ProductData.GetTopSellingProduct();

                ViewData["topsellingproduct"] = topsellingproduct;

                //to get list of top 3 unique quantity values
                List<int> topthreeqty = thirdLargest(topsellingproduct);

                ViewData["topthreeqty"] = topthreeqty;

                //check if there is any pre-existing item in cart
                int count = CartData.CheckLastInCart(HttpContext.Session.GetString("userid"));

                //get WishList if logged in
                List<Wish> wishlist = new List<Wish>();
                if (HttpContext.Session.GetString("name") != null)
                {
                    wishlist = WishData.GetWishList(HttpContext.Session.GetString("userid"));
                }

                //send data to View
                ViewData["wishlist"] = wishlist;
                ViewData["count"] = count;
                ViewData["search"] = search;
                ViewData["foundproducts"] = searchedproductlists;
                ViewBag.a = 2; //indicator to display searched products

                //pass name, if any, to HTML
                ViewData["name"] = HttpContext.Session.GetString("name");

                // to highlight "Shopping" as the selected menu-item
                ViewData["Is_Shopping"] = "menu_hilite";
            }
            return View("DisplayProduct");
        }

        static List<int> thirdLargest(List<Purchases> topsellingproduct)
        {
            List<int> topthreehighestqty = new List<int>();

            //find first largest quantity value 
            int first = topsellingproduct[0].Quantity;

            for (int i = 1; i < topsellingproduct.Count; i++)
            {
                if (topsellingproduct[i].Quantity > first)
                    first = topsellingproduct[i].Quantity;
            }

            topthreehighestqty.Add(first);

            //find second largest quantity value 
            int second = 0;

            for (int i = 0; i < topsellingproduct.Count; i++)
                if (topsellingproduct[i].Quantity > second && topsellingproduct[i].Quantity < first)
                    second = topsellingproduct[i].Quantity;

            topthreehighestqty.Add(second);

            //find third largest quantity value 
            int third = 0;

            for (int i = 0; i < topsellingproduct.Count; i++)
            {
                if (topsellingproduct[i].Quantity > third && topsellingproduct[i].Quantity < second)
                    third = topsellingproduct[i].Quantity;
            }

            topthreehighestqty.Add(third);

            return topthreehighestqty;
        }
    }
}
