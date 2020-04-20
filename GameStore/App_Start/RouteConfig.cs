﻿using System;
using System.Web.Routing;

namespace GameStore
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.MapPageRoute(null, "list/{category}/{page}",
										"~/Pages/Listing.aspx");
			routes.MapPageRoute(null, "list/{page}", "~/Pages/Listing.aspx");
			routes.MapPageRoute(null, "", "~/Pages/Listing.aspx");
			routes.MapPageRoute(null, "list", "~/Pages/Listing.aspx");

			routes.MapPageRoute("cart", "cart", "~/Pages/CartView.aspx");
			routes.MapPageRoute("in", "in", "~/Pages/Login.aspx");
			routes.MapPageRoute("out", "out", "~/Pages/Out.aspx");
			routes.MapPageRoute("pro", "pro", "~/Pages/Profile.aspx");
			routes.MapPageRoute("checkout", "checkout", "~/Pages/Checkout.aspx");

			routes.MapPageRoute("admin_orders", "admin/orders", "~/Pages/Admin/Orders.aspx");
			routes.MapPageRoute("admin_games", "admin/games", "~/Pages/Admin/Games.aspx");
		}
	}
}