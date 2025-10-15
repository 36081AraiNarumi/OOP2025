﻿using Sample.Data;
using SQLite;
using System;
using System.Reflection.PortableExecutable;
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

namespace Sample;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {
    private List<Person> _persons = new List<Person>();

    public MainWindow() {
        InitializeComponent();
        //ReadDatebase();
        _persons.Add(new Person { Id = 1, Name = "aaaa", Phone = "12345" });
        PersonListView.ItemsSource = _persons;
    }

    private void ReadDatebase() {
        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Person>();
            PersonListView.ItemsSource = connection.Table<Person>().ToList();
        }
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e) {
        var person = new Person() {
            Name = NameTextBox.Text,
            Phone = PhoneTextBox.Text,
        };
     
        using(var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Person>();
            connection.Insert(person);
        }
    }

    private void ReadButton_Click(object sender, RoutedEventArgs e) {


        _persons.Add(new Person { Id = 1, Name = "bbbbbb", Phone = "4567890" });
        
    }
}