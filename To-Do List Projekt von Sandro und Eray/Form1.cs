using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_Projekt_von_Sandro_und_Eray
{
    public partial class Todolist : Form
    {
        public Todolist()
        {
            InitializeComponent();
        }

        DataTable ToDoList = new DataTable();
        bool istBearbeitung = false;
        private void Todolist_Load(object sender, EventArgs e)
        {
            // Erstelle column
            ToDoList.Columns.Add("Titel");
            ToDoList.Columns.Add("Beschreibung");

            // Bringt datagridview zu datenquelle
            ToDoListView.DataSource = ToDoList;
        }

        private void CmdNeu_Click(object sender, EventArgs e)
        {
            Titeltextbox.Text = "";
            Beschreibungtextbox.Text = "";
        }

        private void CmdBearbeiten_Click(object sender, EventArgs e)
        {
            istBearbeitung = true;
            // füll Text felder mit daten von Table
            Titeltextbox.Text = ToDoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            Beschreibungtextbox.Text = ToDoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void CmdLöschen_Click(object sender, EventArgs e)
        {
            try
            {
                ToDoList.Rows[ToDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            { 
                Console.WriteLine("Error" + ex); 
            }
        }

        private void CmdSpeichern_Click(object sender, EventArgs e)
        {
            if (istBearbeitung)
            {
                ToDoList.Rows[ToDoListView.CurrentCell.RowIndex]["Titel"] = Titeltextbox.Text;
                ToDoList.Rows[ToDoListView.CurrentCell.RowIndex]["Beschreibung"] = Beschreibungtextbox.Text;
            }
            else
            {
                ToDoList.Rows.Add(Titeltextbox.Text, Beschreibungtextbox.Text);
            }
            // Leert nachher alle Felder Nach dem Speichern
            Titeltextbox.Text = "";
            Beschreibungtextbox.Text = "";
            istBearbeitung = false;
        }
    }
}
