
namespace Auto_Configurator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.audiButton = new System.Windows.Forms.Button();
            this.vwButton = new System.Windows.Forms.Button();
            this.car = new System.Windows.Forms.PictureBox();
            this.ShowOrder = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.Button();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.TextAreaOrderHistory = new System.Windows.Forms.TextBox();
            this.label_History = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // audiButton
            // 
            this.audiButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.audiButton.Image = ((System.Drawing.Image)(resources.GetObject("audiButton.Image")));
            this.audiButton.Location = new System.Drawing.Point(11, 31);
            this.audiButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.audiButton.Name = "audiButton";
            this.audiButton.Size = new System.Drawing.Size(343, 166);
            this.audiButton.TabIndex = 0;
            this.audiButton.UseVisualStyleBackColor = true;
            this.audiButton.Click += new System.EventHandler(this.AudiButton_Click);
            // 
            // vwButton
            // 
            this.vwButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.vwButton.Image = ((System.Drawing.Image)(resources.GetObject("vwButton.Image")));
            this.vwButton.Location = new System.Drawing.Point(358, 31);
            this.vwButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.vwButton.Name = "vwButton";
            this.vwButton.Size = new System.Drawing.Size(368, 166);
            this.vwButton.TabIndex = 1;
            this.vwButton.UseVisualStyleBackColor = true;
            this.vwButton.Click += new System.EventHandler(this.VwButton_Click);
            // 
            // car
            // 
            this.car.Location = new System.Drawing.Point(532, 420);
            this.car.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(1049, 482);
            this.car.TabIndex = 2;
            this.car.TabStop = false;
            // 
            // ShowOrder
            // 
            this.ShowOrder.Font = new System.Drawing.Font("Impact", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShowOrder.Location = new System.Drawing.Point(760, 31);
            this.ShowOrder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowOrder.Name = "ShowOrder";
            this.ShowOrder.Size = new System.Drawing.Size(273, 98);
            this.ShowOrder.TabIndex = 3;
            this.ShowOrder.Text = "Afișați comanda cu numărul";
            this.ShowOrder.UseVisualStyleBackColor = true;
            this.ShowOrder.Click += new System.EventHandler(this.ShowOrder_Click);
            // 
            // Order
            // 
            this.Order.Font = new System.Drawing.Font("Impact", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Order.Location = new System.Drawing.Point(760, 161);
            this.Order.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(273, 72);
            this.Order.TabIndex = 4;
            this.Order.Text = "Comandați";
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // TextBoxID
            // 
            this.TextBoxID.Font = new System.Drawing.Font("Impact", 52.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxID.Location = new System.Drawing.Point(1038, 31);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(161, 92);
            this.TextBoxID.TabIndex = 5;
            // 
            // TextAreaOrderHistory
            // 
            this.TextAreaOrderHistory.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAreaOrderHistory.Location = new System.Drawing.Point(760, 248);
            this.TextAreaOrderHistory.Multiline = true;
            this.TextAreaOrderHistory.Name = "TextAreaOrderHistory";
            this.TextAreaOrderHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextAreaOrderHistory.Size = new System.Drawing.Size(553, 157);
            this.TextAreaOrderHistory.TabIndex = 6;
            // 
            // label_History
            // 
            this.label_History.AutoSize = true;
            this.label_History.BackColor = System.Drawing.Color.Transparent;
            this.label_History.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_History.Location = new System.Drawing.Point(628, 248);
            this.label_History.Name = "label_History";
            this.label_History.Size = new System.Drawing.Size(128, 78);
            this.label_History.TabIndex = 7;
            this.label_History.Text = "Istoric \r\nComenzi";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Maroon;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despreToolStripMenuItem,
            this.ajutorToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1443, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip";
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.despreToolStripMenuItem.Text = "Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.DespreToolStripMenuItem_Click);
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.ajutorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ajutorToolStripMenuItem.Text = "Ajutor";
            this.ajutorToolStripMenuItem.Click += new System.EventHandler(this.AjutorToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1443, 1013);
            this.Controls.Add(this.label_History);
            this.Controls.Add(this.TextAreaOrderHistory);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.ShowOrder);
            this.Controls.Add(this.car);
            this.Controls.Add(this.vwButton);
            this.Controls.Add(this.audiButton);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Auto Configurator";
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button audiButton;
        private System.Windows.Forms.Button vwButton;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.Button ShowOrder;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.TextBox TextAreaOrderHistory;
        private System.Windows.Forms.Label label_History;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
    }
}

