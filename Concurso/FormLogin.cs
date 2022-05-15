using Domain;

namespace Concurso
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario"){
                txtUser.Text = "";
                txtUser.ForeColor = Color.White;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.White;
                txtPass.UseSystemPasswordChar = true;                    
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "Usuario")
            {
                if(txtPass.Text != "Contraseña")
                {
                    UserModel user = new UserModel();
                    var validarLogin = user.LoginUser(txtUser.Text, txtPass.Text);
                    if (validarLogin == true)
                    {
                        FormHome home = new FormHome();
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MsgError("Usuario o Contraseña incorrecta. Intente nuevamente");
                        txtPass.Clear();
                        txtUser.Clear();
                        txtUser.Focus();
                    }

                }
                else
                {
                    MsgError("Por favor ingrese su contraseña");
                }
            } else
            {
                MsgError("Por favor ingrese su usuario");
            }
        }

        private void MsgError(string msg) 
        {
            labelError.Text = "   " + msg;
            labelError.Visible = true;
        }

    }
}