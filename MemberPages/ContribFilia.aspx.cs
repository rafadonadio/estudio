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

public partial class ContribFilia : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		rgvFechaNac.MinimumValue = DateTime.Today.AddYears(-300).ToShortDateString();
		rgvFechaNac.MaximumValue = DateTime.Today.ToShortDateString();
		if (!IsPostBack)
		{
			LoadControls();
			LoadFilial();
		}
		SetMenuContribuyente();
    }

	private void LoadFilial()
	{
		if (Session["ContribId"] != null && Convert.ToInt32(Session["ContribId"]) > 0)
		{
			Filial filial = DataAccess.Filial_GetByTaxpayerId(Convert.ToInt32(Session["ContribId"]));
			if (filial != null)
			{
				hdnIdFilial.Value = filial.Id.ToString();
				txtFechaNac.Text = ((filial.Birthdate.HasValue) ? filial.Birthdate.Value.ToShortDateString() : "");
				txtLugarNac.Text = filial.Birthplace;
				cboTipoDoc1.SelectedIndex = cboTipoDoc1.Items.IndexOf(cboTipoDoc1.Items.FindByValue(filial.DocumentType1.Id.ToString()));
				cboTipoDoc2.SelectedIndex = cboTipoDoc2.Items.IndexOf(cboTipoDoc2.Items.FindByValue(filial.DocumentType2.Id.ToString()));
				cboTipoDoc3.SelectedIndex = cboTipoDoc3.Items.IndexOf(cboTipoDoc3.Items.FindByValue(filial.DocumentType3.Id.ToString()));
				txtDoc1.Text = filial.DocumentNumber1;
				txtDoc2.Text = filial.DocumentNumber2;
				txtDoc3.Text = filial.DocumentNumber3;

				if (filial.FilialAddress != null && filial.FilialAddress.Id > 0)
				{
					hdnIdDir.Value = filial.FilialAddress.Id.ToString();
					txtDireccion.Text = filial.FilialAddress.StreetAddress;
					txtCiudad.Text = filial.FilialAddress.City;
					txtProvincia.Text = filial.FilialAddress.State;
					txtCP.Text = filial.FilialAddress.PostCode;
					txtPais.Text = filial.FilialAddress.Country;
				}
				cboSexo.SelectedIndex = cboSexo.Items.IndexOf(cboSexo.Items.FindByValue(filial.Sex.Id.ToString()));
				cboEstado.SelectedIndex = cboEstado.Items.IndexOf(cboEstado.Items.FindByValue(filial.MartialStatus.Id.ToString()));
			}
		}
	}

	private void LoadControls()
	{
		cboTipoDoc1.DataSource = DataAccess.Code_GetByGroup("Tipo Documento");
		cboTipoDoc1.DataValueField = "Id";
		cboTipoDoc1.DataTextField = "Code";
		cboTipoDoc1.DataBind();

		cboTipoDoc2.DataSource = DataAccess.Code_GetByGroup("Tipo Documento");
		cboTipoDoc2.DataValueField = "Id";
		cboTipoDoc2.DataTextField = "Code";
		cboTipoDoc2.DataBind();
		
		cboTipoDoc3.DataSource = DataAccess.Code_GetByGroup("Tipo Documento");
		cboTipoDoc3.DataValueField = "Id";
		cboTipoDoc3.DataTextField = "Code";
		cboTipoDoc3.DataBind();

		cboSexo.DataSource = DataAccess.Code_GetByGroup("Sexo");
		cboSexo.DataValueField = "Id";
		cboSexo.DataTextField = "Description";
		cboSexo.DataBind();

		cboEstado.DataSource = DataAccess.Code_GetByGroup("Estado Civil");
		cboEstado.DataValueField = "Id";
		cboEstado.DataTextField = "Description";
		cboEstado.DataBind();

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
		items.Add(new CategoryItem("Filiatorios", "ContribFilia.aspx"));
		items.Add(new CategoryItem("Familiares", "ContribEnConstruccion.aspx"));
		items.Add(new CategoryItem("Legal", "ContribEnConstruccion.aspx"));
		items.Add(new CategoryItem("Fiscal", "ContribEnConstruccion.aspx"));
		items.Add(new CategoryItem("Obligaciones", "ContribEnConstruccion.aspx"));
		items.Add(new CategoryItem("Comunicación", "ContribEnConstruccion.aspx"));
		items.Add(new CategoryItem("Bienes", "ContribEnConstruccion.aspx"));
		items.Add(new CategoryItem("Balances", "ContribEnConstruccion.aspx"));
		items.Add(new CategoryItem("Períodos", "ContribEnConstruccion.aspx"));
		mnContribuyente.Items = items;
		mnContribuyente.Title = "Información&nbsp;&nbsp;";
	}
	protected void btnSave_Click(object sender, ImageClickEventArgs e)
	{
		if (Session["ContribId"] != null && Convert.ToInt32(Session["ContribId"]) > 0)
		{
			Filial filial = new Filial();
			filial.TaxpayerId = Convert.ToInt32(Session["ContribId"]);
			filial.Id = String.IsNullOrEmpty(hdnIdFilial.Value) ? 0 : Convert.ToInt32(hdnIdFilial.Value);
			if(!String.IsNullOrEmpty(txtFechaNac.Text))
				filial.Birthdate = Convert.ToDateTime(txtFechaNac.Text);
			filial.Birthplace = txtLugarNac.Text;
			filial.DocumentType1 = new Code(Convert.ToInt32(cboTipoDoc1.SelectedValue));
			filial.DocumentType2 = new Code(Convert.ToInt32(cboTipoDoc2.SelectedValue));
			filial.DocumentType3 = new Code(Convert.ToInt32(cboTipoDoc3.SelectedValue));
			filial.DocumentNumber1 = txtDoc1.Text;
			filial.DocumentNumber2 = txtDoc2.Text;
			filial.DocumentNumber3 = txtDoc3.Text;

			filial.FilialAddress = new Address();
			filial.FilialAddress.AddressType = new AddressType();
			filial.FilialAddress.AddressType.Id = Convert.ToInt32(Application["AddressTypeFAID"]);
			filial.FilialAddress.Id = String.IsNullOrEmpty(hdnIdDir.Value) ? 0 : Convert.ToInt32(hdnIdDir.Value);
			filial.FilialAddress.StreetAddress = txtDireccion.Text.Trim();
			filial.FilialAddress.City = txtCiudad.Text.Trim();
			filial.FilialAddress.State = txtProvincia.Text.Trim();
			filial.FilialAddress.PostCode = txtCP.Text.Trim();
			filial.FilialAddress.Country = txtPais.Text.Trim();

			filial.Sex = new Code(Convert.ToInt32(cboSexo.SelectedValue));
			filial.MartialStatus = new Code(Convert.ToInt32(cboEstado.SelectedValue));

			hdnIdFilial.Value = (filial.Set().Value.ToString());
			//Response.Redirect("ContribFilia.aspx?solapa=contrib");
		}
	}
	
}
