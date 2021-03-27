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
/// Summary description for CodeDescription
/// </summary>
public class CodeDescription
{
	public CodeDescription()
	{
	}
	public CodeDescription(int id, string code, string description)
	{
		this.id = id;
		this.code = code;
		this.description = description;
	}

	#region Properties
	private int id;

	public int Id
	{
		get { return id; }
		set { id = value; }
	}
	
	private string code;

	public string Code
	{
		get { return code; }
		set { code = value; }
	}

	private string description;

	public string Description
	{
		get { return description; }
		set { description = value; }
	}
	
	private Guid updatingUser;

	public Guid UpdatingUser
	{
		get { return updatingUser; }
		set { updatingUser = value; }
	}


	private DateTime updatingDate;

	public DateTime UpdatingDate
	{
		get { return updatingDate; }
		set { updatingDate = value; }
	}
	#endregion Properties


	/*
	 
	 
	 
	#region Properties
	private int id;

	public int Id
	{
		get { return id; }
		set { id = value; }
	}

	private Guid updatingUser;

	public Guid UpdatingUser
	{
		get { return updatingUser; }
		set { updatingUser = value; }
	}


	private DateTime updatingDate;

	public DateTime UpdatingDate
	{
		get { return updatingDate; }
		set { updatingDate = value; }
	}
	#endregion Properties
	 
	 */
}
