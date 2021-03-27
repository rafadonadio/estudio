﻿using System;
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

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

	
	protected void Login1_LoggedIn(object sender, EventArgs e)
	{
		string[] roles = Roles.GetRolesForUser(((System.Web.UI.WebControls.Login)sender).UserName);
		Session["UserId"] = DataAccess.GetUserId(((System.Web.UI.WebControls.Login)sender).UserName);
	}
}
