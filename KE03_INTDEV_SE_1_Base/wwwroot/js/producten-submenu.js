document.addEventListener('DOMContentLoaded', () => {
    document.querySelectorAll('#productenOffcanvas .menu-item.has-submenu').forEach(menuItem => {
        const submenuId = menuItem.getAttribute('data-submenu');
        const submenu = document.getElementById(submenuId);

        if (!submenu) return;

        let hideTimeout;

        function showSubmenu() {
            clearTimeout(hideTimeout);
            document.querySelectorAll('#productenOffcanvas .submenu').forEach(sm => {
                if (sm !== submenu) sm.style.display = 'none';
            });
            submenu.style.display = 'flex';
        }

        function hideSubmenu() {
            hideTimeout = setTimeout(() => {
                submenu.style.display = 'none';
            }, 200);
        }

        menuItem.addEventListener('mouseenter', showSubmenu);
        menuItem.addEventListener('mouseleave', hideSubmenu);
        submenu.addEventListener('mouseenter', () => {
            clearTimeout(hideTimeout);
            submenu.style.display = 'flex';
        });
        submenu.addEventListener('mouseleave', hideSubmenu);
    });
});
