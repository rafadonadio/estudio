using System;
using System.Collections;
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

public partial class BuscarContribuyente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		cboTipoPersona.Attributes.Add("onchange", "EnableControlsInSearch();");
		if (!IsPostBack)
		{
			txtNombre.Text = "Carolina";
			LoadControls();
		}
    }
	private void LoadControls()
	{

		cboTipoDoc.DataSource = DataAccess.Code_GetByGroup("Tipo Documento");
		cboTipoDoc.DataValueField = "Id";
		cboTipoDoc.DataTextField = "Code";
		cboTipoDoc.DataBind();

		cboTipoPersona.DataSource = DataAccess.PersonType_GetAll();
		cboTipoPersona.DataValueField = "Id";
		cboTipoPersona.DataTextField = "Description";
		cboTipoPersona.DataBind();

		cboTipoSociedad.DataSource = DataAccess.SocietyType_GetAll();
		cboTipoSociedad.DataValueField = "Id";
		cboTipoSociedad.DataTextField = "Description";
		cboTipoSociedad.DataBind();
		cboTipoSociedad.Items.Insert(0, new ListItem(Constants.SIN_SEL, Constants.SIN_SEL_ID));

	}
	protected void btnSearch_Click(object sender, ImageClickEventArgs e)
	{
		resultTPDataSource.SelectMethod = "SearchTaxpayer";
		resultTPDataSource.SelectParameters.Clear();
		resultTPDataSource.SelectParameters.Add("documentTypeId", cboTipoDoc.SelectedValue);
		resultTPDataSource.SelectParameters.Add("documentNumber", txtNroDoc.Text);
		resultTPDataSource.SelectParameters.Add("name", txtNombre.Text);
		resultTPDataSource.SelectParameters.Add("iibb", txtIIBB.Text);
		resultTPDataSource.SelectParameters.Add("personTypeId", cboTipoPersona.SelectedValue);
		resultTPDataSource.SelectParameters.Add("societyTypeId", cboTipoSociedad.SelectedValue);
		dgvBusqueda.DataBind();
		
	}
}
