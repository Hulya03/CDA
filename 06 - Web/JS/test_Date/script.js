let nom = document.getElementById("nom");
let prenom = document.getElementById("prenom");
let date = document.getElementById("date");
let sub = document.getElementById("sub");
let today = new Date();
const delaiLivraison = 691200000;

let result = document.getElementById('result')

function datum() {
  let dateD = new Date(date.value);
  let diff = dateD.getTime() - today.getTime();
  if (diff > delaiLivraison) {
    console.log("commande ok");

    result.innerHTML = "delai suffisant pour commander"
  } else {
    console.log(" Date trop courte ");
    result.innerHTML = "delai insuffisant pour commander"
  }
  
}

function def(event) {
  event.preventDefault();
}

sub.addEventListener("click", def);

sub.addEventListener("click", datum);

