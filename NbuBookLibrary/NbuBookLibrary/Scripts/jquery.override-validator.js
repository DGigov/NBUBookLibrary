jQuery(function ($) {
    //$.validator.addMethod('date',
    //function (value, element) {
    //    if (this.optional(element)) {
    //        return true;
    //    }

    //    var ok = moment(value, 'DD.MM.YYYY', true).isValid();

    //    if (!ok) {
    //        ok = moment(value, 'DD.MM.YYYY HH:mm', true).isValid();
    //    }

    //    if (!ok) {
    //        ok = moment(value, 'DD.MM.YYYY HH:mm:ss', true).isValid();
    //    }

    //    if (!ok) {
    //        ok = moment(value, 'MM.YYYY', true).isValid();
    //    }
        
    //    return ok;
    //});

    $.validator.addMethod('number', function (value, element) {
        return this.optional(element) || /^-?(?:\d+)(?:(\.|,)\d+)?$/.test(value);
    });
});