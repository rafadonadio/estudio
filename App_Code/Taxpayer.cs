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
/// Summary description for Taxpayer
/// </summary>
public class Taxpayer
{
	private static int auxID = -1;
	
	public Taxpayer()
	{
		id = auxID;
		auxID--;
	}

	#region Properties
	private int id;

	public int Id
	{
		get { return id; }
		set { id = value; }
	}


	private string cuit;

	public string CUIT
	{
		get { return cuit; }
		set { cuit = value; }
	}

	private string name;

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	private PersonType personType;

	public PersonType PersonType
	{
		get { return personType; }
		set { personType = value; }
	}

	private SocietyType societyType;

	public SocietyType SocietyType
	{
		get { return societyType; }
		set { societyType = value; }
	}
		
				
	private int? closingMonth;

	public int? ClosingMonth
	{
		get { return closingMonth; }
		set { closingMonth = value; }
	}

	private int? closingYear;

	public int? ClosingYear
	{
		get { return closingYear; }
		set { closingYear = value; }
	}

	private Address legalAddress;

	public Address LegalAddress
	{
		get { return legalAddress; }
		set { legalAddress = value; }
	}

	private Address realAddress;

	public Address RealAddress
	{
		get { return realAddress; }
		set { realAddress = value; }
	}

	private string jurisdiction;

	public string Jurisdiction
	{
		get { return jurisdiction; }
		set { jurisdiction = value; }
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

	#region Methods
	public int? Set() {
		//TODO:
		/*
		* Preguntar si es vacio y es nuevo (el id <0 ) -> no grabar 
		* y si es vacio y el id es viejo -> Borrar
		*/

		if (id > 0)
		{
			DataAccess.Taxpayer_Update(this);
			return this.id;
		}
		else
			return DataAccess.Taxpayer_Insert(this);
	} 
	#endregion Methods






















}
