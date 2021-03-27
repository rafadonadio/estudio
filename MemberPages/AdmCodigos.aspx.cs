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

public partial class AdmCodigos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		lblError.Text = "";
		if(!IsPostBack)
			LoadControls();
    }

	private void LoadControls()
	{
		cboGrupo.DataSource = DataAccess.Code_GetGroups();
		cboGrupo.DataValueField = "Group";
		cboGrupo.DataTextField = "Group";
		cboGrupo.DataBind();
//		cboTipoSociedad.Items.Insert(0, new ListItem(Constants.SIN_SEL, Constants.SIN_SEL_ID));

	}
	protected void btnSave_Click(object sender, ImageClickEventArgs e)
	{
		//Preguntar si el combo de grupo esta seleccionado
		DataAccess.Code_Insert(new Code(0, cboGrupo.SelectedValue, txtCodigo.Text.Trim(), txtDescripcion.Text.Trim()));
		txtCodigo.Text = "";
		txtDescripcion.Text = "";
		GridView1.DataBind();
	}
	protected void codDataSource_Deleted(object sender, ObjectDataSourceStatusEventArgs e)
	{
		if (e.Exception != null)
		{
			lblError.Text = "<br/>No se pudo eliminar el registro";
			e.ExceptionHandled = true;
		}
		
	}
	protected void cboGrupo_SelectedIndexChanged(object sender, EventArgs e)
	{
		GridView1.DataBind();
	}
}
