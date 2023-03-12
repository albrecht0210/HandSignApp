namespace HandSignApp
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
            this.create_model_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.olearn_rate_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ilearn_rate_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.oneuron_size_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hneuron_size_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ineuron_size_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.train_btn = new System.Windows.Forms.Button();
            this.epoch_num_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.alphabet_box = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.test_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.input_image_btn = new System.Windows.Forms.Button();
            this.output_show_txt = new System.Windows.Forms.TextBox();
            this.input_image = new System.Windows.Forms.PictureBox();
            this.input_image_dialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_image)).BeginInit();
            this.SuspendLayout();
            // 
            // create_model_btn
            // 
            this.create_model_btn.Location = new System.Drawing.Point(6, 167);
            this.create_model_btn.Name = "create_model_btn";
            this.create_model_btn.Size = new System.Drawing.Size(182, 30);
            this.create_model_btn.TabIndex = 4;
            this.create_model_btn.Text = "Create Model";
            this.create_model_btn.UseVisualStyleBackColor = true;
            this.create_model_btn.Click += new System.EventHandler(this.create_model_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.olearn_rate_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ilearn_rate_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.oneuron_size_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.hneuron_size_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.create_model_btn);
            this.groupBox1.Controls.Add(this.ineuron_size_txt);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Learning Rate(Out):";
            // 
            // olearn_rate_txt
            // 
            this.olearn_rate_txt.Location = new System.Drawing.Point(127, 138);
            this.olearn_rate_txt.Name = "olearn_rate_txt";
            this.olearn_rate_txt.Size = new System.Drawing.Size(61, 23);
            this.olearn_rate_txt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Learning Rate(In):";
            // 
            // ilearn_rate_txt
            // 
            this.ilearn_rate_txt.Location = new System.Drawing.Point(127, 109);
            this.ilearn_rate_txt.Name = "ilearn_rate_txt";
            this.ilearn_rate_txt.Size = new System.Drawing.Size(61, 23);
            this.ilearn_rate_txt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output Neuron:";
            // 
            // oneuron_size_txt
            // 
            this.oneuron_size_txt.Location = new System.Drawing.Point(127, 80);
            this.oneuron_size_txt.Name = "oneuron_size_txt";
            this.oneuron_size_txt.Size = new System.Drawing.Size(61, 23);
            this.oneuron_size_txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hidden Neuron:";
            // 
            // hneuron_size_txt
            // 
            this.hneuron_size_txt.Location = new System.Drawing.Point(127, 51);
            this.hneuron_size_txt.Name = "hneuron_size_txt";
            this.hneuron_size_txt.Size = new System.Drawing.Size(61, 23);
            this.hneuron_size_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Neuron:";
            // 
            // ineuron_size_txt
            // 
            this.ineuron_size_txt.Location = new System.Drawing.Point(127, 22);
            this.ineuron_size_txt.Name = "ineuron_size_txt";
            this.ineuron_size_txt.Size = new System.Drawing.Size(61, 23);
            this.ineuron_size_txt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.train_btn);
            this.groupBox2.Controls.Add(this.epoch_num_txt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.alphabet_box);
            this.groupBox2.Location = new System.Drawing.Point(18, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 191);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dataset";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Epoch:";
            // 
            // train_btn
            // 
            this.train_btn.Location = new System.Drawing.Point(6, 80);
            this.train_btn.Name = "train_btn";
            this.train_btn.Size = new System.Drawing.Size(176, 30);
            this.train_btn.TabIndex = 7;
            this.train_btn.Text = "Train";
            this.train_btn.UseVisualStyleBackColor = true;
            this.train_btn.Click += new System.EventHandler(this.train_btn_Click);
            // 
            // epoch_num_txt
            // 
            this.epoch_num_txt.Location = new System.Drawing.Point(55, 22);
            this.epoch_num_txt.Name = "epoch_num_txt";
            this.epoch_num_txt.Size = new System.Drawing.Size(127, 23);
            this.epoch_num_txt.TabIndex = 5;
            this.epoch_num_txt.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Letter: ";
            // 
            // alphabet_box
            // 
            this.alphabet_box.FormattingEnabled = true;
            this.alphabet_box.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y"});
            this.alphabet_box.Location = new System.Drawing.Point(55, 51);
            this.alphabet_box.Name = "alphabet_box";
            this.alphabet_box.Size = new System.Drawing.Size(127, 23);
            this.alphabet_box.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.test_btn);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.input_image_btn);
            this.groupBox3.Controls.Add(this.output_show_txt);
            this.groupBox3.Controls.Add(this.input_image);
            this.groupBox3.Location = new System.Drawing.Point(230, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 403);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Testing";
            // 
            // test_btn
            // 
            this.test_btn.Location = new System.Drawing.Point(87, 366);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(75, 30);
            this.test_btn.TabIndex = 9;
            this.test_btn.Text = "Test";
            this.test_btn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Letter:";
            // 
            // input_image_btn
            // 
            this.input_image_btn.Location = new System.Drawing.Point(6, 366);
            this.input_image_btn.Name = "input_image_btn";
            this.input_image_btn.Size = new System.Drawing.Size(75, 30);
            this.input_image_btn.TabIndex = 8;
            this.input_image_btn.Text = "Input";
            this.input_image_btn.UseVisualStyleBackColor = true;
            // 
            // output_show_txt
            // 
            this.output_show_txt.Location = new System.Drawing.Point(87, 206);
            this.output_show_txt.Name = "output_show_txt";
            this.output_show_txt.ReadOnly = true;
            this.output_show_txt.Size = new System.Drawing.Size(102, 23);
            this.output_show_txt.TabIndex = 10;
            // 
            // input_image
            // 
            this.input_image.Location = new System.Drawing.Point(39, 22);
            this.input_image.Name = "input_image";
            this.input_image.Size = new System.Drawing.Size(150, 150);
            this.input_image.TabIndex = 0;
            this.input_image.TabStop = false;
            // 
            // input_image_dialog
            // 
            this.input_image_dialog.Filter = "Image files|*.png|*.jpeg|*.jpg";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 428);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "  ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button create_model_btn;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox ilearn_rate_txt;
        private Label label4;
        private TextBox oneuron_size_txt;
        private Label label3;
        private TextBox hneuron_size_txt;
        private Label label1;
        private TextBox ineuron_size_txt;
        private GroupBox groupBox2;
        private Label label6;
        private Button train_btn;
        private TextBox epoch_num_txt;
        private Label label2;
        private ComboBox alphabet_box;
        private GroupBox groupBox3;
        private Label label7;
        private Button input_image_btn;
        private TextBox output_show_txt;
        private PictureBox input_image;
        private Button test_btn;
        private OpenFileDialog input_image_dialog;
        private OpenFileDialog openFileDialog2;
        private Label label8;
        private TextBox olearn_rate_txt;
        private Button button2;
        private Button button1;
    }
}