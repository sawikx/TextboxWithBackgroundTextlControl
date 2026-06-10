using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextboxWithBackgroundTextlControl
{   
    public partial class TextboxWithBackgroundTextlControl : UserControl
    {
        public TextboxWithBackgroundTextlControl()
        {
            InitializeComponent();
        }

        private string backgroundText = "";

        public string BackgroundText
        {
            get { return backgroundText; }
            set
            {
                backgroundText = value;
                tbBackgroundText.Text = backgroundText;
            }
        }

        public string Value
        {
            get { return txtInput.Text; }
            set
            {
                txtInput.Text = value;
            }
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
                tbBackgroundText.Visibility = Visibility.Visible;
            else
                tbBackgroundText.Visibility = Visibility.Hidden;


        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }
    }
}
