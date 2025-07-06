Feature: Verify Tumblr works properly

  Scenario: Verify the login
      Given Check login button is available below
      When Click On Login button
      Then User should see the continue with email option
      Then Enter Email in Email text field
      Then Input The Password in Password field
      When Click on Log in button
      Then Show the Home Page is available in Display

