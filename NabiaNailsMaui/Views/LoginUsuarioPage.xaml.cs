using BIZ;
using COMMON.Entidades;
using COMMON.Validadores;

namespace NabiaNailsMaui.Views;

public partial class LoginUsuarioPage : ContentPage
{
    UsuariosManager usuariosManager;

    public LoginUsuarioPage()
    {
        InitializeComponent();
        usuariosManager = FabricManager.UsuariosManager;
    }

    private async void OnEntrarClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            await DisplayAlert("Advertencia", "Ingresa tu correo y contraseña", "OK");
            return;
        }

        var usuarios = await usuariosManager.ObtenerTodos();

        if (usuarios == null)
        {
            await DisplayAlert("Error", usuariosManager.Error, "OK");
            return;
        }

        var usuario = usuarios.FirstOrDefault(u => u.Email == txtEmail.Text && u.Password == txtPassword.Text);

        if (usuario != null)
        {
            if (usuario.Rol == "Cliente")
            {
                await Navigation.PushAsync(new DashboardClientePage());
            }
            else
            {
                await DisplayAlert("Acceso denegado", "Solo clientes pueden acceder desde la app móvil", "OK");
            }
        }
        else
        {
            await DisplayAlert("Error", "Credenciales incorrectas", "OK");
        }
    }
}
