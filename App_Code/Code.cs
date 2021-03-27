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
/// Summary description for AddressType
/// </summary>
public class Code: CodeDescription
{
	private string group;
	
	public Code()
	{
		
	}

	public Code(int id)
		: base(id, null, null)
	{
		
	}
	public Code(int id, string group,  string code, string description)
		: base(id, code, description)
	{
		this.group = group;
	}


	
	public string Group
	{
		get { return group; }
		set { group = value; }
	}

				
				
				
				
				
}
