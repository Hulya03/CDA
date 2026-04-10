<!DOCTYPE html>
<html lang="fr-FR">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Calcul Prêt</title>
    <link rel="stylesheet" href="./assets/css/style.css">
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
   
</head>

<body>
    <?php
    include "./models/Pret.php";

    if ($_SERVER['REQUEST_METHOD'] == 'GET') {
        if (!empty($_GET["nom"]) && !empty($_GET["capital"]) && !empty($_GET["taux"]) && !empty($_GET["duree"])) {
            $nom = strval($_GET["nom"]);
            $capital = floatval($_GET["capital"]);
            $taux = floatval($_GET["taux"]);
            $nb = intval($_GET["duree"]);

            $objPret = new Pret($nom, $capital, $taux, $nb);
            $mensualite = $objPret->calculMensualite2();
            
            $table = $objPret->getTableauAmortissementHtml();

            $chaineJSON = $objPret->getTableauAmortissementJSON();
           // $objPret->getreportJSON();
           
        } else {
            $msg = "Veuillez remplir toutes les zones du formulaire :";
        }
    } else {
        $msg = "Veuillez utiliser le formulaire suivant :";
    }

    ?>
    <div class="wrapper">
        <form method="GET" action="<?php echo $_SERVER['PHP_SELF'] ?>">
            <fieldset>
                <legend>Simulation de Prêt</legend>
                <label for="nom">Nom emprunteur :</label>
                <input type="text" name="nom" id="nom" maxlength="30" required value="<?php echo $test = $nom ?? "";  ?>">

                <label for="capital">Capital emprunté</label>
                <input type="number" id="capital" name="capital" min="0" value="<?php echo $test = $capital ?? 0;  ?>" required>

                <label for="taux">Taux (%)</label>
                <input type="number" id="taux" name="taux" min="0" step="0.01" value="<?php echo $test = $taux ?? 0.0;  ?>" required>

                <label for="duree">Durée (années)</label>
                <input type="number" id="duree" name="duree" min="1" value="<?php echo $test = $nb ?? 0;  ?>" required>

                <button type="submit">Valider</button>

                <label for="mensualite">Mensualité</label>
                <input type="text" id="mensualite" name="mensualite" value="<?php echo $test = $mensualite ?? "0 €";  ?>" readonly>
                <button type="reset">remise à zéro</button>
                <div class="display">
                    <?php
                    if (isset($msg)) {
                        echo "<p class='message'>" . $msg . "</p>";
                    }
                    if (isset($table)) {
                        echo "<h2>Tableau d'amortissement de " . $nom . "</h2>";
                        echo $table;
                      
                    }
                    ?>
                </div>
            </fieldset>
        </form>
    </div>
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.min.js" integrity="sha384-G/EV+4j2dNv+tEPo3++6LCgdCROaejBqfUeNjuKAiuXbjrxilcCdDz6ZAVfHWe1Y" crossorigin="anonymous"></script>
</body>

</html>