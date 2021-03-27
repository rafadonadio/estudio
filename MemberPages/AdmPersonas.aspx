<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeFile="AdmPersonas.aspx.cs"
	Inherits="AdmPersonas" %>

<%@ Register Src="~/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Src="~/Categoria.ascx" TagName="Categoria" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Administración de Tipos de Persona</title>
	<link href="~/StyleSheets/style.css" rel="stylesheet" type="text/css" />
	<link href="~/StyleSheets/fonts.css" rel="stylesheet" type="text/css" />
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
					<asp:WebPartZone ID="wpzLeft" runat="server" PartChromePadding="0px" PartChromeType="None">
						<ZoneTemplate>
							<uc2:Categoria ID="mnContribuyente" runat="server" />
						</ZoneTemplate>
					</asp:WebPartZone>
				</td>
				<td id="tdBody" valign="top">
					<br />
					<br />
					<table cellpadding="0" cellspacing="0" border="0">
						<tr>
							<td>
								<img src="images/l_containertitle_leftcorner.jpg" alt="title" width="15" height="28" />
							</td>
							<td class="light_resulttitle floatleft">
								<h1 class="tahoma11 color_5b5b5b">
									Administración de Tipos de Persona</h1>
							</td>
							<td>
								<img src="images/l_containertitle_rightbg.jpg" alt="title" width="235" height="27" />
							</td>
							<td>
								<img src="images/l_containertitle_rightsign.jpg" alt="sign" width="26" height="27" />
							</td>
						</tr>
						<tr>
							<td colspan="3">
								&nbsp;
							</td>
						</tr>
						<tr>
							<td colspan="3">
								&nbsp;
							</td>
						</tr>
						<tr>
							<td colspan="3" class="textblock tahoma11 color_5b5b5b interLine">
								<table align=center>
									<tr>
										<td>
											<asp:Label ID="lblCodigo" runat="server" Text="Código"></asp:Label>
										</td>
										<td>
											<asp:TextBox ID="txtCodigo" runat="server" ValidationGroup></asp:TextBox>
											<asp:RequiredFieldValidator ID="rqvCod" runat="server" CssClass="error" 
												Display="Dynamic" ErrorMessage="Debe ingresar el código" ValidationGroup="alta" ControlToValidate="txtCodigo">*</asp:RequiredFieldValidator>
										</td>
										<td>&nbsp;
										</td>
										<td>
											<asp:Label ID="lblDescripcion" runat="server" Text="Descripción"></asp:Label>
										</td>
										<td>
											<asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
											<asp:RequiredFieldValidator ID="rqvDesc" runat="server" CssClass="error" 
												Display="Dynamic" ErrorMessage="Debe ingresar la descripción" 
												ValidationGroup="alta" ControlToValidate="txtDescripcion">*</asp:RequiredFieldValidator>
										</td>
									</tr>
									<tr>
										<td colspan="5">
											<asp:ValidationSummary ID="valSumm" runat="server" ValidationGroup="alta" />
										</td>
									</tr>
									<tr>
										<td colspan="5" align=center>
											<asp:ImageButton ID="btnSave" runat="server" onclick="btnSave_Click" 
												ImageUrl="images/save_button.jpg" CausesValidation=true ValidationGroup="alta" />
										</td>
									</tr>
									<tr>
										<td colspan="5">&nbsp;
										</td>
									</tr>
								</table>
							</td>
						</tr>
						<tr class="allresults_container" align=center>
							<td class="textblock tahoma11 color_5b5b5b" colspan="3">
								<asp:GridView ID="GridView1" align=center runat="server" AutoGenerateColumns="False" DataSourceID="ptDataSource"
									DataKeyNames="Id">
									<RowStyle CssClass="leftmenu_categories_container" />
									<Columns>
										<asp:BoundField DataField="Id" ReadOnly="true" HeaderText="Id" SortExpression="Id" />
										<asp:BoundField DataField="Code" HeaderText="Code" SortExpression="Code" />
										<asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
										<asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
									</Columns>
									<SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
									<HeaderStyle  CssClass="headerGrid" Height=22 />
									<AlternatingRowStyle CssClass="darkoption" />
									</asp:GridView>
								<asp:ObjectDataSource ID="ptDataSource" runat="server" SelectMethod="PersonType_GetAll"
									TypeName="DataAccess" UpdateMethod="PersonType_Update" DataObjectTypeName="PersonType"
									DeleteMethod="PersonType_Delete"  InsertMethod="PersonType_Insert" ondeleted="ptDataSource_Deleted" 
									></asp:ObjectDataSource>
								<asp:Label ID="lblError" runat="server" CssClass=error></asp:Label>
							</td>
						</tr>
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
