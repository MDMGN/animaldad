document.addEventListener('DOMContentLoaded',()=>{
    //Agregar la clase active
    const $nav = document.querySelector(".nav-tabs");
    const listItems = $nav.querySelectorAll("li");
    console.log(location.href.split("/"))
    listItems.forEach(function (listItem) {
        const currentURL = location.href.split("/")[3];
        const target = currentURL.toLowerCase()
        if (target==listItem.id)  listItem.className = "active"
    });
});
