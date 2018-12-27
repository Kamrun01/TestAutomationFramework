Feature:HomePage
     Responsible for checking home page functiolity


Scenario:Check home page functionality
Given I have navigated to the application
And I see application opened
When I enter UserName and Password 
| UserName       | Password |
| raz@mai.com    | salesforce18 |
Then I click login button
And I click home link
Then I click username link