﻿namespace SistemComputadora.VISTA.ComputadoraVista
{
    partial class ComputadoraInsertarVista
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 68);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 112);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "DESCRIPCION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 166);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "PRECIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 217);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 3;
            label4.Text = "FECHA FABRICACION";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(357, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(199, 163);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(357, 23);
            textBox3.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(199, 211);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(357, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(227, 347);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(481, 347);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // ComputadoraInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ComputadoraInsertarVista";
            Text = "ComputadoraInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
    }
}