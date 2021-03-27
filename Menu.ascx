<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu.ascx.cs" Inherits="Menu" %>
<!-- Header-->
<script>

String.prototype.endsWith = function(str) {return (this.match(str+"$")==str)}


function SetMenu(sender){
	var subMenu = document.getElementById('<%= ulSubMenu.ClientID %>');
	var contrib = document.getElementById('<%= imgContrib.ClientID %>');
	var reportes = document.getElementById('<%= imgReportes.ClientID %>');
	var usuarios = document.getElementById('<%= imgUsuarios.ClientID %>');
	var conf = document.getElementById('<%= imgConf.ClientID %>');
	var ayuda = document.getElementById('<%= imgAyuda.ClientID %>');
	var bullet =  "<img src=\"images/topsubmenu_bullet.jpg\" width=\"6\" height=\"6\"  />";
	var subMenuItems ="";
	if(!contrib.src.endsWith("_no.jpg$"))
		contrib.src = "images/Contribuyentes_no.jpg";
	if(!reportes.src.endsWith("_no.jpg$"))
		reportes.src = "images/Reportes_no.jpg";
	if(!usuarios.src.endsWith("_no.jpg$"))
		usuarios.src = "images/Usuarios_no.jpg";
	if(!conf.src.endsWith("_no.jpg$"))
		conf.src = "images/Configuracion_no.jpg";
	if(!ayuda.src.endsWith("_no.jpg$"))
		ayuda.src = "images/Ayuda_no.jpg";
	if(sender.id == '<%= imgContrib.ClientID %>'){
		sender.src = "images/Contribuyentes_o.jpg"
		subMenuItems = document.getElementById('<%= hdnItemsContrib.ClientID %>').value;
		//subMenuItems = "<li><a href=\"\" class=\"bold\">Buscar Contribuyente</a></li><li>|</li>";
		//subMenuItems += "<li><a href=\"\" class=\"bold\">Crear Contribuyente</a></li>";
	}
	else if(sender.id == '<%= imgReportes.ClientID %>'){
		sender.src = "images/Reportes_o.jpg"
		subMenuItems = document.getElementById('<%= hdnItemsReportes.ClientID %>').value;
		//subMenuItems = "<li><a href=\"\" class=\"bold\">Contrib con cierre en este mes</a></li><li>|</li>";
		//subMenuItems += "<li><a href=\"\" class=\"bold\">Controb con vencimientos esta semana</a></li>";
	}
	else if(sender.id == '<%= imgUsuarios.ClientID %>'){
		sender.src = "images/Usuarios_o.jpg"
		subMenuItems = document.getElementById('<%= hdnItemsUsuarios.ClientID %>').value;
		//subMenuItems = "<li><a href=\"\" class=\"bold\">Registrarse</a></li><li>|</li>";
		//subMenuItems += "<li><a href=\"\" class=\"bold\">Cambiar Clave</a></li><li>|</li>";
		//subMenuItems += "<li><a href=\"\" class=\"bold\">Recuperar Clave</a></li><li>|</li>";
		//subMenuItems += "<li><a href=\"\" class=\"bold\">Roles</a></li>";
	}
	else if(sender.id == '<%= imgConf.ClientID %>'){
		sender.src = "images/Configuracion_o.jpg"
		subMenuItems = document.getElementById('<%= hdnItemsConfig.ClientID %>').value;
		//subMenuItems = "<li><a href=\"\" class=\"bold\">Personas</a></li><li>|</li>";
		//subMenuItems += "<li><a href=\"\" class=\"bold\">Sociedades</a></li><li>|</li>";
		//subMenuItems += "<li><a href=\"\" class=\"bold\">Parentesco</a></li><li>|</li>";
		//subMenuItems += "<li><a href=\"\" class=\"bold\">Agencia AFIP</a></li><li>|</li>";
		//subMenuItems += "<li><a href=\"\" class=\"bold\">Acividad Agencia</a></li><li>|</li>";
		//subMenuItems += "<li><a href=\"\" class=\"bold\">Bienes</a></li><li>|</li>";
		//subMenuItems += "<li><a href=\"\" class=\"bold\">Parametros</a></li>";
	}
	else if(sender.id == '<%= imgAyuda.ClientID %>'){
		sender.src = "images/Ayuda_o.jpg"
		subMenuItems = document.getElementById('<%= hdnItemsAyuda.ClientID %>').value;
		//subMenuItems = "<li><a href=\"\" class=\"bold\">Temas de ayuda</a></li>";
	}
	subMenu.innerHTML = subMenuItems ;

}
</script>
<table cellpadding=0 cellspacing=0 border=0 width="100%">
	<tr >
		<td width=13 ><img alt="" src="images/topleft_corner.jpg" />
		</td>
		<td width=130 background="images/top_intermediate.jpg" ></td>
		<td colspan=6 background="images/top_intermediate.jpg"> </td>
		
		<td width="13px"  >
			<img alt="" src="images/topright_corner.jpg" width="13px"  />
			</td>
	</tr>
	<tr  class="newsletter_form">
		
		<td colspan=3 >
		<img id="imgContrib" runat=server alt="" src="images/Contribuyentes_o.jpg"  onclick="SetMenu(this);"/>
			</td>
		
		<td><img id="imgReportes" runat=server alt="" src="images/Reportes_no.jpg"  onclick="SetMenu(this);"/>
		</td>
		<td><img id="imgUsuarios" runat=server alt="Usuarios" src="images/Usuarios_no.jpg"  onclick="SetMenu(this);"/>
		</td>
		<td>
		<img id="imgConf" runat=server alt="Configuración" src="images/Configuracion_no.jpg"  onclick="SetMenu(this);"/>
		</td>
		<td>
		<img id="imgAyuda" runat=server alt="Ayuda" src="images/Ayuda_no.jpg"  onclick="SetMenu(this);"/>
		</td>
		<td nowrap=nowrap background=images/middleright_bg.jpg><asp:Label ID="lblBuscar" runat="server" Text="&nbsp;&nbsp;Buscar&nbsp;&nbsp;" class="tahoma12 color_dfe9f0"></asp:Label>
			<asp:TextBox ID="txtBuscar" runat="server" class="neswletterform_input tahoma9"></asp:TextBox>
			<asp:Image ID="Image1" runat="server"  ImageUrl="images/Buscar_ok.jpg"/>
		</td>
		
		<td ><img alt="" src="images/middleright_corner.jpg"  />
			</td>
	</tr>
	<tr class="footer_menu tahoma11"><td colspan=9><ul  runat=server id="ulSubMenu" class="tahoma11">
</ul>
</td></tr>
<tr width="100%" class="greyseparator"><td  colspan=9>&nbsp</td></tr>
<tr width="100%" class="whiteseparator"><td  colspan=9>&nbsp</td></tr>
</table>
<asp:HiddenField ID="hdnItemsContrib" runat="server" />
<asp:HiddenField ID="hdnItemsReportes" runat="server" />
<asp:HiddenField ID="hdnItemsUsuarios" runat="server" />
<asp:HiddenField ID="hdnItemsConfig" runat="server" />
<asp:HiddenField ID="hdnItemsAyuda" runat="server" />
