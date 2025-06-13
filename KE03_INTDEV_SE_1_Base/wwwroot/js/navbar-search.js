$(function () {
    const $input = $('#navbarSearch');
    const $results = $('#navbarSearchResults');
    let xhr = null;

    $input.on('input', function () {
        const query = $(this).val().trim();
        if (query.length < 2) {
            $results.hide().empty();
            return;
        }

        if (xhr) xhr.abort();

        xhr = $.get('/Api/SearchProducts', { q: query }, function (data) {
            $results.empty();
            if (!data || data.length === 0) {
                $results.hide();
                return;
            }
            data.forEach(item => {
                $results.append(
                    `<a href="/Part/${item.id}" class="list-group-item list-group-item-action">
                        <strong>${item.name}</strong> <small class="text-muted">(${item.articleNumber})</small><br/>
                        <span class="text-secondary">${item.manufacturer}</span>
                    </a>`
                );
            });
            $results.show();
        });
    });

    // Verberg resultaten als je buiten de zoekbalk klikt
    $(document).on('click', function (e) {
        if (!$(e.target).closest('.navbar-search').length) {
            $results.hide();
        }
    });
});