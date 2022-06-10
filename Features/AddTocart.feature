Feature: Add To Cart

@tag1
Scenario: Add Printed Summner Dress
	Given a user navigate to the Website
	When a user enter "Printed Summer Dress" in search box
	And a user click search
	And a user select dress with price value $28.98
	And a user change colour to Blue
	And a user click on dropdown to change size to M
	And a user click on plus icon to change quantity to 2
	And a user click on Add to Cart
	Then the total value "$57.96" is displayed
	When a user click on on proceed to checkout
	Then the basket should contain "Printed Summer Dress","Color : Blue, Size : M","$57.96","$57.96","$2.00","$59.96","$0.00","$59.96" is updated
	When a user click on plus icon to increase quantity to 3
	Then the basket should contain "Printed Summer Dress","Color : Blue, Size : M","$86.94","$86.94","$2.00","$88.94","$0.00","$88.94" is updated


	