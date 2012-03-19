(function() {
  var CustomerDto, HighValueCustomersViewModel, Mapping;

  Mapping = {
    'Items': {
      create: function(options) {
        return new CustomerDto(options.data);
      }
    }
  };

  CustomerDto = (function() {

    function CustomerDto(data) {
      this.self = this;
      this.CustomerID = ko.observable();
      this.Name = ko.observable();
      this.Description = ko.observable();
      this.CustomerSince = ko.observable();
      this.TotalSpent = ko.observable();
      ko.mapping.fromJS(data, _, this.self);
    }

    return CustomerDto;

  })();

  HighValueCustomersViewModel = (function() {

    function HighValueCustomersViewModel() {
      this.Items = ko.observableArray([]);
    }

    return HighValueCustomersViewModel;

  })();

  window.CustomerDto = CustomerDto;

  window.viewModel = new HighValueCustomersViewModel();

}).call(this);
