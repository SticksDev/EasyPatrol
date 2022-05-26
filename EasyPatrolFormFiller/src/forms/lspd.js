const puppeteer = require('puppeteer');

async function fill(config) {
    // Create a new puppeteer browser
    const browser = await puppeteer.launch({
        headless: false,
        args: ['--start-maximized']
    });

    // Load the LSPD form
    const page = await browser.newPage();
    await page.goto('https://docs.google.com/forms/d/e/1FAIpQLSe-C26eG0eMZXtr33hmpTC0bBChBiL2h-XPZ775Y0uIn24yNA/viewform');

    // Name and Unit No
    await page.waitForSelector('.Qr7Oae:nth-child(1) > .XkWAb > .geS5n > .AgroKb > .rFrNMe > .aCsJod > .aXBtI > .Xb9hP > .whsOnd')
    await page.click('.Qr7Oae:nth-child(1) > .XkWAb > .geS5n > .AgroKb > .rFrNMe > .aCsJod > .aXBtI > .Xb9hP > .whsOnd')
    await page.keyboard.type(config.dojIdent);

    // Web ID
    await page.waitForSelector('.Qr7Oae:nth-child(2) > .XkWAb > .geS5n > .AgroKb > .rFrNMe > .aCsJod > .aXBtI > .Xb9hP > .whsOnd')
    await page.click('.Qr7Oae:nth-child(2) > .XkWAb > .geS5n > .AgroKb > .rFrNMe > .aCsJod > .aXBtI > .Xb9hP > .whsOnd')
    await page.keyboard.type(config.webID);

    // Month of Patrol + Day + Year
    await page.type('input[jsname=YPqjbf]', config.monthOfPatrol);

    // Time of Patrol
    await page.waitForSelector('.Qr7Oae:nth-child(3) > .XkWAb:nth-child(1) > .geS5n:nth-child(1) .A6uyJd:nth-child(1) > .qk62ef:nth-child(2) > .JUorw:nth-child(1) > .ocBCTb:nth-child(1) > .vEXS5c:nth-child(1) > .rFrNMe:nth-child(2) .whsOnd:nth-child(1)')
    await page.click('.Qr7Oae:nth-child(3) > .XkWAb:nth-child(1) > .geS5n:nth-child(1) .A6uyJd:nth-child(1) > .qk62ef:nth-child(2) > .JUorw:nth-child(1) > .ocBCTb:nth-child(1) > .vEXS5c:nth-child(1) > .rFrNMe:nth-child(2) .whsOnd:nth-child(1)')
    await page.keyboard.type(config.timeStart, {delay: 100});

    // Year of Patrol
    await page.waitForSelector('.Qr7Oae:nth-child(3) > .XkWAb:nth-child(1) > .geS5n:nth-child(1) > div:nth-child(2) > .A6uyJd:nth-child(1) > .qk62ef:nth-child(2) > .JUorw:nth-child(1) > .ocBCTb:nth-child(1) > .jgvuAb:nth-child(4) .MocG8c:nth-child(1)')
    await page.click('.Qr7Oae:nth-child(3) > .XkWAb:nth-child(1) > .geS5n:nth-child(1) > div:nth-child(2) > .A6uyJd:nth-child(1) > .qk62ef:nth-child(2) > .JUorw:nth-child(1) > .ocBCTb:nth-child(1) > .jgvuAb:nth-child(4) .MocG8c:nth-child(1)')

    // Current year
    await page.keyboard.type(Date.now().toString().substring(0, 4));
}

// Export the fill function
module.exports = { fill };