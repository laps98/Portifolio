$(function () {
    var items = document.querySelectorAll('.carousel .carousel-item');

    items.forEach((e) => {
        const slide = 4;
        let next = e.nextElementSibling;
        for (var i = 0; i < slide; i++) {
            if (!next) {
                next = items[0]
            }
            let clonechild = next.cloneNode(true)
            e.appendChild(clonechild.children[0])
            next = next.nextElementSibling
        }
    })
})