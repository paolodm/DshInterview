Mapping = 
	'Items':
		create: (options) ->
			new CustomerDto(options.data)			

class CustomerDto
	constructor: (data) ->
		@self = this

		@CustomerID = ko.observable()
		@Name = ko.observable()
		@Description = ko.observable()
		@CustomerSince = ko.observable()
		@TotalSpent = ko.observable()  

		ko.mapping.fromJS(data, _, @self)

class HighValueCustomersViewModel
	constructor: () ->
		@Items = ko.observableArray([])

window.CustomerDto = CustomerDto

window.viewModel = new HighValueCustomersViewModel()

