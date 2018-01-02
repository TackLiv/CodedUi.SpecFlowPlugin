Feature: NotepadEditing
	Check notepad editing function
	In order to test editing
	As a user I should have notepad laucnhed

Background: 
	Given I launched notepad application

@sanity
Scenario: TypeWords
	When I enter "blablabla"
    Then Verify that 'blablabla' displayed
	And  I click close button
	Then Verify the PopupWindow should show on the screen
	When I click "Don't Save" button
	Then Verify that PopupWindow should disapeared
	And Verify the notepad application close
