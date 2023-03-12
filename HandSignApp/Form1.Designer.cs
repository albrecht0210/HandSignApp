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
            create_model_btn = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            olearn_rate_txt = new TextBox();
            label5 = new Label();
            ilearn_rate_txt = new TextBox();
            label3 = new Label();
            hneuron_size_txt = new TextBox();
            groupBox2 = new GroupBox();
            load_btn = new Button();
            save_btn = new Button();
            label6 = new Label();
            train_btn = new Button();
            epoch_num_txt = new TextBox();
            label2 = new Label();
            alphabet_box = new ComboBox();
            groupBox3 = new GroupBox();
            test_btn = new Button();
            label7 = new Label();
            input_image_btn = new Button();
            output_show_txt = new TextBox();
            image_display = new PictureBox();
            input_image_dialog = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image_display).BeginInit();
            SuspendLayout();
            // 
            // create_model_btn
            // 
            create_model_btn.Location = new Point(6, 109);
            create_model_btn.Name = "create_model_btn";
            create_model_btn.Size = new Size(182, 30);
            create_model_btn.TabIndex = 4;
            create_model_btn.Text = "Create Model";
            create_model_btn.UseVisualStyleBackColor = true;
            create_model_btn.Click += create_model_btn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(olearn_rate_txt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(ilearn_rate_txt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(hneuron_size_txt);
            groupBox1.Controls.Add(create_model_btn);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(194, 148);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 84);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 12;
            label8.Text = "Learning Rate(Out):";
            // 
            // olearn_rate_txt
            // 
            olearn_rate_txt.Location = new Point(127, 80);
            olearn_rate_txt.Name = "olearn_rate_txt";
            olearn_rate_txt.Size = new Size(61, 23);
            olearn_rate_txt.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 55);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 10;
            label5.Text = "Learning Rate(In):";
            // 
            // ilearn_rate_txt
            // 
            ilearn_rate_txt.Location = new Point(127, 51);
            ilearn_rate_txt.Name = "ilearn_rate_txt";
            ilearn_rate_txt.Size = new Size(61, 23);
            ilearn_rate_txt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 26);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 6;
            label3.Text = "Hidden Neuron:";
            // 
            // hneuron_size_txt
            // 
            hneuron_size_txt.Location = new Point(127, 22);
            hneuron_size_txt.Name = "hneuron_size_txt";
            hneuron_size_txt.Size = new Size(61, 23);
            hneuron_size_txt.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(load_btn);
            groupBox2.Controls.Add(save_btn);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(train_btn);
            groupBox2.Controls.Add(epoch_num_txt);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(alphabet_box);
            groupBox2.Location = new Point(12, 167);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(194, 191);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dataset";
            // 
            // load_btn
            // 
            load_btn.Location = new Point(6, 152);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(182, 30);
            load_btn.TabIndex = 14;
            load_btn.Text = "Load";
            load_btn.UseVisualStyleBackColor = true;
            load_btn.Click += load_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(6, 116);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(182, 30);
            save_btn.TabIndex = 13;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 26);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 12;
            label6.Text = "Epoch:";
            // 
            // train_btn
            // 
            train_btn.Location = new Point(6, 80);
            train_btn.Name = "train_btn";
            train_btn.Size = new Size(182, 30);
            train_btn.TabIndex = 7;
            train_btn.Text = "Train";
            train_btn.UseVisualStyleBackColor = true;
            train_btn.Click += train_btn_Click;
            // 
            // epoch_num_txt
            // 
            epoch_num_txt.Location = new Point(55, 22);
            epoch_num_txt.Name = "epoch_num_txt";
            epoch_num_txt.Size = new Size(133, 23);
            epoch_num_txt.TabIndex = 5;
            epoch_num_txt.Text = "1000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Letter: ";
            // 
            // alphabet_box
            // 
            alphabet_box.FormattingEnabled = true;
            alphabet_box.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y" });
            alphabet_box.Location = new Point(55, 51);
            alphabet_box.Name = "alphabet_box";
            alphabet_box.Size = new Size(133, 23);
            alphabet_box.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(test_btn);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(input_image_btn);
            groupBox3.Controls.Add(output_show_txt);
            groupBox3.Controls.Add(image_display);
            groupBox3.Location = new Point(230, 13);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(227, 345);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Testing";
            // 
            // test_btn
            // 
            test_btn.Location = new Point(87, 306);
            test_btn.Name = "test_btn";
            test_btn.Size = new Size(75, 30);
            test_btn.TabIndex = 9;
            test_btn.Text = "Test";
            test_btn.UseVisualStyleBackColor = true;
            test_btn.Click += test_btn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 210);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 14;
            label7.Text = "Letter:";
            // 
            // input_image_btn
            // 
            input_image_btn.Location = new Point(6, 306);
            input_image_btn.Name = "input_image_btn";
            input_image_btn.Size = new Size(75, 30);
            input_image_btn.TabIndex = 8;
            input_image_btn.Text = "Input";
            input_image_btn.UseVisualStyleBackColor = true;
            input_image_btn.Click += input_image_btn_Click;
            // 
            // output_show_txt
            // 
            output_show_txt.Location = new Point(87, 206);
            output_show_txt.Name = "output_show_txt";
            output_show_txt.ReadOnly = true;
            output_show_txt.Size = new Size(102, 23);
            output_show_txt.TabIndex = 10;
            // 
            // image_display
            // 
            image_display.Location = new Point(39, 22);
            image_display.Name = "image_display";
            image_display.Size = new Size(150, 150);
            image_display.TabIndex = 0;
            image_display.TabStop = false;
            // 
            // input_image_dialog
            // 
            input_image_dialog.Filter = "Image files|*.png|*.jpeg|*.jpg";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 370);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "  ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image_display).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button create_model_btn;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox ilearn_rate_txt;
        private Label label3;
        private TextBox hneuron_size_txt;
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
        private PictureBox image_display;
        private Button test_btn;
        private OpenFileDialog input_image_dialog;
        private OpenFileDialog openFileDialog2;
        private Label label8;
        private TextBox olearn_rate_txt;
        private Button load_btn;
        private Button save_btn;
    }
}