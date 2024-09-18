// Simple alert when clicking the contact button
document.addEventListener('DOMContentLoaded', function () {
    const contactButton = document.querySelector('.contact-btn');

    if (contactButton) {
        contactButton.addEventListener('click', function () {
            alert('You clicked the contact button!');
        });
    }
});
