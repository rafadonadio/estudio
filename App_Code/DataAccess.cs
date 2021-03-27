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
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Web;


/// <summary>
/// Summary description for DataAccess
/// </summary>
public class DataAccess
{
	private static Database db = DatabaseFactory.CreateDatabase();

	static DataAccess()
	{
	}
	public static Guid GetUserId(string userName)
	{
		DbCommand dbCommand = db.GetStoredProcCommand("spGetUserByName", "/MFD_SICC", userName);
		DataSet ds = db.ExecuteDataSet(dbCommand);
		try
		{
			return new Guid(ds.Tables[0].Rows[0]["UserId"].ToString());
		}
		catch
		{
			throw new Exception("No se encontró el usuario logueado en la base de datos");
		}
	}
	#region Taxpayer
	public static Taxpayer Taxpayer_GetById(int id) {
		Taxpayer taxpayer = null;
		DataSet ds =  db.ExecuteDataSet("spTaxpayerGetById", id);
		if (ds.Tables[0].Rows.Count > 0) {
			DataRow dr = ds.Tables[0].Rows[0];
			taxpayer = new Taxpayer();
			taxpayer.Id = Convert.ToInt32(dr["Id"]);
			taxpayer.CUIT = dr["CUIT"].ToString();
			taxpayer.Name = dr["Name"].ToString();
			taxpayer.PersonType = new PersonType();
			taxpayer.PersonType.Id = Convert.ToInt32(dr["PersonTypeId"]);
			if ((dr["SocietyTypeId"] != DBNull.Value))
			{
				taxpayer.SocietyType = new SocietyType();
				taxpayer.SocietyType.Id = Convert.ToInt32(dr["SocietyTypeId"]);
			}
			taxpayer.ClosingMonth = (int?)dr["ClosingMonth"];
			taxpayer.ClosingYear = (int?)dr["ClosingYear"];
			
			taxpayer.Jurisdiction = dr["Jurisdiction"].ToString();
			if(dr["LegalAddressId"] !=DBNull.Value){
				taxpayer.LegalAddress = Address_GetById((int)dr["LegalAddressId"]);
			}
			if (dr["RealAddressId"] != DBNull.Value)
			{
				taxpayer.RealAddress = Address_GetById((int)dr["RealAddressId"]);
			}
		}
		return taxpayer;
	}
	public static int? Taxpayer_Insert(Taxpayer taxpayer)
	{
		int? legalAddressId = taxpayer.LegalAddress.Set();
		int? realAddressId = taxpayer.RealAddress.Set();

		return Convert.ToInt32(db.ExecuteScalar("spTaxpayerInsert", taxpayer.CUIT,
		taxpayer.Name, taxpayer.PersonType.Id, taxpayer.SocietyType.Id, taxpayer.ClosingMonth, taxpayer.ClosingYear,
		legalAddressId, realAddressId, taxpayer.Jurisdiction, HttpContext.Current.Session["UserId"]));
	}
	public static void Taxpayer_Update(Taxpayer taxpayer)
	{
		int? realAddressId, legalAddressId;
		if (taxpayer.LegalAddress.Id <= 0)
			legalAddressId = taxpayer.LegalAddress.Set();
		else
		{

			if (taxpayer.LegalAddress.IsEmpty()) //Luego del uptade de Taxpayer se borra el registro
				legalAddressId = null;
			else
				legalAddressId = taxpayer.LegalAddress.Id;
		}
		if(taxpayer.RealAddress.Id<=0)
			realAddressId = taxpayer.RealAddress.Set();
		else
		{
			if (taxpayer.RealAddress.IsEmpty())//Luego del uptade de Taxpayer se borra el registro
				realAddressId = null;
			else
				realAddressId = taxpayer.RealAddress.Id;
		}

		db.ExecuteScalar("spTaxpayerUpdate", taxpayer.Id, taxpayer.CUIT,
		taxpayer.Name, taxpayer.PersonType.Id, taxpayer.SocietyType.Id, taxpayer.ClosingMonth, taxpayer.ClosingYear,
		legalAddressId, realAddressId, taxpayer.Jurisdiction, HttpContext.Current.Session["UserId"]);
		
		if (taxpayer.LegalAddress.Id > 0)
			legalAddressId = taxpayer.LegalAddress.Set();
		if (taxpayer.RealAddress.Id > 0)
			realAddressId = taxpayer.RealAddress.Set();
	}
	public static List<ResultTaxpayer> SearchTaxpayer(int documentTypeId, string documentNumber, string name, string iibb, int personTypeId, int societyTypeId)
	{
		List<ResultTaxpayer> result = new List<ResultTaxpayer>();
		DataSet ds = db.ExecuteDataSet("spTaxpayerSearch", name);
		if (ds.Tables[0].Rows.Count > 0)
		{
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				//TODO: Falta hacer control de cantidad de resultados y paginacion
				ResultTaxpayer res = new ResultTaxpayer();
				res.CUIT = dr["CUIT"].ToString();
				res.TaxpayerName = dr["TaxpayerName"].ToString();
				res.Name = dr["Name"].ToString();
				res.NameType = dr["NameType"].ToString();
				res.DocumentType = dr["DocumentType"].ToString();
				res.Document = dr["DocumentNumber"].ToString();
				//res.Action = "<a href=\"~/MemberPages/Contribuyente.aspx?solapa=contrib&id=" + dr["Id"].ToString() + "\">ver mas...</a>";
				res.Action = "Contribuyente.aspx?solapa=contrib&id=" + dr["Id"].ToString() ;
				result.Add(res);
			}
		}
		return result;
	}
	public static List<ResultTaxpayer> SearchTaxpayer()
	{
		List<ResultTaxpayer> result = new List<ResultTaxpayer>();
		ResultTaxpayer res1 = new ResultTaxpayer();
		res1.CUIT = "30-25252525-3";
		res1.TaxpayerName = "Nombre Empresa 1";
		res1.Name = "Carolina Directora";
		res1.NameType = "Director";
		res1.PersonType = "PJ";
		res1.IIBB = "1111";
		res1.DocumentType = "DNI";
		res1.Document = "25252525";
		res1.Action = "<a href=\"~/MemberPages/Contribuyente.aspx?solapa=contrib&id=1\">ver mas...</a>";
		result.Add(res1);
		ResultTaxpayer res2 = new ResultTaxpayer();
		res2.CUIT = "20-28282828-3";
		res2.TaxpayerName = "Carolina Contribuyente";
		res2.Name = "Carolina Contribuyente";
		res2.NameType = "Contribuyente";
		res2.PersonType = "PF";
		res2.IIBB = "222222";
		res2.DocumentType = "DNI";
		res2.Document = "28282828";
		res2.Action = "<a href=\"~/MemberPages/Contribuyente.aspx?solapa=contrib&id=2\">ver mas...</a>";
		result.Add(res2);
		ResultTaxpayer res3 = new ResultTaxpayer();
		res3.CUIT = "33-22222222-3";
		res3.TaxpayerName = "Nombre Empresa 3";
		res3.Name = "Carolina Socio 1";
		res3.NameType = "Socio";
		res3.PersonType = "PJ";
		res3.IIBB = "3333";
		res3.DocumentType = "DNI";
		res3.Document = "22222222";
		res3.Action = "<a href=\"~/MemberPages/Contribuyente.aspx?solapa=contrib&id=3\">ver mas...</a>";
		result.Add(res3);
		ResultTaxpayer res4 = new ResultTaxpayer();
		res4.CUIT = "22-27272727-3";
		res4.TaxpayerName = "Nombre Empresa 4";
		res4.Name = "Carolina Esposa";
		res4.NameType = "Esposa";
		res4.PersonType = "PF";
		res4.IIBB = "44444";
		res4.DocumentType = "DNI";
		res4.Document = "27272727";
		res4.Action = "<a href=\"~/MemberPages/Contribuyente.aspx?solapa=contrib&id=4\">ver mas...</a>";
		result.Add(res4);
		/*DataSet ds = new DataSet();
		DataTable dt = new DataTable();
		dt.Columns.Add("CUIT");
		dt.Columns.Add("Name");
		dt.Columns.Add("NameType");
		dt.Columns.Add("PersonType");
		dt.Columns.Add("IIBB");
		DataRow dr1 = dt.NewRow();
		dr1.ItemArray = new string[] { "CUIT", "Name", "NameType", "PersonType", "IIBB" };
		dt.Rows.Add(dr1);
		ds.Tables.Add(dt);*/
		return result;
	}
	#endregion Taxpayer
	#region Address
	public static Address Address_GetById(int id)
	{
		Address address = null;
		DataSet ds = db.ExecuteDataSet("spAddressGetById", id);
		if (ds.Tables[0].Rows.Count > 0)
		{
			DataRow dr = ds.Tables[0].Rows[0];
			address = new Address();
			address.Id = Convert.ToInt32(dr["Id"]);
			address.AddressType = new AddressType();
			address.AddressType.Id = Convert.ToInt32(dr["AddressTypeId"]); 
			address.AddressType.Code = dr["ATCode"].ToString();
			address.AddressType.Description = dr["ATDescription"].ToString();
			address.StreetAddress = dr["Address"].ToString();
			address.City = dr["City"].ToString();
			address.State = dr["State"].ToString();
			address.PostCode = dr["PostCode"].ToString();
			address.Country = dr["Country"].ToString();

			address.CopyValuesToOrigValues();

		}
		return address;
	}
	public static int? Address_Insert(Address address)
	{
		return Convert.ToInt32(db.ExecuteScalar("spAddressInsert", address.AddressType.Id,
			address.StreetAddress, address.City, address.State, address.PostCode,
			address.Country, HttpContext.Current.Session["UserId"]));
		address.CopyValuesToOrigValues();
	}
	public static void Address_Update(Address address)
	{
		db.ExecuteNonQuery("spAddressUpdate", address.Id, address.AddressType.Id,
		address.StreetAddress, address.City, address.State, address.PostCode,
		address.Country, HttpContext.Current.Session["UserId"]);
		address.CopyValuesToOrigValues();
	}
	public static void Address_Delete(int id) {
		db.ExecuteNonQuery("spAddressDelete", id);
	}
	#endregion Address
	#region Filial

	public static Filial Filial_GetByTaxpayerId(int id)
	{
		Filial filial = null;
		DataSet ds = db.ExecuteDataSet("spFilialGetByTaxpayerId", id);
		if (ds.Tables[0].Rows.Count > 0)
		{
			DataRow dr = ds.Tables[0].Rows[0];
			filial = new Filial();
			filial.Id = Convert.ToInt32( dr["Id"]);
			filial.TaxpayerId = Convert.ToInt32( dr["TaxpayerId"]);
			if ((dr["Birthdate"] != DBNull.Value))
				filial.Birthdate = (DateTime?)(dr["Birthdate"]);
			filial.Birthplace = dr["Birthplace"].ToString();
			filial.DocumentType1 = new Code(Convert.ToInt32( dr["DocumentTypeId1"]));
			filial.DocumentNumber1 = dr["DocumentNumber1"].ToString();
			filial.DocumentType2 = new Code(Convert.ToInt32( dr["DocumentTypeId2"]));
			filial.DocumentNumber2 = dr["DocumentNumber2"].ToString();
			filial.DocumentType3 = new Code(Convert.ToInt32( dr["DocumentTypeId3"]));
			filial.DocumentNumber3 = dr["DocumentNumber3"].ToString();
			if (dr["AddressId"] != DBNull.Value)
			{
				filial.FilialAddress = Address_GetById(Convert.ToInt32(dr["AddressId"]));
			}

			filial.Sex = new Code(Convert.ToInt32( dr["SexId"]));
			filial.MartialStatus = new Code(Convert.ToInt32(dr["MartialStatusId"]));
			filial.PdfFile = dr["PdfFile"].ToString();

			filial.CopyValuesToOrigValues();

		}
		return filial;
	}
	public static int? Filial_Insert(Filial filial)
	{
		int? filialAddressId = filial.FilialAddress.Set();

		return Convert.ToInt32(db.ExecuteScalar("spFilialInsert", filial.TaxpayerId,
			filial.Birthdate, filial.Birthplace, filial.DocumentType1.Id, filial.DocumentNumber1,
			filial.DocumentType2.Id, filial.DocumentNumber2, filial.DocumentType3.Id, filial.DocumentNumber3, 
			filialAddressId, filial.Sex.Id, filial.MartialStatus.Id, filial.PdfFile,
			HttpContext.Current.Session["UserId"]));
		filial.CopyValuesToOrigValues();
	}
	public static void Filial_Update(Filial filial)
	{
		int? filialAddressId;
		if (filial.FilialAddress .Id <= 0)
			filialAddressId = filial.FilialAddress.Set();
		else
		{

			if (filial.FilialAddress.IsEmpty()) //Luego del uptade de Filial se borra el registro
				filialAddressId = null;
			else
				filialAddressId = filial.FilialAddress.Id;
		}
		
		db.ExecuteScalar("spFilialUpdate", filial.Id, filial.TaxpayerId,
			filial.Birthdate, filial.Birthplace, filial.DocumentType1.Id, filial.DocumentNumber1,
			filial.DocumentType2.Id, filial.DocumentNumber2, filial.DocumentType3.Id, filial.DocumentNumber3, 
			filialAddressId, filial.Sex.Id, filial.MartialStatus.Id, filial.PdfFile,
			HttpContext.Current.Session["UserId"]);
		filial.CopyValuesToOrigValues();

		if (filial.FilialAddress.Id > 0)
			filialAddressId = filial.FilialAddress.Set();
		
	}
	public static void Filial_Delete(int id)
	{
		db.ExecuteNonQuery("spFilialDelete", id);
	}
	
	#endregion Filial
	#region AddressType
	public static List<AddressType> AddressType_GetAll()
	{
		List<AddressType> list = new List<AddressType>();
		DataSet ds = db.ExecuteDataSet("spAddressTypeGetAll");
		if (ds.Tables[0].Rows.Count > 0)
		{
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				list.Add(new AddressType(Convert.ToInt32(dr["id"]), dr["code"].ToString(), dr["description"].ToString()));
			}
		}
		return list;
	}
	#endregion AddressType
	#region PersonType
	public static List<PersonType> PersonType_GetAll()
	{
		List<PersonType> list = new List<PersonType>();
		DataSet ds = db.ExecuteDataSet("spPersonTypeGetAll");
		if (ds.Tables[0].Rows.Count > 0)
		{
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				list.Add(new PersonType(Convert.ToInt32(dr["id"]), dr["code"].ToString(), dr["description"].ToString()));
			}
		}
		return list;
	}

	public static int? PersonType_Insert(PersonType personType)
	{
		return Convert.ToInt32(db.ExecuteScalar("spPersonTypeInsert", personType.Code,
				personType.Description, HttpContext.Current.Session["UserId"]));
	}
	public static void PersonType_Update(PersonType personType)
	{
		db.ExecuteNonQuery("spPersonTypeUpdate", personType.Id, personType.Code,
			personType.Description, HttpContext.Current.Session["UserId"]);
	}
	public static void PersonType_Delete(int id)
	{
		db.ExecuteNonQuery("spPersonTypeDelete", id);
	}

	public static void PersonType_Delete(PersonType personType)
	{
		db.ExecuteNonQuery("spPersonTypeDelete", personType.Id);
	}
	
	#endregion PersonType
	#region SocietyType
	public static List<SocietyType> SocietyType_GetAll()
	{
		List<SocietyType> list = new List<SocietyType>();
		DataSet ds = db.ExecuteDataSet("spSocietyTypeGetAll");
		if (ds.Tables[0].Rows.Count > 0)
		{
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				list.Add(new SocietyType(Convert.ToInt32(dr["id"]), dr["code"].ToString(), dr["description"].ToString()));
			}
		}
		return list;
	}
	public static int? SocietyType_Insert(SocietyType societyType) {
		return Convert.ToInt32(db.ExecuteScalar("spSocietyTypeInsert", societyType.Code,
				societyType.Description, HttpContext.Current.Session["UserId"]));
	}
	public static void SocietyType_Update(SocietyType societyType)
	{
		db.ExecuteNonQuery("spSocietyTypeUpdate", societyType.Id, societyType.Code, 
			societyType.Description, HttpContext.Current.Session["UserId"]);
	}
	public static void SocietyType_Delete(int id)
	{
		db.ExecuteNonQuery("spSocietyTypeDelete", id);
	}

	public static void SocietyType_Delete(SocietyType societyType)
	{
		db.ExecuteNonQuery("spSocietyTypeDelete", societyType.Id);
	}
	#endregion SocietyTypes

	#region Code
	public static List<Code> Code_GetGroups()
	{
		List<Code> list = new List<Code>();
		DataSet ds = db.ExecuteDataSet("spCodeGetGroups");
		if (ds.Tables[0].Rows.Count > 0)
		{
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				//Feo, para no crear otra clase :D
				list.Add(new Code(0, dr["Group"].ToString(), dr["Group"].ToString(), dr["Group"].ToString()));
			}
		}
		return list;
	}
	public static List<Code> Code_GetByGroup(string group)
	{
		List<Code> list = new List<Code>();
		DataSet ds = db.ExecuteDataSet("spCodeGetByGroup", group);
		if (ds.Tables[0].Rows.Count > 0)
		{
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				list.Add(new Code(Convert.ToInt32(dr["id"]), dr["Group"].ToString(), dr["code"].ToString(), dr["description"].ToString()));
			}
		}
		return list;
	}
	public static int? Code_Insert(Code code)
	{
		return Convert.ToInt32(db.ExecuteScalar("spCodeInsert", code.Group, code.Code,
				code.Description, HttpContext.Current.Session["UserId"]));
	}
	public static void Code_Update(Code code)
	{
		db.ExecuteNonQuery("spCodeUpdate", code.Id, code.Code,
			code.Description, HttpContext.Current.Session["UserId"]);
	}
	public static void Code_Delete(int id)
	{
		db.ExecuteNonQuery("spCodeDelete", id);
	}

	public static void Code_Delete(Code code)
	{
		db.ExecuteNonQuery("spCodeDelete", code.Id);
	}
	#endregion Codes

}
