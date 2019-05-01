function Logout() {
    localStorage.removeItem("username");
    window.alert("You have successfully logged out.");
    window.location.href = "/Login";
}