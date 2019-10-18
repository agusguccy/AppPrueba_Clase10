using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppPrueba_Clase10.Views
{
    public class Index : ContentPage
    {
        Label label;
        public Index()  //esto es el constructor
        {
            
            label = new Label();
            label.Text = "Hola mundo";
            label.TextColor = Color.Red;
           // label.HorizontalTextAlignment = TextAlignment.Center;
            label.BackgroundColor = Color.Yellow;

            Label label1 = new Label();
            Label label2 = new Label();

            StackLayout stackLayout = new StackLayout(); //va apilando las cosas como un div
            stackLayout.Children.Add(label); //Children es como un array, de ésta manera agregamos el label al stackLayout
            stackLayout.Children.Add(label1);
            stackLayout.Children.Add(label2);

            label1.Text = "Waddup";
            //label1.FontAttributes = Fontstyle.Bold; 
            label1.TextDecorations = TextDecorations.Underline;
            label1.HorizontalTextAlignment = TextAlignment.Center;

            Button button = new Button { Text = "Presione" };
            stackLayout.Children.Add(button);

            button.Clicked += presiono; //para poder acceder a la funcionalidad del evento se le agrega una función que se ejecuta cuando alguien toque el boton




            ////Otra forma de escribirlo
            //Content = new Label { Text = "Hola mundo!" };


            Content = stackLayout;

        }

        private void presiono(object sender, EventArgs e) //sender tiene el valor del objeto que generó el evento, en e tengo datos del evento
        {
            label.BackgroundColor = Color.Aqua;
        }
    }
}