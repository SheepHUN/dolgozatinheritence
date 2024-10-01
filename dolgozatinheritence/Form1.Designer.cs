
namespace dolgozatinheritence
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.title = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.nametitle = new System.Windows.Forms.Label();
            this.nameinput = new System.Windows.Forms.TextBox();
            this.quantitytitle = new System.Windows.Forms.Label();
            this.pricetitle = new System.Windows.Forms.Label();
            this.quantityinput = new System.Windows.Forms.NumericUpDown();
            this.priceinput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quantityinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceinput)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 264);
            this.listBox1.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.title.Location = new System.Drawing.Point(7, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(107, 25);
            this.title.TabIndex = 1;
            this.title.Text = "PÉKÁRÚK";
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.delete.Location = new System.Drawing.Point(237, 270);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(132, 34);
            this.delete.TabIndex = 2;
            this.delete.Text = "Törlés";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.add.Location = new System.Drawing.Point(237, 229);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(132, 35);
            this.add.TabIndex = 3;
            this.add.Text = "Hozzáadás";
            this.add.UseVisualStyleBackColor = true;
            // 
            // nametitle
            // 
            this.nametitle.AutoSize = true;
            this.nametitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nametitle.Location = new System.Drawing.Point(234, 40);
            this.nametitle.Name = "nametitle";
            this.nametitle.Size = new System.Drawing.Size(88, 17);
            this.nametitle.TabIndex = 4;
            this.nametitle.Text = "Pékárú neve";
            // 
            // nameinput
            // 
            this.nameinput.Location = new System.Drawing.Point(237, 68);
            this.nameinput.Name = "nameinput";
            this.nameinput.Size = new System.Drawing.Size(132, 20);
            this.nameinput.TabIndex = 5;
            // 
            // quantitytitle
            // 
            this.quantitytitle.AutoSize = true;
            this.quantitytitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.quantitytitle.Location = new System.Drawing.Point(234, 101);
            this.quantitytitle.Name = "quantitytitle";
            this.quantitytitle.Size = new System.Drawing.Size(76, 17);
            this.quantitytitle.TabIndex = 6;
            this.quantitytitle.Text = "Mennyiség";
            // 
            // pricetitle
            // 
            this.pricetitle.AutoSize = true;
            this.pricetitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pricetitle.Location = new System.Drawing.Point(234, 165);
            this.pricetitle.Name = "pricetitle";
            this.pricetitle.Size = new System.Drawing.Size(21, 16);
            this.pricetitle.TabIndex = 8;
            this.pricetitle.Text = "Ár";
            // 
            // quantityinput
            // 
            this.quantityinput.Location = new System.Drawing.Point(237, 130);
            this.quantityinput.Name = "quantityinput";
            this.quantityinput.Size = new System.Drawing.Size(132, 20);
            this.quantityinput.TabIndex = 10;
            // 
            // priceinput
            // 
            this.priceinput.Location = new System.Drawing.Point(237, 194);
            this.priceinput.Name = "priceinput";
            this.priceinput.Size = new System.Drawing.Size(132, 20);
            this.priceinput.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 332);
            this.Controls.Add(this.priceinput);
            this.Controls.Add(this.quantityinput);
            this.Controls.Add(this.pricetitle);
            this.Controls.Add(this.quantitytitle);
            this.Controls.Add(this.nameinput);
            this.Controls.Add(this.nametitle);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.title);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.quantityinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceinput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label nametitle;
        private System.Windows.Forms.TextBox nameinput;
        private System.Windows.Forms.Label quantitytitle;
        private System.Windows.Forms.Label pricetitle;
        private System.Windows.Forms.NumericUpDown quantityinput;
        private System.Windows.Forms.NumericUpDown priceinput;
    }
}

