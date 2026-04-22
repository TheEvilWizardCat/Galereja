using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Galereja
{
    public class MainPageViewModel
    {
        public ObservableCollection<Contact> Contacts { get; set; } = new();

        public string NewName { get; set; }
        public string NewPhoneNumber { get; set; }
        public string NewImageUrl { get; set; }
        
        public ICommand AddContactCommand { get; }

        public MainPageViewModel()
        {
            AddContactCommand = new Command(() =>
            {
                if (!string.IsNullOrWhiteSpace(NewName))
                {
                    Contacts.Add(new Contact
                    {
                        Name = NewName,
                        PhoneNumber = NewPhoneNumber,
                        ImageUrl = string.IsNullOrWhiteSpace(NewImageUrl) ? "dotnet_bot.png" : NewImageUrl
                    });
                }
            });
        
        }
    }
}

//**********************************************
//nazwa funkcji: MainPageViewModel
//opis funkcji:Klasa odpowiada za logikę widoku głównego, przechowuje listę kontaktów oraz obsługuje dodawanie nowych elementów do kolekcji.
//parametry: brak.
//zwracany typ i opis:brak – jest to konstruktor klasy ViewModel, inicjalizuje komendę oraz kolekcję kontaktów.                  
//autor: 7
//***********************************************
