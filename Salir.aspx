<%@ Page Language="C#" ValidateRequest="false" AutoEventWireup="true" CodeFile="Salir.aspx.cs" Inherits="Salir" %>

<%@ Register Src="Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title>Estudio Ivanovic & Asociados</title>
	<link href="StyleSheets/style.css" rel="stylesheet" type="text/css" />
	<link href="StyleSheets/fonts.css" rel="stylesheet" type="text/css" />
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<asp:WebPartManager ID="WebPartManager1" runat="server">
		</asp:WebPartManager>
		<table id="tblTemplate" width="100%" cellpadding="0" cellspacing="0" border="0">
			<tr>
				<td id="trHeader" colspan="3">
					<asp:WebPartZone ID="wpzHeader" runat="server" LayoutOrientation="Horizontal" EmptyZoneTextStyle-Width="0"
						EmptyZoneTextStyle-Height="0" PartChromePadding="0px" PartChromeType="None">
						<EmptyZoneTextStyle Height="0px" Width="0px" />
						<ZoneTemplate>
							<uc1:Menu ID="Menu1" runat="server" />
						</ZoneTemplate>
					</asp:WebPartZone>
				</td>
			</tr>
			<tr height="500px">
				<td id="tdLeft" width="20%">
					<asp:WebPartZone ID="wpzLeft" runat="server" PartChromePadding="0px" 
						PartChromeType="None">
						<ZoneTemplate>
							
						</ZoneTemplate>
					</asp:WebPartZone>
				</td>
				<td id="tdBody" valign=top>
					<br /><br />
					<table cellpadding=0 cellspacing=0 border=0>
						<tr>
							<td>
								<img src="images/l_containertitle_leftcorner.jpg" alt="title" width="15" height="28" />
							</td>
							<td class="light_resulttitle floatleft">
								<h1 class="tahoma11 color_5b5b5b">
									Salir</h1>
							</td>
							
							<td><img src="Images/l_containertitle_rightbg.jpg" alt="title" width="235" height="27" /> </td>
							<td><img src="images/l_containertitle_rightsign.jpg" alt="sign" width="26" height="27" /></td>
						</tr>
						<tr><td colspan=3>&nbsp;</td></tr>
						<tr class="allresults_container"><td colspan=3 
								class="textblock tahoma11 color_5b5b5b"></td></tr>
						<tr class="allresults_container"><td colspan=3 
								class="textblock tahoma11 color_5b5b5b">
<asp:LoginView ID="LoginView1" runat="server" >
								<LoggedInTemplate>
									El usuario
									<asp:LoginName ID="LoginName1" runat="server" />
									&nbsp;se encuentra logueado.<br />
									<br />
									<br />
									<asp:LoginStatus ID="LoginStatus1" runat="server" LogoutAction="Redirect" 
										LogoutPageUrl="Inicio.aspx" onloggedout="LoginStatus1_LoggedOut" />
								</LoggedInTemplate>
								<AnonymousTemplate>
									No hay ningún usuario logueado actualmente
								</AnonymousTemplate>
							</asp:LoginView>						</td></tr>
					</table>
				</td>
				<td id="tdRigth" width="20%">
					<asp:WebPartZone ID="wpzRigth" runat="server">
						<ZoneTemplate>
						</ZoneTemplate>
					</asp:WebPartZone>
				</td>
			</tr>
			<tr>
				<td id="tdFooter" colspan="3">
					<asp:WebPartZone ID="wpzFooter" runat="server" Width="98px" LayoutOrientation="Horizontal">
					</asp:WebPartZone>
				</td>
			</tr>
		</table>
	</div>
	</form>
</body>
</html>
