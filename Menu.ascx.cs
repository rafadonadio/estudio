using System;
using System.Collections;
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
using System.Text;
public partial class Menu : System.Web.UI.UserControl
{
	protected void Page_Load(object sender, EventArgs e)
	{
		SetMenu();
	}

	private void SetMenu()
	{
		hdnItemsContrib.Value = MenuItemsConst.Contribuyentes;
		hdnItemsReportes.Value = MenuItemsConst.Reportes;
		hdnItemsUsuarios.Value = MenuItemsConst.Usuarios;
		hdnItemsConfig.Value = MenuItemsConst.Configuracion;
		hdnItemsAyuda.Value = MenuItemsConst.Ayuda;

		imgContrib.Src = "Images/Contribuyentes_no.jpg";
		imgReportes.Src = "Images/Reportes_no.jpg";
		imgUsuarios.Src = "Images/Usuarios_no.jpg";
		imgConf.Src = "Images/Configuracion_no.jpg";
		imgAyuda.Src = "Images/Ayuda_no.jpg";
		
		if (String.IsNullOrEmpty(Request.QueryString["solapa"]) || Request.QueryString["solapa"] == "contrib")
		{
			ulSubMenu.InnerHtml = MenuItemsConst.Contribuyentes;
			imgContrib.Src = "Images/Contribuyentes_o.jpg";
		}
		else if (!String.IsNullOrEmpty(Request.QueryString["solapa"]) && Request.QueryString["solapa"] == "reportes")
		{
			ulSubMenu.InnerHtml = MenuItemsConst.Reportes;
			imgReportes.Src = "Images/Reportes_o.jpg";
		}
		else if (!String.IsNullOrEmpty(Request.QueryString["solapa"]) && Request.QueryString["solapa"] == "usuarios")
		{
			ulSubMenu.InnerHtml = MenuItemsConst.Usuarios;
			imgUsuarios.Src = "Images/Usuarios_o.jpg";
		}
		else if (!String.IsNullOrEmpty(Request.QueryString["solapa"]) && Request.QueryString["solapa"] == "config")
		{
			ulSubMenu.InnerHtml = MenuItemsConst.Configuracion;
			imgConf.Src = "Images/Configuracion_o.jpg";
		}
		else if (!String.IsNullOrEmpty(Request.QueryString["solapa"]) && Request.QueryString["solapa"] == "ayuda")
		{
			ulSubMenu.InnerHtml = MenuItemsConst.Ayuda;
			imgAyuda.Src = "Images/Ayuda_o.jpg";
		}
		else
		{
			ulSubMenu.InnerHtml = MenuItemsConst.Contribuyentes;
			imgContrib.Src = "Images/Contribuyentes_o.jpg";
			imgReportes.Src = "Images/Reportes_no.jpg";
			imgUsuarios.Src = "Images/Usuarios.jpg";
			imgConf.Src = "Images/Configuracion_no.jpg";
			imgAyuda.Src = "Images/Ayuda_no.jpg";
		}
	}


	protected void btnContrib_Click(object sender, ImageClickEventArgs e)
	{
		StringBuilder sbSubMenu = new StringBuilder();
		sbSubMenu.Append("<img src=\"Images/topsubmenu_bullet.jpg\" width=\"6\" height=\"6\"/>");
		sbSubMenu.Append("<li>");
		sbSubMenu.Append("<a href=\"\" class=\"bold\">Full Sites</a></li>");
		sbSubMenu.Append("<li>|</li>");
		sbSubMenu.Append("<li><a href=\"\" class=\"bold\">Full Flash Sites</a></li>");
		sbSubMenu.Append("<li>|</li>");
		sbSubMenu.Append("<li><a href=\"\" class=\"bold\">Website Templates</a></li>");
		sbSubMenu.Append("<li>|</li>");
		sbSubMenu.Append("<li><a href=\"\" class=\"bold\">Flash Templates</a></li>");
		sbSubMenu.Append("<li>|</li>");
		sbSubMenu.Append("<li><a href=\"\" class=\"bold\">Flash Enabled Templates</a></li>");
		sbSubMenu.Append("<li>|</li>");
		sbSubMenu.Append("<li><a href=\"\" class=\"bold\">Logo Templates</a></li>");
		sbSubMenu.Append("<li>|</li>");
		sbSubMenu.Append("<li><a href=\" class=\"bold\">Newsletter Templates</a></li>");
		sbSubMenu.Append("<img src=\"Images/topsubmenu_bullet.jpg\" width=\"6\" height=\"6\"/>");

		ulSubMenu.InnerHtml = sbSubMenu.ToString();
	}
	protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
	{
		Response.Redirect("../MemberPages/BuscarContribuyente.aspx");
	}
}
