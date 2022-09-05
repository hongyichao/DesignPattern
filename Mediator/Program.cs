// See https://aka.ms/new-console-template for more information
using Mediator;

Console.WriteLine("Hello, World!");

var signupDialogBox = new SignUpDialogBox();

signupDialogBox.userNameTextBox.SetContent("tester");
Console.WriteLine("Button: " + signupDialogBox.button.IsEnabled());

signupDialogBox.passwordTextBox.SetContent("tester");
Console.WriteLine("Button: " + signupDialogBox.button.IsEnabled());

signupDialogBox.checkBox.SetChecked(true);
Console.WriteLine("Button: " + signupDialogBox.button.IsEnabled());

//Console.WriteLine("TextBox: " + titleTextBox.getContent());
//System.out.println("Button: " + saveButton.isEnabled());