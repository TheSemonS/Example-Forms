using System.Data;

namespace FormsApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            gamesTableAdapter.Fill(dataSetGamesDb.Games);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            gamesBindingSource.EndEdit();
            gamesTableAdapter.Update(dataSetGamesDb.Games);
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            gamesTableAdapter.Fill(dataSetGamesDb.Games);
        }

        private void toolStripButtonGameInf_Click(object sender, EventArgs e)
        {
            var currentRow = gamesBindingSource.Current;
            var objectId = (currentRow as DataRowView)?.Row["Id"];
            if (objectId != null && objectId is int id)
            {
                var gameInfoForm = new FormGameInf(id);
                gameInfoForm.ShowDialog();
            }

        }
    }
}
