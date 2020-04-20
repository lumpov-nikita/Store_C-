using GameStore.Models;
using GameStore.Models.Repository;
using GameStore.Pages.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameStore.Pages
{
	public partial class Profile : System.Web.UI.Page
	{


		protected void Page_Load(object sender, EventArgs e)
		{
			checkoutForm.Visible = true;
			checkoutMessage.Visible = false;

			if (IsPostBack)
			{
				Personnel myPers = new Personnel();
				if (TryUpdateModel(myPers,
				   new FormValueProvider(ModelBindingExecutionContext)))
				{

					new Repository().SavePersonnel(myPers);

					checkoutForm.Visible = false;
					checkoutMessage.Visible = true;
				}
			}

		}

		public string OrdersUrl
		{
			get
			{
				return generateURL("admin_orders");
			}
		}

		public string GamesUrl
		{
			get
			{
				return generateURL("admin_games");
			}
		}

		private string generateURL(string routeName)
		{
			return RouteTable.Routes.GetVirtualPath(null, routeName, null).VirtualPath;
		}
	}
}