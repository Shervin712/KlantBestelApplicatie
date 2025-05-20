document.addEventListener('DOMContentLoaded', () => {
    const alphabetNav = document.getElementById('alphabetNav');
    if (!alphabetNav) return;

    const letters = ['#', ...'ABCDEFGHIJKLMNOPQRSTUVWXYZ'.split('')];

    letters.forEach(letter => {
        const link = document.createElement('a');
        link.href = `#section-${letter === '#' ? '-' : letter.toLowerCase()}`;
        link.className = 'alphabet-link';
        link.textContent = letter;
        alphabetNav.appendChild(link);
    });
});
