Feature: Verify rav.ai login works properly

  Scenario: Verify the login
      Given Check login button is available below
      When Click On Login button
      Then User should see the continue with email option
      Then Enter Email in Email text field
      Then Input The Password in Password field
      When Click on Log in button
      Then Show the Home Page is available in Display

  # Scenario: Verify dashboard functionality after login
  #     Given Check login button is available below
  #     When Click On Login button
  #     Then User should see the continue with email option
  #     Then Enter Email in Email text field
  #     Then Input The Password in Password field
  #     When Click on Log in button
  #     Then Show the Home Page is available in Display
  #     Given Check dashboard page is loaded properly
  #     When Navigate to dashboard section
  #     Then Verify dashboard elements are displayed
  #     And Verify dashboard functionality works correctly