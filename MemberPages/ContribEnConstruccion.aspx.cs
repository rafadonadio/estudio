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

public partial class ContribEnConstruccion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

		SetMenuContribuyente();
	}

	private void SetMenuContribuyente()
	{
		/*List<CategoryItem> items = new List<CategoryItem>();
		items.Add(new CategoryItem("Legal", "ContribLegal.aspx"));
		items.Add(new CategoryItem("Fiscal", "ContribFiscal.aspx"));
		items.Add(new CategoryItem("Obligaciones", "ContribObligaciones.aspx"));
		items.Add(new CategoryItem("Comunicación", "ContribComunicacion.aspx"));
		items.Add(new CategoryItem("Familiares", "ContribFamiliares.aspx"));
		mnContribuyente.Items = items;
		mnContribuyente.Title="Información&nbsp;&nbsp;";*/

		List<CategoryItem> items = new List<CategoryItem>();
		items.Add(new CategoryItem("General", "Contribuyente.aspx"));
		items.Add(new CategoryItem("Legal", "ContribEnConstruccion.aspx"));
		items.Add(new CategoryItem("Fiscal", "ContribEnConstruccion.aspx"));
		items.Add(new CategoryItem("Obligaciones", "ContribEnConstruccion.aspx"));
		items.Add(new CategoryItem("Comunicación", "ContribEnConstruccion.aspx"));
		items.Add(new CategoryItem("Familiares", "ContribEnConstruccion.aspx"));
		mnContribuyente.Items = items;
		mnContribuyente.Title = "Información&nbsp;&nbsp;";
	}
}
