let today;
const myDate = document.getElementById('myDate');
const calculate = document.getElementById('calculate');
const result = document.getElementById('result');

/**
 * Calcule l'age à partir de la date fournie dans le champ "myDate"
 * 1. Récupérer la valeur dans le champ "myDate"
 * 2. Vérifier la validité de la date (format, date dans le passé)
 *      2.1 : Si la date est incorrecte : afficher le message d'erreur
 *      2.2 : Retour à l'étape 1
 * 3. Afficher la date au format français (DD/MM/YYYY) et l'heure au format (HH:II:SS).
 * 4. Calculer et afficher l'âge à partir de la date fournie.
 * 
 */
function calculateAge() {
    result.textContent = ""; 
    let userDate = myDate.value; // Récupère la valeur du champ sous forme de chaine de caractères
    userDate = Date.parse(userDate); // Convertit la chaine et nombre de millisecondes depuis EPOCH
    userDate = new Date(userDate); // Crée une instance de Date 
    today = new Date(); // date d'aujourd'hui

    if(userDate > today) {
        result.textContent = "ERREUR : Sélectionnez une date dans le passé.";
        return;
    }

    let dateFr = userDate.toLocaleDateString('fr-FR'); //Affichage date eu fromat francais
    let timeFr = userDate.toLocaleTimeString('fr-FR'); // Affichage temps en hh:mm:ss

    result.innerHTML = `Vous êtes né le <span> ${dateFr}</span> à <span>${timeFr}</span>.<br><hr><br>`;

    let diff = today - userDate;  // différenc en millisecondes
    diff = Math.floor(diff/1000/60/60/24/364.25); // Math.floor garde la partie entière ; /1000 pour avoir secondes, /60 pour avoir minutes, /60 pour avoir heures, /24 pour avoir jour, /365.25 pour avoir année   

    result.innerHTML += `Il s'est écoulé <span>${diff}</span> années depuis votre naissance.<br><hr><br>`

    let month = userDate.getMonth() + 1; // récupère le mois dans une date     !! Il faut ajouter 1 car commence à zéro
    let day = userDate.getDate();    // récupère le jour dans une DATE     !!ATTENTION : getDay() donne une valeur entre 0 et 6 pour le jour de la semaine (lundi,mardi..)


    if ((day>= 20 && month==1) || (day <= 18 && month ==2)){
        result.innerHTML += `Votre signe astrologique : <span>Verseau</span>`;
    }else if ((day>= 19 && month==2) || (day <= 20 && month ==3)){
        result.innerHTML += `Votre signe astrologique : <span>Poisson</span>`;
    }else if((day>= 21 && month==3) || (day <= 19 && month ==4)){
        result.innerHTML += `Votre signe astrologique : <span>Bélier</span>`;
    }else if ((day>= 20 && month==4) || (day <= 20 && month ==5)){
        result.innerHTML += `Votre signe astrologique : <span>Taureau</span>`;
    }else if ((day>= 21 && month==5) || (day <= 20 && month ==6)){
        result.innerHTML += `Votre signe astrologique : <span>Gémeaux</span>`;
    }else if ((day>= 21 && month==6) || (day <= 22 && month ==7)){
        result.innerHTML += `Votre signe astrologique : <span>Cancer</span>`;
    }else if ((day>= 23 && month==7) || (day <= 22 && month ==8)){
        result.innerHTML += `Votre signe astrologique : <span>Lion</span>`;
    }else if ((day>= 23 && month==8) || (day <= 22 && month ==9)){
        result.innerHTML += `Votre signe astrologique : <span>Vierge</span>`;
    }else if ((day>= 23 && month==9) || (day <= 22 && month ==10)){
        result.innerHTML += `Votre signe astrologique : <span>Balance</span>`;
    }else if ((day>= 23 && month==10) || (day <= 21 && month ==11)){
        result.innerHTML += `Votre signe astrologique : <span>Scorpion</span>`;
    }else if((day>= 22 && month==11) || (day <= 21 && month ==12)){
        result.innerHTML += `Votre signe astrologique : <span>Sagitaire</span>`;
    }else {
        result.innerHTML += `Votre signe astrologique : <span>Capricorne</span>`;
    }

}

calculate.addEventListener('click', calculateAge);

