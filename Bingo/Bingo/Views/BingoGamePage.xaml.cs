using Bingo.Models;
using Bingo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bingo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BingoGamePage : ContentPage
    {
        Player player;
        public BingoGamePage(Player player)
        {
            Console.WriteLine("Going to Bingo Game Board");
            this.player = player;
            InitializeComponent();
            ((BingoGameViewModel)BindingContext).Player = this.player;

            ((BingoGameViewModel)BindingContext).B1 = this.player.card.B[0];
            ((BingoGameViewModel)BindingContext).B2 = this.player.card.B[1];
            ((BingoGameViewModel)BindingContext).B3 = this.player.card.B[2];
            ((BingoGameViewModel)BindingContext).B4 = this.player.card.B[3];
            ((BingoGameViewModel)BindingContext).B5 = this.player.card.B[4];

            ((BingoGameViewModel)BindingContext).I1 = this.player.card.I[0];
            ((BingoGameViewModel)BindingContext).I2 = this.player.card.I[1];
            ((BingoGameViewModel)BindingContext).I3 = this.player.card.I[2];
            ((BingoGameViewModel)BindingContext).I4 = this.player.card.I[3];
            ((BingoGameViewModel)BindingContext).I5 = this.player.card.I[4];

            ((BingoGameViewModel)BindingContext).N1 = this.player.card.N[0];
            ((BingoGameViewModel)BindingContext).N2 = this.player.card.N[1];
            ((BingoGameViewModel)BindingContext).N3 = this.player.card.N[2];
            ((BingoGameViewModel)BindingContext).N4 = this.player.card.N[3];
            ((BingoGameViewModel)BindingContext).N5 = this.player.card.N[4];

            ((BingoGameViewModel)BindingContext).G1 = this.player.card.G[0];
            ((BingoGameViewModel)BindingContext).G2 = this.player.card.G[1];
            ((BingoGameViewModel)BindingContext).G3 = this.player.card.G[2];
            ((BingoGameViewModel)BindingContext).G4 = this.player.card.G[3];
            ((BingoGameViewModel)BindingContext).G5 = this.player.card.G[4];

            ((BingoGameViewModel)BindingContext).O1 = this.player.card.O[0];
            ((BingoGameViewModel)BindingContext).O2 = this.player.card.O[1];
            ((BingoGameViewModel)BindingContext).O3 = this.player.card.O[2];
            ((BingoGameViewModel)BindingContext).O4 = this.player.card.O[3];
            ((BingoGameViewModel)BindingContext).O5 = this.player.card.O[4];
        }
        private async void CombinationClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackgroundColor = button.BackgroundColor != Color.Red ? Color.Red : Color.Yellow;
        }
    }
}