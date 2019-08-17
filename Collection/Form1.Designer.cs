namespace Collection
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
            this.btnarraylist = new System.Windows.Forms.Button();
            this.btnqueue = new System.Windows.Forms.Button();
            this.btnstack = new System.Windows.Forms.Button();
            this.btnhashtable = new System.Windows.Forms.Button();
            this.btnlist = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btndictionary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnarraylist
            // 
            this.btnarraylist.Location = new System.Drawing.Point(42, 92);
            this.btnarraylist.Name = "btnarraylist";
            this.btnarraylist.Size = new System.Drawing.Size(343, 41);
            this.btnarraylist.TabIndex = 0;
            this.btnarraylist.Text = "ArrayList";
            this.btnarraylist.UseVisualStyleBackColor = true;
            this.btnarraylist.Click += new System.EventHandler(this.btnarraylist_Click);
            // 
            // btnqueue
            // 
            this.btnqueue.Location = new System.Drawing.Point(42, 139);
            this.btnqueue.Name = "btnqueue";
            this.btnqueue.Size = new System.Drawing.Size(343, 41);
            this.btnqueue.TabIndex = 1;
            this.btnqueue.Text = "Queue";
            this.btnqueue.UseVisualStyleBackColor = true;
            this.btnqueue.Click += new System.EventHandler(this.btnqueue_Click);
            // 
            // btnstack
            // 
            this.btnstack.Location = new System.Drawing.Point(42, 186);
            this.btnstack.Name = "btnstack";
            this.btnstack.Size = new System.Drawing.Size(343, 41);
            this.btnstack.TabIndex = 2;
            this.btnstack.Text = "Stack";
            this.btnstack.UseVisualStyleBackColor = true;
            this.btnstack.Click += new System.EventHandler(this.btnstack_Click);
            // 
            // btnhashtable
            // 
            this.btnhashtable.Location = new System.Drawing.Point(42, 233);
            this.btnhashtable.Name = "btnhashtable";
            this.btnhashtable.Size = new System.Drawing.Size(343, 41);
            this.btnhashtable.TabIndex = 3;
            this.btnhashtable.Text = "Hashtable";
            this.btnhashtable.UseVisualStyleBackColor = true;
            this.btnhashtable.Click += new System.EventHandler(this.btnhashtable_Click);
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(409, 91);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(306, 41);
            this.btnlist.TabIndex = 4;
            this.btnlist.Text = "List<T>";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(409, 139);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(306, 41);
            this.btn.TabIndex = 5;
            this.btn.Text = "button2";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(409, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(306, 41);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btndictionary
            // 
            this.btndictionary.Location = new System.Drawing.Point(409, 233);
            this.btndictionary.Name = "btndictionary";
            this.btndictionary.Size = new System.Drawing.Size(306, 41);
            this.btndictionary.TabIndex = 7;
            this.btndictionary.Text = "DictionalryTkey, Tvalue>";
            this.btndictionary.UseVisualStyleBackColor = true;
            this.btndictionary.Click += new System.EventHandler(this.btndictionary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Generic:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Collection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 325);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndictionary);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.btnhashtable);
            this.Controls.Add(this.btnstack);
            this.Controls.Add(this.btnqueue);
            this.Controls.Add(this.btnarraylist);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnarraylist;
        private System.Windows.Forms.Button btnqueue;
        private System.Windows.Forms.Button btnstack;
        private System.Windows.Forms.Button btnhashtable;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btndictionary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

