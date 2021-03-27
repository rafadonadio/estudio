<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    	<h1>
    Registrar
    	</h1>
    </div>
    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" 
		ContinueDestinationPageUrl="~/Default.aspx" 
		oncreateduser="CreateUserWizard1_CreatedUser">
		<WizardSteps>
			<asp:CreateUserWizardStep runat="server" />
			<asp:CompleteWizardStep runat="server" />
		</WizardSteps>
	</asp:CreateUserWizard>
	<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Home</asp:HyperLink>
    </form>
</body>
</html>
