window.getDeviceId = function () {
    // Ini adalah contoh sederhana dan mungkin tidak unik atau persisten.
    // Pertimbangkan menggunakan library fingerprinting yang lebih canggih.
    return navigator.userAgent + '-' + window.screen.width + '-' + window.screen.height;
};

window.observeElement = (elementId, dotNetHelper) => {
    const target = document.querySelector(elementId);
    if (!target) return;

    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                dotNetHelper.invokeMethodAsync('LoadMoreProducts');
            }
        });
    }, {
        root: null,
        rootMargin: '0px',
        threshold: 1.0
    });

    observer.observe(target);
};

window.registerClickOutside = (elementId, dotnetHelper, methodName) => {
    document.addEventListener('click', function (event) {
        const target = document.getElementById(elementId);
        if (target && !target.contains(event.target)) {
            dotnetHelper.invokeMethodAsync(methodName);
        }
    });
};

window.triggerClick = (element) => {
        element.click();
};

window.scrollToTop = () => {
    window.scrollTo({ top: 0, behavior: 'smooth' });
};

window.scrollToTopModal = (element) => {
    if (element) {
        element.scrollTop = 0;
    }
};

window.readFileAsHex = (input, dotNetHelper) => {
    const file = input.files[0];
    if (!file) return;

    const reader = new FileReader();
    reader.onload = function () {
        const arrayBuffer = reader.result;
        const bytes = new Uint8Array(arrayBuffer);
        let hex = '0x';
        for (let b of bytes) {
            hex += b.toString(16).padStart(2, '0');
        }
        dotNetHelper.invokeMethodAsync('ReceiveHexFromJs', hex);
    };
    reader.readAsArrayBuffer(file);
};

window.readFileAsHexAndBase64 = (input, dotNetHelper) => {
    const file = input.files[0];
    if (!file) return;

    const reader = new FileReader();
    reader.onload = function () {
        const arrayBuffer = reader.result;
        const bytes = new Uint8Array(arrayBuffer);

        // Convert to Hex
        let hex = '0x';
        for (let b of bytes) {
            hex += b.toString(16).padStart(2, '0');
        }

        // Convert to Base64
        const base64 = btoa(String.fromCharCode(...bytes));

        // Send both to .NET
        dotNetHelper.invokeMethodAsync('ReceiveHexAndBase64FromJs', hex, base64);
    };
    reader.readAsArrayBuffer(file);
};

window.downloadBase64File = (base64, fileName) => {
    const link = document.createElement('a');
    link.href = `data:application/pdf;base64,${base64}`;
    link.download = fileName;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
};

window.autoClickCarouselNextProdHome = function () {
    setInterval(() => {
        const btn = document.getElementById("autoNextBtn");
        if (btn) {
            btn.click();
        }
    }, 4000);
};