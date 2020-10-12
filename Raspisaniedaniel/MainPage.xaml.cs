using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Raspisaniedaniel
{
    public partial class MainPage : ContentPage
    {
        BoxView box;
        Label lbl, nomer0, nomer1, nomer2, nomer3, nomer4, nomer5, nomer6, nomer7, nomer8, nomer9, nomer10, p1, p2, p3, p4, p5, r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14;
        Frame frm, frm2;
        public MainPage()
        {
            Grid abs = new Grid();
            for (int i = 0; i < 4; i++)
            {
                abs.RowDefinitions.Add(new RowDefinition
                { Height = new GridLength(1, GridUnitType.Star) });

            }
            for (int j = 0; j < 3; j++)
            {
                abs.ColumnDefinitions.Add(new ColumnDefinition
                { Width = new GridLength(1, GridUnitType.Star) });
            }

            nomer1 = new Label { BackgroundColor = Color.White };
            abs.Children.Add(nomer1, 0, 0);
            nomer2 = new Label { BackgroundColor = Color.White, Text = "1" };
            abs.Children.Add(nomer2, 3, 0);
            nomer3 = new Label { BackgroundColor = Color.White, Text = "2" };
            abs.Children.Add(nomer3, 4, 0);
            nomer4 = new Label { BackgroundColor = Color.White, Text = "3" };
            abs.Children.Add(nomer4, 5, 0);
            nomer5 = new Label { BackgroundColor = Color.White, Text = "4" };
            abs.Children.Add(nomer5, 6, 0);
            nomer6 = new Label { BackgroundColor = Color.White, Text = "5" };
            abs.Children.Add(nomer6, 7, 0);
            nomer7 = new Label { BackgroundColor = Color.White, Text = "6" };
            abs.Children.Add(nomer7, 8, 0);
            nomer8 = new Label { BackgroundColor = Color.White, Text = "7" };
            abs.Children.Add(nomer8, 9, 0);
            nomer9 = new Label { BackgroundColor = Color.White, Text = "8" };
            abs.Children.Add(nomer9, 10, 0);
            nomer10 = new Label { BackgroundColor = Color.White, Text = "9" };
            abs.Children.Add(nomer10, 11, 0);

            p1 = new Label { BackgroundColor = Color.White, Text = "Понедельник" };
            abs.Children.Add(p1, 0, 1);
            Grid.SetColumnSpan(p1, 2);
            p2 = new Label { BackgroundColor = Color.White, Text = "Вторник" };
            abs.Children.Add(p2, 0, 2);
            Grid.SetColumnSpan(p2, 2);
            p3 = new Label { BackgroundColor = Color.White, Text = "Среда" };
            abs.Children.Add(p3, 0, 3);
            Grid.SetColumnSpan(p3, 2);
            p4 = new Label { BackgroundColor = Color.White, Text = "Четверг" };
            abs.Children.Add(p4, 0, 4);
            Grid.SetColumnSpan(p4, 2);
            p5 = new Label { BackgroundColor = Color.White, Text = "Пятница" };
            abs.Children.Add(p5, 0, 5);
            Grid.SetColumnSpan(p5, 2);
            Content = abs;

            r1 = new Label { BackgroundColor = Color.Green, Text = "Keel ja \n Kirjandus \n \n B221" };
            abs.Children.Add(r1, 3, 1);
            Grid.SetColumnSpan(r1, 2);
            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += async (s, e) =>
            {
                r1 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет B221 \n Mihhailova Ljudmilla", "закрыть");
            };
            r1.GestureRecognizers.Add(tap1);

            r2 = new Label { BackgroundColor = Color.FromRgb(255, 204, 204),Text = "Võrgud ja seadm. \n \n \n A123" };
            abs.Children.Add(r2, 5, 1);
            Grid.SetColumnSpan(r2, 3);
            var tap2 = new TapGestureRecognizer();

            tap2.Tapped += async (s, e) =>
            {
                r2 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет A123 \n Agapov Mikhail", "закрыть");
            };
            r2.GestureRecognizers.Add(tap2);

            r3 = new Label { BackgroundColor = Color.LightBlue, Text = "Mob.rak \n \n \n E07" };
            abs.Children.Add(r3, 9, 1);
            Grid.SetColumnSpan(r3, 3);
            var tap3 = new TapGestureRecognizer();
            tap3.Tapped += async (s, e) =>
            {
                r3 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет E07 \n Oleinik Marina", "закрыть");
            };
            r3.GestureRecognizers.Add(tap3);

            r4 = new Label { BackgroundColor = Color.FromRgb(204, 255, 204), Text = "Transp.Log.juht \n \n \n B002" };
            abs.Children.Add(r4, 3, 2);
            Grid.SetColumnSpan(r4, 3);
            var tap4 = new TapGestureRecognizer();
            tap4.Tapped += async (s, e) =>
            {
                r4 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет B002 \n Jaanus Krull", "закрыть");
            };
            r4.GestureRecognizers.Add(tap4);

            r5 = new Label { BackgroundColor = Color.Gray, Text = "Inglise W.hald \n \n \n B242" };
            abs.Children.Add(r5, 7, 2);
            Grid.SetColumnSpan(r5, 2);
            var tap5 = new TapGestureRecognizer();
            tap5.Tapped += async (s, e) =>
            {
                r5 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет B242 \n Voronetskaja Julia", "закрыть");
            };
            r5.GestureRecognizers.Add(tap5);

            r6 = new Label { BackgroundColor = Color.DeepPink, Text = "Eesti keel \n teise Kellena \n \n \n B236" };
            abs.Children.Add(r6, 9, 2);
            Grid.SetColumnSpan(r6, 2);
            var tap6 = new TapGestureRecognizer();
            tap6.Tapped += async (s, e) =>
            {
                r6 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет B236 \n Laaneväli Toots Alina", "закрыть");
            };
            r6.GestureRecognizers.Add(tap6);

            r7 = new Label { BackgroundColor = Color.DeepPink, Text = "W.paig.sead.\n \n \n A243" };
            abs.Children.Add(r7, 3, 3);
            Grid.SetColumnSpan(r7, 3);
            var tap7 = new TapGestureRecognizer();
            tap7.Tapped += async (s, e) =>
            {
                r7 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет A243 \n Shkarbanova Lury", "закрыть");
            };
            r7.GestureRecognizers.Add(tap7);

            r8 = new Label { BackgroundColor = Color.FromRgb(204, 244, 204), Text = "Transp.log.juht \n \n \n B003" };
            abs.Children.Add(r8, 6, 3);
            Grid.SetColumnSpan(r8, 5);
            var tap8 = new TapGestureRecognizer();
            tap8.Tapped += async (s, e) =>
            {
                r8 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет B003 \n Jaanus Krull", "закрыть");
            };
            r8.GestureRecognizers.Add(tap8);

            r9 = new Label { BackgroundColor = Color.Pink, Text = "Keemia \n Biologia\n \n \n B144" };
            abs.Children.Add(r9, 11, 3);
            var tap9 = new TapGestureRecognizer();
            tap9.Tapped += async (s, e) =>
            {
                r9 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет B144 \n Pesetkaja Svetlana", "закрыть");
            };
            r9.GestureRecognizers.Add(tap9);

            r10 = new Label { BackgroundColor = Color.DeepPink, Text = "W.paig.sead\n \n \n A243." };
            abs.Children.Add(r10, 3, 4);
            Grid.SetColumnSpan(r10, 3);
            var tap10 = new TapGestureRecognizer();
            tap10.Tapped += async (s, e) =>
            {
                r10 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет A243 \n Shkarbanova Lury", "закрыть");
            };
            r10.GestureRecognizers.Add(tap10);

            r11 = new Label { BackgroundColor = Color.FromRgb(255, 204, 204), Text = "Võrgud ja seadm.\n \n A123" };
            abs.Children.Add(r11, 7, 4);
            Grid.SetColumnSpan(r11, 2);
            var tap11 = new TapGestureRecognizer();
            tap11.Tapped += async (s, e) =>
            {
                r11 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет A123 \n Agapov Mikhail", "закрыть");
            };
            r11.GestureRecognizers.Add(tap11);

            r12 = new Label { BackgroundColor = Color.Gray, Text = "Inglise W.hald.\n \n \n B242" };
            abs.Children.Add(r12, 9, 4);
            Grid.SetColumnSpan(r12, 2);
            var tap12 = new TapGestureRecognizer();
            tap12.Tapped += async (s, e) =>
            {
                r12 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет B242 \n Voronetskaja Julia", "закрыть");
            };
            r12.GestureRecognizers.Add(tap12);
            r13 = new Label { BackgroundColor = Color.Pink, Text = "Keemia \n Biologia \n \n \n B144" };
            abs.Children.Add(r13, 3, 5);
            var tap13 = new TapGestureRecognizer();
            tap13.Tapped += async (s, e) =>
            {
                r13 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет B144 \n Pesetkaja Svetlana", "закрыть");
            };
            r13.GestureRecognizers.Add(tap13);
            r14 = new Label { BackgroundColor = Color.LightBlue, Text = "Mob. Rak. \n \n \n E07" };
            abs.Children.Add(r14, 5, 5);
            Grid.SetColumnSpan(r14, 3);
            var tap14 = new TapGestureRecognizer();
            tap14.Tapped += async (s, e) =>
            {
                r14 = (Label)s;
                await DisplayAlert("Дополнительная информация", "Кабинет E07 \n Oleinik Marina", "закрыть");
            };
            r14.GestureRecognizers.Add(tap14);
            Content = abs;
        }
    }
}

