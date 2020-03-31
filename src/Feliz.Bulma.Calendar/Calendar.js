import bulmaCalendar from 'bulma-calendar/dist/js/bulma-calendar';
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

const timers = [];

const makeThrottledCall = function (delay, calc, callback) {
    if (timers[calc._id]) {
        return
    }
    timers[calc._id] = setTimeout(function () {
        makeCall(calc, callback);
        timers[calc._id] = undefined;
    }, delay)
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
    
    function fixPrefilledDateTime (calendar) {
        
        if (options.startDate != null) {
            const hours = options.startDate.getHours();
            const minutes = options.startDate.getMinutes();
            // set value
            if (calendar.timePicker._time.start != null) {
                calendar.timePicker._time.start = options.startDate;
            }
            // set ui
            if (calendar.timePicker._ui.start.hours.number != null && calendar.timePicker._ui.start.minutes.number != null) {
                calendar.timePicker._ui.start.hours.number.innerHTML = hours;
                calendar.timePicker._ui.start.minutes.number.innerHTML = minutes;
            }
        }
        
        if (options.endDate != null) {
            const hours = options.endDate.getHours();
            const minutes = options.endDate.getMinutes();
            // set value
            if (calendar.timePicker._time.end != null) {
                calendar.timePicker._time.end = options.endDate;
            }
            // set ui
            if (calendar.timePicker._ui.end.hours.number != null && calendar.timePicker._ui.end.minutes.number != null) {
                calendar.timePicker._ui.end.hours.number.innerHTML = hours;
                calendar.timePicker._ui.end.minutes.number.innerHTML = minutes;
            }
        }
        calendar.refresh();
    }
    
    function triggerOnTimeChange(element) {
        const searchRoot = element.element.parentElement.parentElement.parentElement;
        const timepickers = searchRoot.querySelectorAll('.timepicker-next,.timepicker-previous');
        timepickers.forEach(tp => {
            tp.addEventListener('click', ign => element.emit('select',element));
        });
    }
    
    function refreshHandlers(element) {
        element.removeListeners('hide');
        element.removeListeners('select');
        element.on('hide', calc => makeThrottledCall(10, calc, callback));
        element.on('select', calc => makeThrottledCall(10, calc, callback));
    }
    
    if (isAttached === false) {
        const calendars = bulmaCalendar.attach(selector, options);
        calendars.forEach(calendar => {
            if (calendar.element.id === id) {
                refreshHandlers(calendar);
                fixPrefilledDateTime(calendar);
                
                if(options.expTriggerOnTimeChange === true) {
                    triggerOnTimeChange(calendar);
                }
            }
        });
    } else {
        const element = document.querySelector(selector);
        if (element) {
            refreshHandlers(element.bulmaCalendar);
        }
    }
}