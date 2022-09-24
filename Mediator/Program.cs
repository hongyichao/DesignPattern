/*
 Mediator pattern is used when there are multiple components/ data sources which can change 
the states/ generate events 
and the states of other objects will need to be updated based on the changes or events,
so we introduce a Mediator to manage the events and the states of the objects
 */

using Mediator;

var signupDialogBox = new SignUpDialogBox();

signupDialogBox.userNameTextBox.SetContent("tester");
Console.WriteLine("Button: " + signupDialogBox.button.IsEnabled());

signupDialogBox.passwordTextBox.SetContent("tester");
Console.WriteLine("Button: " + signupDialogBox.button.IsEnabled());

signupDialogBox.checkBox.SetChecked(true);
Console.WriteLine("Button: " + signupDialogBox.button.IsEnabled());

signupDialogBox.checkBox.SetChecked(false);
Console.WriteLine("Button: " + signupDialogBox.button.IsEnabled());

signupDialogBox.passwordTextBox.SetContent("tester2");
signupDialogBox.userNameTextBox.SetContent("tester2");

//Console.WriteLine("TextBox: " + titleTextBox.getContent());
//System.out.println("Button: " + saveButton.isEnabled());