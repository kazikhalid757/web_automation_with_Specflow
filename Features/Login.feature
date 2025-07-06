Feature: Verify Tumblr works properly

  Scenario: Verify the login
      Given Check login button is available below
      When Click On Login button
      Then User should see the continue with email option
      And  Click on continue with Email button
      Then Enter Email in Email text field
      When Click on next button
      Then Input The Password in Password field
      When Click on Log in button
      Then Show the Home Page is available in Display

#   Scenario: Check Tumblr Activity works properly
#       Given Check login button is available below
#       When Click On Login button
#       Then User should see the continue with email option
#       And Click on continue with Email button
#       Then Enter Email in Email text field
#       When Click on next button
#       Then Input The Password in Password field
#       When Click on Log in button
#       Given Check Activity is available in site
#       When Click on Activity button
#       Then Show the Activity Page is available in Display

#   Scenario: Check Tumblr explore works properly
#       Given Check login button is available below
#       When Click On Login button
#       Then User should see the continue with email option
#       And Click on continue with Email button
#       Then Enter Email in Email text field
#       When Click on next button
#       Then Input The Password in Password field
#       When Click on Log in button
#       Given Check explore is available in site
#       When Click on explore button
#       Then Show the explore Page is available in Display

#   Scenario: Check Tumblr message works properly
#       Given Check login button is available below
#       When Click On Login button
#       Then User should see the continue with email option
#       And Click on continue with Email button
#       Then Enter Email in Email text field
#       When Click on next button
#       Then Input The Password in Password field
#       When Click on Log in button
#       Given Check message is available in site
#       When Click on message button
#       Then Show the message box is available in Display

#   Scenario: Check Tumblr inbox works properly
#       Given Check login button is available below
#       When Click On Login button
#       Then User should see the continue with email option
#       And Click on continue with Email button
#       Then Enter Email in Email text field
#       When Click on next button
#       Then Input The Password in Password field
#       When Click on Log in button
#       Given Check inbox is available in site
#       When Click on inbox button
#       Then Show the inbox box is available in Display

#   Scenario: Check Tumblr Account works properly
#       Given Check login button is available below
#       When Click On Login button
#       Then User should see the continue with email option
#       And Click on continue with Email button
#       Then Enter Email in Email text field
#       When Click on next button
#       Then Input The Password in Password field
#       When Click on Log in button
#       Given Check account is available in site
#       When Click on account button
#       Then Show the account sub menu is available in Display

#   Scenario: Check Tumblr Like button works properly
#       Given Check login button is available below
#       When Click On Login button
#       Then User should see the continue with email option
#       And Click on continue with Email button
#       Then Enter Email in Email text field
#       When Click on next button
#       Then Input The Password in Password field
#       When Click on Log in button
#       Given Check account is available in site
#       When Click on account button
#       When Click on The like button
#       Then Show the like page available in display