<div class="main-content">
    <h2>Connexion Candidat</h2>
    <form action="index.php?page=login" method="POST">
        <label for="email">Email candidat:</label>
        <input type="email" id="email" name="email" required>
        
        <label for="password">Mot de passe:</label>
        <input type="password" id="password" name="password" required>
        
        <div class="form-message"></div> 
        
        <button type="submit">S'authentifier</button>
    </form>
</div>