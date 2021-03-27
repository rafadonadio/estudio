<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Categoria.ascx.cs" Inherits="Categoria" %>
<script>

</script>
<table cellpadding="0" cellspacing="0" border="0">
	<tr class="leftmenu_titlecornered">
		<td>
			<img src="Images/leftmenu_leftcorner.jpg" alt="" width="30" height="41" />
		</td>
		<td>
			<h1 class="tahoma12 color_dfe9f0 bold">
				<asp:Label ID="lblTitle" runat="server"></asp:Label></h1>
		</td>
		<td>
			<img src="Images/leftmenu_rightcorner.jpg" alt="" width="12" height="41" />
		</td>
	</tr>
	<tr class="leftmenu_categories_container">
		<td colspan="3">
			<ul class="leftmenu_list" runat="server" id="ulItems">
			</ul>
		</td>
	</tr>
</table>
