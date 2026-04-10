const people = [
    'Mike Dev', 
    'John Makenzie', 
    'Léa Grande'
];
let unorderedList = document.getElementById('unorderedList');


// for (let i=0; i < people.length; i++) {
//     unorderedList.innerHTML += '<li>' +people[i]+ '</li>';
// }



for (let i = 0; i < people.length; i++) {
    let li = document.createElement("li");
    li.textContent = people[i]
    unorderedList.append(li);       // permet d'ajouter le contenu de li dans unorderedList (si on fait avec html, ca beug car c'est un objet)
    console.log(people[i]);
}


function generateTable() {

    
}


