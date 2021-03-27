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

public partial class Contribuyente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		cboTipoPersona.Attributes.Add("onchange", "SetLabelName();");
		if (!IsPostBack)
		{
			LoadControls();
			LoadTaxpayer();
		}
		SetMenuContribuyente();
    }

	private void LoadTaxpayer()
	{
		if ((!String.IsNullOrEmpty(Request.QueryString["id"]) && Convert.ToInt32(Request.QueryString["id"])>0) ||
			(Session["ContribId"] != null && Convert.ToInt32(Session["ContribId"]) > 0) ) {
			int id = 0;
			if ( !String.IsNullOrEmpty(Request.QueryString["id"]) && Convert.ToInt32(Request.QueryString["id"])>0 ){
				id = Convert.ToInt32(Request.QueryString["id"]);
			}
			else if(Session["ContribId"] != null && Convert.ToInt32(Session["ContribId"]) > 0) 
			{
				id = Convert.ToInt32(Session["ContribId"]);
			}
			Taxpayer taxpayer = DataAccess.Taxpayer_GetById(id);
			hdnIdContrib.Value = taxpayer.Id.ToString();
			Session["ContribId"] = hdnIdContrib.Value;
			Session["ContribPersonaFisica"] = ((int)Application["PersonaFisicaId"] == taxpayer.PersonType.Id);
			txtCUIT.Text = taxpayer.CUIT;
			txtNombre.Text = taxpayer.Name;
			cboTipoPersona.SelectedIndex = cboTipoPersona.Items.IndexOf(cboTipoPersona.Items.FindByValue(taxpayer.PersonType.Id.ToString()));
			if ( taxpayer.SocietyType != null)
				cboTipoSociedad.SelectedIndex = cboTipoSociedad.Items.IndexOf(cboTipoSociedad.Items.FindByValue(taxpayer.SocietyType.Id.ToString()));
			txtMesCierre.Text = taxpayer.ClosingMonth.ToString();
			txtAnioCierre.Text = taxpayer.ClosingYear.ToString();
			txtJurisdiccion.Text = taxpayer.Jurisdiction;

			if (taxpayer.RealAddress != null && taxpayer.RealAddress.Id > 0)
			{
				hdnIdDirReal.Value = taxpayer.RealAddress.Id.ToString();
				txtDireccionR.Text = taxpayer.RealAddress.StreetAddress;
				txtCiudadR.Text = taxpayer.RealAddress.City;
				txtProvinciaR.Text = taxpayer.RealAddress.State;
				txtCPR.Text = taxpayer.RealAddress.PostCode;
				txtPaisR.Text = taxpayer.RealAddress.Country;
			}

			if (taxpayer.LegalAddress != null && taxpayer.LegalAddress.Id > 0) {
				hdnIdDirLegal.Value = taxpayer.LegalAddress.Id.ToString();
				txtDireccionL.Text = taxpayer.LegalAddress.StreetAddress;
				txtCiudadL.Text = taxpayer.LegalAddress.City;
				txtProvinciaL.Text = taxpayer.LegalAddress.State;
				txtCPL.Text = taxpayer.LegalAddress.PostCode;
				txtPaisL.Text = taxpayer.LegalAddress.Country;
			}
		}
	}

	private void LoadControls()
	{
		cboTipoPersona.DataSource = DataAccess.PersonType_GetAll();
		cboTipoPersona.DataValueField = "Id";
		cboTipoPersona.DataTextField = "Description";
		cboTipoPersona.DataBind();

		cboTipoSociedad.DataSource = DataAccess.SocietyType_GetAll();
		cboTipoSociedad.DataValueField = "Id";
		cboTipoSociedad.DataTextField = "Description";
		cboTipoSociedad.DataBind();
		cboTipoSociedad.Items.Insert(0,new ListItem(Constants.SIN_SEL, Constants.SIN_SEL_ID));

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
		Taxpayer taxpayer = new Taxpayer();
		taxpayer.Id = String.IsNullOrEmpty(hdnIdContrib.Value) ? 0 : Convert.ToInt32(hdnIdContrib.Value);
		taxpayer.CUIT = txtCUIT.Text;
		taxpayer.Name = txtNombre.Text;
		taxpayer.PersonType = new PersonType();
		taxpayer.PersonType.Id = Convert.ToInt32(cboTipoPersona.SelectedValue);
		taxpayer.SocietyType = new SocietyType();
		taxpayer.SocietyType.Id = Convert.ToInt32(cboTipoSociedad.SelectedValue);
		taxpayer.ClosingMonth = Convert.ToInt32(txtMesCierre.Text.Trim());
		taxpayer.ClosingYear = Convert.ToInt32(txtAnioCierre.Text.Trim());
		taxpayer.Jurisdiction = txtJurisdiccion.Text.Trim();

		taxpayer.RealAddress = new Address();
		taxpayer.RealAddress.AddressType = new AddressType();
		taxpayer.RealAddress.AddressType.Id = Convert.ToInt32(Application["AddressTypeRAID"]); 
		taxpayer.RealAddress.Id = String.IsNullOrEmpty(hdnIdDirReal.Value) ? 0 : Convert.ToInt32(hdnIdDirReal.Value);
		taxpayer.RealAddress.StreetAddress = txtDireccionR.Text.Trim();
		taxpayer.RealAddress.City = txtCiudadR.Text.Trim();
		taxpayer.RealAddress.State = txtProvinciaR.Text.Trim();
		taxpayer.RealAddress.PostCode = txtCPR.Text.Trim();
		taxpayer.RealAddress.Country = txtPaisR.Text.Trim();

		taxpayer.LegalAddress = new Address();
		taxpayer.LegalAddress.AddressType = new AddressType();
		taxpayer.LegalAddress.AddressType.Id = Convert.ToInt32(Application["AddressTypeLAID"]);
		taxpayer.LegalAddress.Id = String.IsNullOrEmpty(hdnIdDirLegal.Value) ? 0 : Convert.ToInt32(hdnIdDirLegal.Value); ;
		taxpayer.LegalAddress.StreetAddress = txtDireccionL.Text.Trim();
		taxpayer.LegalAddress.City = txtCiudadL.Text.Trim();
		taxpayer.LegalAddress.State = txtProvinciaL.Text.Trim();
		taxpayer.LegalAddress.PostCode = txtCPL.Text.Trim();
		taxpayer.LegalAddress.Country = txtPaisL.Text.Trim();



		hdnIdContrib.Value = (taxpayer.Set().Value.ToString());
		Session["ContribId"] = hdnIdContrib.Value;
		if (String.IsNullOrEmpty(Request.QueryString["id"])) {
			Response.Redirect("Contribuyente.aspx?solapa=contrib&id=" + hdnIdContrib.Value);
		}
	}
}
