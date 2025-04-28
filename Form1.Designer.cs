namespace Assignment_4._1._1
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mobilePhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            workPhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            personBindingSource = new BindingSource(components);
            splitContainerMain = new SplitContainer();
            splitContainer2 = new SplitContainer();
            buttonNewContact = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            addTextBoxAddress = new TextBox();
            addTextBoxWork = new TextBox();
            addTextBoxMobile = new TextBox();
            addTextBoxLastName = new TextBox();
            addTextBoxFirstName = new TextBox();
            buttonFindPerson = new Button();
            NameLabel = new Label();
            searchTextBoxName = new TextBox();
            removeCheckBox = new CheckBox();
            buttonRemove = new Button();
            removeTextBoxName = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, mobilePhoneDataGridViewTextBoxColumn, workPhoneDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, Id });
            dataGridView1.DataSource = personBindingSource;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(596, 420);
            dataGridView1.TabIndex = 0;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // mobilePhoneDataGridViewTextBoxColumn
            // 
            mobilePhoneDataGridViewTextBoxColumn.DataPropertyName = "MobilePhone";
            mobilePhoneDataGridViewTextBoxColumn.HeaderText = "MobilePhone";
            mobilePhoneDataGridViewTextBoxColumn.Name = "mobilePhoneDataGridViewTextBoxColumn";
            // 
            // workPhoneDataGridViewTextBoxColumn
            // 
            workPhoneDataGridViewTextBoxColumn.DataPropertyName = "WorkPhone";
            workPhoneDataGridViewTextBoxColumn.HeaderText = "WorkPhone";
            workPhoneDataGridViewTextBoxColumn.Name = "workPhoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "GUID";
            Id.Name = "Id";
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Person);
            // 
            // splitContainerMain
            // 
            splitContainerMain.Location = new Point(12, 12);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(splitContainer2);
            splitContainerMain.Size = new Size(776, 426);
            splitContainerMain.SplitterDistance = 602;
            splitContainerMain.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(buttonNewContact);
            splitContainer2.Panel1.Controls.Add(label5);
            splitContainer2.Panel1.Controls.Add(label4);
            splitContainer2.Panel1.Controls.Add(label3);
            splitContainer2.Panel1.Controls.Add(label2);
            splitContainer2.Panel1.Controls.Add(label1);
            splitContainer2.Panel1.Controls.Add(addTextBoxAddress);
            splitContainer2.Panel1.Controls.Add(addTextBoxWork);
            splitContainer2.Panel1.Controls.Add(addTextBoxMobile);
            splitContainer2.Panel1.Controls.Add(addTextBoxLastName);
            splitContainer2.Panel1.Controls.Add(addTextBoxFirstName);
            splitContainer2.Panel1.Controls.Add(buttonFindPerson);
            splitContainer2.Panel1.Controls.Add(NameLabel);
            splitContainer2.Panel1.Controls.Add(searchTextBoxName);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(removeCheckBox);
            splitContainer2.Panel2.Controls.Add(buttonRemove);
            splitContainer2.Panel2.Controls.Add(removeTextBoxName);
            splitContainer2.Panel2.Controls.Add(label6);
            splitContainer2.Size = new Size(170, 426);
            splitContainer2.SplitterDistance = 248;
            splitContainer2.TabIndex = 0;
            // 
            // buttonNewContact
            // 
            buttonNewContact.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNewContact.Location = new Point(87, 221);
            buttonNewContact.Name = "buttonNewContact";
            buttonNewContact.Size = new Size(83, 23);
            buttonNewContact.TabIndex = 13;
            buttonNewContact.Text = "New/Update";
            buttonNewContact.UseVisualStyleBackColor = true;
            buttonNewContact.Click += NewContactEvent;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(20, 195);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 12;
            label5.Text = "Address";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(12, 166);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 11;
            label4.Text = "Work No.";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 137);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 10;
            label3.Text = "Mobile No.";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(6, 108);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 9;
            label2.Text = "Last Name";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(6, 79);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 8;
            label1.Text = "First Name";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // addTextBoxAddress
            // 
            addTextBoxAddress.Location = new Point(70, 192);
            addTextBoxAddress.Name = "addTextBoxAddress";
            addTextBoxAddress.Size = new Size(100, 23);
            addTextBoxAddress.TabIndex = 7;
            // 
            // addTextBoxWork
            // 
            addTextBoxWork.Location = new Point(70, 163);
            addTextBoxWork.Name = "addTextBoxWork";
            addTextBoxWork.Size = new Size(100, 23);
            addTextBoxWork.TabIndex = 6;
            // 
            // addTextBoxMobile
            // 
            addTextBoxMobile.Location = new Point(70, 134);
            addTextBoxMobile.Name = "addTextBoxMobile";
            addTextBoxMobile.Size = new Size(100, 23);
            addTextBoxMobile.TabIndex = 5;
            // 
            // addTextBoxLastName
            // 
            addTextBoxLastName.Location = new Point(70, 105);
            addTextBoxLastName.Name = "addTextBoxLastName";
            addTextBoxLastName.Size = new Size(100, 23);
            addTextBoxLastName.TabIndex = 4;
            // 
            // addTextBoxFirstName
            // 
            addTextBoxFirstName.Location = new Point(70, 76);
            addTextBoxFirstName.Name = "addTextBoxFirstName";
            addTextBoxFirstName.Size = new Size(100, 23);
            addTextBoxFirstName.TabIndex = 3;
            // 
            // buttonFindPerson
            // 
            buttonFindPerson.Location = new Point(87, 32);
            buttonFindPerson.Name = "buttonFindPerson";
            buttonFindPerson.Size = new Size(83, 23);
            buttonFindPerson.TabIndex = 2;
            buttonFindPerson.Text = "Find Person";
            buttonFindPerson.UseVisualStyleBackColor = true;
            buttonFindPerson.Click += FindPersonEvent;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(3, 6);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(61, 15);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Full Name";
            // 
            // searchTextBoxName
            // 
            searchTextBoxName.Location = new Point(70, 3);
            searchTextBoxName.Name = "searchTextBoxName";
            searchTextBoxName.Size = new Size(100, 23);
            searchTextBoxName.TabIndex = 0;
            // 
            // removeCheckBox
            // 
            removeCheckBox.AutoSize = true;
            removeCheckBox.Location = new Point(49, 37);
            removeCheckBox.Name = "removeCheckBox";
            removeCheckBox.Size = new Size(15, 14);
            removeCheckBox.TabIndex = 15;
            removeCheckBox.UseVisualStyleBackColor = true;
            removeCheckBox.CheckStateChanged += ConfirmDelete;
            // 
            // buttonRemove
            // 
            buttonRemove.Enabled = false;
            buttonRemove.Font = new Font("Segoe UI", 8F);
            buttonRemove.Location = new Point(67, 32);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(100, 23);
            buttonRemove.TabIndex = 14;
            buttonRemove.Text = "Remove Contact";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += RemoveContactEvent;
            // 
            // removeTextBoxName
            // 
            removeTextBoxName.Location = new Point(67, 3);
            removeTextBoxName.Name = "removeTextBoxName";
            removeTextBoxName.Size = new Size(100, 23);
            removeTextBoxName.TabIndex = 14;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 6);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 2;
            label6.Text = "Full Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainerMain);
            Name = "Form1";
            Text = "Assignment 4.1.1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource personBindingSource;
        private SplitContainer splitContainerMain;
        private SplitContainer splitContainer2;
        private Label NameLabel;
        private TextBox searchTextBoxName;
        private Button buttonFindPerson;
        private TextBox addTextBoxLastName;
        private TextBox addTextBoxFirstName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox addTextBoxAddress;
        private TextBox addTextBoxWork;
        private TextBox addTextBoxMobile;
        private Button buttonNewContact;
        private Button buttonRemove;
        private TextBox removeTextBoxName;
        private Label label6;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mobilePhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Id;
        private CheckBox removeCheckBox;
    }
}
