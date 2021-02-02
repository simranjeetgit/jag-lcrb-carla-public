﻿Feature: LiquorPrimaryDownloadLicence
    As a logged in business user
    I want to download a Liquor Primary licence

@liquorprimaryapp
Scenario: DEV Liquor Primary Download Licence 
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Liquor Primary Licence
    And I review the account profile for a private corporation
    And I complete the Liquor Primary application for a private corporation
    And I click on the Submit button
    And I log in as local government for Saanich
    And I click on the link for Applications for Review
    And I click on the link for Review Application
    And I specify my contact details as the approving authority
    And I log in as a return user
    And I click on the link for Complete Application
    And I review the local government response for a liquor primary licence
    And I click on the Licences tab
    And I click on the link for Download Licence
    And the account is deleted
    Then I see the login page