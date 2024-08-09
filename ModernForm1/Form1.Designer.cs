namespace ModernForm1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.pic_Color = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btn_rect);
            this.panel1.Controls.Add(this.btn_ellipse);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.pic_Color);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_line);
            this.panel1.Controls.Add(this.btn_eraser);
            this.panel1.Controls.Add(this.btn_pencil);
            this.panel1.Controls.Add(this.btn_fill);
            this.panel1.Controls.Add(this.btn_color);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 661);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("CaptainMarvel", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_save.Location = new System.Drawing.Point(-45, 629);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(243, 32);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // pic_Color
            // 
            this.pic_Color.FlatAppearance.BorderSize = 0;
            this.pic_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pic_Color.Font = new System.Drawing.Font("CaptainMarvel", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pic_Color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pic_Color.Location = new System.Drawing.Point(-7, 594);
            this.pic_Color.Name = "pic_Color";
            this.pic_Color.Size = new System.Drawing.Size(195, 29);
            this.pic_Color.TabIndex = 1;
            this.pic_Color.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.pic_Color.UseVisualStyleBackColor = true;
            this.pic_Color.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.color_picker);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 252);
            this.panel2.TabIndex = 0;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(186, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(848, 661);
            this.pic.TabIndex = 4;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // btn_rect
            // 
            this.btn_rect.FlatAppearance.BorderSize = 0;
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.Font = new System.Drawing.Font("CaptainMarvel", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_rect.Image = global::ModernForm1.Properties.Resources.rectangle_16dp_FFFFFF_FILL0_wght400_GRAD0_opsz20;
            this.btn_rect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_rect.Location = new System.Drawing.Point(0, 470);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(186, 40);
            this.btn_rect.TabIndex = 1;
            this.btn_rect.Text = "Rectangle  ";
            this.btn_rect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_rect.UseVisualStyleBackColor = true;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            this.btn_rect.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.FlatAppearance.BorderSize = 0;
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.Font = new System.Drawing.Font("CaptainMarvel", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ellipse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_ellipse.Image = global::ModernForm1.Properties.Resources.radio_button_unchecked_16dp_FFFFFF_FILL0_wght400_GRAD0_opsz20;
            this.btn_ellipse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ellipse.Location = new System.Drawing.Point(0, 420);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(186, 44);
            this.btn_ellipse.TabIndex = 1;
            this.btn_ellipse.Text = "Ellipse";
            this.btn_ellipse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_ellipse.UseVisualStyleBackColor = true;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            this.btn_ellipse.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // btn_clear
            // 
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("CaptainMarvel", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_clear.Image = global::ModernForm1.Properties.Resources.disabled_by_default_31dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            this.btn_clear.Location = new System.Drawing.Point(0, 548);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(213, 40);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear       ";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            this.btn_clear.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // btn_line
            // 
            this.btn_line.FlatAppearance.BorderSize = 0;
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.Font = new System.Drawing.Font("CaptainMarvel", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_line.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_line.Image = global::ModernForm1.Properties.Resources.pen_size_1_16dp_FFFFFF_FILL0_wght400_GRAD0_opsz20;
            this.btn_line.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_line.Location = new System.Drawing.Point(4, 516);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(184, 26);
            this.btn_line.TabIndex = 1;
            this.btn_line.Text = "Line";
            this.btn_line.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            this.btn_line.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // btn_eraser
            // 
            this.btn_eraser.FlatAppearance.BorderSize = 0;
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.Font = new System.Drawing.Font("CaptainMarvel", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eraser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_eraser.Image = global::ModernForm1.Properties.Resources.ink_eraser_16dp_FFFFFF_FILL0_wght400_GRAD0_opsz20;
            this.btn_eraser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eraser.Location = new System.Drawing.Point(0, 382);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(186, 32);
            this.btn_eraser.TabIndex = 1;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_eraser.UseVisualStyleBackColor = true;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            this.btn_eraser.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // btn_pencil
            // 
            this.btn_pencil.FlatAppearance.BorderSize = 0;
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.Font = new System.Drawing.Font("CaptainMarvel", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pencil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_pencil.Image = global::ModernForm1.Properties.Resources.draw_16dp_FFFFFF_FILL0_wght400_GRAD0_opsz201;
            this.btn_pencil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pencil.Location = new System.Drawing.Point(0, 338);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(186, 38);
            this.btn_pencil.TabIndex = 1;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_pencil.UseVisualStyleBackColor = true;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            this.btn_pencil.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // btn_fill
            // 
            this.btn_fill.FlatAppearance.BorderSize = 0;
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.Font = new System.Drawing.Font("CaptainMarvel", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_fill.Image = global::ModernForm1.Properties.Resources.format_color_fill_16dp_FFFFFF_FILL0_wght400_GRAD0_opsz201;
            this.btn_fill.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_fill.Location = new System.Drawing.Point(0, 299);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(186, 31);
            this.btn_fill.TabIndex = 1;
            this.btn_fill.Text = "Fill";
            this.btn_fill.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            this.btn_fill.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // btn_color
            // 
            this.btn_color.FlatAppearance.BorderSize = 0;
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.Font = new System.Drawing.Font("CaptainMarvel", 9.749999F);
            this.btn_color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_color.Image = global::ModernForm1.Properties.Resources.palette_21dp_FFFFFF_FILL0_wght400_GRAD0_opsz20;
            this.btn_color.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_color.Location = new System.Drawing.Point(0, 258);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(186, 35);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Color";
            this.btn_color.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            this.btn_color.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // color_picker
            // 
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.color_picker.Image = global::ModernForm1.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(0, 0);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(186, 252);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 0;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PainT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Button pic_Color;
        private System.Windows.Forms.PictureBox pic;
    }
}

