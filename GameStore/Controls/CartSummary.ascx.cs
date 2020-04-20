using System;
using System.Linq;
using GameStore.Models;
using System.Web.Routing;
using GameStore.Pages.Helpers;
using System.Web.Security;

namespace GameStore.Controls
{
	public partial class CartSummary : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Cart myCart = SessionHelper.GetCart(Session);
			csQuantity.InnerText = myCart.Lines.Sum(x => x.Quantity).ToString();
			csTotal.InnerText = myCart.ComputeTotalValue().ToString("c");
			csLink.HRef = RouteTable.Routes.GetVirtualPath(null, "cart",
				null).VirtualPath;
			if (this.Request.IsAuthenticated)
			{
				csLink_in1.Visible = false;
				csLink_pro1.Visible = true;
				csLink_out1.Visible = true;
			}
			if (!this.Request.IsAuthenticated)
			{
				csLink_in1.Visible = true;
				csLink_pro1.Visible = false;
				csLink_out1.Visible = false;
			}
			csLink_in1.HRef = RouteTable.Routes.GetVirtualPath(null, "in",
				null).VirtualPath;
			csLink_out1.HRef = RouteTable.Routes.GetVirtualPath(null, "out",
				null).VirtualPath;
			csLink_pro1.HRef = RouteTable.Routes.GetVirtualPath(null, "pro",
				null).VirtualPath;
		}
	}
}