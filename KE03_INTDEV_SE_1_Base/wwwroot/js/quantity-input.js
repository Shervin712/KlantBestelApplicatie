document.addEventListener('DOMContentLoaded', function () {
    document.querySelectorAll('.quantity-input').forEach(function (container) {
        const input = container.querySelector('input[type="text"], input.qty-input');
        container.querySelectorAll('.btn-qty').forEach(function (btn) {
            btn.addEventListener('click', function () {
                let value = parseInt(input.value) || 1;
                if (btn.dataset.action === 'increment') {
                    value++;
                } else if (btn.dataset.action === 'decrement' && value > 1) {
                    value--;
                }
                input.value = value;
            });
        });
        input.addEventListener('input', function () {
            let value = parseInt(input.value) || 1;
            if (value < 1) value = 1;
            input.value = value;
        });
    });
});
