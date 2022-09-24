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