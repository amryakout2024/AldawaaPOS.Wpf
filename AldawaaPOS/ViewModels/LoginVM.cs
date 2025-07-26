using AldawaaPOS.Helpers;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AldawaaPOS.ViewModels
{
     class LoginVM:ViewModelBase
     {
        private string empId;
        public string EmpId
        {
            get { return empId; }
            set { empId = value;OnPropertyChanged(); }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(); }
        }
        private bool isEmpIdFocused;
        public bool IsEmpIdFocused
        {
            get { return isEmpIdFocused; }
            set { isEmpIdFocused = value; OnPropertyChanged(); }
        }

        private bool isPasswordFocused;

        public bool IsPasswordFocused
        {
            get { return isPasswordFocused; }
            set { isPasswordFocused = value; OnPropertyChanged(); }
        }

        public ICommand LoginCommand { get; private set; }
        public ICommand Calculator1Command { get; private set; }
        public ICommand Calculator2Command { get; private set; }
        public ICommand Calculator3Command { get; private set; }
        public ICommand Calculator4Command { get; private set; }
        public ICommand Calculator5Command { get; private set; }
        public ICommand Calculator6Command { get; private set; }
        public ICommand Calculator7Command { get; private set; }
        public ICommand Calculator8Command { get; private set; }
        public ICommand Calculator9Command { get; private set; }
        public ICommand Calculator0Command { get; private set; }
        public ICommand CalculatorClearCommand { get; private set; }
        public ICommand CalculatorDeleteCommand { get; private set; }

        public LoginVM()
        {
            ActivateCommands();

        }

        private void ActivateCommands()
        {
            LoginCommand = new ActionCommand(Login);
            Calculator1Command = new ActionCommand(Calculator1);
            Calculator2Command = new ActionCommand(Calculator2);
            Calculator3Command = new ActionCommand(Calculator3);
            Calculator4Command = new ActionCommand(Calculator4);
            Calculator5Command = new ActionCommand(Calculator5);
            Calculator6Command = new ActionCommand(Calculator6);
            Calculator7Command = new ActionCommand(Calculator7);
            Calculator8Command = new ActionCommand(Calculator8);
            Calculator9Command = new ActionCommand(Calculator9);
            Calculator0Command = new ActionCommand(Calculator0);
            CalculatorClearCommand = new ActionCommand(CalculatorClear);
            CalculatorDeleteCommand = new ActionCommand(CalculatorDelete);
        }
        private void Login()
        {
            MessageBox.Show("Test");
        }

        private void GetCalculatorNumber(string number)
        {
            if (isEmpIdFocused)
            {
                EmpId = EmpId + number;
            }

            if (IsPasswordFocused)
            {
                Password = Password + number;
            }
        }

        private void Calculator1()
        {
            GetCalculatorNumber("1");
        }

        private void Calculator2()
        {
            GetCalculatorNumber("2");
        }

        private void Calculator3()
        {
            GetCalculatorNumber("3");
        }

        private void Calculator4()
        {
            GetCalculatorNumber("4");
        }

        private void Calculator5()
        {
            GetCalculatorNumber("5");
        }

        private void Calculator6()
        {
            GetCalculatorNumber("6");
        }

        private void Calculator7()
        {
            GetCalculatorNumber("7");
        }

        private void Calculator8()
        {
            GetCalculatorNumber("8");
        }

        private void Calculator9()
        {
            GetCalculatorNumber("9");
        }

        private void Calculator0()
        {
            GetCalculatorNumber("0");
        }

        private void CalculatorClear()
        {
            if (isEmpIdFocused)
            {
                EmpId = "";
            }

            if (IsPasswordFocused)
            {
                Password = "";
            }
        }
        private void CalculatorDelete()
        {
            if (isEmpIdFocused)
            {
                if (!string.IsNullOrEmpty(empId))
                {
                    EmpId = EmpId.Remove(EmpId.Length - 1);
                }
            }

            if (IsPasswordFocused)
            {
                if (!string.IsNullOrEmpty(Password))
                {
                    Password = Password.Remove(Password.Length - 1);
                }
            }
        }
    }
}
