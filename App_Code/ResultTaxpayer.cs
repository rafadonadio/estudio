using System;

using System.Collections.Generic;
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
/// Summary description for ResultTaxpayer
/// </summary>
public class ResultTaxpayer
{
	public ResultTaxpayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
	#region Properties
	private int taxpayerId;

	public int TaxpayerId
	{
		get { return taxpayerId; }
		set { taxpayerId = value; }
	}

	private string cuit;

	public string CUIT
	{
		get { return cuit; }
		set { cuit = value; }
	}

	private string taxpayerName;

	public string TaxpayerName
	{
		get { return taxpayerName; }
		set { taxpayerName = value; }
	}

	private string name;

	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	private string nameType;
	public string NameType
	{
		get { return nameType; }
		set { nameType = value; }
	}

	private string address;

	public string Address
	{
		get { return address; }
		set { address = value; }
	}

	private string document;

	public string Document
	{
		get { return document; }
		set { document = value; }
	}

	private string documentType;

	public string DocumentType
	{
		get { return documentType; }
		set { documentType = value; }
	}


	private string iibb;

	public string IIBB
	{
		get { return iibb; }
		set { iibb = value; }
	}


	private string personType;

	public string PersonType
	{
		get { return personType; }
		set { personType = value; }
	}


	private string societyType;

	public string SocietyType
	{
		get { return societyType; }
		set { societyType = value; }
	}


	private string action;

	public string Action
	{
		get { return action; }
		set { action = value; }
	}

				
				
	#endregion Properties

	


















}
