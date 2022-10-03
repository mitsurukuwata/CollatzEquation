
namespace _3x_1UI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.jsonSaveBtn = new System.Windows.Forms.Button();
            this.loadJson = new System.Windows.Forms.Button();
            this.jsonPathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plusNumbers = new System.Windows.Forms.Label();
            this.minesNumbers = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pathFinder = new System.Windows.Forms.Button();
            this.pathText = new System.Windows.Forms.Label();
            this.settingBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.avarageMinesLabel = new System.Windows.Forms.Label();
            this.standardDeviationMinesLabel = new System.Windows.Forms.Label();
            this.avarageLabel = new System.Windows.Forms.Label();
            this.standarDeviationLabel = new System.Windows.Forms.Label();
            this.SpecialBtn = new System.Windows.Forms.RadioButton();
            this.SameEquation = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(23, 6);
            this.chart1.Name = "chart1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Number";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "M.Numbers";
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(1492, 738);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(23, 865);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(112, 20);
            this.numberBox.TabIndex = 1;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(148, 864);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(229, 864);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // jsonSaveBtn
            // 
            this.jsonSaveBtn.Location = new System.Drawing.Point(369, 863);
            this.jsonSaveBtn.Name = "jsonSaveBtn";
            this.jsonSaveBtn.Size = new System.Drawing.Size(95, 23);
            this.jsonSaveBtn.TabIndex = 4;
            this.jsonSaveBtn.Text = "Save as Json";
            this.jsonSaveBtn.UseVisualStyleBackColor = true;
            this.jsonSaveBtn.Click += new System.EventHandler(this.jsonSaveBtn_Click);
            // 
            // loadJson
            // 
            this.loadJson.Location = new System.Drawing.Point(470, 863);
            this.loadJson.Name = "loadJson";
            this.loadJson.Size = new System.Drawing.Size(83, 23);
            this.loadJson.TabIndex = 5;
            this.loadJson.Text = "Load Json";
            this.loadJson.UseVisualStyleBackColor = true;
            this.loadJson.Click += new System.EventHandler(this.loadJson_Click);
            // 
            // jsonPathBox
            // 
            this.jsonPathBox.Location = new System.Drawing.Point(559, 866);
            this.jsonPathBox.Name = "jsonPathBox";
            this.jsonPathBox.Size = new System.Drawing.Size(127, 20);
            this.jsonPathBox.TabIndex = 6;
            this.jsonPathBox.Text = "Folder Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numbers : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "(+) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(137, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "(-) :";
            // 
            // plusNumbers
            // 
            this.plusNumbers.AutoSize = true;
            this.plusNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plusNumbers.Location = new System.Drawing.Point(8, 72);
            this.plusNumbers.Name = "plusNumbers";
            this.plusNumbers.Size = new System.Drawing.Size(0, 15);
            this.plusNumbers.TabIndex = 14;
            // 
            // minesNumbers
            // 
            this.minesNumbers.AutoSize = true;
            this.minesNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minesNumbers.Location = new System.Drawing.Point(140, 72);
            this.minesNumbers.Name = "minesNumbers";
            this.minesNumbers.Size = new System.Drawing.Size(0, 15);
            this.minesNumbers.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minesNumbers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.plusNumbers);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1521, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 738);
            this.panel1.TabIndex = 16;
            // 
            // pathFinder
            // 
            this.pathFinder.Location = new System.Drawing.Point(692, 866);
            this.pathFinder.Name = "pathFinder";
            this.pathFinder.Size = new System.Drawing.Size(75, 20);
            this.pathFinder.TabIndex = 17;
            this.pathFinder.Text = "Select Path";
            this.pathFinder.UseVisualStyleBackColor = true;
            this.pathFinder.Click += new System.EventHandler(this.pathFinder_Click);
            // 
            // pathText
            // 
            this.pathText.AutoSize = true;
            this.pathText.Location = new System.Drawing.Point(773, 870);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(38, 13);
            this.pathText.TabIndex = 18;
            this.pathText.Text = "Path : ";
            // 
            // settingBtn
            // 
            this.settingBtn.Location = new System.Drawing.Point(1653, 865);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(75, 23);
            this.settingBtn.TabIndex = 19;
            this.settingBtn.Text = "Settings";
            this.settingBtn.UseVisualStyleBackColor = true;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.avarageMinesLabel);
            this.panel2.Controls.Add(this.standardDeviationMinesLabel);
            this.panel2.Controls.Add(this.avarageLabel);
            this.panel2.Controls.Add(this.standarDeviationLabel);
            this.panel2.Location = new System.Drawing.Point(23, 751);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1492, 100);
            this.panel2.TabIndex = 20;
            // 
            // avarageMinesLabel
            // 
            this.avarageMinesLabel.AutoSize = true;
            this.avarageMinesLabel.Location = new System.Drawing.Point(6, 80);
            this.avarageMinesLabel.Name = "avarageMinesLabel";
            this.avarageMinesLabel.Size = new System.Drawing.Size(68, 13);
            this.avarageMinesLabel.TabIndex = 3;
            this.avarageMinesLabel.Text = "Avarage (-) : ";
            // 
            // standardDeviationMinesLabel
            // 
            this.standardDeviationMinesLabel.AutoSize = true;
            this.standardDeviationMinesLabel.Location = new System.Drawing.Point(6, 58);
            this.standardDeviationMinesLabel.Name = "standardDeviationMinesLabel";
            this.standardDeviationMinesLabel.Size = new System.Drawing.Size(119, 13);
            this.standardDeviationMinesLabel.TabIndex = 2;
            this.standardDeviationMinesLabel.Text = "Standard Deviation (-) : ";
            // 
            // avarageLabel
            // 
            this.avarageLabel.AutoSize = true;
            this.avarageLabel.Location = new System.Drawing.Point(6, 33);
            this.avarageLabel.Name = "avarageLabel";
            this.avarageLabel.Size = new System.Drawing.Size(71, 13);
            this.avarageLabel.TabIndex = 1;
            this.avarageLabel.Text = "Avarage (+) : ";
            // 
            // standarDeviationLabel
            // 
            this.standarDeviationLabel.AutoSize = true;
            this.standarDeviationLabel.Location = new System.Drawing.Point(6, 11);
            this.standarDeviationLabel.Name = "standarDeviationLabel";
            this.standarDeviationLabel.Size = new System.Drawing.Size(122, 13);
            this.standarDeviationLabel.TabIndex = 0;
            this.standarDeviationLabel.Text = "Standard Deviation (+) : ";
            // 
            // SpecialBtn
            // 
            this.SpecialBtn.AutoSize = true;
            this.SpecialBtn.Checked = true;
            this.SpecialBtn.Location = new System.Drawing.Point(1525, 758);
            this.SpecialBtn.Name = "SpecialBtn";
            this.SpecialBtn.Size = new System.Drawing.Size(195, 17);
            this.SpecialBtn.TabIndex = 21;
            this.SpecialBtn.TabStop = true;
            this.SpecialBtn.Text = "Special Equation For Negative(3x-1)";
            this.SpecialBtn.UseVisualStyleBackColor = true;
            // 
            // SameEquation
            // 
            this.SameEquation.AutoSize = true;
            this.SameEquation.Location = new System.Drawing.Point(1525, 781);
            this.SameEquation.Name = "SameEquation";
            this.SameEquation.Size = new System.Drawing.Size(190, 17);
            this.SameEquation.TabIndex = 22;
            this.SameEquation.Text = "Same Equation For Negative(3x+1)";
            this.SameEquation.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1525, 803);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "Enter Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1761, 894);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SameEquation);
            this.Controls.Add(this.SpecialBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.pathFinder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.jsonPathBox);
            this.Controls.Add(this.loadJson);
            this.Controls.Add(this.jsonSaveBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3X+1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button jsonSaveBtn;
        private System.Windows.Forms.Button loadJson;
        private System.Windows.Forms.TextBox jsonPathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label plusNumbers;
        private System.Windows.Forms.Label minesNumbers;
        private System.Windows.Forms.Button pathFinder;
        private System.Windows.Forms.Label pathText;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label avarageLabel;
        private System.Windows.Forms.Label standarDeviationLabel;
        private System.Windows.Forms.Label avarageMinesLabel;
        private System.Windows.Forms.Label standardDeviationMinesLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton SpecialBtn;
        private System.Windows.Forms.RadioButton SameEquation;
        private System.Windows.Forms.TextBox textBox1;
    }
}

