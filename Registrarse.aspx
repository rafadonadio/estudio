<%@ Page Language="C#" ValidateRequest="false" AutoEventWireup="true" CodeFile="Registrarse.aspx.cs" Inherits="Registrarse" %>

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
									Registrarse</h1>
							</td>
							
							<td><img src="images/l_containertitle_rightbg.jpg" alt="title" width="235" height="27" /> </td>
							<td><img src="images/l_containertitle_rightsign.jpg" alt="sign" width="26" height="27" /></td>
						</tr>
						<tr><td colspan=3>&nbsp;</td></tr>
						<tr class="allresults_container"><td colspan=3 
								class="textblock tahoma11 color_5b5b5b"></td></tr>
						<tr class="allresults_container"><td colspan=3 
								class="textblock tahoma11 color_5b5b5b">
							<asp:CreateUserWizard ID="CreateUserWizard1" runat="server" 
								ContinueDestinationPageUrl="~/Inicio.aspx" 
								CssClass="interLine" AnswerLabelText="Respuesta de serguridad:" 
								AnswerRequiredErrorMessage="Debe ingresar la pregunta de seguridad." 
								CancelButtonText="Cancelar" 
								CompleteSuccessText="El usuario ha sido creado con éxito." 
								ConfirmPasswordCompareErrorMessage="La clave y su confirmación deben ser iguales." 
								ConfirmPasswordLabelText="Confirmar clave:" 
								ConfirmPasswordRequiredErrorMessage="Debe ingresar la confirmación de la clave." 
								ContinueButtonText="Continuar" CreateUserButtonText="Crear usuario" 
								DuplicateEmailErrorMessage="Por favor ingrese un email diferente." 
								DuplicateUserNameErrorMessage="Por favor ingrese un usuario diferente." 
								EmailRegularExpressionErrorMessage="Por favor ingrese un email diferente." 
								EmailRequiredErrorMessage="Debe ingresar el email." 
								FinishCompleteButtonText="Terminar" FinishPreviousButtonText="Anterior" 
								InvalidAnswerErrorMessage="Por favor ingrese una respuesta diferente." 
								InvalidEmailErrorMessage="Por favor ingrese un email válido." 
								InvalidPasswordErrorMessage="Largo mínimo de la clave: {0}." 
								InvalidQuestionErrorMessage="Por favor ingrese una pregunta de seguridad diferente." 
								PasswordLabelText="Clave:" 
								PasswordRegularExpressionErrorMessage="Por favor ingrese una clave diferente." 
								PasswordRequiredErrorMessage="Debe ingresar la clave." 
								QuestionLabelText="Pregunta de Seguridad:" 
								QuestionRequiredErrorMessage="Debe ingresar la pregunta de seguridad." 
								StartNextButtonText="Siguiente" StepNextButtonText="Siguiente" 
								StepPreviousButtonText="Anterior" 
								UnknownErrorMessage="No se pudo crear el usuario" UserNameLabelText="Usuario:" 
								UserNameRequiredErrorMessage="Debe ingresar el usuario." 
								EmailRegularExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
								<LabelStyle HorizontalAlign="Left" />
								<WizardSteps>
									<asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server" Title="" />
									<asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server" Title="" />
								</WizardSteps>
							</asp:CreateUserWizard>
						</td></tr>
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
