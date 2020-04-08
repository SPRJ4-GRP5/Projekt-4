// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const detailView = document.querySelector('.detail');
const detailTitle = document.querySelector('.detail-title');
const masterItems = document.querySelectorAll('.master-item');

function select(selected) {
    for (var item of masterItems) {
        item.classList.remove('active-item');
    }
    selected.classList.add('active-item');
    detailTitle.innerHTML = selected.innerHTML;

}


//masterItems.forEach((item) => {
//    item.addEventListener('click', function () {
//        console.log('Clicked item');
//        for (let item of masterItems) {
//            item.classList.remove('active-item');
//        }

//        this.classList.add('active-item');
//        detailTitle.innerHTML = this.innerHTML;
//    });
//});