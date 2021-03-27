function SetLabelName(){
		var cboTP = document.getElementById("cboTipoPersona");
		var lbl = document.getElementById("lblNombre");
		if (cboTP.options[cboTP.selectedIndex].innerHTML== "Física")
		{
			lbl.innerHTML = "Nombre";
			EnableItems(true);
			EnableCboSocietyType(true);
		}
		else
		{
			lbl.innerHTML = "Denominación";
			EnableItems(false);
			EnableCboSocietyType(false);
		}
		
		
	}

function EnableItems(personaFisica){
	
		var itFiliatorios = document.getElementById("lnkFiliatorios");
		var itFamiliares = document.getElementById("lnkFamiliares");
		var itLegal = document.getElementById("lnkLegal");
		var itBalances= document.getElementById("lnkBalances");
		if (personaFisica)
		{
			itFiliatorios.disabled = false;
			itFamiliares.disabled = false;
			itLegal.disabled = true;
			itBalances.disabled = true;
		}
		else
		{
			itFiliatorios.disabled = true;
			itFamiliares.disabled = true;
			itLegal.disabled = false;
			itBalances.disabled = false;		
		}
}
var selectedCboSocietyTypeAux = 0;
function EnableCboSocietyType(personaFisica){
	var cboTS = document.getElementById("cboTipoSociedad");
	if(!personaFisica){
		cboTS.disabled = false;
		cboTS.selectedIndex=selectedCboSocietyTypeAux;
	}
	else{
		selectedCboSocietyTypeAux = cboTS.selectedIndex;
		cboTS.selectedIndex=0;
		cboTS.disabled = true;
	}
		
}


function EnableControlsInSearch(){
		var cboTP = document.getElementById("cboTipoPersona");
		if (cboTP.options[cboTP.selectedIndex].innerHTML== "Física")
		{
			EnableCboSocietyType(true);
		}
		else
		{
			EnableCboSocietyType(false);
		}
}