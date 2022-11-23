using Pra.Contacts.Core;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pra.Properties.Contacts.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ContactBookApp cba = new ContactBookApp();
        public MainWindow()
        {
            InitializeComponent();

            cmbContactBooks.ItemsSource = cba.Contactbooks;
            SetAllButtonsHidden();
        }

        private void AddContactBook_Click(object sender, RoutedEventArgs e)
        {
            string name = txtNewBookName.Text;
            cba.AddContactBook(name);
            cmbContactBooks.Items.Refresh();
        }

        private void ContactBookSelection_Changed(object sender, SelectionChangedEventArgs e)
        {
            ContactBook selected = (ContactBook) cmbContactBooks.SelectedItem;
            lstContacts.ItemsSource = selected.Contacts;

            SetAllButtonsHidden();
            btnNewContact.Visibility = Visibility.Visible;
            btnChange.Visibility = Visibility.Visible;
        }

        private void AddContact_Click(object sender, RoutedEventArgs e)
        {

            ContactBook selected = (ContactBook)cmbContactBooks.SelectedItem;

            string name = txtName.Text;
            string address = txtAddress.Text;
            string telephoneNumber = txtPhoneNumber.Text;

            cba.AddContactToContactBook(selected, name, address, telephoneNumber);

            lstContacts.Items.Refresh();

            SetAllButtonsHidden();
            btnNewContact.Visibility = Visibility.Visible;
            btnChange.Visibility = Visibility.Visible;
        }

        private void NewContactMode_Click(object sender, RoutedEventArgs e)
        {
            SetAllButtonsHidden();
            btnAddContact.Visibility = Visibility.Visible;
        }

        private void SetAllButtonsHidden()
        {
            btnChange.Visibility = Visibility.Hidden;
            btnChangeContact.Visibility = Visibility.Hidden;
            btnNewContact.Visibility = Visibility.Hidden;
            btnAddContact.Visibility = Visibility.Hidden;
        }

        private void ChangeContactMode_Click(object sender, RoutedEventArgs e)
        {
            SetAllButtonsHidden();
            btnChangeContact.Visibility = Visibility.Visible;
        }

        private void ChangeContact_Click(object sender, RoutedEventArgs e)
        {
            Contact selected = (Contact) lstContacts.SelectedItem;
            if (selected == null) return;

            string name = txtName.Text;
            string address = txtAddress.Text;
            string telephoneNumber = txtPhoneNumber.Text;

            selected.Name = name;
            selected.TelephoneNumber = telephoneNumber;
            selected.Address = address;

            lstContacts.Items.Refresh();
        }

        private void ContactSelection_Changed(object sender, SelectionChangedEventArgs e)
        {
            Contact c = (Contact) lstContacts.SelectedItem;
            if (c == null) return;

            txtAddress.Text = c.Address;
            txtName.Text = c.Name;
            txtPhoneNumber.Text = c.TelephoneNumber;
        }
    }

}
