Blade = (function () {
    // create class with prototypal inheritance
    function derive(target, base) {
        function x() { this.constructor = target; }
        x.prototype = base.prototype;
        target.prototype = new x;
    }

    // set type contracts
    function impl(target /* parms */) {
        target.prototype.__contracts = [];
        for (var i = 1; i < arguments.length; i++) {
            target.prototype.__contracts[i - 1] = arguments[i];
        }
    }

    // is target assignable to type
    function is(target, type) {
        if (typeof type == 'function')
            return target instanceof type;
        else if (typeof type == 'string' && target.__contracts) {
            var c = target.__contracts;
            for (var i = 0; i < c.length; i++) {
                if (c[i] == type) return true;
            }
        }
        return false;
    }

    // nullable cast
    function as(target, type) {
        return is(target, type) ? target : null;
    }

    // array enumerator
    function Enum(array) {
        this.a = array;
        this.i = -1;
    }
    Enum.prototype = {
        MoveNext: function () {
            this.i++;
            return (this.i < this.a.length);
        },
        get_Current: function () {
            return this.a[this.i];
        },
        Reset: function () {
            this.i = -1;
        }
    };

    // event list
    function Event() {
        this.a = [];
    }
    Event.prototype = {
        add: function (func, ctx) {
            this.a.push([func, ctx]);
        },
        rem: function (func) {
            for (var i = 0; i < this.a.length; i++) {
                if (this.a[i][0] == func) {
                    this.a.splice(i, 1);
                    break;
                }
            }
        },
        pub: function () {
            for (var i = 0; i < this.a.length; i++) {
                this.a[i][0].apply(this.a[i][1], arguments);
            }
        }
    };

    return {
        derive: derive,
        impl: impl,
        is: is,
        as: as,
        Enum: Enum,
        Event: Event
    };
})();

// extend array prototype for enumerable
Array.prototype.GetEnumerator = function () {
    return new Blade.Enum(this);
};