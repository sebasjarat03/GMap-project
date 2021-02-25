
namespace GMap_project
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.loadPoints = new System.Windows.Forms.Button();
            this.openTableWindow = new System.Windows.Forms.Button();
            this.clearMapButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.municipiosBox = new System.Windows.Forms.ComboBox();
            this.openChartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(468, 2);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 20;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(784, 654);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 8D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // loadPoints
            // 
            this.loadPoints.Location = new System.Drawing.Point(353, 612);
            this.loadPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadPoints.Name = "loadPoints";
            this.loadPoints.Size = new System.Drawing.Size(109, 44);
            this.loadPoints.TabIndex = 1;
            this.loadPoints.Text = "Load data";
            this.loadPoints.UseVisualStyleBackColor = true;
            this.loadPoints.Click += new System.EventHandler(this.loadPoints_Click);
            // 
            // openTableWindow
            // 
            this.openTableWindow.Location = new System.Drawing.Point(177, 612);
            this.openTableWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openTableWindow.Name = "openTableWindow";
            this.openTableWindow.Size = new System.Drawing.Size(169, 44);
            this.openTableWindow.TabIndex = 2;
            this.openTableWindow.Text = "Open table window";
            this.openTableWindow.UseVisualStyleBackColor = true;
            this.openTableWindow.Click += new System.EventHandler(this.openTableWindow_Click);
            // 
            // clearMapButton
            // 
            this.clearMapButton.Location = new System.Drawing.Point(348, 14);
            this.clearMapButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearMapButton.Name = "clearMapButton";
            this.clearMapButton.Size = new System.Drawing.Size(115, 44);
            this.clearMapButton.TabIndex = 3;
            this.clearMapButton.Text = "Clear map";
            this.clearMapButton.UseVisualStyleBackColor = true;
            this.clearMapButton.Click += new System.EventHandler(this.clearMapButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Show from:";
            // 
            // municipiosBox
            // 
            this.municipiosBox.FormattingEnabled = true;
            this.municipiosBox.Location = new System.Drawing.Point(47, 80);
            this.municipiosBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.municipiosBox.Name = "municipiosBox";
            this.municipiosBox.Size = new System.Drawing.Size(253, 24);
            this.municipiosBox.TabIndex = 5;
            this.municipiosBox.SelectedIndexChanged += new System.EventHandler(this.municipiosBox_SelectedIndexChanged);
            // 
            // openChartButton
            // 
            this.openChartButton.Location = new System.Drawing.Point(8, 612);
            this.openChartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openChartButton.Name = "openChartButton";
            this.openChartButton.Size = new System.Drawing.Size(161, 44);
            this.openChartButton.TabIndex = 6;
            this.openChartButton.Text = "Open chart reports";
            this.openChartButton.UseVisualStyleBackColor = true;
            this.openChartButton.Click += new System.EventHandler(this.openChartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 657);
            this.Controls.Add(this.openChartButton);
            this.Controls.Add(this.municipiosBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearMapButton);
            this.Controls.Add(this.openTableWindow);
            this.Controls.Add(this.loadPoints);
            this.Controls.Add(this.gMapControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button loadPoints;
        private System.Windows.Forms.Button openTableWindow;
        private System.Windows.Forms.Button clearMapButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox municipiosBox;
        private System.Windows.Forms.Button openChartButton;
    }
}

