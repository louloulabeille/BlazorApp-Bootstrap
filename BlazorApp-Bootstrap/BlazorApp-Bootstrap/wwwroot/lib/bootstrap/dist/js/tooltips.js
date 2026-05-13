const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]')
const tooltipList = [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl))


// - donner le focus sur le bouton btn-Modal-Close

const myModal = document.getElementById('exampleModal')
const myInput = document.getElementById('btn-Modal-Close')

myModal.addEventListener('shown.bs.modal', () => {
    myInput.focus()
})
