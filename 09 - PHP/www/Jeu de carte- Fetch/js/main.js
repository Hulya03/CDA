// fetch("https://arfp.github.io/tp/web/javascript/03-cardgame/cardgame.json")
// .then(response => response.json())
// .then(response => alert(JSON.stringify(response)))
// .catch(error => alert("Erreur : " + error));




function insertTitleCell(row, value){                    //ajout de cellule dans une ligne 
    myCell = document.createElement("th");
    myCell.textContent = value;                          //textContent = ajout de contenu entre balise ouvrante et fermante    => création de la valeur
    //myCell.setAttribute("class", "titre");             //pour faire du css 
    row.appendChild(myCell);                             // ajout de cellule dans row
}



function afficherCarte(tabCartes){                      // tabCartes = tableau d'objets litéraux = objet défini par attribut et valeur (pas de constructeur ni de méthode)

    const myTable = document.querySelector("#jeu");
    const myThead = myTable.createTHead();           // création du thead avec une fonction
    const myTitleRow = myThead.insertRow();          // ajout d'une ligne (= ajout tr dans thead)


    for(let key in tabCartes[0]){
        insertTitleCell(myTitleRow, key);
    }
        // autre facon de Récupérer les clés du premier objet carte
        //Object.keys(tabCartes[0]).forEach(key => {
        //insertTitleCell(myTitleRow, key);
        //});


    const myTbody = myTable.createTBody();

    for (let i = 0; i < tabCartes.length; i++) {

        const myCurrentRow = myTbody.insertRow();

        for (const key in tabCartes[i]){

           const currentCell = myCurrentRow.insertCell();
           currentCell.textContent = tabCartes[i][key];
        }
        
    }

        
};


fetch("https://arfp.github.io/tp/web/javascript/03-cardgame/cardgame.json")
.then(response => response.json())
.then((response) => {
    //console.log(response)   //pour etre sur qu'on l'a bien chargé

    afficherCarte(response);
});