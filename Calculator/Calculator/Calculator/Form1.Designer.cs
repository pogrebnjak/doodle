﻿namespace Calculator
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Multiply = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Substraction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.Logarithm = new System.Windows.Forms.Button();
            this.Sinus = new System.Windows.Forms.Button();
            this.Squaring = new System.Windows.Forms.Button();
            this.Module = new System.Windows.Forms.Button();
            this.Cube = new System.Windows.Forms.Button();
            this.Root = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.Arctangent = new System.Windows.Forms.Button();
            this.RootCube = new System.Windows.Forms.Button();
            this.Indicative = new System.Windows.Forms.Button();
            this.Exponent = new System.Windows.Forms.Button();
            this.Arcsine = new System.Windows.Forms.Button();
            this.Arccosine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(4, 344);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(12, 61);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(44, 44);
            this.Multiply.TabIndex = 3;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.button1_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(74, 61);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(46, 44);
            this.Division.TabIndex = 4;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(138, 61);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(44, 44);
            this.Add.TabIndex = 5;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Substraction
            // 
            this.Substraction.Location = new System.Drawing.Point(204, 61);
            this.Substraction.Name = "Substraction";
            this.Substraction.Size = new System.Drawing.Size(44, 44);
            this.Substraction.TabIndex = 6;
            this.Substraction.Text = "-";
            this.Substraction.UseVisualStyleBackColor = true;
            this.Substraction.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "first digit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "second digit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "answer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            this.eventLog1.EntryWritten += new System.Diagnostics.EntryWrittenEventHandler(this.eventLog1_EntryWritten);
            // 
            // Logarithm
            // 
            this.Logarithm.Location = new System.Drawing.Point(12, 111);
            this.Logarithm.Name = "Logarithm";
            this.Logarithm.Size = new System.Drawing.Size(44, 43);
            this.Logarithm.TabIndex = 10;
            this.Logarithm.Text = "log";
            this.Logarithm.UseVisualStyleBackColor = true;
            this.Logarithm.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Sinus
            // 
            this.Sinus.Location = new System.Drawing.Point(74, 111);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(46, 43);
            this.Sinus.TabIndex = 11;
            this.Sinus.Text = "sin";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Squaring
            // 
            this.Squaring.Location = new System.Drawing.Point(138, 111);
            this.Squaring.Name = "Squaring";
            this.Squaring.Size = new System.Drawing.Size(44, 43);
            this.Squaring.TabIndex = 12;
            this.Squaring.Text = "x^2";
            this.Squaring.UseVisualStyleBackColor = true;
            this.Squaring.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Module
            // 
            this.Module.Location = new System.Drawing.Point(204, 112);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(44, 42);
            this.Module.TabIndex = 13;
            this.Module.Text = "mod";
            this.Module.UseVisualStyleBackColor = true;
            this.Module.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Cube
            // 
            this.Cube.Location = new System.Drawing.Point(12, 160);
            this.Cube.Name = "Cube";
            this.Cube.Size = new System.Drawing.Size(44, 43);
            this.Cube.TabIndex = 14;
            this.Cube.Text = "X^3";
            this.Cube.UseVisualStyleBackColor = true;
            this.Cube.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Root
            // 
            this.Root.Location = new System.Drawing.Point(74, 160);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(44, 43);
            this.Root.TabIndex = 15;
            this.Root.Text = "Root";
            this.Root.UseVisualStyleBackColor = true;
            this.Root.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(138, 160);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(44, 43);
            this.log.TabIndex = 16;
            this.log.Text = "Log";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.button1_Click);
            // 
            // Arctangent
            // 
            this.Arctangent.Location = new System.Drawing.Point(204, 160);
            this.Arctangent.Name = "Arctangent";
            this.Arctangent.Size = new System.Drawing.Size(44, 43);
            this.Arctangent.TabIndex = 17;
            this.Arctangent.Text = "Arctan";
            this.Arctangent.UseVisualStyleBackColor = true;
            this.Arctangent.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // RootCube
            // 
            this.RootCube.Location = new System.Drawing.Point(13, 209);
            this.RootCube.Name = "RootCube";
            this.RootCube.Size = new System.Drawing.Size(44, 43);
            this.RootCube.TabIndex = 18;
            this.RootCube.Text = "x^(1/y)";
            this.RootCube.UseVisualStyleBackColor = true;
            this.RootCube.Click += new System.EventHandler(this.button1_Click);
            // 
            // Indicative
            // 
            this.Indicative.Location = new System.Drawing.Point(16, 258);
            this.Indicative.Name = "Indicative";
            this.Indicative.Size = new System.Drawing.Size(44, 43);
            this.Indicative.TabIndex = 21;
            this.Indicative.Text = "Indicative";
            this.Indicative.UseVisualStyleBackColor = true;
            this.Indicative.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Exponent
            // 
            this.Exponent.Location = new System.Drawing.Point(204, 209);
            this.Exponent.Name = "Exponent";
            this.Exponent.Size = new System.Drawing.Size(44, 43);
            this.Exponent.TabIndex = 22;
            this.Exponent.Text = "Exponent";
            this.Exponent.UseVisualStyleBackColor = true;
            this.Exponent.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Arcsine
            // 
            this.Arcsine.Location = new System.Drawing.Point(138, 209);
            this.Arcsine.Name = "Arcsine";
            this.Arcsine.Size = new System.Drawing.Size(44, 43);
            this.Arcsine.TabIndex = 23;
            this.Arcsine.Text = "Arcsine";
            this.Arcsine.UseVisualStyleBackColor = true;
            this.Arcsine.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Arccosine
            // 
            this.Arccosine.Location = new System.Drawing.Point(74, 209);
            this.Arccosine.Name = "Arccosine";
            this.Arccosine.Size = new System.Drawing.Size(44, 43);
            this.Arccosine.TabIndex = 24;
            this.Arccosine.Text = "Arccosine";
            this.Arccosine.UseVisualStyleBackColor = true;
            this.Arccosine.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 376);
            this.Controls.Add(this.Arccosine);
            this.Controls.Add(this.Arcsine);
            this.Controls.Add(this.Exponent);
            this.Controls.Add(this.Indicative);
            this.Controls.Add(this.RootCube);
            this.Controls.Add(this.Arctangent);
            this.Controls.Add(this.log);
            this.Controls.Add(this.Root);
            this.Controls.Add(this.Cube);
            this.Controls.Add(this.Module);
            this.Controls.Add(this.Squaring);
            this.Controls.Add(this.Sinus);
            this.Controls.Add(this.Logarithm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Substraction);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Substraction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button Module;
        private System.Windows.Forms.Button Squaring;
        private System.Windows.Forms.Button Sinus;
        private System.Windows.Forms.Button Logarithm;
        private System.Windows.Forms.Button Cube;
        private System.Windows.Forms.Button Root;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button Arctangent;
        private System.Windows.Forms.Button RootCube;
        private System.Windows.Forms.Button Arccosine;
        private System.Windows.Forms.Button Arcsine;
        private System.Windows.Forms.Button Exponent;
        private System.Windows.Forms.Button Indicative;
    }
}

