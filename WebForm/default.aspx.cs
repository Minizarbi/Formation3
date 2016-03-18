using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;

namespace WebForm
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MonBouton_OnClick(object sender, EventArgs e)
        {
            var service = new EFRecipeService();
            var recipes = service.GetRecipes(MaZoneDeTexte.Text);

            MaDataGrid.DataSource = recipes;
            MaDataGrid.DataBind();
        }
    }
}