using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Windows;
using static CajeroPOS.MainWindow;

namespace CajeroPOS
{
    public partial class LoginWindow : Window
    {
        private bool loginExitoso = false;
        private List<Usuario> usuarios;
        public Usuario UsuarioLogueado { get; private set; }

        public LoginWindow(List<Usuario> usuariosRecibidos)
        {
            InitializeComponent();
            this.Closing += LoginWindow_Closing;

            // Usamos la lista que viene del MainWindow
            usuarios = usuariosRecibidos;
        }

        private void LoginWindow_Closing(object sender, CancelEventArgs e)
        {
            if (!loginExitoso)
            {
                // Cierra toda la app si se cierra el login sin loguearse
                Application.Current.Shutdown();
            }
        }

        private void BtnIngresar_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Password;

            if (ValidarUsuario(usuario, password))
            {
                loginExitoso = true;
                this.DialogResult = true; // Devuelve true al MainWindow
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool ValidarUsuario(string nombre, string password)
        {
            foreach (Usuario u in usuarios)
            {
                if (u.Nombre == nombre && u.Password == password)
                {
                    UsuarioLogueado = u;
                    return true;
                }
            }
            return false;
        }

        // Guardar usuarios en archivo JSON 
        public void GuardarUsuarios(List<Usuario> usuarios)
        {
            string json = JsonSerializer.Serialize(usuarios, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("usuarios.json", json);
        }

        public List<Usuario> CargarUsuarios()
        {
            if (!File.Exists("usuarios.json"))
                return new List<Usuario>();

            string json = File.ReadAllText("usuarios.json");
            return JsonSerializer.Deserialize<List<Usuario>>(json);
        }
    }
}
