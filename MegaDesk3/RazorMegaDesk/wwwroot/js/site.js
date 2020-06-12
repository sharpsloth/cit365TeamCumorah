// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function openNav() {
    document.getElementById("mySidenav").style.width = "100%";
}

/* Close/hide the sidenav */
function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
}

function onChangeDesktopMaterial() {
    var selectedMaterialElement = document.getElementById("desktopMaterialSelect");
    var selectedMaterial = selectedMaterialElement.options[selectedMaterialElement.selectedIndex].text;
    // console.log(selectedMaterial)
    switch (selectedMaterial) {
        case "Oak":
            document.getElementById("dynamic-image").src = "/images/oak.jpg";
            break;
        case "Laminate":
            document.getElementById("dynamic-image").src = "/images/laminate.jpg";
            break;
        case "Pine":
            document.getElementById("dynamic-image").src = "/images/pine.jpg";
            break;
        case "Rosewood":
            document.getElementById("dynamic-image").src = "/images/rosewood.jpg";
            break;
        case "Veneer":
            document.getElementById("dynamic-image").src = "/images/veneer.jpg";
            break;
    }
}