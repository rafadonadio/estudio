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

public partial class AdmPersonas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		lblError.Text = "";
    }
	protected void btnSave_Click(object sender, ImageClickEventArgs e)
	{
		DataAccess.PersonType_Insert(new PersonType(0, txtCodigo.Text.Trim(), txtDescripcion.Text.Trim()));
		txtCodigo.Text = "";
		txtDescripcion.Text = "";
		GridView1.DataBind();
	}
	protected void ptDataSource_Deleted(object sender, ObjectDataSourceStatusEventArgs e)
	{
		if (e.Exception != null)
		{
			lblError.Text = "<br/>No se pudo eliminar el registro";
			e.ExceptionHandled = true;
		}
		
	}
}
