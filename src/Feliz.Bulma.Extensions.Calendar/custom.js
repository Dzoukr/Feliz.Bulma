import bulmaCalendar from 'bulma-calendar/src/js/index.js';
import defaultOptions from 'bulma-calendar/src/js/defaultOptions';

export function attach (id, callback) {

    const options = {
        ...defaultOptions,
        type:"datetime",
        isRange:true
    };
    
    const calendars = bulmaCalendar.attach('[type="date"]', options);
    calendars.forEach(calendar => {
        if (calendar.element.id === id) {
            calendar.on('select', calc => {
                console.log(calc);
                let d = {
                    startDate : calc.data.startDate,
                    endDate : calc.data.endDate,
                    startTime : calc.data.startTime,
                    endTime : calc.data.endTime
                };
                callback(d);
            });
        }
    });
} 