const actualDate = document.getElementById('actualDate');
const actualTime = document.getElementById('actualTime');
const btnDisplayCurrentDay = document.getElementById('btnDisplayCurrentDate');
let result = document.getElementById('result');

btnDisplayCurrentDay.addEventListener('click', displayDate);

function displayDate() {
    let today = new Date();

    let dateFr = today.toLocaleDateString('fr-FR');
    let timeFr = today.toLocaleTimeString('fr-FR');

    result.innerHTML = `<hr>Aujourd'hui nous sommes le <span>${dateFr}</span>, l'heure courante est : <span>${timeFr}</span><hr>`;

    actualDate.value = today.toLocaleDateString('fr-CA');                // actualDate.value est en format YYYY-MM-DD, comme le format canadien. donc il récupère en reconnaissant le bon format mais affiche en format FR quand on est en France (adapte affichage au format local)
    actualTime.value = (today.toLocaleTimeString('fr-FR')).slice(0,5);   //slice(0,5) permet de récupérer une partie de la chaine de caractere. Dans ce cas les éléments de l'index 0 à 4 (on inclue pas la fin, donc le 5)



}