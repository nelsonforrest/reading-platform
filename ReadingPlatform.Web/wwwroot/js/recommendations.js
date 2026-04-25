const cards = document.querySelectorAll(".recommendation-card:not(.end-card)");
const endCard = document.querySelector(".end-card");
const page = document.getElementById("bookPage");
const likeButton = document.getElementById("likeBook");
const skipButton = document.getElementById("skipBook");

let currentIndex = 0;
let animating = false;

function showCard(index) {
    cards.forEach(card => card.classList.remove("active"));

    if (cards[index]) {
        cards[index].classList.add("active");
    } else {
        endCard.classList.add("active");
        likeButton.disabled = true;
        skipButton.disabled = true;
    }
}

function nextBook(animationClass) {
    if (animating) return;

    animating = true;
    page.classList.add(animationClass);

    setTimeout(() => {
        page.classList.remove(animationClass);
        currentIndex++;
        showCard(currentIndex);
        animating = false;
    }, 800);
}

likeButton.addEventListener("click", () => {
    nextBook("page-turn");
});

skipButton.addEventListener("click", () => {
    nextBook("page-rip");
});

showCard(currentIndex);