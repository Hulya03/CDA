<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Calcul Prêt</title>
    <link rel="stylesheet" href="assets/css/style.css">
</head>
<body>

<?php


?>
    <div class="container">
        <form>
            <fieldset>
                <legend>Calcul de prêt</legend>

                <label for="nom">Nom emprunteur :</label>
                <input type="text" name="nom" id="nom" maxlength="30" required>

                <label for="capital">Capital emprunté</label>
                <input type="number" id="capital" name="capital" required>

                <label for="taux">Taux intérêt en % : </label>
                <input type="number" id="taux" name="taux" min="0" required>

                <label for="duree_remb">Durée de remboursement en nb d'année: </label>
                <input type="number" id="duree_remb" name="duree_remb" min="0" required>

                <button type="submit">Calculer</button>

                <label for="mensualite">Mensualité : </label>
                <input type="number" id="mensualite" name="mensualite" readonly>

            </fieldset>
        </form>
    </div>
</body>
</html>