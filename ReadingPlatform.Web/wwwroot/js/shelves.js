const shelfBooks = document.querySelectorAll(".shelf-book");
const overlay = document.getElementById("bookDetailOverlay");
const panel = document.getElementById("bookDetailPanel");
const closeButton = document.getElementById("closeBook");

const detailTitle = document.getElementById("detailTitle");
const detailAuthor = document.getElementById("detailAuthor");
const detailFormat = document.getElementById("detailFormat");
const detailGenre = document.getElementById("detailGenre");
const detailStatus = document.getElementById("detailStatus");
const detailProgress = document.getElementById("detailProgress");
const detailRating = document.getElementById("detailRating");
const detailDescription = document.getElementById("detailDescription");
const shelfTooltip = document.createElement("div");
shelfTooltip.className = "shelf-tooltip";
document.body.appendChild(shelfTooltip);

shelfBooks.forEach(book => {
    book.addEventListener("mouseenter", () => {
        shelfTooltip.textContent = book.dataset.title;
        shelfTooltip.classList.add("active");
    });

    book.addEventListener("mousemove", event => {
        shelfTooltip.style.left = `${event.clientX + 14}px`;
        shelfTooltip.style.top = `${event.clientY + 14}px`;
    });

    book.addEventListener("mouseleave", () => {
        shelfTooltip.classList.remove("active");
    });

    book.addEventListener("click", () => {
        detailTitle.textContent = book.dataset.title;
        detailAuthor.textContent = `by ${book.dataset.author}`;
        detailFormat.textContent = book.dataset.format;
        detailGenre.textContent = book.dataset.genre;
        detailStatus.textContent = book.dataset.status;
        detailProgress.textContent = book.dataset.progress;
        detailRating.textContent = `${book.dataset.rating} š`;
        detailDescription.textContent = book.dataset.description;

        overlay.classList.add("active");
        panel.classList.remove("book-open-animation");

        requestAnimationFrame(() => {
            panel.classList.add("book-open-animation");
        });
    });
});

function closeBookDetails() {
    overlay.classList.remove("active");
    panel.classList.remove("book-open-animation");
}

closeButton.addEventListener("click", closeBookDetails);

overlay.addEventListener("click", event => {
    if (event.target === overlay) {
        closeBookDetails();
    }
});