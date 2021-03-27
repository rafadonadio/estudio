<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeFile="ContribFilia.aspx.cs"
	Inherits="ContribFilia" Culture="es-AR" UICulture="es-AR"    %>

<%@ Register Src="~/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Src="~/Categoria.ascx" TagName="Categoria" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title>Estudio Ivanovic & Asociados</title>
	<link href="~/StyleSheets/style.css" rel="stylesheet" type="text/css" />
	<link href="~/StyleSheets/fonts.css" rel="stylesheet" type="text/css" />

	<script src="../Scripts/Script.js" type="text/javascript"></script>

	<script src="Scripts/calendar1.js" type="text/javascript"></script>

	
</head>
<body onload="">
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
									Contribuyente - Datos Filiatorios</h1>
								<asp:HiddenField ID="hdnIdFilial" runat="server" />
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
								<table width="440" cellpadding="0" cellspacing="0" border="0" class="interline">
									<tr>
										<td >
											<asp:Label ID="lblFechaNac" runat="server" Text="Fecha Nacimiento"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:TextBox ID="txtFechaNac" runat="server" Width="74px" MaxLength="10"></asp:TextBox>
											<a href="javascript:cal2.popup();" runat="server" id="A1">
												<img src="images/cal.gif" width="16" height="16" border="0" alt="haga click para seleccionar la fecha"
													id="imgCalendar" runat="server" style="font-size: medium" align=bottom></a>
											<asp:RangeValidator ID="rgvFechaNac" runat="server" ControlToValidate="txtFechaNac" Display="Dynamic" 
												CssClass="error" ErrorMessage="Fecha inválida" Type="Date"></asp:RangeValidator>
										</td>
									</tr>
									<tr>
										<td >
											<asp:Label ID="lblLugarNac" runat="server" Text="Lugar Nacimiento"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:TextBox ID="txtLugarNac" runat="server" Width="100%"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td >
											<asp:Label ID="lblDoc1" runat="server" Text="Documento 1"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:DropDownList ID="cboTipoDoc1" runat="server" >
											</asp:DropDownList>
											<asp:TextBox ID="txtDoc1" runat="server" Width="34%" MaxLength="13"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td >
											<asp:Label ID="lblDoc2" runat="server" Text="Documento 2"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:DropDownList ID="cboTipoDoc2" runat="server" >
											</asp:DropDownList>
											<asp:TextBox ID="txtDoc2" runat="server" Width="34%" MaxLength="13"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td >
											<asp:Label ID="lblDoc3" runat="server" Text="Documento 3"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:DropDownList ID="cboTipoDoc3" runat="server" >
											</asp:DropDownList>
											<asp:TextBox ID="txtDoc3" runat="server" Width="34%" MaxLength="13"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td colspan="3">
											<hr />
										</td>
									</tr>
									<tr>
										<td colspan="3">
											Dirección<asp:HiddenField ID="hdnIdDir" runat="server" />
										</td>
									</tr>
									<tr>
										<td colspan="3">
											<hr />
										</td>
									</tr>
									<tr>
										<td >
											<asp:Label ID="lblDireccion" runat="server" Text="Dirección"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:TextBox ID="txtDireccion" runat="server" Width="120"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td >
											<asp:Label ID="lblCiudad" runat="server" Text="Ciudad"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:TextBox ID="txtCiudad" runat="server" Width="120"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td >
											<asp:Label ID="lblProvincia" runat="server" Text="Provincia"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:TextBox ID="txtProvincia" runat="server" Width="120"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td >
											<asp:Label ID="lblCP" runat="server" Text="Código Postal"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:TextBox ID="txtCP" runat="server" Width="120"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td >
											<asp:Label ID="lblPais" runat="server" Text="País"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:TextBox ID="txtPais" runat="server" Width="120"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td colspan="3">
											<hr />
										</td>
									</tr>
									<tr>
										<td >
											<asp:Label ID="lblSexo" runat="server" Text="Sexo"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:DropDownList ID="cboSexo" runat="server" >
											</asp:DropDownList>
										</td>
									</tr>
									<tr>
										<td >
											<asp:Label ID="lblEstado" runat="server" Text="Estado Civil"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:DropDownList ID="cboEstado" runat="server" >
											</asp:DropDownList>
										</td>
									</tr>
									<tr>
										<td colspan="3">
											&nbsp;
										</td>
									</tr>
									<tr>
										<td colspan="3">
											<asp:Label ID="lblAgregar" runat="server" Text="Agregar hijo"></asp:Label>
										</td>
									</tr>
									<tr>
										<td colspan="3" align="center">
											<asp:ImageButton ID="btnSave" runat="server" ImageUrl="images/save_button.jpg" 
												onclick="btnSave_Click" />
										</td>
									</tr>
								</table>
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

	<script>
	var cal2 = new calendar1(document.getElementById("<%= txtFechaNac.ClientID %>"));
	cal2.year_scroll = true;
	cal2.time_comp = false;
	</script>

</body>
</html>
