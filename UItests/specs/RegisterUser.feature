Feature: Register Page

Scenario Outline: Register a user
Given I open the home page
  When I click the signup/login button
  Then I should see the signup/login page
  And I should see New User Signup is visible
  When I enter the name and email address
  Then I click the signup button
  Then I should see ENTER ACCOUNT INFORMATION
  When I fill details <Title> , <Name> , <Email> , <Password> , <DateOfBirth>
Examples:
  |  Title  |  Name  |  Email                        |  Password  |  DateOfBirth  |
  |  Title1 |  User  |  userfirsttestuser@gmail.com  | password   |  01/01/2001  |
  
  Then I select checkbox "sign up for our newsletter!"
  And I select checkbox "Receive special offers from our partners"

  When I fill details <First name>, <Last name>, <Company>, <Address>, <Address2>, <Country>, <State>, <City>, <Zipcode>, <Mobile Number>
Examples:
  |  First name  |  Last name  |  Company  |  Address  |  Address2   |  Country  |  State  |  City  |  Zipcode  |  Mobile Number  | 
  |  User1       |  FirstUser  |  Testing  |  MyAdress |  TestAdress |  Country1 |  State1 |  City1 |  1234     |  0123456789     |
  
  When I click the "Create Account Button"
  Then I should see "ACCOUNT CREATED" is visible
  When I click the "Continue" button
  Then I should see "Logged in as {username}" is visible
  When I click the "Delete Account" button
  Then I should see "ACCOUNT DELETED"
  And I should click the "Continue" button
