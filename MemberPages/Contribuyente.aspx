<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeFile="Contribuyente.aspx.cs"
	Inherits="Contribuyente" %>

<%@ Register Src="~/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Src="~/Categoria.ascx" TagName="Categoria" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title>Estudio Ivanovic & Asociados</title>
	<link href="~/StyleSheets/style.css" rel="stylesheet" type="text/css" />
	<link href="~/StyleSheets/fonts.css" rel="stylesheet" type="text/css" />
	<script src="../Scripts/Script.js" type="text/javascript"></script>
	
</head>
<body onload="SetLabelName();">
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
									Contribuyente</h1><asp:HiddenField ID="hdnIdContrib" runat="server" />
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
								<table width="240" cellpadding="0" cellspacing="0" border="0" class="interline">
									<tr>
										<td width="30%">
											<asp:Label ID="lblCUIT" runat="server" Text="CUIT"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:TextBox ID="txtCUIT" runat="server" Width="120"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td width="30%">
											<asp:Label ID="lblPersona" runat="server" Text="Persona"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:DropDownList ID="cboTipoPersona" runat="server">
											</asp:DropDownList>
										</td>
									</tr>
									<tr>
										<td width="30%">
											<asp:Label ID="lblSociedad" runat="server" Text="Sociedad"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:DropDownList ID="cboTipoSociedad" runat="server">
											</asp:DropDownList>
										</td>
									</tr>
									<tr>
										<td width="30%">
											<asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:TextBox ID="txtNombre" runat="server" Width="120"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td width="30%">
											<asp:Label ID="lblCierre" runat="server" Text="Cierre"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:Label ID="lblMes" runat="server" Text="Mes: &nbsp;"></asp:Label>
											<asp:TextBox ID="txtMesCierre" runat="server" MaxLength="2" Width="19px"></asp:TextBox>
											<asp:Label ID="lblAnio" runat="server" Text="Año: &nbsp;"></asp:Label>
											<asp:TextBox ID="txtAnioCierre" runat="server" MaxLength="4" Width="30px"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td colspan="3">
											<hr />
										</td>
									</tr>
									<tr>
										<td colspan="3">
											Dirección Legal<asp:HiddenField ID="hdnIdDirLegal" runat="server" />
										</td>
									</tr>
									<tr>
										<td colspan="3">
											<hr />
										</td>
									</tr>
									<tr>
										<td width="30%">
											<asp:Label ID="lblDireccionL" runat="server" Text="Dirección"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:TextBox ID="txtDireccionL" runat="server" Width="120"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td width="30%">
											<asp:Label ID="lblCiudadL" runat="server" Text="Ciudad"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:TextBox ID="txtCiudadL" runat="server" Width="120"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td width="30%">
											<asp:Label ID="lblProvinciaL" runat="server" Text="Provincia"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:TextBox ID="txtProvinciaL" runat="server" Width="120"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td width="30%">
											<asp:Label ID="lblCPL" runat="server" Text="Código Postal"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:TextBox ID="txtCPL" runat="server" Width="120"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td width="30%">
											<asp:Label ID="lblPaisL" runat="server" Text="País"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:TextBox ID="txtPaisL" runat="server" Width="120"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td colspan="3">
											<hr />
										</td>
									</tr>
									<tr>
										<td colspan="3">
											Dirección Real<asp:HiddenField ID="hdnIdDirReal" runat="server" />
										</td>
									</tr>
									<tr>
										<td colspan="3">
											<hr />
										</td>
									</tr>
									<tr>
										<td width="30%">
											<asp:Label ID="lblDireccionR" runat="server" Text="Dirección"></asp:Label>
										</td>
										<td width="10%">
											&nbsp;
										</td>
										<td width="60%">
											<asp:TextBox ID="txtDireccionR" runat="server" Width="120"></asp:TextBox>
										</td>
									</tr>
								<tr>
									<td width="30%">
										<asp:Label ID="lblCiudadR" runat="server" Text="Ciudad"></asp:Label>
									</td>
									<td width="10%">
										&nbsp;
									</td>
									<td width="60%">
										<asp:TextBox ID="txtCiudadR" runat="server" Width="120"></asp:TextBox>
									</td>
								</tr>
						<tr>
							<td width="30%">
								<asp:Label ID="lblProvinciaR" runat="server" Text="Provincia"></asp:Label>
							</td>
							<td width="10%">
								&nbsp;
							</td>
							<td width="60%">
								<asp:TextBox ID="txtProvinciaR" runat="server" Width="120"></asp:TextBox>
							</td>
						</tr>
						<tr>
							<td width="30%">
								<asp:Label ID="lblCPR" runat="server" Text="Código Postal"></asp:Label>
							</td>
							<td width="10%">
								&nbsp;
							</td>
							<td width="60%">
								<asp:TextBox ID="txtCPR" runat="server" Width="120"></asp:TextBox>
							</td>
						</tr>
						<tr>
							<td width="30%">
								<asp:Label ID="lblPaisR" runat="server" Text="País"></asp:Label>
							</td>
							<td width="10%">
								&nbsp;
							</td>
							<td width="60%">
								<asp:TextBox ID="txtPaisR" runat="server" Width="120"></asp:TextBox>
							</td>
						</tr>
						<tr>
										<td colspan="3">
											<hr />
										</td>
									</tr><tr>
							<td width="30%">
								<asp:Label ID="lblJurisdiccion" runat="server" Text="Jurisdicción"></asp:Label>
							</td>
							<td width="10%">
								&nbsp;
							</td>
							<td width="60%">
								<asp:TextBox ID="txtJurisdiccion" runat="server" Width="120"></asp:TextBox>
							</td>
						</tr>
						<tr>
							<td colspan="3">
								&nbsp;
							</td>
						</tr>
						<tr>
							<td colspan="3" align="center">
								<asp:ImageButton ID="btnSave" runat="server" ImageUrl="images/save_button.jpg" OnClick="btnSave_Click" />
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
</body>
</html>
