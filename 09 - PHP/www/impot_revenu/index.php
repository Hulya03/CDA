<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Calcul Impôt</title>
    <link rel="stylesheet" href="assets/css/style.css">
</head>
<body>

<?php

    $message = "";
    require "./models/Contribuable.php";                                    //On va chercher la classe métier
    if (isset($_GET["envoi"])) {                                            //GET : tableau associatif de variables (=variable super Global)     // isset : Détermine si une variable est considérée définie, ceci signifie qu'elle est déclarée et est différente de null.
        if (!empty($_GET["nom"]) && !empty($_GET["revenu"]))                                                                                     // isset() renverra false lors de la vérification d'une variable de valeur null. Il est à noter que aussi que le caractère nul ("\0") n'est pas équivalent à la constante PHP null.
            {
                                                                           // protection des saisies :
                $nom = htmlspecialchars($_GET["nom"]);                     // htmlspecialchars : Convertit les caractères spéciaux en entités HTML 
                $revenu =floatval($_GET["revenu"]);                        // floatval : Convertit une chaîne en nombre à virgule flottante
                $objContribuable = new Contribuable($nom, $revenu);
                $result = $objContribuable->CalculImpot(); 
        }else{
            $message = "Veuillez remplir tous les champs";
        }
    }
?>
    <div class="container">
        <form   method="GET" action ="<?php echo $_SERVER ['PHP_SELF'] ?>" enctype="text/plain"  >       
            <fieldset>
                <legend>Calcul de l'Impôt sur le Revenu</legend>

                <label for="nom">Nom Contribuable</label>
                <input type="text" id="nom" name="nom"  value="<?php echo $nom??''; ?>">

                <label for="revenu">Revenu Annuel</label>
                <input type="number" id="revenu" name="revenu" min="0" required value="<?php echo $revenu??0 ; ?>">      <!-- Coalescent : verification si variable est nulle--> 

                <button type="submit" name="envoi" >Calculer</button>

                <label for="impot">Impôt sur le revenu annuel</label>
                <input type="text" id="impot" name="impot" readonly value= "<?php echo (isset($result))?$result:0 ; ?>" >
                    <div id="summary"> <?php echo $message ?></div>
            </fieldset>
        </form>
    </div>
</body>
</html>