let tabData=[];




function fillList(_tabData)
{ 
 tabData= _tabData;

    for (let i = 0; i < tabData.length; i++) {
       
       const myOption = document.createElement("option");
       myOption.value=tabData[i].codePostal;
     myOption.textContent= tabData[i].codePostal+"-"+tabData[i].nomCommune;
     document.querySelector("#cp").appendChild(myOption);   
        
    }





}
const btnRecherche= document.getElementById("btncp");
btnRecherche.addEventListener("click",function(){
let maSelection = document.querySelector("#zipcode").value;
objCommune= tabData.find(item=>item.codePostal== maSelection );
console.log(objCommune);
alert(objCommune.nomCommune);
let myItem=document.createElement("li");
myItem.textContent=objCommune.nomCommune;

document.querySelector("#listcity").appendChild(myItem);

})

fetch("https://arfp.github.io/tp/web/javascript/02-zipcodes/zipcodes.json")
.then(response=>response.json())
.then((data)=>{console.log(data);  

fillList(data);

} )
.catch(console.error());
