using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MasterDetailTest
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Phone selectedPhone;

        public ObservableCollection<Phone> Phones { get; set; }
        public Phone SelectedPhone
        {
            get => selectedPhone;
            set
            {
                selectedPhone = value;
                OnPropertyChanged(nameof(SelectedPhone));
            }
        }

        public ApplicationViewModel()
        {
            List<Person> iphOwners = new List<Person>()
            {
                new Person(){Name = "Иван", Surname = "Иванов"},
                new Person(){Name = "Иван", Surname = "Петров"}
            };
            List<Person> samsOwners = new List<Person>()
            {
                new Person(){Name = "Иван", Surname = "Samsung"},
                new Person(){Name = "Иван", Surname = "SamPetr"}
            };
            List<Person> hpOwns = new List<Person>()
            {
                new Person(){Name = "Иван", Surname = "HPIV"},
                new Person(){Name = "Иван", Surname = "HPPetr"}
            };
            List<Person> xiOwns = new List<Person>()
            {
                new Person(){Name = "Иван", Surname = "XiIv"},
                new Person(){Name = "Иван", Surname = "XiPetr"}
            };
            Phones = new ObservableCollection<Phone>
            {
                new Phone { Title="iPhone 7", Manufacturer= "Apple", Price=56000, Owners = new ObservableCollection<Person>(iphOwners)},
                new Phone {Title="Galaxy S7 Edge", Manufacturer="Samsung", Price =60000, Owners = new ObservableCollection<Person>(samsOwners) },
                new Phone {Title="Elite x3", Manufacturer="HP", Price=56000, Owners =  new ObservableCollection<Person>(hpOwns)},
                new Phone {Title="Mi5S", Manufacturer="Xiaomi", Price=35000, Owners = new ObservableCollection<Person>(xiOwns)}
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
