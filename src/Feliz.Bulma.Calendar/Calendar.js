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
    const useLiveUpdate = options.expLiveUpdate === true;
    const triggerOnTimeChange = options.expTriggerOnTimeChange === true;
    
    function setDate (calendar, startDate, endDate) {
        
        function fixNumbers (n) {
            return ("0" + n).slice(-2);
        }
        
        if (startDate != null) {
            const hours = fixNumbers(startDate.getHours());
            const minutes = fixNumbers(startDate.getMinutes());
            // set value
            if (calendar.datePicker._date.start != null) {
                calendar.datePicker._date.start = startDate;
            }
            if (calendar.timePicker._time.start != null) {
                calendar.timePicker._time.start = startDate;
            }
            // set ui
            if (calendar.timePicker._ui.start.hours.number != null && calendar.timePicker._ui.start.minutes.number != null) {
                calendar.timePicker._ui.start.hours.number.innerHTML = hours;
                calendar.timePicker._ui.start.minutes.number.innerHTML = minutes;
            }
        }
        
        if (endDate != null) {
            const hours = fixNumbers(endDate.getHours());
            const minutes = fixNumbers(endDate.getMinutes());
            // set value
            if (calendar.datePicker._date.end != null) {
                calendar.datePicker._date.end = endDate;
            }
            if (calendar.timePicker._time.end != null) {
                calendar.timePicker._time.end = endDate;
            }
            // set ui
            if (calendar.timePicker._ui.end.hours.number != null && calendar.timePicker._ui.end.minutes.number != null) {
                calendar.timePicker._ui.end.hours.number.innerHTML = hours;
                calendar.timePicker._ui.end.minutes.number.innerHTML = minutes;
            }
        }
        calendar.refresh();
    }
    
    function addOnTimeChangeTriggers(element) {
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
        element.on('clear', calc => makeThrottledCall(10, calc, callback));
    }
    
    if (isAttached === false) {
        const calendars = bulmaCalendar.attach(selector, options);
        calendars.forEach(calendar => {
            if (calendar.element.id === id) {
                refreshHandlers(calendar);
                
                setDate(calendar, options.startDate, options.endDate);
                
                if(triggerOnTimeChange) {
                    addOnTimeChangeTriggers(calendar);
                }
            }
        });
    } else {
        const element = document.querySelector(selector);
        if (element) {
            refreshHandlers(element.bulmaCalendar);
            if (useLiveUpdate) {
                setDate(element.bulmaCalendar, options.startDate, options.endDate);
            }
        }
    }
}