using System.Windows.Forms;
using System.Drawing;

namespace NetworkRequestApplication
{
    partial class MainPage
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
            this.networkRequestLabel = new System.Windows.Forms.Label();
            this.userdetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.userdetailsPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.richAddressTextBox = new System.Windows.Forms.RichTextBox();
            this.groupResident = new System.Windows.Forms.GroupBox();
            this.residentLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.indianPanel = new System.Windows.Forms.Panel();
            this.permanentAddressLabel = new System.Windows.Forms.Label();
            this.richPermanentAddressTextbox = new System.Windows.Forms.RichTextBox();
            this.nriPanel = new System.Windows.Forms.Panel();
            this.passportNumberLabel = new System.Windows.Forms.Label();
            this.passportNumberTextbox = new System.Windows.Forms.TextBox();
            this.localStayAddressLabel = new System.Windows.Forms.Label();
            this.richLocalStayAddressTextbox = new System.Windows.Forms.RichTextBox();
            this.othersPanel = new System.Windows.Forms.Panel();
            this.visaNumberLabel = new System.Windows.Forms.Label();
            this.visaNumberTextbox = new System.Windows.Forms.TextBox();
            this.nationalityLabel = new System.Windows.Forms.Label();
            this.nationalityTextbox = new System.Windows.Forms.TextBox();
            this.scrollablePanel = new System.Windows.Forms.Panel();
            this.bigButton = new System.Windows.Forms.Button();
            this.serviceGroup = new System.Windows.Forms.GroupBox();
            this.servicePanel = new System.Windows.Forms.Panel();
            this.connectionTypeGroup = new System.Windows.Forms.GroupBox();
            this.newConnectionPanel = new System.Windows.Forms.Panel();
            this.newConnExpectedPrizeTextbox = new System.Windows.Forms.TextBox();
            this.newConnExpectedPrizeLabel = new System.Windows.Forms.Label();
            this.newConnQuaterlyRB = new System.Windows.Forms.RadioButton();
            this.newConnMonthlyRB = new System.Windows.Forms.RadioButton();
            this.newConnWeeklyRB = new System.Windows.Forms.RadioButton();
            this.newConnectionPreferedPlan = new System.Windows.Forms.Label();
            this.richNCNewAddressTextbox = new System.Windows.Forms.RichTextBox();
            this.newConnectionNewAddressLabel = new System.Windows.Forms.Label();
            this.relocationRB = new System.Windows.Forms.RadioButton();
            this.newConnectionRB = new System.Windows.Forms.RadioButton();
            this.connectionTypeLabel = new System.Windows.Forms.Label();
            this.relocationPanel = new System.Windows.Forms.Panel();
            this.oldConnectionIDLabel = new System.Windows.Forms.Label();
            this.oldConnectionIDTextbox = new System.Windows.Forms.TextBox();
            this.oldAddressLabel = new System.Windows.Forms.Label();
            this.richOldAddress = new System.Windows.Forms.RichTextBox();
            this.expectedPriceLabel = new System.Windows.Forms.Label();
            this.newAddressLabel = new System.Windows.Forms.Label();
            this.richNewAddress = new System.Windows.Forms.RichTextBox();
            this.preferedPlanLabel = new System.Windows.Forms.Label();
            this.weeklyRB = new System.Windows.Forms.RadioButton();
            this.monthlyRB = new System.Windows.Forms.RadioButton();
            this.quaterlyRB = new System.Windows.Forms.RadioButton();
            this.expectedPriceTextbox = new System.Windows.Forms.TextBox();
            this.eSIMRB = new System.Windows.Forms.RadioButton();
            this.physicalRB = new System.Windows.Forms.RadioButton();
            this.SIMTypeLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.paymentGroup = new System.Windows.Forms.GroupBox();
            this.paymentMethodLabel = new System.Windows.Forms.Label();
            this.cardRB = new System.Windows.Forms.RadioButton();
            this.upiRB = new System.Windows.Forms.RadioButton();
            this.netBankingRB = new System.Windows.Forms.RadioButton();
            this.cardPanel = new Panel();
            this.paymentPanel = new Panel();

