using Bingo.Models;
using Bingo.Services;
using Bingo.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Bingo.ViewModels
{
    class CodeRegisterViewModel : BaseViewModel
    {
        private Player player;
        private string token;
        public CodeRegisterViewModel()
        {
            player = new Player();
            Console.WriteLine("Ikuzoo");
            JoinGameCommand = new Command(OnJoinGame);
        }

        public string Token 
        { 
            get => token; 
            set => SetProperty(ref token, value);
        }

        public Command JoinGameCommand
        {
            get; set;
        }

        public Player Player
        {
            get { return player; }
            set { SetProperty(ref player, value); }
        }

        private async void OnJoinGame()
        {
            Console.WriteLine("Initiate Getting Player Card");
            
            if(Token != null)
            {
                Console.WriteLine(Token);
                Player = await REST.GetPlayer(Token);
                Console.WriteLine(Player.playcard_token);
                Console.WriteLine("Successfully got player");
                await Application.Current.MainPage.Navigation.PushAsync(new BingoGamePage(Player));
            }
            else
            {
                Console.WriteLine("Please Input a Token");
            }
        }
    }
}
