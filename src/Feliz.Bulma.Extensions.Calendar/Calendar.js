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

export function attach (id, callback, optObj) {
    const options = {
        ...defaultOptions,
        ...optObj
    };
    const calendars = bulmaCalendar.attach('input[type="date"]', options);
    calendars.forEach(calendar => {
        if (calendar.element.id === id) {
            calendar.on('hide', calc => makeCall(calc, callback));
            calendar.on('select', calc => makeCall(calc, callback));
        }
    });
}