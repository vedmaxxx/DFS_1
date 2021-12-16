﻿namespace RGR
{
    partial class DFS_Form
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
            this.sheet = new System.Windows.Forms.PictureBox();
            this.Btn_drawVert = new System.Windows.Forms.Button();
            this.Btn_drawEdge = new System.Windows.Forms.Button();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.listBox_Matrix = new System.Windows.Forms.ListBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.btn_BFS = new System.Windows.Forms.Button();
            this.startVert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DFS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Matrix_lbl = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // sheet
            // 
            this.sheet.Location = new System.Drawing.Point(9, 12);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(490, 319);
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // Btn_drawVert
            // 
            this.Btn_drawVert.Location = new System.Drawing.Point(99, 348);
            this.Btn_drawVert.Name = "Btn_drawVert";
            this.Btn_drawVert.Size = new System.Drawing.Size(100, 39);
            this.Btn_drawVert.TabIndex = 1;
            this.Btn_drawVert.Text = "Нарисовать вершины";
            this.Btn_drawVert.UseVisualStyleBackColor = true;
            this.Btn_drawVert.Click += new System.EventHandler(this.Btn_drawVert_Click);
            // 
            // Btn_drawEdge
            // 
            this.Btn_drawEdge.Location = new System.Drawing.Point(205, 348);
            this.Btn_drawEdge.Name = "Btn_drawEdge";
            this.Btn_drawEdge.Size = new System.Drawing.Size(100, 39);
            this.Btn_drawEdge.TabIndex = 2;
            this.Btn_drawEdge.Text = "Нарисовать ребра";
            this.Btn_drawEdge.UseVisualStyleBackColor = true;
            this.Btn_drawEdge.Click += new System.EventHandler(this.Btn_drawEdge_Click);
            // 
            // Btn_delete
            // 
            this.Btn_delete.Location = new System.Drawing.Point(311, 348);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(100, 39);
            this.Btn_delete.TabIndex = 3;
            this.Btn_delete.Text = "Удалить объект";
            this.Btn_delete.UseVisualStyleBackColor = true;
            this.Btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(11, 348);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(82, 39);
            this.btn_Select.TabIndex = 4;
            this.btn_Select.Text = "Отмена";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // listBox_Matrix
            // 
            this.listBox_Matrix.FormattingEnabled = true;
            this.listBox_Matrix.HorizontalScrollbar = true;
            this.listBox_Matrix.Location = new System.Drawing.Point(555, 24);
            this.listBox_Matrix.Name = "listBox_Matrix";
            this.listBox_Matrix.Size = new System.Drawing.Size(271, 225);
            this.listBox_Matrix.TabIndex = 5;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(555, 364);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(248, 20);
            this.resultBox.TabIndex = 6;
            // 
            // btn_BFS
            // 
            this.btn_BFS.Location = new System.Drawing.Point(18, 450);
            this.btn_BFS.Name = "btn_BFS";
            this.btn_BFS.Size = new System.Drawing.Size(62, 39);
            this.btn_BFS.TabIndex = 7;
            this.btn_BFS.Text = "Поиск в ширину";
            this.btn_BFS.UseVisualStyleBackColor = true;
            this.btn_BFS.Visible = false;
            this.btn_BFS.Click += new System.EventHandler(this.BFS);
            // 
            // startVert
            // 
            this.startVert.Location = new System.Drawing.Point(713, 268);
            this.startVert.Name = "startVert";
            this.startVert.Size = new System.Drawing.Size(31, 20);
            this.startVert.TabIndex = 8;
            this.startVert.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите начальную вершину:";
            // 
            // btn_DFS
            // 
            this.btn_DFS.Location = new System.Drawing.Point(555, 292);
            this.btn_DFS.Name = "btn_DFS";
            this.btn_DFS.Size = new System.Drawing.Size(61, 39);
            this.btn_DFS.TabIndex = 10;
            this.btn_DFS.Text = "Поиск в глубину";
            this.btn_DFS.UseVisualStyleBackColor = true;
            this.btn_DFS.Click += new System.EventHandler(this.DFS);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Результат:";
            // 
            // listBox_Matrix_lbl
            // 
            this.listBox_Matrix_lbl.AutoSize = true;
            this.listBox_Matrix_lbl.Location = new System.Drawing.Point(552, 9);
            this.listBox_Matrix_lbl.Name = "listBox_Matrix_lbl";
            this.listBox_Matrix_lbl.Size = new System.Drawing.Size(111, 13);
            this.listBox_Matrix_lbl.TabIndex = 21;
            this.listBox_Matrix_lbl.Text = "Матрица смежности";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(205, 407);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Задать вес ребра:";
            // 
            // DFS_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 502);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox_Matrix_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_DFS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startVert);
            this.Controls.Add(this.btn_BFS);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.listBox_Matrix);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.Btn_delete);
            this.Controls.Add(this.Btn_drawEdge);
            this.Controls.Add(this.Btn_drawVert);
            this.Controls.Add(this.sheet);
            this.Name = "DFS_Form";
            this.Text = "DFS";
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.Button Btn_drawVert;
        private System.Windows.Forms.Button Btn_drawEdge;
        private System.Windows.Forms.Button Btn_delete;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.ListBox listBox_Matrix;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button btn_BFS;
        private System.Windows.Forms.TextBox startVert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DFS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label listBox_Matrix_lbl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
    }
}

