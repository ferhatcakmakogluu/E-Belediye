document.addEventListener("DOMContentLoaded", function () {
    const menuItems = document.querySelectorAll(".menu-item");

    menuItems.forEach((item) => {
        item.addEventListener("click", function () {
            // Eğer yalnızca bir menü açık kalmasını istiyorsanız:
            menuItems.forEach((el) => {
                if (el !== this) {
                    el.classList.remove("active");
                }
            });

            // Aktif durumu toggle et
            this.classList.toggle("active");
        });
    });
});