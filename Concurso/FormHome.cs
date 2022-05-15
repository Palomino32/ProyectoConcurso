using Domain;

namespace Concurso
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();            
        }
        private void FormContenedorLoad(object sender, EventArgs e){

        }
        
        int lx, ly, sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly=this.Location.Y;
            sw=this.Size.Width;
            sh=this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void textBienveniedo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {            
            QuestionModel question = new QuestionModel();
            var q = question.Questions();

            LevelModel level = new LevelModel();
            var l = level.Levels(); 
            
            AnswerModel answer = new AnswerModel();
            var a = answer.Answers();

            foreach (var item in q)
            {
                string pregunta;
                if (item.Id == 1)
                {                    
                    pregunta = item.Pregunta;
                    this.textBienvenido.Text = pregunta;                                       
                }
            }

            foreach (var item in l)
            {
                string categoria;
                if (item.Nivel == 1)
                {
                    this.textLevel1.Visible = true;
                    categoria = item.Categoria;
                    this.textLevel1.Text = "Nivel" + item.Nivel + "," + categoria;
                }
            }
            
            foreach (var item in a)
            {
                string data;                                
                if (item.Pregunta_Id == 1)
                {
                    data = item.Respuesta.ToString();                    
                    ListBox1.Items.Add(data);
                    this.ListBox1.Visible = true;
                    
                }
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

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void OpenForm <MyForm>() where MyForm:Form, new()
        {
            Form form;
            form = panelBarraFormulario.Controls.OfType<MyForm>().FirstOrDefault();
            if (form == null)
            {
                form = new MyForm();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                panelBarraFormulario.Controls.Add(form);
                panelBarraFormulario.Tag = form;
                form.Show();
                form.BringToFront();
            }
            else
            {
                form.BringToFront();
            }
        }
       
    }
}
