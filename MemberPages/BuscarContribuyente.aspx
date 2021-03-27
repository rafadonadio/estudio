<%@ Page Language="C#" ValidateRequest="false" AutoEventWireup="true" CodeFile="BuscarContribuyente.aspx.cs"
	Inherits="BuscarContribuyente" Culture="es-AR" UICulture="es-AR"  %>

<%@ Register Src="~/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title>Estudio Ivanovic & Asociados</title>
	<link href="~/StyleSheets/style.css" rel="stylesheet" type="text/css" />
	<link href="~/StyleSheets/fonts.css" rel="stylesheet" type="text/css" />
	<script src="../Scripts/Script.js" type="text/javascript"></script>
</head>
<body onload="EnableControlsInSearch();">
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
									Buscar Contribuyente</h1>
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
						<tr class="allresults_container">
							<td colspan="3" class="textblock tahoma11 color_5b5b5b">
							</td>
						</tr>
						<tr class="allresults_container">
							<td colspan="3" class="textblock tahoma11 color_5b5b5b interLine">
								<table class="interLine" width="100%" cellpadding="0" cellspacing="0" border="0">
									<tr>
										<td>
											<asp:Label ID="lblTipoDoc" runat="server" Text="Tipo Documento"></asp:Label>
										</td>
										<td>&nbsp;&nbsp;
										</td>
										<td>
											<asp:DropDownList ID="cboTipoDoc" runat="server">
											</asp:DropDownList>
										</td>
									</tr>
									<tr>
										<td>
											<asp:Label ID="lblNroDoc" runat="server" Text="Nro. Documento"></asp:Label>
										</td>
										<td>&nbsp;&nbsp;
										</td>
										<td>
											<asp:TextBox ID="txtNroDoc" runat="server"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td>
											<asp:Label ID="lblNombre" runat="server" Text="Nombre/Denominación"></asp:Label>
										</td>
										<td>
										</td>&nbsp;&nbsp;
										<td>
											<asp:TextBox ID="txtNombre" runat="server" ></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td>
											<asp:Label ID="lblIIBB" runat="server" Text="IIBB"></asp:Label>
										</td>
										<td>&nbsp;&nbsp;
										</td>
										<td>
											<asp:TextBox ID="txtIIBB" runat="server"></asp:TextBox>
										</td>
									</tr>
									<tr>
										<td>
											<asp:Label ID="lblTPersona" runat="server" Text="Tipo Persona"></asp:Label>
										</td>
										<td>&nbsp;&nbsp;
										</td>
										<td><asp:DropDownList ID="cboTipoPersona" runat="server">
											</asp:DropDownList>
										</td>
									</tr>
									<tr>
										<td>
											<asp:Label ID="lblTSociedad" runat="server" Text="Tipo Sociedad"></asp:Label>
										</td>
										<td>&nbsp;&nbsp;
										</td>
										<td>
										<asp:DropDownList ID="cboTipoSociedad" runat="server">
											</asp:DropDownList>	
										</td>
									</tr>
									<tr><td colspan=3 align=center>&nbsp;&nbsp;</td></tr>
									<tr><td colspan=3 align=center>
										<asp:ImageButton ID="btnSearch" ImageUrl="images/search_button.jpg" 
											runat="server" onclick="btnSearch_Click" /></td></tr>
									<tr><td colspan=3 align=center>&nbsp;&nbsp;</td></tr>
									<tr><td colspan=3 align=center>
										<asp:Label ID="Label1" runat="server" ForeColor="Red" 
											Text="Por el momento solo busca por Nombre / Denominación"></asp:Label>
										&nbsp;&nbsp;</td></tr>
								</table>
							</td>
						</tr>
						<tr>
							<td>
								<img src="images/l_containertitle_leftcorner.jpg" alt="title" width="15" height="28" />
							</td>
							<td class="light_resulttitle floatleft">
								<h1 class="tahoma11 color_5b5b5b">
									Resultados</h1>
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
						<tr >
							<td colspan="3" class="allresults_container tahoma11 color_5b5b5b" align=center> 
								<asp:GridView ID="dgvBusqueda" runat="server" AutoGenerateColumns="False" 
									DataSourceID="resultTPDataSource" BackColor="White" BorderColor="#999999" BorderStyle="None" 
									BorderWidth="1px" CellPadding="3" GridLines="Vertical">
									<RowStyle CssClass="leftmenu_categories_container" />
									<Columns>
										<asp:BoundField DataField="TaxpayerId" HeaderText="TaxpayerId" 
											Visible=false />
										<asp:BoundField DataField="CUIT" HeaderText="CUIT" SortExpression="CUIT" />
										<asp:HyperLinkField DataTextField="TaxpayerName" HeaderText="Contribuyente" SortExpression="Name" DataNavigateUrlFields="Action" />
										<asp:BoundField DataField="Name" HeaderText="Nombre" SortExpression="Name" />
										<asp:BoundField DataField="NameType" HeaderText="Tipo Nombre" 
											SortExpression="NameType" />
										<asp:BoundField DataField="DocumentType" HeaderText="Tipo Doc" 
											SortExpression="DocumentType" />
										<asp:BoundField DataField="Document" HeaderText="Documento" 
											SortExpression="Document" />
									</Columns>
									<FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
									<PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
									<SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
									<HeaderStyle  CssClass="headerGrid" />
									<AlternatingRowStyle CssClass="darkoption" />
								</asp:GridView>
								<asp:ObjectDataSource ID="resultTPDataSource" runat="server" 
									SelectMethod="SearchTaxpayer" TypeName="DataAccess"></asp:ObjectDataSource>
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
