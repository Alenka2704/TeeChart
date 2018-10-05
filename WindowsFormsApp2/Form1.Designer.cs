namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
			this.tChart1 = new Steema.TeeChart.TChart();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// tChart1
			// 
			this.tChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.tChart1.Aspect.ColorPaletteIndex = 20;
			this.tChart1.Aspect.View3D = false;
			// 
			// 
			// 
			this.tChart1.Axes.Automatic = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Grid.DrawEvery = 2;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart1.Axes.Bottom.Labels.Font.Size = 9;
			this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
			this.tChart1.Axes.Bottom.Labels.MultiLine = true;
			this.tChart1.Axes.Bottom.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
			this.tChart1.Axes.Bottom.Labels.ValueFormat = "dd.MM.yyyy HH:mm";
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart1.Axes.Bottom.Title.Font.Size = 11;
			this.tChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Labels.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Labels.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Grid.DrawEvery = 2;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
			this.tChart1.Axes.Left.Labels.Font.Size = 9;
			this.tChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart1.Axes.Left.Title.Font.Size = 11;
			this.tChart1.Axes.Left.Title.Font.SizeFloat = 11F;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart1.Axes.Right.Labels.Font.Size = 9;
			this.tChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart1.Axes.Top.Labels.Font.Size = 9;
			this.tChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
			this.tChart1.Axes.Top.Labels.Visible = false;
			this.tChart1.CurrentTheme = Steema.TeeChart.ThemeType.Report;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Gray;
			this.tChart1.Header.Font.Size = 12;
			this.tChart1.Header.Font.SizeFloat = 12F;
			this.tChart1.Header.Lines = new string[] {
        ""};
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tChart1.Legend.Font.Size = 9;
			this.tChart1.Legend.Font.SizeFloat = 9F;
			// 
			// 
			// 
			this.tChart1.Legend.Shadow.Visible = false;
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(12, 34);
			this.tChart1.Name = "tChart1";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Gradient.Visible = false;
			this.tChart1.Panel.MarginUnits = Steema.TeeChart.PanelMarginUnits.Pixels;
			this.tChart1.Size = new System.Drawing.Size(776, 404);
			this.tChart1.TabIndex = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Back.Brush.Visible = false;
			this.tChart1.Walls.Back.Visible = false;
			// 
			// checkBox1
			// 
			this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(12, 432);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(74, 17);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "Smoothed";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.tChart1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Steema.TeeChart.TChart tChart1;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}

