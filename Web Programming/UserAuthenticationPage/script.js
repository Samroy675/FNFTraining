function Validate(name, paswrd) {
    if (name && paswrd) {
        const storedPassword = localStorage.getItem(name);
        if (storedPassword && storedPassword === paswrd) {
            document.body.innerHTML = `
                <h1>Welcome, ${name}!</h1>
                <a href="WelcomePage.html"></a>
            `;
        } else {
            alert("Invalid credentials or user not found. Please sign up first.");
        }
    } else {
        alert("Please enter both username and password.");
    }
}
