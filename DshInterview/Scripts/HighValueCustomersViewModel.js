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
      this.CustomerName = ko.observable();
      this.Description = ko.observable();
      this.CustomerSince = ko.observable();
      this.TotalSpent = ko.observable();
      if (data != null) {
        ko.mapping.fromJS(data, _, this.self);
      }
    }

    return CustomerDto;

  })();

  window.CustomerDto = CustomerDto;

  HighValueCustomersViewModel = (function() {

    function HighValueCustomersViewModel() {
      this.Items = ko.observableArray([]);
      this.CustomerEntry = new CustomerDto();
    }

    HighValueCustomersViewModel.prototype.EditCustomer = function(customer) {
      this.CustomerEntry.CustomerID(customer.CustomerID);
      this.CustomerEntry.CustomerName(customer.CustomerName);
      this.CustomerEntry.Description(customer.Description);
      this.CustomerEntry.CustomerSince(customer.CustomerSince);
      return this.CustomerEntry.TotalSpent(customer.TotalSpent);
    };

    HighValueCustomersViewModel.prototype.SaveCustomer = function(customer) {
      return $.ajax({
        url: "/Customers/Save",
        method: "POST",
        data: {
          CustomerName: this.CustomerEntry.CustomerName()
        }
      });
    };

    return HighValueCustomersViewModel;

  })();

  window.viewModel = new HighValueCustomersViewModel();

}).call(this);
