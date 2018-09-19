namespace SnowBurn
{
    partial class frmBurn
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboModeloMCU = new System.Windows.Forms.ComboBox();
            this.btnBurn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPortaSerial = new System.Windows.Forms.ComboBox();
            this.ofdHexFile = new System.Windows.Forms.OpenFileDialog();
            this.spBurn = new System.IO.Ports.SerialPort(this.components);
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnSelecionarHex = new System.Windows.Forms.Button();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Arquivo Hex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Modelo MCU";
            // 
            // cboModeloMCU
            // 
            this.cboModeloMCU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModeloMCU.FormattingEnabled = true;
            this.cboModeloMCU.Location = new System.Drawing.Point(172, 25);
            this.cboModeloMCU.Name = "cboModeloMCU";
            this.cboModeloMCU.Size = new System.Drawing.Size(117, 21);
            this.cboModeloMCU.TabIndex = 13;
            this.cboModeloMCU.SelectedIndexChanged += new System.EventHandler(this.cboModeloMCU_SelectedIndexChanged);
            // 
            // btnBurn
            // 
            this.btnBurn.Location = new System.Drawing.Point(576, 138);
            this.btnBurn.Name = "btnBurn";
            this.btnBurn.Size = new System.Drawing.Size(117, 38);
            this.btnBurn.TabIndex = 12;
            this.btnBurn.Text = "Burn, Baby, Burn";
            this.btnBurn.UseVisualStyleBackColor = true;
            this.btnBurn.Click += new System.EventHandler(this.Burn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Porta Serial";
            // 
            // cboPortaSerial
            // 
            this.cboPortaSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPortaSerial.FormattingEnabled = true;
            this.cboPortaSerial.Location = new System.Drawing.Point(12, 25);
            this.cboPortaSerial.Name = "cboPortaSerial";
            this.cboPortaSerial.Size = new System.Drawing.Size(117, 21);
            this.cboPortaSerial.TabIndex = 10;
            this.cboPortaSerial.SelectedIndexChanged += new System.EventHandler(this.cboPortaSerial_SelectedIndexChanged);
            // 
            // spBurn
            // 
            this.spBurn.BaudRate = 19200;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(15, 182);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(678, 222);
            this.txtOutput.TabIndex = 18;
            // 
            // btnSelecionarHex
            // 
            this.btnSelecionarHex.Location = new System.Drawing.Point(382, 52);
            this.btnSelecionarHex.Name = "btnSelecionarHex";
            this.btnSelecionarHex.Size = new System.Drawing.Size(93, 50);
            this.btnSelecionarHex.TabIndex = 17;
            this.btnSelecionarHex.Text = "Selecionar HEX";
            this.btnSelecionarHex.UseVisualStyleBackColor = true;
            this.btnSelecionarHex.Click += new System.EventHandler(this.SelecionarHex_Click);
            // 
            // txtHex
            // 
            this.txtHex.Enabled = false;
            this.txtHex.Location = new System.Drawing.Point(382, 26);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(311, 20);
            this.txtHex.TabIndex = 16;
            // 
            // frmBurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboModeloMCU);
            this.Controls.Add(this.btnBurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPortaSerial);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnSelecionarHex);
            this.Controls.Add(this.txtHex);
            this.Name = "frmBurn";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboModeloMCU;
        private System.Windows.Forms.Button btnBurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPortaSerial;
        private System.Windows.Forms.OpenFileDialog ofdHexFile;
        private System.IO.Ports.SerialPort spBurn;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnSelecionarHex;
        private System.Windows.Forms.TextBox txtHex;
    }
}

