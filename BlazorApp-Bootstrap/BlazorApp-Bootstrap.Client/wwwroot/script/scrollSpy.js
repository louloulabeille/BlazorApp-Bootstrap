window.initScrollSpy = () => {
    var el = document.querySelector('[data-bs-spy="scroll"]');
    if (!el) return;
    bootstrap.ScrollSpy.getOrCreateInstance(el);
}

window.refreshScrollSpy = () => {
    var el = document.querySelector('[data-bs-spy="scroll"]');
    var inst = bootstrap.ScrollSpy.getInstance(el);
    if (inst) inst.refresh();
}
