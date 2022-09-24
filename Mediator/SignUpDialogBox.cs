using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class SignUpDialogBox: IEventHandler
    {
        public TextBox userNameTextBox = new TextBox();
        public TextBox passwordTextBox = new TextBox();        
        public CheckBox checkBox = new CheckBox();
        public Button button = new Button();

        public SignUpDialogBox()         
        {
            userNameTextBox.AddEventHandler(EnableButton);
            userNameTextBox.AddEventHandler(UserNameChangedEvent);
            passwordTextBox.AddEventHandler(EnableButton);
            passwordTextBox.AddEventHandler(PasswordChangedEvent);
            checkBox.AddEventHandler(EnableButton);
        }

        public void UserNameChangedEvent() 
        {
            Console.WriteLine("Username changed!");
        }

        public void PasswordChangedEvent()
        {
            Console.WriteLine("Password changed!");
        }

        public void EnableButton()
        {
            var username = userNameTextBox.GetContent();
            var password = passwordTextBox.GetContent();
            var isTicked = checkBox.IsChecked();

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && isTicked)
            {
                button.SetEnabled(true);
            }
            else {
                button.SetEnabled(false);
            }
            
        }

        public void handler()
        {
            EnableButton();
        }
    }
}
