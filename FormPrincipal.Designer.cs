
namespace BidirectionalCommunicationCasparCG
{
    partial class FormPrincipal
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
            this.tableLayoutPanel_base = new System.Windows.Forms.TableLayoutPanel();
            this.label_data = new System.Windows.Forms.Label();
            this.tableLayoutPanel_bottom = new System.Windows.Forms.TableLayoutPanel();
            this.button_loadTemplate = new System.Windows.Forms.Button();
            this.button_inGame = new System.Windows.Forms.Button();
            this.button_playGame = new System.Windows.Forms.Button();
            this.button_updateTime = new System.Windows.Forms.Button();
            this.button_solveGame = new System.Windows.Forms.Button();
            this.button_openCaspar = new System.Windows.Forms.Button();
            this.tableLayoutPanel_base.SuspendLayout();
            this.tableLayoutPanel_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_base
            // 
            this.tableLayoutPanel_base.ColumnCount = 3;
            this.tableLayoutPanel_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel_base.Controls.Add(this.label_data, 0, 1);
            this.tableLayoutPanel_base.Controls.Add(this.tableLayoutPanel_bottom, 0, 2);
            this.tableLayoutPanel_base.Controls.Add(this.button_openCaspar, 0, 0);
            this.tableLayoutPanel_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_base.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_base.Name = "tableLayoutPanel_base";
            this.tableLayoutPanel_base.RowCount = 3;
            this.tableLayoutPanel_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel_base.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel_base.TabIndex = 0;
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.tableLayoutPanel_base.SetColumnSpan(this.label_data, 3);
            this.label_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data.Location = new System.Drawing.Point(3, 60);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(794, 330);
            this.label_data.TabIndex = 2;
            this.label_data.Text = "€";
            this.label_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_bottom
            // 
            this.tableLayoutPanel_bottom.ColumnCount = 5;
            this.tableLayoutPanel_base.SetColumnSpan(this.tableLayoutPanel_bottom, 3);
            this.tableLayoutPanel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_bottom.Controls.Add(this.button_loadTemplate, 0, 0);
            this.tableLayoutPanel_bottom.Controls.Add(this.button_inGame, 1, 0);
            this.tableLayoutPanel_bottom.Controls.Add(this.button_playGame, 2, 0);
            this.tableLayoutPanel_bottom.Controls.Add(this.button_updateTime, 3, 0);
            this.tableLayoutPanel_bottom.Controls.Add(this.button_solveGame, 4, 0);
            this.tableLayoutPanel_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_bottom.Location = new System.Drawing.Point(3, 393);
            this.tableLayoutPanel_bottom.Name = "tableLayoutPanel_bottom";
            this.tableLayoutPanel_bottom.RowCount = 1;
            this.tableLayoutPanel_bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_bottom.Size = new System.Drawing.Size(794, 54);
            this.tableLayoutPanel_bottom.TabIndex = 1;
            // 
            // button_loadTemplate
            // 
            this.button_loadTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_loadTemplate.Location = new System.Drawing.Point(3, 3);
            this.button_loadTemplate.Name = "button_loadTemplate";
            this.button_loadTemplate.Size = new System.Drawing.Size(152, 48);
            this.button_loadTemplate.TabIndex = 0;
            this.button_loadTemplate.Text = "Load Template";
            this.button_loadTemplate.UseVisualStyleBackColor = true;
            this.button_loadTemplate.Click += new System.EventHandler(this.button_loadTemplate_Click);
            // 
            // button_inGame
            // 
            this.button_inGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_inGame.Location = new System.Drawing.Point(161, 3);
            this.button_inGame.Name = "button_inGame";
            this.button_inGame.Size = new System.Drawing.Size(152, 48);
            this.button_inGame.TabIndex = 1;
            this.button_inGame.Text = "In Game";
            this.button_inGame.UseVisualStyleBackColor = true;
            this.button_inGame.Click += new System.EventHandler(this.button_inGame_Click);
            // 
            // button_playGame
            // 
            this.button_playGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_playGame.Location = new System.Drawing.Point(319, 3);
            this.button_playGame.Name = "button_playGame";
            this.button_playGame.Size = new System.Drawing.Size(152, 48);
            this.button_playGame.TabIndex = 2;
            this.button_playGame.Text = "Play game";
            this.button_playGame.UseVisualStyleBackColor = true;
            this.button_playGame.Click += new System.EventHandler(this.button_playGame_Click);
            // 
            // button_updateTime
            // 
            this.button_updateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_updateTime.Location = new System.Drawing.Point(477, 3);
            this.button_updateTime.Name = "button_updateTime";
            this.button_updateTime.Size = new System.Drawing.Size(152, 48);
            this.button_updateTime.TabIndex = 3;
            this.button_updateTime.Text = "Update Time";
            this.button_updateTime.UseVisualStyleBackColor = true;
            this.button_updateTime.Click += new System.EventHandler(this.button_updateTime_Click);
            // 
            // button_solveGame
            // 
            this.button_solveGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_solveGame.Location = new System.Drawing.Point(635, 3);
            this.button_solveGame.Name = "button_solveGame";
            this.button_solveGame.Size = new System.Drawing.Size(156, 48);
            this.button_solveGame.TabIndex = 4;
            this.button_solveGame.Text = "Solve Game";
            this.button_solveGame.UseVisualStyleBackColor = true;
            this.button_solveGame.Click += new System.EventHandler(this.button_solveGame_Click);
            // 
            // button_openCaspar
            // 
            this.tableLayoutPanel_base.SetColumnSpan(this.button_openCaspar, 3);
            this.button_openCaspar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_openCaspar.Location = new System.Drawing.Point(3, 3);
            this.button_openCaspar.Name = "button_openCaspar";
            this.button_openCaspar.Size = new System.Drawing.Size(794, 54);
            this.button_openCaspar.TabIndex = 0;
            this.button_openCaspar.Text = "Open CasparCG";
            this.button_openCaspar.UseVisualStyleBackColor = true;
            this.button_openCaspar.Click += new System.EventHandler(this.button_openCaspar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel_base);
            this.Name = "FormPrincipal";
            this.Text = "Two-way communication";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.tableLayoutPanel_base.ResumeLayout(false);
            this.tableLayoutPanel_base.PerformLayout();
            this.tableLayoutPanel_bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_base;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_bottom;
        private System.Windows.Forms.Button button_solveGame;
        private System.Windows.Forms.Button button_playGame;
        private System.Windows.Forms.Button button_inGame;
        private System.Windows.Forms.Button button_loadTemplate;
        private System.Windows.Forms.Button button_updateTime;
        private System.Windows.Forms.Button button_openCaspar;
    }
}

