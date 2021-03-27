<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<asp:WebPartManager ID="WebPartManager1" runat="server">
		</asp:WebPartManager>
		<table id="tblTemplate" width="100%" cellpadding="0" cellspacing="0" border="0">
			<tr>
				<td id="trHeader" colspan="3" background="Images/TitPrinc.jpg">
					<asp:WebPartZone ID="wpzHeader" runat="server" LayoutOrientation="Horizontal">
						<ZoneTemplate>
							<asp:LoginView ID="LoginView1" runat="server">
								<LoggedInTemplate>
									<span><span class="input">You are logged in. Welcome&nbsp;&nbsp; </span>
									<asp:LoginName ID="LoginName1" runat="server" />
									<br />
									<br />
									.</span><asp:HyperLink ID="HyperLink4" runat="server" 
										NavigateUrl="MemberPages/ChangePassword.aspx."><span 
										style="display:inline-block;height:100%;">cambiar Pass</span></asp:HyperLink>
									&nbsp;
									<br />
									<asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="Default.aspx"><span 
										style="display:inline-block;height:100%;">Cerrar Sesion</span><span 
										style="display:inline-block;height:100%;">Cerrar Sesion</span></asp:HyperLink>
									<br />
									<br />
									<asp:LoginStatus ID="LoginStatus1" runat="server" />
								</LoggedInTemplate>
								<AnonymousTemplate>
									<span><span class="input">You are not logged in. <br />
									<asp:HyperLink ID="HyperLink5" runat="server" 
										NavigateUrl="RecoverPassword.aspx"><span 
										style="display:inline-block;height:100%;"><span><span class="input">rec pass</span></span></span></asp:HyperLink>
									&nbsp;-
									<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="Login.aspx"><span 
										style="display:inline-block;height:100%;"><span><span class="input">Login</span></span></span><span 
										style="display:inline-block;height:100%;"><span><span class="input"><span 
										style="display:inline-block;height:100%;"><span><span class="input">Login</span></span></span></span></span></span></asp:HyperLink>
									&nbsp;-
									</span></span>
									<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="Register.aspx"><span 
										style="display:inline-block;height:100%;">Registrarse</span></asp:HyperLink>
								</AnonymousTemplate>
							</asp:LoginView>
						</ZoneTemplate>
					</asp:WebPartZone>
				</td>
			</tr>
			<tr height="500px">
				<td id="tdLeft" width="20%">
					<asp:WebPartZone ID="wpzLeft" runat="server">
						<ZoneTemplate>
							<asp:Button ID="btnMoverWP" runat="server" Style="height: 26px" Text="Mover Web Parts"
								OnClick="btnMoverWP_Click" />
								<asp:Button ID="btnEditar" runat="server" Style="height: 26px" Text="Editar"
								OnClick="btnEditar_Click" />
							<asp:Button ID="btnSinEdicion" runat="server" Text="Volver a vista sin Edición" OnClick="btnSinEdicion_Click" />
							<asp:Button ID="btnCatalogo" runat="server" Text="Catalogo" OnClick="btnCatalogo_Click" />
						</ZoneTemplate>
					</asp:WebPartZone>
				</td>
				<td id="tdBody">
					<asp:HyperLink ID="HyperLink1" runat="server" 
						NavigateUrl="MemberPages/Members.aspx">HyperLink</asp:HyperLink>
				<asp:CatalogZone ID="CatalogZone1" runat="server" BackColor="#F7F6F3" BorderColor="#CCCCCC"
						BorderWidth="1px" Font-Names="Verdana" Padding="6">
						<ZoneTemplate>
							<asp:PageCatalogPart ID="PageCatalogPart1" runat="server" />
						</ZoneTemplate>
						<PartLinkStyle Font-Size="0.8em" />
						<PartTitleStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.8em" ForeColor="White" />
						<EditUIStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" />
						<PartStyle BorderColor="#F7F6F3" BorderWidth="5px" />
						<HeaderVerbStyle Font-Bold="False" Font-Size="0.8em" Font-Underline="False" ForeColor="#333333" />
						<PartChromeStyle BorderColor="#E2DED6" BorderStyle="Solid" BorderWidth="1px" />
						<EmptyZoneTextStyle Font-Size="0.8em" ForeColor="#333333" />
						<SelectedPartLinkStyle Font-Size="0.8em" />
						<VerbStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" />
						<LabelStyle Font-Size="0.8em" ForeColor="#333333" />
						<FooterStyle BackColor="#E2DED6" HorizontalAlign="Right" />
						<HeaderStyle BackColor="#E2DED6" Font-Bold="True" Font-Size="0.8em" ForeColor="#333333" />
						<InstructionTextStyle Font-Size="0.8em" ForeColor="#333333" />
					</asp:CatalogZone>
					<asp:EditorZone ID="EditorZone1" runat="server">
						<ZoneTemplate>
							<asp:AppearanceEditorPart ID="AppearanceEditorPart1" runat="server" />
							<asp:BehaviorEditorPart ID="BehaviorEditorPart1" runat="server" />
							<asp:LayoutEditorPart ID="LayoutEditorPart1" runat="server" />
						</ZoneTemplate>
					</asp:EditorZone>
				</td>
				<td id="tdRigth" width="20%">
					<asp:WebPartZone ID="wpzRigth" runat="server">
						<ZoneTemplate>
							<asp:Login ID="Login1" runat="server" onauthenticate="Login1_Authenticate">
							</asp:Login>
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
