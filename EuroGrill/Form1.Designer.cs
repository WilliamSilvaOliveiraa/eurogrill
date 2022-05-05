namespace EuroGrill
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnBancoDeDados = new System.Windows.Forms.Button();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelPrincipal.Controls.Add(this.btnBancoDeDados);
            this.panelPrincipal.Controls.Add(this.btnNovoPedido);
            this.panelPrincipal.Controls.Add(this.panelForm);
            this.panelPrincipal.Controls.Add(this.btnHome);
            this.panelPrincipal.Location = new System.Drawing.Point(-2, 78);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(220, 447);
            this.panelPrincipal.TabIndex = 0;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // btnBancoDeDados
            // 
            this.btnBancoDeDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBancoDeDados.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBancoDeDados.FlatAppearance.BorderSize = 0;
            this.btnBancoDeDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBancoDeDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBancoDeDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBancoDeDados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBancoDeDados.ForeColor = System.Drawing.Color.Silver;
            this.btnBancoDeDados.Image = ((System.Drawing.Image)(resources.GetObject("btnBancoDeDados.Image")));
            this.btnBancoDeDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBancoDeDados.Location = new System.Drawing.Point(0, 144);
            this.btnBancoDeDados.Name = "btnBancoDeDados";
            this.btnBancoDeDados.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBancoDeDados.Size = new System.Drawing.Size(220, 72);
            this.btnBancoDeDados.TabIndex = 4;
            this.btnBancoDeDados.Text = "Histórico De Registros";
            this.btnBancoDeDados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBancoDeDados.UseCompatibleTextRendering = true;
            this.btnBancoDeDados.UseVisualStyleBackColor = true;
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovoPedido.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNovoPedido.FlatAppearance.BorderSize = 0;
            this.btnNovoPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnNovoPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnNovoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovoPedido.ForeColor = System.Drawing.Color.Silver;
            this.btnNovoPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoPedido.Image")));
            this.btnNovoPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoPedido.Location = new System.Drawing.Point(0, 72);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnNovoPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNovoPedido.Size = new System.Drawing.Size(220, 72);
            this.btnNovoPedido.TabIndex = 3;
            this.btnNovoPedido.Text = "Registrar Pedido";
            this.btnNovoPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNovoPedido.UseCompatibleTextRendering = true;
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.Silver;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(0, 0, 110, 0);
            this.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnHome.Size = new System.Drawing.Size(220, 72);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseCompatibleTextRendering = true;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Maroon;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(-2, -1);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(984, 81);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelForm
            // 
            this.panelForm.Location = new System.Drawing.Point(218, 3);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(766, 444);
            this.panelForm.TabIndex = 2;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForm_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(980, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelPrincipal;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Button btnHome;
        private Button btnBancoDeDados;
        private Button btnNovoPedido;
        private Panel panelForm;
        private Label label1;
    }
}