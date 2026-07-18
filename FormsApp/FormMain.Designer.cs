namespace FormsApp
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gamesBindingSource = new BindingSource(components);
            dataSetGamesDb = new DataSetGamesDb();
            gamesTableAdapter = new FormsApp.DataSetGamesDbTableAdapters.GamesTableAdapter();
            toolStrip1 = new ToolStrip();
            toolStripButtonSave = new ToolStripButton();
            toolStripButtonRefresh = new ToolStripButton();
            toolStripButtonGameInf = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gamesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSetGamesDb).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dataGridView2.DataSource = gamesBindingSource;
            dataGridView2.Location = new Point(12, 28);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(445, 463);
            dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // gamesBindingSource
            // 
            gamesBindingSource.DataMember = "Games";
            gamesBindingSource.DataSource = dataSetGamesDb;
            // 
            // dataSetGamesDb
            // 
            dataSetGamesDb.DataSetName = "DataSetGamesDb";
            dataSetGamesDb.Namespace = "http://tempuri.org/DataSetGamesDb.xsd";
            dataSetGamesDb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamesTableAdapter
            // 
            gamesTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonSave, toolStripButtonRefresh, toolStripButtonGameInf });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(474, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSave.Image = (Image)resources.GetObject("toolStripButtonSave.Image");
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(23, 22);
            toolStripButtonSave.Text = "Save";
            toolStripButtonSave.Click += toolStripButtonSave_Click;
            // 
            // toolStripButtonRefresh
            // 
            toolStripButtonRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRefresh.Image = (Image)resources.GetObject("toolStripButtonRefresh.Image");
            toolStripButtonRefresh.ImageTransparentColor = Color.Magenta;
            toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            toolStripButtonRefresh.Size = new Size(23, 22);
            toolStripButtonRefresh.Text = "Refresh";
            toolStripButtonRefresh.Click += toolStripButtonRefresh_Click;
            // 
            // toolStripButtonGameInf
            // 
            toolStripButtonGameInf.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonGameInf.Image = (Image)resources.GetObject("toolStripButtonGameInf.Image");
            toolStripButtonGameInf.ImageTransparentColor = Color.Magenta;
            toolStripButtonGameInf.Name = "toolStripButtonGameInf";
            toolStripButtonGameInf.Size = new Size(23, 22);
            toolStripButtonGameInf.Text = "GameInf";
            toolStripButtonGameInf.Click += toolStripButtonGameInf_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 507);
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView2);
            Name = "FormMain";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gamesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSetGamesDb).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView2;
        private DataSetGamesDb dataSetGamesDb;
        private BindingSource gamesBindingSource;
        private DataSetGamesDbTableAdapters.GamesTableAdapter gamesTableAdapter;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonSave;
        private ToolStripButton toolStripButtonRefresh;
        private ToolStripButton toolStripButtonGameInf;
    }
}
