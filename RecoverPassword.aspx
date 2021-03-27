<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RecoverPassword.aspx.cs" Inherits="RecoverPassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>
		<span><span class="input">Reset my password to a new value</span></span></h1>
    <div>
    
    	<asp:PasswordRecovery ID="PasswordRecovery1" runat="server">
		</asp:PasswordRecovery>
    
    </div>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">home</asp:HyperLink>
    </form>
</body>
</html>
