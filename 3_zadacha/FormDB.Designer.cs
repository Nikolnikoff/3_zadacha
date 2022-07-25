
namespace _3_zadacha
{
    partial class FormDB
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtv_db = new System.Windows.Forms.DataGridView();
            this.button_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_db)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv_db
            // 
            this.dtv_db.AllowUserToAddRows = false;
            this.dtv_db.AllowUserToDeleteRows = false;
            this.dtv_db.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtv_db.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_db.Location = new System.Drawing.Point(0, 12);
            this.dtv_db.Name = "dtv_db";
            this.dtv_db.ReadOnly = true;
            this.dtv_db.Size = new System.Drawing.Size(704, 386);
            this.dtv_db.TabIndex = 0;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(573, 424);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(119, 25);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "СТОП";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_obn_Click);
            // 
            // FormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 461);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.dtv_db);
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "FormDB";
            this.Text = "Задача_№3";
            this.Load += new System.EventHandler(this.FormDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_db)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv_db;
        private System.Windows.Forms.Button button_close;
    }
}