            this.userdetailsGroupBox.SuspendLayout();
            this.userdetailsPanel.SuspendLayout();
            this.groupResident.SuspendLayout();
            this.indianPanel.SuspendLayout();
            this.nriPanel.SuspendLayout();
            this.othersPanel.SuspendLayout();
            this.scrollablePanel.SuspendLayout();
            this.serviceGroup.SuspendLayout();
            this.servicePanel.SuspendLayout();
            this.connectionTypeGroup.SuspendLayout();
            this.newConnectionPanel.SuspendLayout();
            this.relocationPanel.SuspendLayout();
            this.paymentGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // networkRequestLabel
            // 
            this.networkRequestLabel.AutoSize = true;
            this.networkRequestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.networkRequestLabel.Location = new System.Drawing.Point(300, 10);
            this.networkRequestLabel.Name = "networkRequestLabel";
            this.networkRequestLabel.Size = new System.Drawing.Size(179, 17);
            this.networkRequestLabel.TabIndex = 0;
            this.networkRequestLabel.Text = "Network Request Portal";
            // 
            // userdetailsGroupBox
            // 
            this.userdetailsGroupBox.BackColor = System.Drawing.Color.Beige;
            this.userdetailsGroupBox.Controls.Add(this.userdetailsPanel);
            this.userdetailsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.userdetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.userdetailsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.userdetailsGroupBox.Name = "userdetailsGroupBox";
            this.userdetailsGroupBox.Size = new System.Drawing.Size(1413, 400);
            this.userdetailsGroupBox.TabIndex = 0;
            this.userdetailsGroupBox.TabStop = false;
            this.userdetailsGroupBox.Text = "User Details";
            // 
            // userdetailsPanel
            // 
            this.userdetailsPanel.BackColor = System.Drawing.Color.LightBlue;
            this.userdetailsPanel.Controls.Add(this.nameLabel);
            this.userdetailsPanel.Controls.Add(this.nameTextbox);
            this.userdetailsPanel.Controls.Add(this.phoneNumberLabel);
            this.userdetailsPanel.Controls.Add(this.phoneNumberTextbox);
            this.userdetailsPanel.Controls.Add(this.emailLabel);
            this.userdetailsPanel.Controls.Add(this.emailTextbox);
            this.userdetailsPanel.Controls.Add(this.addressLabel);
            this.userdetailsPanel.Controls.Add(this.richAddressTextBox);
            this.userdetailsPanel.Controls.Add(this.groupResident);
            this.userdetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userdetailsPanel.Location = new System.Drawing.Point(3, 19);
            this.userdetailsPanel.Name = "userdetailsPanel";
            this.userdetailsPanel.Size = new System.Drawing.Size(1407, 378);
            this.userdetailsPanel.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(80, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Full Name";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(170, 21);
            this.nameTextbox.Multiline = true;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(200, 25);
            this.nameTextbox.TabIndex = 1;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(10, 59);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(115, 17);
            this.phoneNumberLabel.TabIndex = 2;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // phoneNumberTextbox
            // 
            this.phoneNumberTextbox.Location = new System.Drawing.Point(170, 59);
            this.phoneNumberTextbox.Multiline = true;
            this.phoneNumberTextbox.Name = "phoneNumberTextbox";
            this.phoneNumberTextbox.Size = new System.Drawing.Size(200, 25);
            this.phoneNumberTextbox.TabIndex = 3;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(10, 103);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(53, 17);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "E-Mail";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(170, 103);
            this.emailTextbox.Multiline = true;
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(200, 25);
            this.emailTextbox.TabIndex = 5;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(10, 147);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(67, 17);
            this.addressLabel.TabIndex = 6;
            this.addressLabel.Text = "Address";
            // 
            // richAddressTextBox
            // 
            this.richAddressTextBox.Location = new System.Drawing.Point(170, 147);
            this.richAddressTextBox.Name = "richAddressTextBox";
            this.richAddressTextBox.Size = new System.Drawing.Size(200, 50);
            this.richAddressTextBox.TabIndex = 7;
            this.richAddressTextBox.Text = "";
            // 
            // groupResident
            // 
            this.groupResident.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupResident.Controls.Add(this.residentLabel);
            this.groupResident.Controls.Add(this.radioButton1);
            this.groupResident.Controls.Add(this.radioButton2);
            this.groupResident.Controls.Add(this.radioButton3);
            this.groupResident.Controls.Add(this.indianPanel);
            this.groupResident.Controls.Add(this.nriPanel);
            this.groupResident.Controls.Add(this.othersPanel);
            this.groupResident.Location = new System.Drawing.Point(10, 200);
            this.groupResident.Name = "groupResident";
            this.groupResident.Size = new System.Drawing.Size(1127, 80);
            this.groupResident.TabIndex = 8;
            this.groupResident.TabStop = false;
            this.groupResident.Text = "Resident type";
            // 
            // residentLabel
            // 
            this.residentLabel.AutoSize = true;
            this.residentLabel.Location = new System.Drawing.Point(1, 30);
            this.residentLabel.Name = "residentLabel";
            this.residentLabel.Size = new System.Drawing.Size(72, 17);
            this.residentLabel.TabIndex = 0;
            this.residentLabel.Text = "Resident";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(100, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Indian";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(200, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "NRI";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(300, 30);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Others";
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // indianPanel
            // 
            this.indianPanel.AutoSize = true;
            this.indianPanel.Controls.Add(this.permanentAddressLabel);
            this.indianPanel.Controls.Add(this.richPermanentAddressTextbox);
            this.indianPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indianPanel.Location = new System.Drawing.Point(3, 19);
            this.indianPanel.Name = "indianPanel";
            this.indianPanel.Size = new System.Drawing.Size(1121, 58);
            this.indianPanel.TabIndex = 3;
            this.indianPanel.Visible = false;
            // 
            // permanentAddressLabel
            // 
            this.permanentAddressLabel.AutoSize = true;
            this.permanentAddressLabel.Location = new System.Drawing.Point(100, 70);
            this.permanentAddressLabel.Name = "permanentAddressLabel";
            this.permanentAddressLabel.Size = new System.Drawing.Size(150, 17);
            this.permanentAddressLabel.TabIndex = 0;
            this.permanentAddressLabel.Text = "Permanent Address";
            // 
            // richPermanentAddressTextbox
            // 
            this.richPermanentAddressTextbox.Location = new System.Drawing.Point(250, 70);
            this.richPermanentAddressTextbox.Name = "richPermanentAddressTextbox";
            this.richPermanentAddressTextbox.Size = new System.Drawing.Size(200, 20);
            this.richPermanentAddressTextbox.TabIndex = 1;
            this.richPermanentAddressTextbox.Text = "";
            // 
            // nriPanel
            // 
            this.nriPanel.AutoSize = true;
            this.nriPanel.Controls.Add(this.passportNumberLabel);
            this.nriPanel.Controls.Add(this.passportNumberTextbox);
            this.nriPanel.Controls.Add(this.localStayAddressLabel);
            this.nriPanel.Controls.Add(this.richLocalStayAddressTextbox);
            this.nriPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nriPanel.Location = new System.Drawing.Point(3, 19);
            this.nriPanel.Name = "nriPanel";
            this.nriPanel.Size = new System.Drawing.Size(1121, 58);
            this.nriPanel.TabIndex = 4;
            this.nriPanel.Visible = false;
            // 
            // passportNumberLabel
            // 
            this.passportNumberLabel.AutoSize = true;
            this.passportNumberLabel.Location = new System.Drawing.Point(100, 70);
            this.passportNumberLabel.Name = "passportNumberLabel";
            this.passportNumberLabel.Size = new System.Drawing.Size(133, 17);
            this.passportNumberLabel.TabIndex = 0;
            this.passportNumberLabel.Text = "Passport Number";
            // 
            // passportNumberTextbox
            // 
            this.passportNumberTextbox.Location = new System.Drawing.Point(250, 70);
            this.passportNumberTextbox.Name = "passportNumberTextbox";
            this.passportNumberTextbox.Size = new System.Drawing.Size(100, 23);
            this.passportNumberTextbox.TabIndex = 1;
            // 
            // localStayAddressLabel
            // 
            this.localStayAddressLabel.AutoSize = true;
            this.localStayAddressLabel.Location = new System.Drawing.Point(100, 100);
            this.localStayAddressLabel.Name = "localStayAddressLabel";
            this.localStayAddressLabel.Size = new System.Drawing.Size(148, 17);
            this.localStayAddressLabel.TabIndex = 2;
            this.localStayAddressLabel.Text = "Local Stay Address";
            // 
            // richLocalStayAddressTextbox
            // 
            this.richLocalStayAddressTextbox.Location = new System.Drawing.Point(250, 100);
            this.richLocalStayAddressTextbox.Name = "richLocalStayAddressTextbox";
            this.richLocalStayAddressTextbox.Size = new System.Drawing.Size(200, 20);
            this.richLocalStayAddressTextbox.TabIndex = 3;
            this.richLocalStayAddressTextbox.Text = "";
            // 
            // othersPanel
            // 
            this.othersPanel.AutoSize = true;
            this.othersPanel.Controls.Add(this.visaNumberLabel);
            this.othersPanel.Controls.Add(this.visaNumberTextbox);
            this.othersPanel.Controls.Add(this.nationalityLabel);
            this.othersPanel.Controls.Add(this.nationalityTextbox);
            this.othersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.othersPanel.Location = new System.Drawing.Point(3, 19);
            this.othersPanel.Name = "othersPanel";
            this.othersPanel.Size = new System.Drawing.Size(1121, 58);
            this.othersPanel.TabIndex = 5;
            this.othersPanel.Visible = false;
            // 
            // visaNumberLabel
            // 
            this.visaNumberLabel.AutoSize = true;
            this.visaNumberLabel.Location = new System.Drawing.Point(100, 70);
            this.visaNumberLabel.Name = "visaNumberLabel";
            this.visaNumberLabel.Size = new System.Drawing.Size(100, 17);
            this.visaNumberLabel.TabIndex = 0;
            this.visaNumberLabel.Text = "Visa Number";
            // 
            // visaNumberTextbox
            // 
            this.visaNumberTextbox.Location = new System.Drawing.Point(250, 70);
            this.visaNumberTextbox.Name = "visaNumberTextbox";
            this.visaNumberTextbox.Size = new System.Drawing.Size(100, 23);
            this.visaNumberTextbox.TabIndex = 1;
            // 
            // nationalityLabel
            // 
            this.nationalityLabel.AutoSize = true;
            this.nationalityLabel.Location = new System.Drawing.Point(100, 100);
            this.nationalityLabel.Name = "nationalityLabel";
            this.nationalityLabel.Size = new System.Drawing.Size(85, 17);
            this.nationalityLabel.TabIndex = 2;
            this.nationalityLabel.Text = "Nationality";
            // 
            // nationalityTextbox
            // 
            this.nationalityTextbox.Location = new System.Drawing.Point(250, 100);
            this.nationalityTextbox.Name = "nationalityTextbox";
            this.nationalityTextbox.Size = new System.Drawing.Size(100, 23);
            this.nationalityTextbox.TabIndex = 3;
            // 
            // scrollablePanel
            // 
            this.scrollablePanel.AutoScroll = true;
            this.scrollablePanel.Controls.Add(this.bigButton);
            this.scrollablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollablePanel.Location = new System.Drawing.Point(0, 0);
            this.scrollablePanel.Name = "scrollablePanel";
            this.scrollablePanel.Size = new System.Drawing.Size(200, 100);
            this.scrollablePanel.TabIndex = 0;
            // 
            // bigButton
            // 
            this.bigButton.Location = new System.Drawing.Point(50, 600);
            this.bigButton.Name = "bigButton";
            this.bigButton.Size = new System.Drawing.Size(75, 23);
            this.bigButton.TabIndex = 0;
            this.bigButton.Text = "I am far away";
            // 
            // serviceGroup
            // 
            this.serviceGroup.AutoSize = true;
            this.serviceGroup.Controls.Add(this.servicePanel);
            this.serviceGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.serviceGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceGroup.Location = new System.Drawing.Point(0, 400);
            this.serviceGroup.Name = "serviceGroup";
            this.serviceGroup.Size = new System.Drawing.Size(1413, 365);
            this.serviceGroup.TabIndex = 1;
            this.serviceGroup.TabStop = false;
            this.serviceGroup.Text = "Service Group";
            // 
            // servicePanel
            // 
            this.servicePanel.AutoSize = true;
            this.servicePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.servicePanel.Controls.Add(this.connectionTypeGroup);
            this.servicePanel.Controls.Add(this.eSIMRB);
            this.servicePanel.Controls.Add(this.physicalRB);
            this.servicePanel.Controls.Add(this.SIMTypeLabel);
            this.servicePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servicePanel.Location = new System.Drawing.Point(3, 18);
            this.servicePanel.Name = "servicePanel";
            this.servicePanel.Size = new System.Drawing.Size(1407, 344);
            this.servicePanel.TabIndex = 0;
            // 
            // connectionTypeGroup
            // 
            this.connectionTypeGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionTypeGroup.Controls.Add(this.newConnectionPanel);
            this.connectionTypeGroup.Controls.Add(this.relocationRB);
            this.connectionTypeGroup.Controls.Add(this.newConnectionRB);
            this.connectionTypeGroup.Controls.Add(this.connectionTypeLabel);
            this.connectionTypeGroup.Controls.Add(this.relocationPanel);
            this.connectionTypeGroup.Location = new System.Drawing.Point(7, 53);
            this.connectionTypeGroup.Name = "connectionTypeGroup";
            this.connectionTypeGroup.Size = new System.Drawing.Size(1331, 288);
            this.connectionTypeGroup.TabIndex = 6;
            this.connectionTypeGroup.TabStop = false;
            this.connectionTypeGroup.Text = "Connection Type";
            // 
            // newConnectionPanel
            // 
            this.newConnectionPanel.AutoSize = true;
            this.newConnectionPanel.Controls.Add(this.newConnExpectedPrizeTextbox);
            this.newConnectionPanel.Controls.Add(this.newConnExpectedPrizeLabel);
            this.newConnectionPanel.Controls.Add(this.newConnQuaterlyRB);
            this.newConnectionPanel.Controls.Add(this.newConnMonthlyRB);
            this.newConnectionPanel.Controls.Add(this.newConnWeeklyRB);
            this.newConnectionPanel.Controls.Add(this.newConnectionPreferedPlan);
            this.newConnectionPanel.Controls.Add(this.richNCNewAddressTextbox);
            this.newConnectionPanel.Controls.Add(this.newConnectionNewAddressLabel);
            this.newConnectionPanel.Location = new System.Drawing.Point(163, 77);
            this.newConnectionPanel.Name = "newConnectionPanel";
            this.newConnectionPanel.Size = new System.Drawing.Size(400, 175);
            this.newConnectionPanel.TabIndex = 7;
            this.newConnectionPanel.Visible = false;
            // 
            // newConnExpectedPrizeTextbox
            // 
            this.newConnExpectedPrizeTextbox.Location = new System.Drawing.Point(137, 97);
            this.newConnExpectedPrizeTextbox.Name = "newConnExpectedPrizeTextbox";
            this.newConnExpectedPrizeTextbox.Size = new System.Drawing.Size(100, 22);
            this.newConnExpectedPrizeTextbox.TabIndex = 9;
            // 
            // newConnExpectedPrizeLabel
            // 
            this.newConnExpectedPrizeLabel.AutoSize = true;
            this.newConnExpectedPrizeLabel.Location = new System.Drawing.Point(14, 101);
            this.newConnExpectedPrizeLabel.Name = "newConnExpectedPrizeLabel";
            this.newConnExpectedPrizeLabel.Size = new System.Drawing.Size(112, 16);
            this.newConnExpectedPrizeLabel.TabIndex = 8;
            this.newConnExpectedPrizeLabel.Text = "Expected Prize";
            // 
            // newConnQuaterlyRB
            // 
            this.newConnQuaterlyRB.Location = new System.Drawing.Point(293, 56);
            this.newConnQuaterlyRB.Name = "newConnQuaterlyRB";
            this.newConnQuaterlyRB.Size = new System.Drawing.Size(104, 24);
            this.newConnQuaterlyRB.TabIndex = 7;
            this.newConnQuaterlyRB.Text = "Quaterly";
            // 
            // newConnMonthlyRB
            // 
            this.newConnMonthlyRB.Location = new System.Drawing.Point(212, 56);
            this.newConnMonthlyRB.Name = "newConnMonthlyRB";
            this.newConnMonthlyRB.Size = new System.Drawing.Size(104, 24);
            this.newConnMonthlyRB.TabIndex = 6;
            this.newConnMonthlyRB.Text = "Monthly";
            // 
            // newConnWeeklyRB
            // 
            this.newConnWeeklyRB.Location = new System.Drawing.Point(133, 56);
            this.newConnWeeklyRB.Name = "newConnWeeklyRB";
            this.newConnWeeklyRB.Size = new System.Drawing.Size(104, 24);
            this.newConnWeeklyRB.TabIndex = 5;
            this.newConnWeeklyRB.Text = "Weekly";
            // 
            // newConnectionPreferedPlan
            // 
            this.newConnectionPreferedPlan.AutoSize = true;
            this.newConnectionPreferedPlan.Location = new System.Drawing.Point(14, 60);
            this.newConnectionPreferedPlan.Name = "newConnectionPreferedPlan";
            this.newConnectionPreferedPlan.Size = new System.Drawing.Size(103, 16);
            this.newConnectionPreferedPlan.TabIndex = 4;
            this.newConnectionPreferedPlan.Text = "Prefered Plan";
            // 
            // richNCNewAddressTextbox
            // 
            this.richNCNewAddressTextbox.Location = new System.Drawing.Point(137, 18);
            this.richNCNewAddressTextbox.Name = "richNCNewAddressTextbox";
            this.richNCNewAddressTextbox.Size = new System.Drawing.Size(141, 22);
            this.richNCNewAddressTextbox.TabIndex = 3;
            this.richNCNewAddressTextbox.Text = "";
            // 
            // newConnectionNewAddressLabel
            // 
            this.newConnectionNewAddressLabel.AutoSize = true;
            this.newConnectionNewAddressLabel.Location = new System.Drawing.Point(14, 18);
            this.newConnectionNewAddressLabel.Name = "newConnectionNewAddressLabel";
            this.newConnectionNewAddressLabel.Size = new System.Drawing.Size(100, 16);
            this.newConnectionNewAddressLabel.TabIndex = 2;
            this.newConnectionNewAddressLabel.Text = "New Address";
            // 
            // relocationRB
            // 
            this.relocationRB.AutoSize = true;
            this.relocationRB.Location = new System.Drawing.Point(306, 33);
            this.relocationRB.Name = "relocationRB";
            this.relocationRB.Size = new System.Drawing.Size(101, 20);
            this.relocationRB.TabIndex = 5;
            this.relocationRB.TabStop = true;
            this.relocationRB.Text = "Relocation";
            this.relocationRB.UseVisualStyleBackColor = true;
            this.relocationRB.CheckedChanged += new System.EventHandler(this.relocationRB_CheckedChanged);
            // 
            // newConnectionRB
            // 
            this.newConnectionRB.AutoSize = true;
            this.newConnectionRB.Location = new System.Drawing.Point(155, 33);
            this.newConnectionRB.Name = "newConnectionRB";
            this.newConnectionRB.Size = new System.Drawing.Size(137, 20);
            this.newConnectionRB.TabIndex = 4;
            this.newConnectionRB.TabStop = true;
            this.newConnectionRB.Text = "New Connection";
            this.newConnectionRB.UseVisualStyleBackColor = true;
            this.newConnectionRB.CheckedChanged += new System.EventHandler(this.newConnectionRB_CheckedChanged);
            // 
            // connectionTypeLabel
            // 
            this.connectionTypeLabel.AutoSize = true;
            this.connectionTypeLabel.Location = new System.Drawing.Point(7, 35);
            this.connectionTypeLabel.Name = "connectionTypeLabel";
            this.connectionTypeLabel.Size = new System.Drawing.Size(125, 16);
            this.connectionTypeLabel.TabIndex = 3;
            this.connectionTypeLabel.Text = "Connection Type";
            // 
            // relocationPanel
            // 
            this.relocationPanel.AutoSize = true;
            this.relocationPanel.Controls.Add(this.oldConnectionIDLabel);
            this.relocationPanel.Controls.Add(this.oldConnectionIDTextbox);
            this.relocationPanel.Controls.Add(this.oldAddressLabel);
            this.relocationPanel.Controls.Add(this.richOldAddress);
            this.relocationPanel.Controls.Add(this.expectedPriceLabel);
            this.relocationPanel.Controls.Add(this.newAddressLabel);
            this.relocationPanel.Controls.Add(this.richNewAddress);
            this.relocationPanel.Controls.Add(this.preferedPlanLabel);
            this.relocationPanel.Controls.Add(this.weeklyRB);
            this.relocationPanel.Controls.Add(this.monthlyRB);
            this.relocationPanel.Controls.Add(this.quaterlyRB);
            this.relocationPanel.Controls.Add(this.expectedPriceTextbox);
            this.relocationPanel.Location = new System.Drawing.Point(163, 77);
            this.relocationPanel.Name = "relocationPanel";
            this.relocationPanel.Size = new System.Drawing.Size(600, 175);
            this.relocationPanel.TabIndex = 6;
            this.relocationPanel.Visible = false;
            // 
            // oldConnectionIDLabel
            // 
            this.oldConnectionIDLabel.Location = new System.Drawing.Point(22, 17);
            this.oldConnectionIDLabel.Name = "oldConnectionIDLabel";
            this.oldConnectionIDLabel.Size = new System.Drawing.Size(142, 23);
            this.oldConnectionIDLabel.TabIndex = 0;
            this.oldConnectionIDLabel.Text = "Old Connection ID";
            // 
            // oldConnectionIDTextbox
            // 
            this.oldConnectionIDTextbox.Location = new System.Drawing.Point(189, 17);
            this.oldConnectionIDTextbox.Name = "oldConnectionIDTextbox";
            this.oldConnectionIDTextbox.Size = new System.Drawing.Size(148, 22);
            this.oldConnectionIDTextbox.TabIndex = 0;
            // 
            // oldAddressLabel
            // 
            this.oldAddressLabel.Location = new System.Drawing.Point(22, 56);
            this.oldAddressLabel.Name = "oldAddressLabel";
            this.oldAddressLabel.Size = new System.Drawing.Size(100, 23);
            this.oldAddressLabel.TabIndex = 0;
            this.oldAddressLabel.Text = "Old Address";
            // 
            // richOldAddress
            // 
            this.richOldAddress.Location = new System.Drawing.Point(189, 56);
            this.richOldAddress.Name = "richOldAddress";
            this.richOldAddress.Size = new System.Drawing.Size(148, 23);
            this.richOldAddress.TabIndex = 0;
            this.richOldAddress.Text = "";
            // 
            // expectedPriceLabel
            // 
            this.expectedPriceLabel.AutoSize = true;
            this.expectedPriceLabel.Location = new System.Drawing.Point(22, 153);
            this.expectedPriceLabel.Name = "expectedPriceLabel";
            this.expectedPriceLabel.Size = new System.Drawing.Size(112, 16);
            this.expectedPriceLabel.TabIndex = 7;
            this.expectedPriceLabel.Text = "Expected Prize";
            // 
            // newAddressLabel
            // 
            this.newAddressLabel.AutoSize = true;
            this.newAddressLabel.Location = new System.Drawing.Point(350, 17);
            this.newAddressLabel.Name = "newAddressLabel";
            this.newAddressLabel.Size = new System.Drawing.Size(100, 16);
            this.newAddressLabel.TabIndex = 1;
            this.newAddressLabel.Text = "New Address";
            // 
            // richNewAddress
            // 
            this.richNewAddress.Location = new System.Drawing.Point(456, 14);
            this.richNewAddress.Name = "richNewAddress";
            this.richNewAddress.Size = new System.Drawing.Size(141, 22);
            this.richNewAddress.TabIndex = 2;
            this.richNewAddress.Text = "";
            // 
            // preferedPlanLabel
            // 
            this.preferedPlanLabel.AutoSize = true;
            this.preferedPlanLabel.Location = new System.Drawing.Point(22, 105);
            this.preferedPlanLabel.Name = "preferedPlanLabel";
            this.preferedPlanLabel.Size = new System.Drawing.Size(103, 16);
            this.preferedPlanLabel.TabIndex = 3;
            this.preferedPlanLabel.Text = "Prefered Plan";
            // 
            // weeklyRB
            // 
            this.weeklyRB.Location = new System.Drawing.Point(186, 100);
            this.weeklyRB.Name = "weeklyRB";
            this.weeklyRB.Size = new System.Drawing.Size(104, 24);
            this.weeklyRB.TabIndex = 4;
            this.weeklyRB.Text = "Weekly";
            // 
            // monthlyRB
            // 
            this.monthlyRB.Location = new System.Drawing.Point(296, 100);
            this.monthlyRB.Name = "monthlyRB";
            this.monthlyRB.Size = new System.Drawing.Size(104, 24);
            this.monthlyRB.TabIndex = 5;
            this.monthlyRB.Text = "Monthly";
            // 
            // quaterlyRB
            // 
            this.quaterlyRB.Location = new System.Drawing.Point(406, 100);
            this.quaterlyRB.Name = "quaterlyRB";
            this.quaterlyRB.Size = new System.Drawing.Size(104, 24);
            this.quaterlyRB.TabIndex = 6;
            this.quaterlyRB.Text = "Quaterly";
            // 
            // expectedPriceTextbox
            // 
            this.expectedPriceTextbox.Location = new System.Drawing.Point(189, 150);
            this.expectedPriceTextbox.Name = "expectedPriceTextbox";
            this.expectedPriceTextbox.Size = new System.Drawing.Size(100, 22);
            this.expectedPriceTextbox.TabIndex = 8;
            // 
            // eSIMRB
            // 
            this.eSIMRB.AutoSize = true;
            this.eSIMRB.Location = new System.Drawing.Point(313, 20);
            this.eSIMRB.Name = "eSIMRB";
            this.eSIMRB.Size = new System.Drawing.Size(61, 20);
            this.eSIMRB.TabIndex = 2;
            this.eSIMRB.TabStop = true;
            this.eSIMRB.Text = "eSIM";
            this.eSIMRB.UseVisualStyleBackColor = true;
            // 
            // physicalRB
            // 
            this.physicalRB.AutoSize = true;
            this.physicalRB.Location = new System.Drawing.Point(162, 20);
            this.physicalRB.Name = "physicalRB";
            this.physicalRB.Size = new System.Drawing.Size(85, 20);
            this.physicalRB.TabIndex = 1;
            this.physicalRB.TabStop = true;
            this.physicalRB.Text = "Physical";
            this.physicalRB.UseVisualStyleBackColor = true;
            // 
            // SIMTypeLabel
            // 
            this.SIMTypeLabel.AutoSize = true;
            this.SIMTypeLabel.Location = new System.Drawing.Point(10, 20);
            this.SIMTypeLabel.Name = "SIMTypeLabel";
            this.SIMTypeLabel.Size = new System.Drawing.Size(74, 16);
            this.SIMTypeLabel.TabIndex = 0;
            this.SIMTypeLabel.Text = "SIM Type";
            // 
            // paymentGroup
            // 
            this.paymentGroup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.paymentGroup.Controls.Add(this.netBankingRB);
            this.paymentGroup.Controls.Add(this.upiRB);
            this.paymentGroup.Controls.Add(this.cardRB);
            this.paymentGroup.Controls.Add(this.paymentMethodLabel);
            this.paymentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentGroup.Location = new System.Drawing.Point(4, 769);
            this.paymentGroup.Name = "paymentGroup";
            this.paymentGroup.AutoSize = true;
            this.paymentGroup.TabIndex = 2;
            this.paymentGroup.TabStop = false;
            this.paymentGroup.Dock = DockStyle.Top;
            this.paymentGroup.Text = "Payment Group";
            
            this.paymentGroup.Controls.Add(this.paymentPanel);

            //paymentPanel
            this.paymentPanel.Location = new Point(5, 15);
            this.paymentPanel.BackColor = Color.LightBlue;
            this.paymentPanel.AutoSize = true;
            this.paymentPanel.Controls.Add(paymentMethodLabel);
            this.paymentPanel.Controls.Add(cardRB);
            this.paymentPanel.Controls.Add(cardPanel);
            this.paymentPanel.Controls.Add(upiRB);
            this.paymentPanel.Controls.Add(netBankingRB);
            // paymentMethodLabel
            // 
            this.paymentMethodLabel.AutoSize = true;
            this.paymentMethodLabel.Location = new System.Drawing.Point(10, 34);
            this.paymentMethodLabel.Name = "paymentMethodLabel";
            this.paymentMethodLabel.Size = new System.Drawing.Size(123, 16);
            this.paymentMethodLabel.TabIndex = 0;
            this.paymentMethodLabel.Text = "Payment Method";
            // 
            // cardRB
            // 
            this.cardRB.AutoSize = true;
            this.cardRB.Location = new System.Drawing.Point(185, 32);
            this.cardRB.Name = "cardRB";
            this.cardRB.Size = new System.Drawing.Size(59, 20);
            this.cardRB.TabIndex = 1;
            this.cardRB.TabStop = true;
            this.cardRB.Text = "Card";
            this.cardRB.UseVisualStyleBackColor = true;
            this.cardRB.CheckedChanged += cardRB_CheckedChanged;
            // 
            // upiRB
            // 
            this.upiRB.AutoSize = true;
            this.upiRB.Location = new System.Drawing.Point(262, 32);
            this.upiRB.Name = "upiRB";
            this.upiRB.Size = new System.Drawing.Size(51, 20);
            this.upiRB.TabIndex = 2;
            this.upiRB.TabStop = true;
            this.upiRB.Text = "UPI";
            this.upiRB.UseVisualStyleBackColor = true;
            // 
            // netBankingRB
            // 
            this.netBankingRB.AutoSize = true;
            this.netBankingRB.Location = new System.Drawing.Point(328, 32);
            this.netBankingRB.Name = "netBankingRB";
            this.netBankingRB.Size = new System.Drawing.Size(110, 20);
            this.netBankingRB.TabIndex = 3;
            this.netBankingRB.TabStop = true;
            this.netBankingRB.Text = "Net Banking";
            this.netBankingRB.UseVisualStyleBackColor = true;

            //cardPanel
            this.cardPanel.Location = new Point(185, 50);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 1061);
            this.Controls.Add(this.paymentGroup);
            this.Controls.Add(this.serviceGroup);
            this.Controls.Add(this.userdetailsGroupBox);
            this.Controls.Add(this.networkRequestLabel);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.userdetailsGroupBox.ResumeLayout(false);
            this.userdetailsPanel.ResumeLayout(false);
            this.userdetailsPanel.PerformLayout();
            this.groupResident.ResumeLayout(false);
            this.groupResident.PerformLayout();
            this.indianPanel.ResumeLayout(false);
            this.indianPanel.PerformLayout();
            this.nriPanel.ResumeLayout(false);
            this.nriPanel.PerformLayout();
            this.othersPanel.ResumeLayout(false);
            this.othersPanel.PerformLayout();
            this.scrollablePanel.ResumeLayout(false);
            this.serviceGroup.ResumeLayout(false);
            this.serviceGroup.PerformLayout();
            this.servicePanel.ResumeLayout(false);
            this.servicePanel.PerformLayout();
            this.connectionTypeGroup.ResumeLayout(false);
            this.connectionTypeGroup.PerformLayout();
            this.newConnectionPanel.ResumeLayout(false);
            this.newConnectionPanel.PerformLayout();
            this.relocationPanel.ResumeLayout(false);
            this.relocationPanel.PerformLayout();
            this.paymentGroup.ResumeLayout(false);
            this.paymentGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private Label networkRequestLabel;
        private GroupBox userdetailsGroupBox;
        private Panel userdetailsPanel;
        private Label nameLabel;
        private TextBox nameTextbox;
        private Label phoneNumberLabel;
        private TextBox phoneNumberTextbox;
        private Label emailLabel;
        private TextBox emailTextbox;
        private Label addressLabel;
        private RichTextBox richAddressTextBox;
        private GroupBox groupResident;
        private Label residentLabel;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Panel scrollablePanel;
        private Button bigButton;
        private Panel indianPanel;
        private Panel nriPanel;
        private Panel othersPanel;
        private Label permanentAddressLabel;
        private RichTextBox richPermanentAddressTextbox;
        private Label passportNumberLabel;
        private TextBox passportNumberTextbox;
        private Label localStayAddressLabel;
        private RichTextBox richLocalStayAddressTextbox;
        private Label visaNumberLabel;
        private TextBox visaNumberTextbox;
        private Label nationalityLabel;
        private TextBox nationalityTextbox;
 
        private GroupBox serviceGroup;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel servicePanel;
        private Label SIMTypeLabel;
        private GroupBox connectionTypeGroup;
        private RadioButton relocationRB;
        private RadioButton newConnectionRB;
        private Label connectionTypeLabel;
        private RadioButton eSIMRB;
        private RadioButton physicalRB;
        private Panel relocationPanel;
        private Label oldConnectionIDLabel;
        private TextBox oldConnectionIDTextbox;
        private Label oldAddressLabel;
        private RichTextBox richOldAddress;
        private Label newAddressLabel;
        private RichTextBox richNewAddress;
        private Label preferedPlanLabel;
        private RadioButton weeklyRB;
        private RadioButton monthlyRB;
        private RadioButton quaterlyRB;
        private Label expectedPriceLabel;
        private TextBox expectedPriceTextbox;
        private Panel newConnectionPanel;
        private TextBox newConnExpectedPrizeTextbox;
        private Label newConnExpectedPrizeLabel;
        private RadioButton newConnQuaterlyRB;
        private RadioButton newConnMonthlyRB;
        private RadioButton newConnWeeklyRB;
        private Label newConnectionPreferedPlan;
        private RichTextBox richNCNewAddressTextbox;
        private Label newConnectionNewAddressLabel;
        private GroupBox paymentGroup;
        private Panel paymentPanel;
        private RadioButton netBankingRB;
        private RadioButton upiRB;
        private RadioButton cardRB;
        private Label paymentMethodLabel;
        private Panel cardPanel;
    }
}