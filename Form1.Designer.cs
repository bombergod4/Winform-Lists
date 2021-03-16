namespace Winform_Lists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNewNumbers = new System.Windows.Forms.Button();
            this.btnSortNumbers = new System.Windows.Forms.Button();
            this.btnNewHeroes = new System.Windows.Forms.Button();
            this.btnSortHeroes = new System.Windows.Forms.Button();
            this.lblTitleN = new System.Windows.Forms.Label();
            this.lblTitleH = new System.Windows.Forms.Label();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lstHeroes = new System.Windows.Forms.ListBox();
            this.lblRemove = new System.Windows.Forms.Label();
            this.btnRemoveNumbers = new System.Windows.Forms.Button();
            this.btnRemoveAllNumbers = new System.Windows.Forms.Button();
            this.txtAddHero = new System.Windows.Forms.TextBox();
            this.btnAddHero = new System.Windows.Forms.Button();
            this.btnRemoveHero = new System.Windows.Forms.Button();
            this.txtRemoveHero = new System.Windows.Forms.TextBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblRemoveHero = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewNumbers
            // 
            this.btnNewNumbers.Location = new System.Drawing.Point(77, 86);
            this.btnNewNumbers.Name = "btnNewNumbers";
            this.btnNewNumbers.Size = new System.Drawing.Size(87, 31);
            this.btnNewNumbers.TabIndex = 0;
            this.btnNewNumbers.Text = "New List";
            this.btnNewNumbers.UseVisualStyleBackColor = true;
            this.btnNewNumbers.Click += new System.EventHandler(this.btnNewNumbers_Click);
            // 
            // btnSortNumbers
            // 
            this.btnSortNumbers.Location = new System.Drawing.Point(184, 86);
            this.btnSortNumbers.Name = "btnSortNumbers";
            this.btnSortNumbers.Size = new System.Drawing.Size(87, 31);
            this.btnSortNumbers.TabIndex = 1;
            this.btnSortNumbers.Text = "Sort";
            this.btnSortNumbers.UseVisualStyleBackColor = true;
            this.btnSortNumbers.Click += new System.EventHandler(this.btnSortNumbers_Click);
            // 
            // btnNewHeroes
            // 
            this.btnNewHeroes.Location = new System.Drawing.Point(323, 86);
            this.btnNewHeroes.Name = "btnNewHeroes";
            this.btnNewHeroes.Size = new System.Drawing.Size(87, 31);
            this.btnNewHeroes.TabIndex = 2;
            this.btnNewHeroes.Text = "New List";
            this.btnNewHeroes.UseVisualStyleBackColor = true;
            this.btnNewHeroes.Click += new System.EventHandler(this.btnNewHeroes_Click);
            // 
            // btnSortHeroes
            // 
            this.btnSortHeroes.Location = new System.Drawing.Point(431, 86);
            this.btnSortHeroes.Name = "btnSortHeroes";
            this.btnSortHeroes.Size = new System.Drawing.Size(87, 31);
            this.btnSortHeroes.TabIndex = 3;
            this.btnSortHeroes.Text = "Sort";
            this.btnSortHeroes.UseVisualStyleBackColor = true;
            this.btnSortHeroes.Click += new System.EventHandler(this.btnSortHeroes_Click);
            // 
            // lblTitleN
            // 
            this.lblTitleN.AutoSize = true;
            this.lblTitleN.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleN.Location = new System.Drawing.Point(74, 50);
            this.lblTitleN.Name = "lblTitleN";
            this.lblTitleN.Size = new System.Drawing.Size(98, 29);
            this.lblTitleN.TabIndex = 4;
            this.lblTitleN.Text = "Numbers";
            // 
            // lblTitleH
            // 
            this.lblTitleH.AutoSize = true;
            this.lblTitleH.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitleH.Location = new System.Drawing.Point(320, 50);
            this.lblTitleH.Name = "lblTitleH";
            this.lblTitleH.Size = new System.Drawing.Size(81, 29);
            this.lblTitleH.TabIndex = 5;
            this.lblTitleH.Text = "Heroes";
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(77, 132);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(194, 121);
            this.lstNumbers.TabIndex = 6;
            // 
            // lstHeroes
            // 
            this.lstHeroes.FormattingEnabled = true;
            this.lstHeroes.Location = new System.Drawing.Point(323, 132);
            this.lstHeroes.Name = "lstHeroes";
            this.lstHeroes.Size = new System.Drawing.Size(194, 121);
            this.lstHeroes.TabIndex = 7;
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.Location = new System.Drawing.Point(74, 276);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(197, 20);
            this.lblRemove.TabIndex = 8;
            this.lblRemove.Text = "Select a number to remove:";
            // 
            // btnRemoveNumbers
            // 
            this.btnRemoveNumbers.Location = new System.Drawing.Point(77, 303);
            this.btnRemoveNumbers.Name = "btnRemoveNumbers";
            this.btnRemoveNumbers.Size = new System.Drawing.Size(87, 31);
            this.btnRemoveNumbers.TabIndex = 10;
            this.btnRemoveNumbers.Text = "Remove";
            this.btnRemoveNumbers.UseVisualStyleBackColor = true;
            this.btnRemoveNumbers.Click += new System.EventHandler(this.btnRemoveNumbers_Click);
            // 
            // btnRemoveAllNumbers
            // 
            this.btnRemoveAllNumbers.Location = new System.Drawing.Point(184, 303);
            this.btnRemoveAllNumbers.Name = "btnRemoveAllNumbers";
            this.btnRemoveAllNumbers.Size = new System.Drawing.Size(87, 31);
            this.btnRemoveAllNumbers.TabIndex = 11;
            this.btnRemoveAllNumbers.Text = "Remove All";
            this.btnRemoveAllNumbers.UseVisualStyleBackColor = true;
            this.btnRemoveAllNumbers.Click += new System.EventHandler(this.btnRemoveAllNumbers_Click);
            // 
            // txtAddHero
            // 
            this.txtAddHero.Location = new System.Drawing.Point(323, 314);
            this.txtAddHero.Name = "txtAddHero";
            this.txtAddHero.Size = new System.Drawing.Size(100, 20);
            this.txtAddHero.TabIndex = 12;
            // 
            // btnAddHero
            // 
            this.btnAddHero.Location = new System.Drawing.Point(431, 314);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(87, 20);
            this.btnAddHero.TabIndex = 13;
            this.btnAddHero.Text = "Add";
            this.btnAddHero.UseVisualStyleBackColor = true;
            this.btnAddHero.Click += new System.EventHandler(this.btnAddHero_Click);
            // 
            // btnRemoveHero
            // 
            this.btnRemoveHero.Location = new System.Drawing.Point(431, 404);
            this.btnRemoveHero.Name = "btnRemoveHero";
            this.btnRemoveHero.Size = new System.Drawing.Size(87, 20);
            this.btnRemoveHero.TabIndex = 17;
            this.btnRemoveHero.Text = "Remove";
            this.btnRemoveHero.UseVisualStyleBackColor = true;
            this.btnRemoveHero.Click += new System.EventHandler(this.btnRemoveHero_Click);
            // 
            // txtRemoveHero
            // 
            this.txtRemoveHero.Location = new System.Drawing.Point(323, 404);
            this.txtRemoveHero.Name = "txtRemoveHero";
            this.txtRemoveHero.Size = new System.Drawing.Size(100, 20);
            this.txtRemoveHero.TabIndex = 16;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(319, 276);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(187, 20);
            this.lblAdd.TabIndex = 18;
            this.lblAdd.Text = "Enter a hero name to add:";
            // 
            // lblRemoveHero
            // 
            this.lblRemoveHero.AutoSize = true;
            this.lblRemoveHero.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveHero.Location = new System.Drawing.Point(319, 366);
            this.lblRemoveHero.Name = "lblRemoveHero";
            this.lblRemoveHero.Size = new System.Drawing.Size(210, 20);
            this.lblRemoveHero.TabIndex = 19;
            this.lblRemoveHero.Text = "Enter a hero name to remove:";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(2, 337);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(298, 104);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblRemoveHero);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnRemoveHero);
            this.Controls.Add(this.txtRemoveHero);
            this.Controls.Add(this.btnAddHero);
            this.Controls.Add(this.txtAddHero);
            this.Controls.Add(this.btnRemoveAllNumbers);
            this.Controls.Add(this.btnRemoveNumbers);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lstHeroes);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.lblTitleH);
            this.Controls.Add(this.lblTitleN);
            this.Controls.Add(this.btnSortHeroes);
            this.Controls.Add(this.btnNewHeroes);
            this.Controls.Add(this.btnSortNumbers);
            this.Controls.Add(this.btnNewNumbers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Using Lists within forms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewNumbers;
        private System.Windows.Forms.Button btnSortNumbers;
        private System.Windows.Forms.Button btnNewHeroes;
        private System.Windows.Forms.Button btnSortHeroes;
        private System.Windows.Forms.Label lblTitleN;
        private System.Windows.Forms.Label lblTitleH;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.ListBox lstHeroes;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Button btnRemoveNumbers;
        private System.Windows.Forms.Button btnRemoveAllNumbers;
        private System.Windows.Forms.TextBox txtAddHero;
        private System.Windows.Forms.Button btnAddHero;
        private System.Windows.Forms.Button btnRemoveHero;
        private System.Windows.Forms.TextBox txtRemoveHero;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblRemoveHero;
        private System.Windows.Forms.Label lblStatus;
    }
}

