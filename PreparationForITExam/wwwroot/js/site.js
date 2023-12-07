// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function SelectSchools(cityValue)
{ 
    let select = document.querySelector("#city");

    select.addEventListener("change", (e) => {
        console.log("just got it");
    let opt = e.currentTarget.querySelector("option:selected");
    cityValue = opt.value;
    });
}