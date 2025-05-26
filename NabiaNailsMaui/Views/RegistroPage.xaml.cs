using BIZ;
using COMMON.Entidades;
using COMMON.Validadores;

namespace NabiaNailsMaui.Views;

public partial class RegistroPage : ContentPage
{
    UsuariosManager usuariosManager;

    public RegistroPage()
    {
        InitializeComponent();
        usuariosManager = FabricManager.UsuariosManager;
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtApellidos.Text) ||
            string.IsNullOrWhiteSpace(txtTelefono.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text) ||
            string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            await DisplayAlert("Advertencia", "Debes llenar todos los campos", "OK");
            return;
        }

        var nuevoUsuario = new Usuarios
        {
            Nombre = txtNombre.Text,
            Apellidos = txtApellidos.Text,
            Telefono = txtTelefono.Text,
            Email = txtEmail.Text,
            Password = txtPassword.Text,
            Rol = "Cliente" // siempre cliente desde app móvil
        };

        var resultado = usuariosManager.Agregar(nuevoUsuario);

        if (resultado != null)
        {
            await DisplayAlert("Éxito", "Registro exitoso", "OK");
            await Navigation.PopAsync(); // vuelve al login
        }
        else
        {
            await DisplayAlert("Error", usuariosManager.Error, "OK");
        }
    }
}

