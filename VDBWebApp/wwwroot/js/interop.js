window.getDeviceId = function () {
    // Ini adalah contoh sederhana dan mungkin tidak unik atau persisten.
    // Pertimbangkan menggunakan library fingerprinting yang lebih canggih.
    return navigator.userAgent + '-' + window.screen.width + '-' + window.screen.height;
};