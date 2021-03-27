using System;
using System.Collections;
using System.Collections.Generic;
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

public partial class Ingresar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		SetMenu();
		try
		{
			LoginView1.FindControl("Login1").Focus();
		}
		catch { }
		
	}

	private void SetMenu()
	{
		List<CategoryItem> items = new List<CategoryItem>();
		items.Add(new CategoryItem("Categoría 1", "EnConstruccion.aspx"));
		items.Add(new CategoryItem("Categoría 2", "EnConstruccion.aspx"));
		items.Add(new CategoryItem("Categoría 3", "EnConstruccion.aspx"));
		items.Add(new CategoryItem("Categoría 4", "EnConstruccion.aspx"));
		Categoria1.Items = items;
		Categoria1.Title = "&nbsp;&nbsp;&nbsp;&nbsp;Categorías&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";


		List<CategoryItem> items2 = new List<CategoryItem>();
		items2.Add(new CategoryItem("Etiqueta 1", "EnConstruccion.aspx"));
		items2.Add(new CategoryItem("Etiqueta 2", "EnConstruccion.aspx"));
		items2.Add(new CategoryItem("Etiqueta 3", "EnConstruccion.aspx"));
		items2.Add(new CategoryItem("Etiqueta 4", "EnConstruccion.aspx"));
		Categoria2.Items = items2;
		Categoria2.Title = "&nbsp;&nbsp;&nbsp;&nbsp;Etiquetas&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";

		List<CategoryItem> items3 = new List<CategoryItem>();
		items3.Add(new CategoryItem("Hoy", "EnConstruccion.aspx"));
		items3.Add(new CategoryItem("Ayer", "EnConstruccion.aspx"));
		items3.Add(new CategoryItem("Semana", "EnConstruccion.aspx"));
		items3.Add(new CategoryItem("Mes", "EnConstruccion.aspx"));
		Categoria3.Items = items3;
		Categoria3.Title = "Lo más buscado";
	}

	protected void Login1_LoggedIn(object sender, EventArgs e)
	{
		Session["UserId"] = DataAccess.GetUserId(((System.Web.UI.WebControls.Login)sender).UserName);

	}
}
