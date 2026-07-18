using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class FormGameInf : Form
    {
        private readonly int id;

        public FormGameInf(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FormGameInf_Load(object sender, EventArgs e)
        {
            gamesTableAdapter.FillById(dataSetGamesDb.Games,id);
            // Привязываем TextBox для имени к колонке "Name" таблицы Games
            textBoxName.DataBindings.Add("Text", gamesBindingSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged);

            // Привязываем TextBox для ID к колонке "Id" таблицы Games (только для чтения, так как это автоинкремент)
            textBoxId.DataBindings.Add("Text", gamesBindingSource, "Id", true);
            textBoxId.ReadOnly = true;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
