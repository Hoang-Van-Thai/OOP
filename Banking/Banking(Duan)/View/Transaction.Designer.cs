namespace Banking.View
{
    partial class Transaction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Save1 = new System.Windows.Forms.Button();
            this.comnhan = new System.Windows.Forms.ComboBox();
            this.tragui = new System.Windows.Forms.Label();
            this.rut = new System.Windows.Forms.Button();
            this.nap = new System.Windows.Forms.Button();
            this.combr = new System.Windows.Forms.ComboBox();
            this.trasotien = new System.Windows.Forms.TextBox();
            this.trand = new System.Windows.Forms.TextBox();
            this.trapin = new System.Windows.Forms.TextBox();
            this.tranv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewtra = new System.Windows.Forms.DataGridView();
            this.comgui = new System.Windows.Forms.ComboBox();
            this.Close = new System.Windows.Forms.Button();
            this.traid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtra)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Save1);
            this.panel1.Controls.Add(this.comnhan);
            this.panel1.Controls.Add(this.tragui);
            this.panel1.Controls.Add(this.rut);
            this.panel1.Controls.Add(this.nap);
            this.panel1.Controls.Add(this.combr);
            this.panel1.Controls.Add(this.trasotien);
            this.panel1.Controls.Add(this.trand);
            this.panel1.Controls.Add(this.trapin);
            this.panel1.Controls.Add(this.tranv);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridViewtra);
            this.panel1.Controls.Add(this.comgui);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.traid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(60, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 500);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 22);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // Save1
            // 
            this.Save1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save1.Location = new System.Drawing.Point(551, 435);
            this.Save1.Name = "Save1";
            this.Save1.Size = new System.Drawing.Size(106, 46);
            this.Save1.TabIndex = 28;
            this.Save1.Text = "Chuyển";
            this.Save1.UseVisualStyleBackColor = false;
            this.Save1.Click += new System.EventHandler(this.Save1_Click);
            // 
            // comnhan
            // 
            this.comnhan.FormattingEnabled = true;
            this.comnhan.Location = new System.Drawing.Point(589, 52);
            this.comnhan.Name = "comnhan";
            this.comnhan.Size = new System.Drawing.Size(234, 24);
            this.comnhan.TabIndex = 26;
            this.comnhan.SelectedIndexChanged += new System.EventHandler(this.comnhan_SelectedIndexChanged);
            // 
            // tragui
            // 
            this.tragui.AutoSize = true;
            this.tragui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tragui.Location = new System.Drawing.Point(34, 51);
            this.tragui.Name = "tragui";
            this.tragui.Size = new System.Drawing.Size(62, 25);
            this.tragui.TabIndex = 23;
            this.tragui.Text = "ID gửi";
            // 
            // rut
            // 
            this.rut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rut.Location = new System.Drawing.Point(265, 435);
            this.rut.Name = "rut";
            this.rut.Size = new System.Drawing.Size(96, 46);
            this.rut.TabIndex = 22;
            this.rut.Text = "Rút";
            this.rut.UseVisualStyleBackColor = true;
            this.rut.Click += new System.EventHandler(this.rut_Click_1);
            // 
            // nap
            // 
            this.nap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nap.Location = new System.Drawing.Point(400, 435);
            this.nap.Name = "nap";
            this.nap.Size = new System.Drawing.Size(96, 46);
            this.nap.TabIndex = 21;
            this.nap.Text = "Nạp";
            this.nap.UseVisualStyleBackColor = true;
            this.nap.Click += new System.EventHandler(this.nap_Click_1);
            // 
            // combr
            // 
            this.combr.FormattingEnabled = true;
            this.combr.Location = new System.Drawing.Point(176, 89);
            this.combr.Name = "combr";
            this.combr.Size = new System.Drawing.Size(234, 24);
            this.combr.TabIndex = 19;
            this.combr.SelectedIndexChanged += new System.EventHandler(this.combr_SelectedIndexChanged);
            // 
            // trasotien
            // 
            this.trasotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trasotien.Location = new System.Drawing.Point(176, 172);
            this.trasotien.Name = "trasotien";
            this.trasotien.Size = new System.Drawing.Size(234, 27);
            this.trasotien.TabIndex = 18;
            this.trasotien.TextChanged += new System.EventHandler(this.trasotien_TextChanged);
            // 
            // trand
            // 
            this.trand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trand.Location = new System.Drawing.Point(589, 127);
            this.trand.Name = "trand";
            this.trand.Size = new System.Drawing.Size(234, 27);
            this.trand.TabIndex = 17;
            this.trand.TextChanged += new System.EventHandler(this.trand_TextChanged);
            // 
            // trapin
            // 
            this.trapin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trapin.Location = new System.Drawing.Point(589, 12);
            this.trapin.Name = "trapin";
            this.trapin.Size = new System.Drawing.Size(234, 27);
            this.trapin.TabIndex = 15;
            this.trapin.TextChanged += new System.EventHandler(this.trapin_TextChanged);
            // 
            // tranv
            // 
            this.tranv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tranv.Location = new System.Drawing.Point(589, 89);
            this.tranv.Name = "tranv";
            this.tranv.Size = new System.Drawing.Size(234, 27);
            this.tranv.TabIndex = 13;
            this.tranv.TextChanged += new System.EventHandler(this.tranv_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(448, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(448, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nội dung";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Chi nhánh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày gửi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã pin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID nhận";
            // 
            // dataGridViewtra
            // 
            this.dataGridViewtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtra.Location = new System.Drawing.Point(39, 230);
            this.dataGridViewtra.Name = "dataGridViewtra";
            this.dataGridViewtra.RowHeadersWidth = 51;
            this.dataGridViewtra.RowTemplate.Height = 24;
            this.dataGridViewtra.Size = new System.Drawing.Size(784, 187);
            this.dataGridViewtra.TabIndex = 4;
            this.dataGridViewtra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtra_CellContentClick);
            // 
            // comgui
            // 
            this.comgui.FormattingEnabled = true;
            this.comgui.Location = new System.Drawing.Point(176, 52);
            this.comgui.Name = "comgui";
            this.comgui.Size = new System.Drawing.Size(234, 24);
            this.comgui.TabIndex = 3;
            this.comgui.SelectedIndexChanged += new System.EventHandler(this.comgui_SelectedIndexChanged_1);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(698, 435);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(101, 46);
            this.Close.TabIndex = 2;
            this.Close.Text = "Thoát";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // traid
            // 
            this.traid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traid.Location = new System.Drawing.Point(176, 14);
            this.traid.Name = "traid";
            this.traid.Size = new System.Drawing.Size(234, 27);
            this.traid.TabIndex = 1;
            this.traid.TextChanged += new System.EventHandler(this.traid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Banking.Properties.Resources.financial_banking_technology_concept_387612_31__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Name = "Transaction";
            this.Size = new System.Drawing.Size(982, 556);
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewtra;
        private System.Windows.Forms.ComboBox comgui;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox traid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combr;
        private System.Windows.Forms.TextBox trasotien;
        private System.Windows.Forms.TextBox trand;
        private System.Windows.Forms.TextBox tranv;
        private System.Windows.Forms.Button rut;
        private System.Windows.Forms.Button nap;
        
        private System.Windows.Forms.Label tragui;
        private System.Windows.Forms.ComboBox comnhan;
        private System.Windows.Forms.Button Save1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox trapin;
        private System.Windows.Forms.Label label3;
    }
}
