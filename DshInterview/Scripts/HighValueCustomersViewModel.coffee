Mapping = 
	'Items':
		create: (options) ->
			new CustomerDto(options.data)			

class CustomerDto
	constructor: (data) ->
		@self = this

		@CustomerID = ko.observable()
		@CustomerName = ko.observable()
		@Description = ko.observable()
		@CustomerSince = ko.observable()
		@TotalSpent = ko.observable()  

		if data?
			ko.mapping.fromJS(data, _, @self)

window.CustomerDto = CustomerDto

class HighValueCustomersViewModel
	constructor: () ->
		@Items = ko.observableArray([])
		@CustomerEntry = new CustomerDto()
	
	EditCustomer: (customer) ->
		@CustomerEntry.CustomerID(customer.CustomerID)
		@CustomerEntry.CustomerName(customer.CustomerName)
		@CustomerEntry.Description(customer.Description)
		@CustomerEntry.CustomerSince(customer.CustomerSince)
		@CustomerEntry.TotalSpent(customer.TotalSpent)

	SaveCustomer: (customer) ->
		$.ajax({
			url: "/Customers/Save",
			method: "POST",
			data: 
				CustomerName: @CustomerEntry.CustomerName()
		});

window.viewModel = new HighValueCustomersViewModel()

