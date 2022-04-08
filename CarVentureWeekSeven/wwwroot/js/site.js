// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
// Write your JavaScript code.
const signUpButton = document.getElementById('signUp');
const signInButton = document.getElementById('signIn');
const container = document.getElementById('container');

signUpButton.addEventListener('click', () => {
    container.classList.add("right-panel-active");
});

signInButton.addEventListener('click', () => {
    container.classList.remove("right-panel-active");
});

document.getElementById("more").addEventListener("click", (e) => {
    document.querySelector(".nav-bar2").style.display = "block";
    document.getElementById("nav-link-wrapper").style.display = "flex";
    document.getElementById("more").style.display = "none";
    document.getElementById("nav-link-wrapper").style.flexDirection = "column";
})