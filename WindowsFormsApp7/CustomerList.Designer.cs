namespace WindowsFormsApp7
{
    partial class CustomerList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmogrenci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmtam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmgozluk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmogrenci,
            this.clmtam,
            this.clmgozluk,
            this.clmmenu});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // clmogrenci
            // 
            this.clmogrenci.HeaderText = "Öğrenci";
            this.clmogrenci.Name = "clmogrenci";
            // 
            // clmtam
            // 
            this.clmtam.HeaderText = "Tam";
            this.clmtam.Name = "clmtam";
            // 
            // clmgozluk
            // 
            this.clmgozluk.HeaderText = "Gözlük";
            this.clmgozluk.Name = "clmgozluk";
            // 
            // clmmenu
            // 
            this.clmmenu.HeaderText = "Menü";
            this.clmmenu.Name = "clmmenu";
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerList";
            this.Text = "CustomerList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmogrenci;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmtam;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmgozluk;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmenu;
    }
}