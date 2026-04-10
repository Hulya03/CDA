const credits = document.getElementById('credits');
const username = document.getElementById('username');
const password1 = document.getElementById('password1');
const password2 = document.getElementById('password2');
const next = document.getElementById('next');
const validate = document.getElementById('validate');
const result = document.getElementById('result');

credits.innerHTML = "Hülya CETIN";

validate.addEventListener('click', controlBeforeValidation);
validate.addEventListener('click',colorChange);


function controlBeforeValidation(event) {
    event.preventDefault();

    result.innerHTML = "";

    if (username.value.length < 3) {
        result.innerHTML= `Le nom d'utilisateur est trop court (3 caractères minimum)`;
    }

    if ((password1.value.length || password2.value.length) < 12 ){
        result.innerHTML += `<br>Le mot de passe est trop court (12 caractères minimum)`;
    }

    if (password1.value != password2.value){
        result.innerHTML += `<br>Les mots de passse ne correspondent pas`;
    }
}

function colorChange() {
    if (
        username.value.length > 3 &&
        ((password1.value.length || password2.value.length) > 12) &&
        password1.value == password2.value
    ) {

        result.innerHTML += "Le formulaire est valide !"
        document.body.style.backgroundColor = "green";
    }
}