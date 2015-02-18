namespace Neo4jTest
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
            this.panelConnection = new System.Windows.Forms.Panel();
            this.panelQuery = new System.Windows.Forms.Panel();
            this.panelResult = new System.Windows.Forms.Panel();
            this.txtBoxCypher = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelConnection.SuspendLayout();
            this.panelQuery.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConnection
            // 
            this.panelConnection.Controls.Add(this.button2);
            this.panelConnection.Controls.Add(this.button1);
            this.panelConnection.Controls.Add(this.txtURL);
            this.panelConnection.Controls.Add(this.label1);
            this.panelConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConnection.Location = new System.Drawing.Point(0, 0);
            this.panelConnection.Name = "panelConnection";
            this.panelConnection.Size = new System.Drawing.Size(580, 48);
            this.panelConnection.TabIndex = 0;
            // 
            // panelQuery
            // 
            this.panelQuery.Controls.Add(this.txtBoxCypher);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 48);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(580, 128);
            this.panelQuery.TabIndex = 1;
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.treeView1);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult.Location = new System.Drawing.Point(0, 176);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(580, 86);
            this.panelResult.TabIndex = 2;
            // 
            // txtBoxCypher
            // 
            this.txtBoxCypher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxCypher.Location = new System.Drawing.Point(0, 0);
            this.txtBoxCypher.Name = "txtBoxCypher";
            this.txtBoxCypher.Size = new System.Drawing.Size(580, 128);
            this.txtBoxCypher.TabIndex = 0;
            this.txtBoxCypher.Text = "MATCH (people:Person)-[relatedTo]-(:Movie {title: \"Cloud Atlas\"}) \nRETURN people." +
    "name, Type(relatedTo), relatedTo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(59, 6);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(269, 20);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "http://192.168.3.18:7474/db/data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Query";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(580, 86);
            this.treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 262);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelQuery);
            this.Controls.Add(this.panelConnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelConnection.ResumeLayout(false);
            this.panelConnection.PerformLayout();
            this.panelQuery.ResumeLayout(false);
            this.panelResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConnection;
        private System.Windows.Forms.Panel panelQuery;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtBoxCypher;
        private System.Windows.Forms.TreeView treeView1;
    }
}

