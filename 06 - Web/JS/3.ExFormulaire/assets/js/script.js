const prenom = document.getElementById("prenom");
const age = document.getElementById("age");
const btnValider = document.getElementById("btnValider");
const btnVider = document.getElementById("btnVider");
const affichageResultat = document.getElementById("affichageResultat");

btnValider.addEventListener("click", afficherTxt);
btnVider.addEventListener("click", viderText);

function afficherTxt(event) {
  const ageEntier = +age.value; //operateur unair : mettre un + devant le nombre, force la valeur d'apres à etre un nombre
  if (prenom.value !== "" && Number.isInteger(ageEntier) && ageEntier > 0) {
    // Number.isInteger(valeur à vérifier) : permet de vérifier si la valeur est un entier
    affichageResultat.innerHTML = `Bonjour <span>${prenom.value}</span>, votre age est : <span>${age.value}</span>.`;
  } else {
    affichageResultat.innerHTML = "Compléter/corriger le formulaire";
  }

  if (ageEntier !== 0) {
    if (ageEntier >= 18) {
      affichageResultat.innerHTML += "<br><br>Vous êtes <span>majeur</span>.";
    } else {
      affichageResultat.innerHTML += "<br><br>Vous êtes <span>mineur</span>.";
    }

    if (ageEntier < 64) {
      affichageResultat.innerHTML += `<br><br>Il vous reste <span> ${
        64 - ageEntier
      } </span> année(s) avant la retraite`;
    } else if (ageEntier > 64) {
      affichageResultat.innerHTML += `<br><br>Vous êtes à la retraite depuis ${
        ageEntier - 64
      } année(s)`;
    } else {
      affichageResultat.innerHTML +=
        "<br><br>Vous prenez votre retraite cette année !";
    }
  }
}

function viderText(event) {
  affichageResultat.innerText = "";
}
