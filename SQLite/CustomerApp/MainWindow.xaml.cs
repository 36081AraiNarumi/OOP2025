using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using CustomerApp.Date;

namespace CustomerApp {
    public partial class MainWindow : Window {
        private ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
        private Customer? selectedCustomer = null;
        private int nextId = 1;

        public MainWindow() {
            InitializeComponent();
            PersonListView.ItemsSource = customers;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            var name = NameTextBox.Text.Trim();
            var phone = PhoneTextBox.Text.Trim();
            var address = AddressTextBox.Text.Trim();

            if (string.IsNullOrEmpty(name)) {
                MessageBox.Show("名前を入力してください");
                return;
            }

            var customer = new Customer {
                Id = nextId++,
                Name = name,
                Phone = phone,
                Address = address
            };

            customers.Add(customer);
            ClearInputs();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            if (selectedCustomer == null) {
                MessageBox.Show("更新する顧客を選択してください");
                return;
            }

            selectedCustomer.Name = NameTextBox.Text.Trim();
            selectedCustomer.Phone = PhoneTextBox.Text.Trim();
            selectedCustomer.Address = AddressTextBox.Text.Trim();
            PersonListView.Items.Refresh();
            ClearInputs();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            if (selectedCustomer != null) {
                customers.Remove(selectedCustomer);
                ClearInputs();
            }
        }

        private void ReadButton_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show($"登録件数: {customers.Count}");
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var keyword = SearchTextBox.Text.Trim().ToLower();
            PersonListView.ItemsSource = string.IsNullOrEmpty(keyword)
                ? customers
                : new ObservableCollection<Customer>(
                    customers.Where(c =>
                        c.Name.ToLower().Contains(keyword) ||
                        c.Phone.Contains(keyword) ||
                        c.Address.ToLower().Contains(keyword)));
        }

        private void PersonListView_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {
            selectedCustomer = PersonListView.SelectedItem as Customer;
            if (selectedCustomer != null) {
                NameTextBox.Text = selectedCustomer.Name;
                PhoneTextBox.Text = selectedCustomer.Phone;
                AddressTextBox.Text = selectedCustomer.Address;
            }
        }

        private void ClearInputs() {
            NameTextBox.Text = "";
            PhoneTextBox.Text = "";
            AddressTextBox.Text = "";
            selectedCustomer = null;
        }
    }
}