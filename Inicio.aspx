<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Inicio.aspx.cs" Inherits="Inicio" %>

<%@ Register Src="Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Src="Categoria.ascx" TagName="Categoria" TagPrefix="uc2" %>
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
							<uc2:Categoria ID="Categoria1" runat="server" Title="Area 1" />
							<uc2:Categoria ID="Categoria2" runat="server" Title="Area 2" />
							<uc2:Categoria ID="Categoria3" runat="server" Title="Area 3" />
						</ZoneTemplate>
					</asp:WebPartZone>
				</td>
				<td id="tdBody" valign=top>
					<br /><br />
					<table cellpadding=0 cellspacing=0 border=0>
						<tr>
							<td>
								<img src="Images/l_containertitle_leftcorner.jpg" alt="title" width="15" height="28" />
							</td>
							<td class="light_resulttitle floatleft">
								<h1 class="tahoma11 color_5b5b5b">
									Titulo 1 - Pagina de Inicio			Titulo 1 - Pagina de Inicio</h1>
							</td>
							
							<td><img src="Images/l_containertitle_rightbg.jpg" alt="title" width="235" height="27" /> </td>
							<td><img src="images/l_containertitle_rightsign.jpg" alt="sign" width="26" height="27" /></td>
						</tr>
						<tr class="allresults_container"><td colspan=3 class="textblock tahoma11 color_5b5b5b" width="100px">Cliente es el nombre generico que se asocia a uno o varios contribuyentes. Es la forma coloquial de distinguir
a un grupo de personas (o uno solo, si es el caso) que engloba e identifica a un grupo de contribuyentes.

Contribuyente es aquel que es pasible de obligaciones tributarias, que posee una CUIT  y sobre el cual se trabaja
y se presentan las formalidades impositivas y legales.

Por lo tanto, puede haber muchos contribuyentes con un cliente (e incluso uno solo) pero no hay cliente sin contribuyente.</td></tr>
						<tr><td colspan=3>&nbsp;</td></tr>
						<tr><td colspan=3></td></tr>
						<tr>
							<td>
								<img src="Images/l_containertitle_leftcorner.jpg" alt="title" width="15" height="28" />
							</td>
							<td class="light_resulttitle floatleft">
								<h1 class="tahoma11 color_5b5b5b">
									Titulo 2 - Pagina de Inicio</h1>
							</td>
							
							<td><img src="Images/l_containertitle_rightbg.jpg" alt="title" width="235" height="27" /> </td>
							<td><img src="images/l_containertitle_rightsign.jpg" alt="sign" width="26" height="27" /></td>
						</tr>
						<tr class="allresults_container"><td colspan=3 class="textblock tahoma11 color_5b5b5b" width="100px">Independientemente de lo que se agregue en el presente esquema, puede ocurrir que un contribuyente  sobre el cual se ha estado
trabajando deje de serlo.

Ello puede ser por muerte, porque el cliente se fue, porque se dio de baja, etc. pero los registros se deben mantener.
Sin embargo en el dia a dia, tener disponible dicha informacion a la vista "estorba" o complica.

Por lo tanto una opcion SI/NO en una opcion "Activo" soluciona la cuestion, permitiendo via otra consulta, ver aquellas cosas que
no se encuentren activas.
</td></tr>
						<tr><td colspan=3>&nbsp;</td></tr>
						<tr><td colspan=3></td></tr>
						<tr>
							<td>
								<img src="Images/l_containertitle_leftcorner.jpg" alt="title" width="15" height="28" />
							</td>
							<td class="light_resulttitle floatleft">
								<h1 class="tahoma11 color_5b5b5b">
									Titulo 3 - Pagina de Inicio</h1>
							</td>
							
							<td><img src="Images/l_containertitle_rightbg.jpg" alt="title" width="235" height="27" /> </td>
							<td><img src="images/l_containertitle_rightsign.jpg" alt="sign" width="26" height="27" /></td>
						</tr>
						<tr class="allresults_container"><td colspan=3 class="textblock tahoma11 color_5b5b5b" width="100px">Una cuestion importante es que es necesario tener una referencia a si el hijo es < a 24 años.
Ello es importante, ya que de ser asi, es deducible a los efectos del impuesto a las ganancias.
Necesitaria que el calculo lo haga solo y aparezca (deducible/No deducible) segun el año.

Otra aclaracion es que la esposa es deducible (a los efectos del impuesto a las ganancias) si tiene un ingreso < a un tope.
Dicho tope cambia periodicamente.</td></tr>
						<tr><td colspan=3>&nbsp;</td></tr>
						<tr><td colspan=3></td></tr>
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
