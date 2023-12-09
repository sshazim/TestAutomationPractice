# TestAutomationPractice

This repo contains some sample UI &amp; API test cases based on some workflows associated with https://www.automationexercise.com

# E-commerce QA Automation Project

## Description

This project aims to automate the quality assurance testing of an e-commerce website https://www.automationexercise.com/. It includes a suite of automated tests that cover various functionalities and scenarios of the site.

## Test Scenarios and Cases

The automation tests cover the following scenarios:

- User registration , login and delete
- Product search and details
- Cart and Checkout

## Testing Approach and Design Patterns

- Page Object Model (POM) for UI Tests
- Data-Driven approach
- Request-Response Model for API Tests

## Technologies Used

- Programming Language: C#
- Testing Framework: NUnit
  - Web Automation: Selenium WebDriver
  - API Automation: RestSharp
- Test Reporting: ExtentReport

## Notes

The tests are written to handle advertisements, yet occasionally, a test might fail due to advertisements.

# Practice Exercise Tests

## Test Cases

Refer to https://www.automationexercise.com/test_cases URL for the UI test cases thast need to be automated.

## UI Tests

### Test 1

For test VerifyRegisterNewUserWithFilledAllFields() which corresponds to "Test Case 1: Register User" from the list of TestCases, parameterize the email address field such that the test can be executed consistently with a success result.

### Test 2

For test VerifyUserLoginWithValidData() which corresponds to "Test Case 2: Login User with correct email and password" from the list of TestCases, optimize the test to use TestCaseSource for supplying input data, such that the test is executed with 2 set of valid input data.
Refer to the VerifyLoginWithInvalidEmailOrPassword() for reference of using TestCaseSource attribute.

### Test 3

For test VerifyTotalPriceOfAllAddedProductsAreCorrectWithoutLogin() which corresponds to "Test Case 12: Add Products in Cart" from the list of TestCases, fix the logic of the code to perform assertions of price values of the 3 unique items added to the cart, current logic incorrectly repeats the assertion of the first item in the cart three times.

### Test 4

For test VerifyCompleteOrderWihtoutAddedProduct() which corresponds to "Test Case 16: Place Order: Login before Checkout" from the list of TestCases, the test case is currently incomplete. Refer to the test case steps available on the website, and implement the code for the missing steps, for adding product to the cart before moving to payment steps. Additionally fix the issues occurring within the POM classes related to Payment page.

### Test 5

Implement a new TestMethod corresponding to the test "Test Case 5: Register User with existing email" from the list of TestCases. Most of the POM objects required for this implementation would be already present within the framework, but in case some objects are missing, feel free to implement the necessary POM objects or actions required for completing this test case.

## API Test

Execute the list of API test cases available within framework & debug and fix the issues within those tests which are causing failures in the tests.
