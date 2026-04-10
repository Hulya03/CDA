<div class="login-container">
        <form class="login-form" method="POST" action="index.php?page=login">
            <h2>Connexion</h2>
            
            <div class="form-group">
                <label for="identifiant">Identifiant</label>
                <input type="text" id="identifiant" name="identifiant" required>
            </div>
            
            <div class="form-group">
                <label for="motdepasse">Mot de passe</label>
                <input type="password" id="motdepasse" name="motdepasse" required>
            </div>
            
            <button type="submit">Se connecter</button>
        </form>
    </div>