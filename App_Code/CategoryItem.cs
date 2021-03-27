using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for CategoryItem
/// </summary>
public class CategoryItem
{
	public CategoryItem()
	{

	}

	public CategoryItem(string name, string url )
	{
		this.name = name;
		this.url = url;
	}

	private string name;

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	private string url;

	public string Url
	{
		get { return url; }
		set { url = value; }
	}

}				
				

