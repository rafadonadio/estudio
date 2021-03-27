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
/// Summary description for Filial
/// </summary>
public class Filial
{
	#region Orig Values
	private DateTime? birthdate_orig;
	private string birthplace_orig;
	private Code documentType1_orig;
	private string documentNumber1_orig;
	private Code documentType2_orig;
	private string documentNumber2_orig;
	private Code documentType3_orig;
	private string documentNumber3_orig;
	private Address filialAddress_orig;
	private Code sex_orig;
	private Code martialStatus_orig;
	private string pdfFile_orig;
	#endregion  Orig Values
	
	private static int auxID = -1;
	public Filial()
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

	private int taxpayerId;
	public int TaxpayerId
	{
		get { return taxpayerId; }
		set { taxpayerId = value; }
	}

	private DateTime? birthdate;
	public DateTime? Birthdate
	{
		get { return birthdate; }
		set { birthdate = value; }
	}

	private string birthplace;
	public string Birthplace
	{
		get { return birthplace; }
		set { birthplace = value; }
	}

	private Code documentType1;
	public Code DocumentType1
	{
		get { return documentType1; }
		set { documentType1 = value; }
	}

	private string documentNumber1;
	public string DocumentNumber1
	{
		get { return documentNumber1; }
		set { documentNumber1 = value; }
	}

	private Code documentType2;
	public Code DocumentType2
	{
		get { return documentType2; }
		set { documentType2 = value; }
	}

	private string documentNumber2;
	public string DocumentNumber2
	{
		get { return documentNumber2; }
		set { documentNumber2 = value; }
	}

	private Code documentType3;
	public Code DocumentType3
	{
		get { return documentType3; }
		set { documentType3 = value; }
	}

	private string documentNumber3;
	public string DocumentNumber3
	{
		get { return documentNumber3; }
		set { documentNumber3 = value; }
	}

	private Address filialAddress;
	public Address FilialAddress
	{
		get { return filialAddress; }
		set { filialAddress = value; }
	}

	private Code sex;
	public Code Sex
	{
		get { return sex; }
		set { sex = value; }
	}

	private Code martialStatus;
	public Code MartialStatus
	{
		get { return martialStatus; }
		set { martialStatus = value; }
	}

	private string pdfFile;
	public string PdfFile
	{
		get { return pdfFile; }
		set { pdfFile = value; }
	}

	#endregion Properties


	#region Methods
	public bool IsEmpty()
	{
		return (
		!birthdate.HasValue &&
		String.IsNullOrEmpty(birthplace) &&
		String.IsNullOrEmpty(documentNumber1) &&
		String.IsNullOrEmpty(documentNumber2) &&
		String.IsNullOrEmpty(documentNumber3) &&
		filialAddress.IsEmpty() &&
		String.IsNullOrEmpty(pdfFile));
	}

	public bool isChanged()
	{
		return (
		birthdate_orig != birthdate ||
		birthplace_orig != birthplace ||
		documentType1_orig.Id != documentType1.Id ||
		documentNumber1_orig != documentNumber1 ||
		documentType2_orig.Id != documentType2.Id ||
		documentNumber2_orig != documentNumber2 ||
		documentType3_orig.Id != documentType3.Id ||
		documentNumber3_orig != documentNumber3 ||
		filialAddress_orig != filialAddress ||
		sex_orig.Id != sex.Id ||
		martialStatus_orig.Id != martialStatus.Id ||
		pdfFile_orig != pdfFile);
	}

	public void CopyValuesToOrigValues()
	{
		birthdate_orig = birthdate;
		birthplace_orig = birthplace;
		documentType1_orig = documentType1;
		documentNumber1_orig = documentNumber1;
		documentType2_orig = documentType2;
		documentNumber2_orig = documentNumber2;
		documentType3_orig = documentType3;
		documentNumber3_orig = documentNumber3;
		filialAddress_orig = filialAddress;
		sex_orig = sex;
		martialStatus_orig = martialStatus;
		pdfFile_orig = pdfFile;
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
				DataAccess.Filial_Delete(id);
				return null;
			}
			else
			{
				DataAccess.Filial_Update(this);
				return this.id;
			}
		}
		else
		{
			if (!IsEmpty())
				return DataAccess.Filial_Insert(this);
			else
				return null;
		}
	}
	#endregion Methods
}
