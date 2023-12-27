namespace To_Do_List_Projekt_von_Sandro_und_Eray
{
    partial class Todolist
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Titeltextbox = new System.Windows.Forms.TextBox();
            this.Beschreibungtextbox = new System.Windows.Forms.TextBox();
            this.Titellbl = new System.Windows.Forms.Label();
            this.Beschreibunglbl = new System.Windows.Forms.Label();
            this.CmdNeu = new System.Windows.Forms.Button();
            this.CmdBearbeiten = new System.Windows.Forms.Button();
            this.CmdLöschen = new System.Windows.Forms.Button();
            this.CmdSpeichern = new System.Windows.Forms.Button();
            this.ToDoListView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ToDoListView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2243, 231);
            this.label1.TabIndex = 0;
            this.label1.Text = "Easy To-Do";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Titeltextbox
            // 
            this.Titeltextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titeltextbox.Location = new System.Drawing.Point(12, 306);
            this.Titeltextbox.Name = "Titeltextbox";
            this.Titeltextbox.Size = new System.Drawing.Size(2242, 44);
            this.Titeltextbox.TabIndex = 1;
            // 
            // Beschreibungtextbox
            // 
            this.Beschreibungtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Beschreibungtextbox.Location = new System.Drawing.Point(13, 397);
            this.Beschreibungtextbox.Name = "Beschreibungtextbox";
            this.Beschreibungtextbox.Size = new System.Drawing.Size(2242, 44);
            this.Beschreibungtextbox.TabIndex = 2;
            // 
            // Titellbl
            // 
            this.Titellbl.Location = new System.Drawing.Point(14, 266);
            this.Titellbl.Name = "Titellbl";
            this.Titellbl.Size = new System.Drawing.Size(2243, 37);
            this.Titellbl.TabIndex = 3;
            this.Titellbl.Text = "Titel:";
            // 
            // Beschreibunglbl
            // 
            this.Beschreibunglbl.Location = new System.Drawing.Point(12, 357);
            this.Beschreibunglbl.Name = "Beschreibunglbl";
            this.Beschreibunglbl.Size = new System.Drawing.Size(2242, 37);
            this.Beschreibunglbl.TabIndex = 4;
            this.Beschreibunglbl.Text = "Beschreibung:";
            // 
            // CmdNeu
            // 
            this.CmdNeu.BackColor = System.Drawing.Color.SteelBlue;
            this.CmdNeu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CmdNeu.Location = new System.Drawing.Point(12, 465);
            this.CmdNeu.Name = "CmdNeu";
            this.CmdNeu.Size = new System.Drawing.Size(555, 85);
            this.CmdNeu.TabIndex = 5;
            this.CmdNeu.Text = "Neu";
            this.CmdNeu.UseVisualStyleBackColor = false;
            this.CmdNeu.Click += new System.EventHandler(this.CmdNeu_Click);
            // 
            // CmdBearbeiten
            // 
            this.CmdBearbeiten.BackColor = System.Drawing.Color.Wheat;
            this.CmdBearbeiten.Location = new System.Drawing.Point(573, 465);
            this.CmdBearbeiten.Name = "CmdBearbeiten";
            this.CmdBearbeiten.Size = new System.Drawing.Size(555, 85);
            this.CmdBearbeiten.TabIndex = 6;
            this.CmdBearbeiten.Text = "Bearbeiten";
            this.CmdBearbeiten.UseVisualStyleBackColor = false;
            this.CmdBearbeiten.Click += new System.EventHandler(this.CmdBearbeiten_Click);
            // 
            // CmdLöschen
            // 
            this.CmdLöschen.BackColor = System.Drawing.Color.Salmon;
            this.CmdLöschen.Location = new System.Drawing.Point(1141, 465);
            this.CmdLöschen.Name = "CmdLöschen";
            this.CmdLöschen.Size = new System.Drawing.Size(555, 85);
            this.CmdLöschen.TabIndex = 7;
            this.CmdLöschen.Text = "Löschen";
            this.CmdLöschen.UseVisualStyleBackColor = false;
            this.CmdLöschen.Click += new System.EventHandler(this.CmdLöschen_Click);
            // 
            // CmdSpeichern
            // 
            this.CmdSpeichern.BackColor = System.Drawing.Color.YellowGreen;
            this.CmdSpeichern.Location = new System.Drawing.Point(1702, 465);
            this.CmdSpeichern.Name = "CmdSpeichern";
            this.CmdSpeichern.Size = new System.Drawing.Size(555, 85);
            this.CmdSpeichern.TabIndex = 8;
            this.CmdSpeichern.Text = "Speichern";
            this.CmdSpeichern.UseVisualStyleBackColor = false;
            this.CmdSpeichern.Click += new System.EventHandler(this.CmdSpeichern_Click);
            // 
            // ToDoListView
            // 
            this.ToDoListView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDoListView.Location = new System.Drawing.Point(13, 580);
            this.ToDoListView.Name = "ToDoListView";
            this.ToDoListView.RowHeadersWidth = 123;
            this.ToDoListView.RowTemplate.Height = 46;
            this.ToDoListView.Size = new System.Drawing.Size(2244, 653);
            this.ToDoListView.TabIndex = 9;
            // 
            // Todolist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(2287, 1250);
            this.Controls.Add(this.ToDoListView);
            this.Controls.Add(this.CmdSpeichern);
            this.Controls.Add(this.CmdLöschen);
            this.Controls.Add(this.CmdBearbeiten);
            this.Controls.Add(this.CmdNeu);
            this.Controls.Add(this.Beschreibunglbl);
            this.Controls.Add(this.Titellbl);
            this.Controls.Add(this.Beschreibungtextbox);
            this.Controls.Add(this.Titeltextbox);
            this.Controls.Add(this.label1);
            this.Name = "Todolist";
            this.Text = "To-Do List";
            this.Load += new System.EventHandler(this.Todolist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToDoListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Titeltextbox;
        private System.Windows.Forms.TextBox Beschreibungtextbox;
        private System.Windows.Forms.Label Titellbl;
        private System.Windows.Forms.Label Beschreibunglbl;
        private System.Windows.Forms.Button CmdNeu;
        private System.Windows.Forms.Button CmdBearbeiten;
        private System.Windows.Forms.Button CmdLöschen;
        private System.Windows.Forms.Button CmdSpeichern;
        private System.Windows.Forms.DataGridView ToDoListView;
    }
}

