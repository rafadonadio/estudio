using System;
using System.Text;
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

public partial class Categoria : System.Web.UI.UserControl
{

	protected void Page_Load(object sender, EventArgs e)
    {
		SetTitle();
		SetItems();
    }

	private void SetTitle()
	{
		lblTitle.Text = title;
	}

	public  void SetItems()
	{
		//StringBuilder sbScriptVars = new StringBuilder();
		StringBuilder sbItems = new StringBuilder();
		int index = 0;
		string cssclass = "";
		foreach (CategoryItem item in items)
		{
			if ((index % 2) == 0)
				cssclass = "class=\"darkoption\"";
			else 
				cssclass = "";
			sbItems.Append("<li " + cssclass + " ><a href=\"" + item.Url + "\" id='lnk" + item.Name + "' >" + item.Name + "</a></li>");
			//sbScriptVars.Append(" var it" + item.Name + " = document.getElementById(\"lnk" + item.Name + "\");");
			Server.UrlPathEncode(item.Name);
			index++;
		}
		ulItems.InnerHtml = sbItems.ToString();
		/*sbScriptVars.Insert(0,"<script>");
		sbScriptVars.Append("</script>");
		Page.RegisterClientScriptBlock("sbScriptVars", sbScriptVars.ToString());*/
		/*
		 var itFilia = document.getElementById("lblNombre");
		var itFami = document.getElementById("lblNombre");
		var itLeg = document.getElementById("lblNombre");
		var itBalan = document.getElementById("lblNombre");
		 */
	}

	#region Properties
	private List<CategoryItem> items = new List<CategoryItem>();

	public List<CategoryItem> Items
	{
		get { return items; }
		set { items = value; }
	}

	private string title="Titulo Default";

	public string Title
	{
		get { return title; }
		set { title= value; }
	}
	#endregion Properties



}
