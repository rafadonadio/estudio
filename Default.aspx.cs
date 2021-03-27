using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page 
{
	
	protected void Page_Load(object sender, EventArgs e)
    {
		InicializarRoles();
		if (WebPartManager1.Personalization.Scope == PersonalizationScope.User)
		{
			if (WebPartManager1.Personalization.CanEnterSharedScope)
			{
				WebPartManager1.Personalization.ToggleScope();
			}
		}
    }

	private void InicializarRoles()
	{
		string roleName = "empleado";
		if(!Roles.RoleExists(roleName))
			Roles.CreateRole(roleName);
		
	}
	
	protected void btnMoverWP_Click(object sender, EventArgs e)
	{
		WebPartManager1.DisplayMode = WebPartManager.DesignDisplayMode;
	}
	protected void btnSinEdicion_Click(object sender, EventArgs e)
	{
		WebPartManager1.DisplayMode = WebPartManager.BrowseDisplayMode;
	}
	protected void btnCatalogo_Click(object sender, EventArgs e)
	{
		WebPartManager1.DisplayMode = WebPartManager.CatalogDisplayMode;
	}
	protected void btnEditar_Click(object sender, EventArgs e)
	{
		WebPartManager1.DisplayMode = WebPartManager.EditDisplayMode;
	}
	protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
	{
		int i = 0;
	}
	protected void Button1_Click(object sender, EventArgs e)
	{
		FormsAuthentication.SignOut();
		
	}
}
