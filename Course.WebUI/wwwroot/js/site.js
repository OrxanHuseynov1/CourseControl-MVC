document.addEventListener("DOMContentLoaded", function () {
    document.querySelector(".scroll-down a").addEventListener("click", function (e) {
        e.preventDefault();
        document.querySelector("#sections").scrollIntoView({ behavior: "smooth" });
    });
});
