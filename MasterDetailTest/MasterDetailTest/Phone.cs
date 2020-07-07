using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using MasterDetailTest.Annotations;

namespace MasterDetailTest
{
    public class Phone: INotifyPropertyChanged
    {
        private string title;
        private int price;
        private string manufacturer;
        private ObservableCollection<Person> owners;
        public string Title {
            get => this.title;
            set
            {
                this.title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
        public  int Price
        {
            get => this.price;

            set
            {
                this.price = value;
                OnPropertyChanged(nameof(Price));
            }
        }

        public ObservableCollection<Person> Owners
        {
            get => this.owners;
            set
            {
                this.owners = value;
                OnPropertyChanged(nameof(Owners));
            }
        }

        public string Manufacturer
        {
            get => this.manufacturer;
            set
            {
                this.manufacturer = value;
                OnPropertyChanged(nameof(Manufacturer));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Person:INotifyPropertyChanged
    {
        private string name;
        private string surname;
        public string Surname
        {
            get => this.surname;
            set
            {
                this.surname = value;
                OnPropertyChanged(nameof(Surname));
            }
        }
        public string Name
        {
            get => this.name;
            set
            {
                this.name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
