<div class="main-content">
    <h2>Inscription Candidat</h2>
    <form action="index.php?page=inscription" method="post" enctype="multipart/form-data">
        <label for="lastname">Nom candidat: *</label>
        <input type="text" id="lastname" name="lastname" required>
        
        <label for="firstname">Prénom candidat: *</label>
        <input type="text" id="firstname" name="firstname" required>
        
        <label for="email">Email candidat: *</label>
        <input type="email" id="email" name="email" required>
        
        <label for="password">Mot de passe: *</label>
        <input type="password" id="password" name="password" required>
        
        <label for="confirmPassword">Confirmation du mot de passe: *</label>
        <input type="password" id="confirmPassword" name="confirmPassword" required>
        
        <label for="department">Département: *</label>
        <select name="department" id="department">
            <?php
                for ($i=0 ; $i<count($tabData) ; $i++)
            {
                echo "<option value='" . $tabData[$i]["id_dep"] . "' >". $tabData[$i]["Name"] . "</option>";
            }         
        ?>
        </select>
        <label for="age">Votre âge : *</label>
        <input type="number" name="age" id="age" step="1" min="18" max="120">

        <div id="summary">Vous devez avoir plus de 18 ans pour participer au jeu concours.</div>
   
        <button type="submit">S'enregistrer</button>
    </form>

</div>