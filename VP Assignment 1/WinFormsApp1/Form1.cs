using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Pakistani stock companies with their respective company tax rates
        private readonly Dictionary<string, double> companies = new Dictionary<string, double>()
        {
            {"Oil & Gas Development Co. (OGDC)", 0.05},    // 5%
            {"Pakistan Petroleum Ltd. (PPL)", 0.055},      // 5.5%
            {"Habib Bank Ltd. (HBL)", 0.075},              // 7.5%
            {"Engro Corporation (ENGRO)", 0.063},          // 6.3%
            {"Lucky Cement Ltd. (LUCK)", 0.099}            // 9.9%
        };

        private ComboBox cmbCompanies;
        private TextBox txtBuyPrice;
        private TextBox txtSellPrice;
        private ComboBox cmbFilerStatus;
        private Button btnCalculate;
        private Label lblResult;

        public Form1()
        {
            InitializeComponent();
            BuildUI();
        }

        private void BuildUI()
        {
            this.Text = "Pakistan Stock Exchange ROI Finder";
            this.Size = new Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;

            Label lblTitle = new Label()
            {
                Text = "Pakistan Stock Exchange ROI Finder",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(120, 20),
                ForeColor = Color.DarkBlue
            };
            this.Controls.Add(lblTitle);

            // Company selection
            Label lblCompany = new Label()
            {
                Text = "Select Company:",
                Location = new Point(80, 100),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            this.Controls.Add(lblCompany);

            cmbCompanies = new ComboBox()
            {
                Location = new Point(250, 95),
                Width = 350,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            foreach (var c in companies.Keys)
                cmbCompanies.Items.Add(c);
            cmbCompanies.SelectedIndex = 0;
            this.Controls.Add(cmbCompanies);

            // Buy price
            Label lblBuy = new Label()
            {
                Text = "Enter Buying Price (Rs):",
                Location = new Point(80, 150),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            this.Controls.Add(lblBuy);

            txtBuyPrice = new TextBox()
            {
                Location = new Point(250, 145),
                Width = 200
            };
            this.Controls.Add(txtBuyPrice);

            // Sell price
            Label lblSell = new Label()
            {
                Text = "Enter Selling Price (Rs):",
                Location = new Point(80, 200),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            this.Controls.Add(lblSell);

            txtSellPrice = new TextBox()
            {
                Location = new Point(250, 195),
                Width = 200
            };
            this.Controls.Add(txtSellPrice);

            // Filer status
            Label lblFiler = new Label()
            {
                Text = "Select Tax Status:",
                Location = new Point(80, 250),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            this.Controls.Add(lblFiler);

            cmbFilerStatus = new ComboBox()
            {
                Location = new Point(250, 245),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbFilerStatus.Items.AddRange(new string[] { "Filer (2%)", "Non-Filer (4%)" });
            cmbFilerStatus.SelectedIndex = 0;
            this.Controls.Add(cmbFilerStatus);

            // Calculate button
            btnCalculate = new Button()
            {
                Text = "Calculate ROI",
                Location = new Point(250, 300),
                Width = 200,
                Height = 45,
                BackColor = Color.DarkBlue,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnCalculate.Click += BtnCalculate_Click;
            this.Controls.Add(btnCalculate);

            // Result label
            lblResult = new Label()
            {
                Location = new Point(80, 370),
                AutoSize = true,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.DarkGreen
            };
            this.Controls.Add(lblResult);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string company = cmbCompanies.SelectedItem.ToString();
                double buyPrice = double.Parse(txtBuyPrice.Text);
                double sellPrice = double.Parse(txtSellPrice.Text);

                double profit = sellPrice - buyPrice;
                double companyTax = companies[company];
                double govTax = cmbFilerStatus.SelectedIndex == 0 ? 0.02 : 0.04;

                if (profit <= 0)
                {
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = $"? Unfortunately, you didn’t gain any profit from {company}.\nNo tax will be charged.";
                }
                else
                {
                    double taxAmount = profit * (companyTax + govTax);
                    double netProfit = profit - taxAmount;

                    lblResult.ForeColor = Color.DarkGreen;
                    lblResult.Text = $"? Company: {company}\n" +
                                     $"Gross Profit: Rs. {profit:F2}\n" +
                                     $"Total Tax Deducted: Rs. {taxAmount:F2}\n" +
                                     $"?? Net Profit After Tax: Rs. {netProfit:F2}";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid numbers for Buy and Sell prices.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
