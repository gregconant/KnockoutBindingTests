function createViewModel() {

	function createPrimaryInfo() {
		return {
			someInfo: ko.observable()
		};
	};

	function createSecondaryInfo() {
		return {
			someInfo: ko.observable()
		};
	};

	var createOrder = function () {
		return {
			orderName: ko.observable()
			, primaryInfo: createPrimaryInfo()
			, secondaryInfo: createSecondaryInfo()
		};
	};

	var createPerson = function () {
		return {
			firstName: ko.observable(),
			lastName: ko.observable()
		};
	};

	var mainId = ko.observable();
	var orders = ko.observableArray([createOrder()]);
	var person = createPerson();

	var addOrder = function () {
		orders.push(createOrder());
	};

	var removeOrder = function () {
		orders.pop();
	};

	return {
		id: mainId,
		orders: orders,
		person: person,
		addOrder: addOrder,
		removeOrder: removeOrder
	};
}
$(document).ready(function () {
	var viewModel = createViewModel();
	ko.applyBindings(viewModel);
});