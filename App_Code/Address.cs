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
/// Summary description for Address
/// </summary>
public class Address
{
	#region Orig Values
	private AddressType addressType_orig;
	private string streetAddress_orig;
	private string city_orig;
	private string state_orig;
	private string postCode_orig;
	private string country_orig;
	#endregion  Orig Values

	private static int auxID = -1;
	public Address()
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

	private AddressType addressType;

	public AddressType AddressType
	{
		get { return addressType; }
		set { addressType = value; }
	}

	private string streetAddress;

	public string StreetAddress
	{
		get { return streetAddress; }
		set { streetAddress = value; }
	}

	private string city;

	public string City
	{
		get { return city; }
		set { city = value; }
	}

	private string state;

	public string State
	{
		get { return state; }
		set { state = value; }
	}

	private string postCode;

	public string PostCode
	{
		get { return postCode; }
		set { postCode = value; }
	}

	private string country;

	public string Country
	{
		get { return country; }
		set { country = value; }
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
	public bool IsEmpty() {
		return (String.IsNullOrEmpty(streetAddress) &&
		String.IsNullOrEmpty(city) &&
		String.IsNullOrEmpty(state) &&
		String.IsNullOrEmpty(postCode) &&
		String.IsNullOrEmpty(country));
	}

	public bool isChanged() { 
		return (
		addressType !=  addressType_orig ||
		streetAddress != streetAddress_orig ||
		city != city_orig ||
		state != state_orig ||
		postCode != postCode_orig ||
		country != country_orig);
	}

	public void CopyValuesToOrigValues() {
		addressType_orig = addressType;
		streetAddress_orig = streetAddress;
		city_orig = city;
		state_orig = state;
		postCode_orig = postCode;
		country_orig = country;
	}
	
	public int? Set()
	{
		/*
		* Preguntar si es vacio y es nuevo (el id <0 ) -> no grabar 
		* y si es vacio y el id es viejo -> Borrar
		*/

		if (id > 0)
		{
			if (IsEmpty())
			{
				DataAccess.Address_Delete(id);
				return null;
			}
			else
			{
				DataAccess.Address_Update(this);
				return this.id;
			}
		}
		else
		{
			if(!IsEmpty())
				return DataAccess.Address_Insert(this);
			else
				return null;
		}
	}
	#endregion Methods
}
