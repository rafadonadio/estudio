using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for MenuItemsConst
/// </summary>
public class MenuItemsConst
{
	public static readonly string Contribuyentes="";
	public static readonly string Reportes = "";
	public static readonly string Usuarios = "";
	public static readonly string Configuracion = "";
	public static readonly string Ayuda = "";
	public static readonly string Bullet = "<img src=\"images/topsubmenu_bullet.jpg\" width=\"6\" height=\"6\"  />";
	
	static MenuItemsConst()
	{
		Contribuyentes = Bullet;
		Contribuyentes += "<li><a href=\"../MemberPages/BuscarContribuyente.aspx?solapa=contrib\" class=\"bold\">Buscar Contribuyente</a></li><li>|</li>";
		Contribuyentes += "<li><a href=\"../MemberPages/Contribuyente.aspx?solapa=contrib&id=0\" class=\"bold\">Crear Contribuyente</a></li>";
		Contribuyentes += Bullet;


		Reportes = Bullet;
		Reportes += "<li><a href=\"../EnConstruccion.aspx?solapa=reportes\" class=\"bold\">Contrib con cierre en este mes</a></li><li>|</li>";
		Reportes += "<li><a href=\"../EnConstruccion.aspx?solapa=reportes\" class=\"bold\">Controb con vencimientos esta semana</a></li>";
		Reportes += Bullet;


		Usuarios = Bullet;
		Usuarios += "<li><a href=\"../Ingresar.aspx?solapa=usuarios\" class=\"bold\">Ingresar</a></li><li>|</li>";
		Usuarios += "<li><a href=\"../Registrarse.aspx?solapa=usuarios\" class=\"bold\">Registrarse</a></li><li>|</li>";
		Usuarios += "<li><a href=\"../MemberPages/CambiarClave.aspx?solapa=usuarios\" class=\"bold\">Cambiar Clave</a></li><li>|</li>";
		Usuarios += "<li><a href=\"../RecuperarClave.aspx?solapa=usuarios\" class=\"bold\">Recuperar Clave</a></li><li>|</li>";
		Usuarios += "<li><a href=\"../Salir.aspx?solapa=usuarios\" class=\"bold\">Salir</a></li><li>|</li>";
		Usuarios += "<li><a href=\"../EnConstruccion.aspx?solapa=usuarios\" class=\"bold\">Roles</a></li>";
		Usuarios += Bullet;

		Configuracion = Bullet;
		Configuracion += "<li><a href=\"../MemberPages/AdmPersonas.aspx?solapa=config\" class=\"bold\">Personas</a></li><li>|</li>";
		Configuracion += "<li><a href=\"../MemberPages/AdmSociedades.aspx?solapa=config\" class=\"bold\">Sociedades</a></li><li>|</li>";
		Configuracion += "<li><a href=\"../EnConstruccion.aspx?solapa=config\" class=\"bold\">Parentesco</a></li><li>|</li>";
		Configuracion += "<li><a href=\"../EnConstruccion.aspx?solapa=config\" class=\"bold\">Agencia AFIP</a></li><li>|</li>";
		Configuracion += "<li><a href=\"../EnConstruccion.aspx?solapa=config\" class=\"bold\">Actividad Agencia</a></li><li>|</li>";
		Configuracion += "<li><a href=\"../EnConstruccion.aspx?solapa=config\" class=\"bold\">Bienes</a></li><li>|</li>";
		Configuracion += "<li><a href=\"../MemberPages/AdmCodigos.aspx?solapa=config\" class=\"bold\">Códigos</a></li><li>|</li>";
		Configuracion += "<li><a href=\"../EnConstruccion.aspx?solapa=config\" class=\"bold\">Parametros</a></li>";
		Configuracion += Bullet;

		Ayuda = Bullet;
		Ayuda += "<li><a href=\"../EnConstruccion.aspx?solapa=ayuda\" class=\"bold\">Temas de ayuda</a></li>";
		Ayuda += Bullet;

	}

	
}
