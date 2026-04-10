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
if ($_SERVER["REQUEST_METHOD"] == "GET" && !empty($_GET["nom"]) && !empty($_GET["revenu"])) {
   
    require_once 'models/Contribuable.php';

    $nom = htmlspecialchars($_GET["nom"]);
    $revenu = floatval($_GET["revenu"]);

    $contribuable = new Contribuable($nom, $revenu);
    $impot = $contribuable->calculerImpot();

    echo "<div class='result'>";
    echo "<h2>Résultat pour " . $contribuable->getNom() . "</h2>";
    echo "<p>Revenu Annuel: " . number_format($contribuable->getRevenus(), 2, ',', ' ') . " €</p>";
    echo "<p>Impôt sur le revenu annuel: " . number_format($impot, 2, ',', ' ') . " €</p>";
    echo "</div>";
}

?>
    <div class="container">
        <form>
            <fieldset>
                <legend>Calcul de l'Impôt sur le Revenu</legend>

                <label for="nom">Nom Contribuable</label>
                <input type="text" id="nom" name="nom" required   value="<?php echo $nom??'' ; ?>">

                <label for="revenu">Revenu Annuel</label>
                <input type="number" id="revenu" name="revenu" min="0" required   value="<?php echo $revenu??0;  ?>">

                <button type="submit">Calculer</button>

                <label for="impot">Impôt sur le revenu annuel</label>
                <input type="text" id="impot" name="impot" readonly  value="<?php  echo $impot??"0";  ?>" >

            </fieldset>
        </form>
    </div>
</body>
</html>