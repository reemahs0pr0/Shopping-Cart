﻿window.onload = function () {
    //create list of all 'Add To Cart' button
    let elemList = document.getElementsByClassName("add-to-cart");

    //check each button for onclick event
    for (let i = 0; i < elemList.length; i++) {
        elemList[i].addEventListener("click", onAddToCart);
    }

    //create list of all 'Wish' icon
    let wish_list = document.getElementsByClassName("wish_icon");

    //check each icon for onclick event
    for (let i = 0; i < wish_list.length; i++) {
        wish_list[i].addEventListener("click", onWish);
    }

    let elem = document.getElementById("logout");
    elem.onclick = function() {
        if (confirm("Confirm logout?")) {
            return true;
        }
        return false;
    }
}

function onAddToCart(event) {
    //get product id for added item
    let elem = event.currentTarget;
    let productId = elem.getAttribute("id");

    let button = document.getElementById("clickme")
    let cartValue = button.getAttribute("value");
    let cart = cartValue.split(" ");
    let count = parseInt(cart[1]) + 1;
    button.value = "Cart: " + count;

    //send AJAX request to server to remove record from database
    let xhr = new XMLHttpRequest();

    //send to action method to receive AJAX call
    xhr.open("POST", "/Cart/AddItem");
    xhr.setRequestHeader("Content-Type", "application/json; charset=utf8");
    xhr.onreadystatechange = function () {
        if (this.readyState === XMLHttpRequest.DONE) {
            if (this.status == 200) {
                let data = JSON.parse(this.responseText);
                console.log("Successful operation: " + data.success);
            }
        }
    };
    //send product id to controller as identifier
    xhr.send(JSON.stringify({
        Id: productId,
    }));
}

function onWish(event) {
    let elem = event.currentTarget;
    let productId = elem.getAttribute("wish_id");

    if (elem.getAttribute("src") === "/img/hearts_black.png") {
        elem.setAttribute("src", "/img/hearts_color.png");
        onAddWish(productId);
    }
    else {
        elem.setAttribute("src", "/img/hearts_black.png");
        onRemoveWish(productId);
    }
}


function onAddWish(productId) {
    //send AJAX request to add record to database
    let xhr = new XMLHttpRequest();

    //send to action method to receive AJAX call
    xhr.open("POST", "/Wish/AddToWishList");
    xhr.setRequestHeader("Content-Type", "application/json; charset=utf8");
    xhr.onreadystatechange = function () {
        if (this.readyState === XMLHttpRequest.DONE) {
            if (this.status == 200) {
                let data = JSON.parse(this.responseText);
                console.log("Successful operation: " + data.success);
            }
        }
    };
    xhr.send(JSON.stringify({
        Id: productId,
    }));

}

function onRemoveWish(productId) {
    //send AJAX request to remove record from database
    let xhr = new XMLHttpRequest();

    //send to action method to receive AJAX call
    xhr.open("POST", "/Wish/RemoveFromWishList");
    xhr.setRequestHeader("Content-Type", "application/json; charset=utf8");
    xhr.onreadystatechange = function () {
        if (this.readyState === XMLHttpRequest.DONE) {
            if (this.status == 200) {
                let data = JSON.parse(this.responseText);
                console.log("Successful operation: " + data.success);
            }
        }
    };
    xhr.send(JSON.stringify({
        Id: productId,
    }));
}