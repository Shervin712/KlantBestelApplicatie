$(function () {
    $('#sort').on('change', function () {
        const sortBy = $(this).val();
        const $list = $('#partsList');
        // Selecteer altijd opnieuw de actuele .product-card elementen
        const $cards = $list.children('.product-card').toArray();

        if (sortBy === 'Prijs laag-hoog') {
            $cards.sort((a, b) => parseFloat($(a).data('price')) - parseFloat($(b).data('price')));
        } else if (sortBy === 'Prijs hoog-laag') {
            $cards.sort((a, b) => parseFloat($(b).data('price')) - parseFloat($(a).data('price')));
        } else if (sortBy === 'Voorraad') {
            $cards.sort((a, b) => parseInt($(b).data('stock')) - parseInt($(a).data('stock')));
        }
        // Relevantie = originele volgorde, dus niet sorteren

        $list.empty().append($cards);
    });
});