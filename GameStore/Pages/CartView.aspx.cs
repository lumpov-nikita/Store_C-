using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using GameStore.Models;
using GameStore.Models.Repository;
using GameStore.Pages.Helpers;

namespace GameStore.Pages
{
	public partial class CartView : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack)
			{
				Repository repository = new Repository();
				int gameId;
				if (int.TryParse(Request.Form["remove"], out gameId))
				{
					Game gameToRemove = repository.Games
						.Where(g => g.GameId == gameId).FirstOrDefault();
					if (gameToRemove != null)
					{
						SessionHelper.GetCart(Session).RemoveLine(gameToRemove);
					}
				}
				if (int.TryParse(Request.Form["up"], out gameId))
				{
					Game gameToAdd = repository.Games
						.Where(g => g.GameId == gameId).FirstOrDefault();
					SessionHelper.GetCart(Session).AddItem(gameToAdd, 1);
				}
				if (int.TryParse(Request.Form["down"], out gameId))
				{
					Game gameToAdd = repository.Games
						.Where(g => g.GameId == gameId).FirstOrDefault();
					SessionHelper.GetCart(Session).DropItem(gameToAdd);
				}
			}
		}

		public IEnumerable<CartLine> GetCartLines()
		{
			return SessionHelper.GetCart(Session).Lines;
		}

		public decimal CartTotal
		{
			get
			{
				return SessionHelper.GetCart(Session).ComputeTotalValue();
			}
		}

		public string ReturnUrl
		{
			get
			{
				return SessionHelper.Get<string>(Session, SessionKey.RETURN_URL);
			}
		}

		public string CheckoutUrl
		{
			get
			{
				return RouteTable.Routes.GetVirtualPath(null, "checkout",
					null).VirtualPath;
			}
		}
	}
}