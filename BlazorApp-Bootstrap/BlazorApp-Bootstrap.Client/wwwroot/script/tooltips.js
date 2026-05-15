window.initTooltips = () => {
    var tlist = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
    tlist.forEach(function (el) {
        bootstrap.Tooltip.getOrCreateInstance(el);

    })
}