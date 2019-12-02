import bulmaCalendar from 'bulma-calendar/src/js/index.js';
import defaultOptions from 'bulma-calendar/src/js/defaultOptions';

const makeCall = function (calc, callback) {
    callback({
        startDate : calc.data.startDate,
        startTime : calc.data.startTime,
        endDate : calc.data.endDate,
        endTime : calc.data.endTime,
        mode : calc.data.options.type,
        isRange : calc.data.options.isRange
    });
};

const isAlreadyAttached = function (selector) {
    const elm = document.querySelector(selector);
    return elm.className === "is-hidden";
};

export function attach (id, callback, optObj) {
    const options = {
        ...defaultOptions,
        ...optObj
    };
    const selector = 'input[id="'+id+'"]';
    const isAttached = isAlreadyAttached(selector);
    
    if (isAttached === false) {
        const calendars = bulmaCalendar.attach(selector, options);
        calendars.forEach(calendar => {
            if (calendar.element.id === id) {
                calendar.on('hide', calc => makeCall(calc, callback));
                calendar.on('select', calc => makeCall(calc, callback));
            }
        });
    }
}