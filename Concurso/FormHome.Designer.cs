namespace Concurso
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelBarraFormulario = new System.Windows.Forms.Panel();
            this.ListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textLevel1 = new System.Windows.Forms.TextBox();
            this.textBienvenido = new System.Windows.Forms.TextBox();
            this.panelBarraMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            this.panelBarraFormulario.SuspendLayout();
            this.panelBarraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelContenedor.Controls.Add(this.panelBarraFormulario);
            this.panelContenedor.Controls.Add(this.panelBarraMenu);
            this.panelContenedor.Controls.Add(this.panelBarraTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.MinimumSize = new System.Drawing.Size(650, 650);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(800, 650);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelBarraFormulario
            // 
            this.panelBarraFormulario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelBarraFormulario.Controls.Add(this.ListBox1);
            this.panelBarraFormulario.Controls.Add(this.textLevel1);
            this.panelBarraFormulario.Controls.Add(this.textBienvenido);
            this.panelBarraFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBarraFormulario.Location = new System.Drawing.Point(200, 40);
            this.panelBarraFormulario.Name = "panelBarraFormulario";
            this.panelBarraFormulario.Size = new System.Drawing.Size(600, 610);
            this.panelBarraFormulario.TabIndex = 2;
            // 
            // ListBox1
            // 
            this.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox1.CheckOnClick = true;
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(82, 185);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(436, 126);
            this.ListBox1.TabIndex = 2;
            this.ListBox1.Visible = false;
            // 
            // textLevel1
            // 
            this.textLevel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textLevel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLevel1.Font = new System.Drawing.Font("Stylus BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLevel1.Location = new System.Drawing.Point(57, 28);
            this.textLevel1.Name = "textLevel1";
            this.textLevel1.Size = new System.Drawing.Size(481, 30);
            this.textLevel1.TabIndex = 1;
            this.textLevel1.Text = "n1";
            this.textLevel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLevel1.Visible = false;
            // 
            // textBienvenido
            // 
            this.textBienvenido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBienvenido.BackColor = System.Drawing.SystemColors.Info;
            this.textBienvenido.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBienvenido.Location = new System.Drawing.Point(58, 107);
            this.textBienvenido.Name = "textBienvenido";
            this.textBienvenido.Size = new System.Drawing.Size(478, 46);
            this.textBienvenido.TabIndex = 0;
            this.textBienvenido.Text = "Bienvenido \r\nal Concurso de \r\nConocimiento.!!";
            this.textBienvenido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBienvenido.UseWaitCursor = true;
            this.textBienvenido.TextChanged += new System.EventHandler(this.textBienveniedo_TextChanged);
            // 
            // panelBarraMenu
            // 
            this.panelBarraMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelBarraMenu.Controls.Add(this.btnLogOut);
            this.panelBarraMenu.Controls.Add(this.btnInicio);
            this.panelBarraMenu.Controls.Add(this.btnResult);
            this.panelBarraMenu.Controls.Add(this.pictureBox1);
            this.panelBarraMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBarraMenu.Location = new System.Drawing.Point(0, 40);
            this.panelBarraMenu.Name = "panelBarraMenu";
            this.panelBarraMenu.Size = new System.Drawing.Size(200, 610);
            this.panelBarraMenu.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(0, 562);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(200, 26);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(52, 339);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(87, 27);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(52, 382);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(87, 29);
            this.btnResult.TabIndex = 0;
            this.btnResult.Text = "Resultado";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelBarraTitulo.Controls.Add(this.textTitulo);
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(800, 40);
            this.panelBarraTitulo.TabIndex = 0;
            // 
            // textTitulo
            // 
            this.textTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTitulo.CausesValidation = false;
            this.textTitulo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textTitulo.Location = new System.Drawing.Point(312, 9);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(231, 25);
            this.textTitulo.TabIndex = 7;
            this.textTitulo.Text = "Concurso de Conocimiento";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(754, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 0;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(780, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(754, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 0;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(728, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            this.panelContenedor.ResumeLayout(false);
            this.panelBarraFormulario.ResumeLayout(false);
            this.panelBarraFormulario.PerformLayout();
            this.panelBarraMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContenedor;
        private Panel panelBarraTitulo;
        private Panel panelBarraFormulario;
        private Panel panelBarraMenu;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private PictureBox btnRestaurar;
        private TextBox textBienvenido;
        private Button btnInicio;
        private Button btnResult;
        private PictureBox pictureBox1;
        private TextBox textTitulo;
        private Button btnLogOut;
        private TextBox textLevel1;
        private CheckedListBox ListBox1;
    }
}