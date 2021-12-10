using System;
using System.Collections.Generic;
using System.Text;
using Bingo.Models;
using Bingo.Services;
using Xamarin.Forms;

namespace Bingo.ViewModels
{
    class BingoGameViewModel : BaseViewModel
    {
        private int b1, b2, b3, b4, b5, i1, i2, i3, i4, i5, n1, n2, n3, n4, n5, g1, g2, g3, g4, g5, o1, o2,
            o3, o4, o5;
        private Player player;
        public BingoGameViewModel() 
        {
            Console.WriteLine("GAYMU STATO!");
            SubmitCommand = new Command(SubmitCard);
        }
        public Command SubmitCommand
        {
            get; set;
        }
        private async void SubmitCard()
        {
            Console.WriteLine(Player.playcard_token);
            int res = await REST.SubmitCard(Player.playcard_token);
            if(res == 1)
            {
                await Application.Current.MainPage.DisplayAlert("WIN", "You WIN!", "OK");
                await Application.Current.MainPage.Navigation.PopAsync();
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("LOSE", "You LOSE!", "OK");
                await Application.Current.MainPage.Navigation.PopAsync();
            }
        }
        public Player Player
        {
            get => player;
            set => SetProperty(ref player, value);
        }
        public int B1
        {
            get => b1;
            set => SetProperty(ref b1, value);
        }
        public int B2
        {
            get => b2;
            set => SetProperty(ref b2, value);
        }
        public int B3
        {
            get => b3;
            set => SetProperty(ref b3, value);
        }
        public int B4
        {
            get => b4;
            set => SetProperty(ref b4, value);
        }
        public int B5
        {
            get => b5;
            set => SetProperty(ref b5, value);
        }
        public int I1
        {
            get => i1;
            set => SetProperty(ref i1, value);
        }
        public int I2
        {
            get => i2;
            set => SetProperty(ref i2, value);
        }
        public int I3
        {
            get => i3;
            set => SetProperty(ref i3, value);
        }
        public int I4
        {
            get => i4;
            set => SetProperty(ref i4, value);
        }

        public int I5
        {
            get => i5;
            set => SetProperty(ref i5, value);
        }
        public int N1
        {
            get => n1;
            set => SetProperty(ref n1, value);
        }
        public int N2
        {
            get => n2;
            set => SetProperty(ref n2, value);
        }
        public int N3
        {
            get => n3;
            set => SetProperty(ref n3, value);
        }
        public int N4
        {
            get => n4;
            set => SetProperty(ref n4, value);
        }
        public int N5
        {
            get => n5;
            set => SetProperty(ref n5, value);
        }
        public int O1
        {
            get => o1;
            set => SetProperty(ref o1, value);
        }
        public int O2
        {
            get => o2;
            set => SetProperty(ref o2, value);
        }
        public int O3
        {
            get => o3;
            set => SetProperty(ref o3, value);
        }
        public int O4
        {
            get => o4;
            set => SetProperty(ref o4, value);
        }
        public int O5
        {
            get => o5;
            set => SetProperty(ref o5, value);
        }
        public int G1
        {
            get => g1;
            set => SetProperty(ref g1, value);
        }
        public int G2
        {
            get => g2;
            set => SetProperty(ref g2, value);
        }
        public int G3
        {
            get => g3;
            set => SetProperty(ref g3, value);
        }
        public int G4
        {
            get => g4;
            set => SetProperty(ref g4, value);
        }
        public int G5
        {
            get => g5;
            set => SetProperty(ref g5, value);
        }
    }
}
