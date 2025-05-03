window.getDeviceId = function () {
    // Ini adalah contoh sederhana dan mungkin tidak unik atau persisten.
    // Pertimbangkan menggunakan library fingerprinting yang lebih canggih.
    return navigator.userAgent + '-' + window.screen.width + '-' + window.screen.height;
};

window.observeElement = (elementClass, componentInstance) => {
    const options = {
        root: null,
        rootMargin: '0px',
        threshold: 1.0
    };

    const callback = (entries, observer) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                componentInstance.invokeMethodAsync('LoadMoreProducts');
            }
        });
    };

    const observer = new IntersectionObserver(callback, options);
    const target = document.querySelector(elementClass);
    observer.observe(target);
};