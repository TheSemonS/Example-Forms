namespace FormsApp
{
    partial class FormGameInf
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
            components = new System.ComponentModel.Container();
            textBoxName = new TextBox();
            textBoxId = new TextBox();
            labelId = new Label();
            labelName = new Label();
            buttonClose = new Button();
            dataSetGamesDb = new DataSetGamesDb();
            gamesTableAdapter = new FormsApp.DataSetGamesDbTableAdapters.GamesTableAdapter();
            gamesBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataSetGamesDb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gamesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(60, 61);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(299, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(60, 30);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(75, 23);
            textBoxId.TabIndex = 1;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(34, 33);
            labelId.Name = "labelId";
            labelId.Size = new Size(20, 15);
            labelId.TabIndex = 2;
            labelId.Text = "Id:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 64);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 15);
            labelName.TabIndex = 3;
            labelName.Text = "Name:";
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClose.Location = new Point(414, 136);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
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
            // gamesBindingSource
            // 
            gamesBindingSource.DataMember = "Games";
            gamesBindingSource.DataSource = dataSetGamesDb;
            // 
            // FormGameInf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 171);
            Controls.Add(buttonClose);
            Controls.Add(labelName);
            Controls.Add(labelId);
            Controls.Add(textBoxId);
            Controls.Add(textBoxName);
            Name = "FormGameInf";
            Text = "FormGameInf";
            Load += FormGameInf_Load;
            ((System.ComponentModel.ISupportInitialize)dataSetGamesDb).EndInit();
            ((System.ComponentModel.ISupportInitialize)gamesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxId;
        private Label labelId;
        private Label labelName;
        private Button buttonClose;
        private DataSetGamesDb dataSetGamesDb;
        private DataSetGamesDbTableAdapters.GamesTableAdapter gamesTableAdapter;
        private BindingSource gamesBindingSource;
    }
}