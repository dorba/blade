
Application = (function() {
    function Application() {
        ko.applyBindings(new ViewModel('Planet', 'Earth'));
    }
    return Application;
})();

ViewModel = (function() {
    function ViewModel(first, last) {
        this.FirstName = ko.observable(first);
        this.LastName = ko.observable(last);
        this.FullName = ko.computed(function() {
            return this.FirstName() + ' ' + this.LastName();
        }, this);
    }
    var p = ViewModel.prototype;
    p.FirstName = null;
    p.LastName = null;
    p.FullName = null;
    return ViewModel;
})();

new Application();
