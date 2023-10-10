using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormularioApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void cbox_terminos_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (cbox_terminos.IsChecked)
                btn_Registrar.IsEnabled = true;
            else
                btn_Registrar.IsEnabled = false;

        }

        private void btn_registrar_Clicked(object sender, EventArgs e)
        {
            string contraseña1 = lbl_password.Text;
            string contraseña2 = lbl_password2.Text;
            if (contraseña1 == contraseña2)
            {
                limpiarRegistro();
                DisplayAlert("Registro Exitoso!", "No olvides suscribirte al canal :)", "Suscribir");
            }
            else
            {
                
                DisplayAlert("Contraseña Diferente!", "Ambas contraseñas deben ser iguales", "Modificar");

            }
        }

        private void limpiarRegistro()
        {
            lbl_nombre.Text = "";
            lbl_correo.Text = "";
            lbl_password.Text = "";
            lbl_password2.Text = "";
            Progress.ProgressTo(0, 250, Easing.Linear);  
        }

        private void sw_example_Toggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("¡Hola!", "Subire mas videos de este tipo", "OK");
        }

        private void lbl_nombre_Completed(object sender, EventArgs e)
        {
            Progress.ProgressTo(.25, 250, Easing.Linear);
            lbl_progress.Text = "25%";
        }

        private void lbl_nombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            String nombre = lbl_nombre.Text.ToString();
            string cadena = $"Bienvenido {nombre}. Llene sus datos";
            lbl_principal.Text = cadena;
        }

        private void lbl_correo_Completed(object sender, EventArgs e)
        {
            Progress.ProgressTo(.5, 250, Easing.Linear);
            lbl_progress.Text = "50%";
        }

        private void lbl_password_Completed(object sender, EventArgs e)
        {
            Progress.ProgressTo(.75, 250, Easing.Linear);
            lbl_progress.Text = "75%";
        }

        private void lbl_password2_Completed(object sender, EventArgs e)
        {
            Progress.ProgressTo(1, 250, Easing.Linear);
            lbl_progress.Text = "100%";
        }
    }

}