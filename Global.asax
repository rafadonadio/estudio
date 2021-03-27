<%@ Application Language="C#" %>
<%@ Import Namespace="System.Collections.Generic" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
		GetIds();
	

    }
    private void GetIds(){

		List<AddressType> addressTypes = DataAccess.AddressType_GetAll();
		foreach( AddressType addressType in addressTypes){
			if(addressType.Code.ToUpper() == "DR"){
				Application["AddressTypeRAID"] = addressType.Id;
			}
			else if (addressType.Code.ToUpper() == "DL")
			{
				Application["AddressTypeLAID"] = addressType.Id;
			}
			else if (addressType.Code.ToUpper() == "DF")
			{
				Application["AddressTypeFAID"] = addressType.Id;
			}
		}
		List<PersonType> pTypes = DataAccess.PersonType_GetAll();
		foreach (PersonType pt in pTypes) {
			if (pt.Code.ToUpper() == "PF") {
				Application["PersonaFisicaId"] = pt.Id;			
			}
		}
		
		
	}
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started
		if (User.Identity.IsAuthenticated)
			FormsAuthentication.SignOut();

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
