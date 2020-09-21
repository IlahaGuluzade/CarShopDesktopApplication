namespace CarsShop.Forms
{
    partial class FrmCarInfo
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.pnlCtrlImages = new DevExpress.XtraEditors.PanelControl();
            this.grdCtrlAdsCar = new DevExpress.XtraGrid.GridControl();
            this.crdVwAdsCar = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlCtrlInfo = new DevExpress.XtraEditors.PanelControl();
            this.lblCreditBarter = new DevExpress.XtraEditors.LabelControl();
            this.lblCatPrice = new DevExpress.XtraEditors.LabelControl();
            this.lblCatGearbox = new DevExpress.XtraEditors.LabelControl();
            this.lblCatConductive = new DevExpress.XtraEditors.LabelControl();
            this.lblCatKm = new DevExpress.XtraEditors.LabelControl();
            this.lblCatFuelType = new DevExpress.XtraEditors.LabelControl();
            this.lblCatEnginePower = new DevExpress.XtraEditors.LabelControl();
            this.lblCatEngineCapacity = new DevExpress.XtraEditors.LabelControl();
            this.lblCatColor = new DevExpress.XtraEditors.LabelControl();
            this.lblCatBanType = new DevExpress.XtraEditors.LabelControl();
            this.lblCatYear = new DevExpress.XtraEditors.LabelControl();
            this.lblCatModel = new DevExpress.XtraEditors.LabelControl();
            this.lblCatBrand = new DevExpress.XtraEditors.LabelControl();
            this.lblCatCity = new DevExpress.XtraEditors.LabelControl();
            this.lblCarPrice = new DevExpress.XtraEditors.LabelControl();
            this.lblCarGearbox = new DevExpress.XtraEditors.LabelControl();
            this.lblCarConductive = new DevExpress.XtraEditors.LabelControl();
            this.lblCarKm = new DevExpress.XtraEditors.LabelControl();
            this.lblCarFuelType = new DevExpress.XtraEditors.LabelControl();
            this.lblEnginePower = new DevExpress.XtraEditors.LabelControl();
            this.lblEngineCapacity = new DevExpress.XtraEditors.LabelControl();
            this.lblCarColor = new DevExpress.XtraEditors.LabelControl();
            this.lblCarBanType = new DevExpress.XtraEditors.LabelControl();
            this.lblCarYear = new DevExpress.XtraEditors.LabelControl();
            this.lblCarModel = new DevExpress.XtraEditors.LabelControl();
            this.lblCarBrand = new DevExpress.XtraEditors.LabelControl();
            this.lblCity = new DevExpress.XtraEditors.LabelControl();
            this.pnlCtrlEquipment = new DevExpress.XtraEditors.PanelControl();
            this.lblEquipment = new DevExpress.XtraEditors.LabelControl();
            this.lblCatInfo = new DevExpress.XtraEditors.LabelControl();
            this.lblCarInfo = new DevExpress.XtraEditors.LabelControl();
            this.lblCarEquipment = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtrlImages)).BeginInit();
            this.pnlCtrlImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlAdsCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crdVwAdsCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtrlInfo)).BeginInit();
            this.pnlCtrlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtrlEquipment)).BeginInit();
            this.pnlCtrlEquipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCtrlImages
            // 
            this.pnlCtrlImages.Controls.Add(this.grdCtrlAdsCar);
            this.pnlCtrlImages.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCtrlImages.Location = new System.Drawing.Point(0, 0);
            this.pnlCtrlImages.Name = "pnlCtrlImages";
            this.pnlCtrlImages.Size = new System.Drawing.Size(800, 226);
            this.pnlCtrlImages.TabIndex = 0;
            // 
            // grdCtrlAdsCar
            // 
            this.grdCtrlAdsCar.Dock = System.Windows.Forms.DockStyle.Top;
            gridLevelNode1.RelationName = "Level1";
            this.grdCtrlAdsCar.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdCtrlAdsCar.Location = new System.Drawing.Point(2, 2);
            this.grdCtrlAdsCar.MainView = this.crdVwAdsCar;
            this.grdCtrlAdsCar.Name = "grdCtrlAdsCar";
            this.grdCtrlAdsCar.Size = new System.Drawing.Size(796, 224);
            this.grdCtrlAdsCar.TabIndex = 3;
            this.grdCtrlAdsCar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.crdVwAdsCar});
            // 
            // crdVwAdsCar
            // 
            this.crdVwAdsCar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.crdVwAdsCar.GridControl = this.grdCtrlAdsCar;
            this.crdVwAdsCar.Name = "crdVwAdsCar";
            this.crdVwAdsCar.OptionsBehavior.FieldAutoHeight = true;
            this.crdVwAdsCar.OptionsView.ShowFieldCaptions = false;
            this.crdVwAdsCar.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.crdVwAdsCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.crdVwAdsCar_MouseDown);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "CAR_IMAGE";
            this.gridColumn2.FieldName = "CAR_IMAGE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // pnlCtrlInfo
            // 
            this.pnlCtrlInfo.Controls.Add(this.lblCreditBarter);
            this.pnlCtrlInfo.Controls.Add(this.lblCatPrice);
            this.pnlCtrlInfo.Controls.Add(this.lblCatGearbox);
            this.pnlCtrlInfo.Controls.Add(this.lblCatConductive);
            this.pnlCtrlInfo.Controls.Add(this.lblCatKm);
            this.pnlCtrlInfo.Controls.Add(this.lblCatFuelType);
            this.pnlCtrlInfo.Controls.Add(this.lblCatEnginePower);
            this.pnlCtrlInfo.Controls.Add(this.lblCatEngineCapacity);
            this.pnlCtrlInfo.Controls.Add(this.lblCatColor);
            this.pnlCtrlInfo.Controls.Add(this.lblCatBanType);
            this.pnlCtrlInfo.Controls.Add(this.lblCatYear);
            this.pnlCtrlInfo.Controls.Add(this.lblCatModel);
            this.pnlCtrlInfo.Controls.Add(this.lblCatBrand);
            this.pnlCtrlInfo.Controls.Add(this.lblCatCity);
            this.pnlCtrlInfo.Controls.Add(this.lblCarPrice);
            this.pnlCtrlInfo.Controls.Add(this.lblCarGearbox);
            this.pnlCtrlInfo.Controls.Add(this.lblCarConductive);
            this.pnlCtrlInfo.Controls.Add(this.lblCarKm);
            this.pnlCtrlInfo.Controls.Add(this.lblCarFuelType);
            this.pnlCtrlInfo.Controls.Add(this.lblEnginePower);
            this.pnlCtrlInfo.Controls.Add(this.lblEngineCapacity);
            this.pnlCtrlInfo.Controls.Add(this.lblCarColor);
            this.pnlCtrlInfo.Controls.Add(this.lblCarBanType);
            this.pnlCtrlInfo.Controls.Add(this.lblCarYear);
            this.pnlCtrlInfo.Controls.Add(this.lblCarModel);
            this.pnlCtrlInfo.Controls.Add(this.lblCarBrand);
            this.pnlCtrlInfo.Controls.Add(this.lblCity);
            this.pnlCtrlInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCtrlInfo.Location = new System.Drawing.Point(0, 226);
            this.pnlCtrlInfo.Name = "pnlCtrlInfo";
            this.pnlCtrlInfo.Size = new System.Drawing.Size(327, 350);
            this.pnlCtrlInfo.TabIndex = 1;
            // 
            // lblCreditBarter
            // 
            this.lblCreditBarter.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreditBarter.Appearance.Options.UseFont = true;
            this.lblCreditBarter.Location = new System.Drawing.Point(157, 321);
            this.lblCreditBarter.Name = "lblCreditBarter";
            this.lblCreditBarter.Size = new System.Drawing.Size(58, 13);
            this.lblCreditBarter.TabIndex = 55;
            this.lblCreditBarter.Text = "KreditBarter";
            // 
            // lblCatPrice
            // 
            this.lblCatPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCatPrice.Appearance.Options.UseFont = true;
            this.lblCatPrice.Location = new System.Drawing.Point(157, 297);
            this.lblCatPrice.Name = "lblCatPrice";
            this.lblCatPrice.Size = new System.Drawing.Size(34, 13);
            this.lblCatPrice.TabIndex = 54;
            this.lblCatPrice.Text = "Qiymət";
            // 
            // lblCatGearbox
            // 
            this.lblCatGearbox.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCatGearbox.Appearance.Options.UseFont = true;
            this.lblCatGearbox.Location = new System.Drawing.Point(157, 249);
            this.lblCatGearbox.Name = "lblCatGearbox";
            this.lblCatGearbox.Size = new System.Drawing.Size(74, 13);
            this.lblCatGearbox.TabIndex = 53;
            this.lblCatGearbox.Text = "Sürətlər qutusu";
            // 
            // lblCatConductive
            // 
            this.lblCatConductive.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCatConductive.Appearance.Options.UseFont = true;
            this.lblCatConductive.Location = new System.Drawing.Point(157, 273);
            this.lblCatConductive.Name = "lblCatConductive";
            this.lblCatConductive.Size = new System.Drawing.Size(39, 13);
            this.lblCatConductive.TabIndex = 52;
            this.lblCatConductive.Text = "Ötürücü";
            // 
            // lblCatKm
            // 
            this.lblCatKm.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCatKm.Appearance.Options.UseFont = true;
            this.lblCatKm.Location = new System.Drawing.Point(157, 225);
            this.lblCatKm.Name = "lblCatKm";
            this.lblCatKm.Size = new System.Drawing.Size(47, 13);
            this.lblCatKm.TabIndex = 51;
            this.lblCatKm.Text = "Yürüş, km";
            // 
            // lblCatFuelType
            // 
            this.lblCatFuelType.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCatFuelType.Appearance.Options.UseFont = true;
            this.lblCatFuelType.Location = new System.Drawing.Point(157, 201);
            this.lblCatFuelType.Name = "lblCatFuelType";
            this.lblCatFuelType.Size = new System.Drawing.Size(68, 13);
            this.lblCatFuelType.TabIndex = 50;
            this.lblCatFuelType.Text = "Yanacaq növü";
            // 
            // lblCatEnginePower
            // 
            this.lblCatEnginePower.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCatEnginePower.Appearance.Options.UseFont = true;
            this.lblCatEnginePower.Location = new System.Drawing.Point(157, 177);
            this.lblCatEnginePower.Name = "lblCatEnginePower";
            this.lblCatEnginePower.Size = new System.Drawing.Size(102, 13);
            this.lblCatEnginePower.TabIndex = 49;
            this.lblCatEnginePower.Text = "Mühərrikin gücü, a.g.";
            // 
            // lblCatEngineCapacity
            // 
            this.lblCatEngineCapacity.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCatEngineCapacity.Appearance.Options.UseFont = true;
            this.lblCatEngineCapacity.Location = new System.Drawing.Point(157, 153);
            this.lblCatEngineCapacity.Name = "lblCatEngineCapacity";
            this.lblCatEngineCapacity.Size = new System.Drawing.Size(79, 13);
            this.lblCatEngineCapacity.TabIndex = 48;
            this.lblCatEngineCapacity.Text = "Mühərrikin həcmi";
            // 
            // lblCatColor
            // 
            this.lblCatColor.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCatColor.Appearance.Options.UseFont = true;
            this.lblCatColor.Location = new System.Drawing.Point(157, 129);
            this.lblCatColor.Name = "lblCatColor";
            this.lblCatColor.Size = new System.Drawing.Size(25, 13);
            this.lblCatColor.TabIndex = 47;
            this.lblCatColor.Text = "Rəng";
            // 
            // lblCatBanType
            // 
            this.lblCatBanType.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCatBanType.Appearance.Options.UseFont = true;
            this.lblCatBanType.Location = new System.Drawing.Point(157, 105);
            this.lblCatBanType.Name = "lblCatBanType";
            this.lblCatBanType.Size = new System.Drawing.Size(45, 13);
            this.lblCatBanType.TabIndex = 46;
            this.lblCatBanType.Text = "Ban növü";
            // 
            // lblCatYear
            // 
            this.lblCatYear.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCatYear.Appearance.Options.UseFont = true;
            this.lblCatYear.Location = new System.Drawing.Point(157, 81);
            this.lblCatYear.Name = "lblCatYear";
            this.lblCatYear.Size = new System.Drawing.Size(48, 13);
            this.lblCatYear.TabIndex = 45;
            this.lblCatYear.Text = "Buraxılış ili";
            // 
            // lblCatModel
            // 
            this.lblCatModel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCatModel.Appearance.Options.UseFont = true;
            this.lblCatModel.Location = new System.Drawing.Point(157, 57);
            this.lblCatModel.Name = "lblCatModel";
            this.lblCatModel.Size = new System.Drawing.Size(28, 13);
            this.lblCatModel.TabIndex = 44;
            this.lblCatModel.Text = "Model";
            // 
            // lblCatBrand
            // 
            this.lblCatBrand.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCatBrand.Appearance.Options.UseFont = true;
            this.lblCatBrand.Location = new System.Drawing.Point(157, 33);
            this.lblCatBrand.Name = "lblCatBrand";
            this.lblCatBrand.Size = new System.Drawing.Size(29, 13);
            this.lblCatBrand.TabIndex = 43;
            this.lblCatBrand.Text = "Marka";
            // 
            // lblCatCity
            // 
            this.lblCatCity.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCatCity.Appearance.Options.UseFont = true;
            this.lblCatCity.Location = new System.Drawing.Point(157, 9);
            this.lblCatCity.Name = "lblCatCity";
            this.lblCatCity.Size = new System.Drawing.Size(28, 13);
            this.lblCatCity.TabIndex = 42;
            this.lblCatCity.Text = "Şəhər";
            // 
            // lblCarPrice
            // 
            this.lblCarPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCarPrice.Appearance.Options.UseFont = true;
            this.lblCarPrice.Location = new System.Drawing.Point(12, 297);
            this.lblCarPrice.Name = "lblCarPrice";
            this.lblCarPrice.Size = new System.Drawing.Size(41, 13);
            this.lblCarPrice.TabIndex = 41;
            this.lblCarPrice.Text = "Qiymət";
            // 
            // lblCarGearbox
            // 
            this.lblCarGearbox.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCarGearbox.Appearance.Options.UseFont = true;
            this.lblCarGearbox.Location = new System.Drawing.Point(11, 249);
            this.lblCarGearbox.Name = "lblCarGearbox";
            this.lblCarGearbox.Size = new System.Drawing.Size(88, 13);
            this.lblCarGearbox.TabIndex = 38;
            this.lblCarGearbox.Text = "Sürətlər qutusu";
            // 
            // lblCarConductive
            // 
            this.lblCarConductive.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCarConductive.Appearance.Options.UseFont = true;
            this.lblCarConductive.Location = new System.Drawing.Point(11, 273);
            this.lblCarConductive.Name = "lblCarConductive";
            this.lblCarConductive.Size = new System.Drawing.Size(45, 13);
            this.lblCarConductive.TabIndex = 37;
            this.lblCarConductive.Text = "Ötürücü";
            // 
            // lblCarKm
            // 
            this.lblCarKm.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCarKm.Appearance.Options.UseFont = true;
            this.lblCarKm.Location = new System.Drawing.Point(11, 225);
            this.lblCarKm.Name = "lblCarKm";
            this.lblCarKm.Size = new System.Drawing.Size(56, 13);
            this.lblCarKm.TabIndex = 35;
            this.lblCarKm.Text = "Yürüş, km";
            // 
            // lblCarFuelType
            // 
            this.lblCarFuelType.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCarFuelType.Appearance.Options.UseFont = true;
            this.lblCarFuelType.Location = new System.Drawing.Point(11, 201);
            this.lblCarFuelType.Name = "lblCarFuelType";
            this.lblCarFuelType.Size = new System.Drawing.Size(79, 13);
            this.lblCarFuelType.TabIndex = 33;
            this.lblCarFuelType.Text = "Yanacaq növü";
            // 
            // lblEnginePower
            // 
            this.lblEnginePower.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnginePower.Appearance.Options.UseFont = true;
            this.lblEnginePower.Location = new System.Drawing.Point(11, 177);
            this.lblEnginePower.Name = "lblEnginePower";
            this.lblEnginePower.Size = new System.Drawing.Size(117, 13);
            this.lblEnginePower.TabIndex = 30;
            this.lblEnginePower.Text = "Mühərrikin gücü, a.g.";
            // 
            // lblEngineCapacity
            // 
            this.lblEngineCapacity.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEngineCapacity.Appearance.Options.UseFont = true;
            this.lblEngineCapacity.Location = new System.Drawing.Point(11, 153);
            this.lblEngineCapacity.Name = "lblEngineCapacity";
            this.lblEngineCapacity.Size = new System.Drawing.Size(98, 13);
            this.lblEngineCapacity.TabIndex = 29;
            this.lblEngineCapacity.Text = "Mühərrikin həcmi";
            // 
            // lblCarColor
            // 
            this.lblCarColor.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCarColor.Appearance.Options.UseFont = true;
            this.lblCarColor.Location = new System.Drawing.Point(11, 129);
            this.lblCarColor.Name = "lblCarColor";
            this.lblCarColor.Size = new System.Drawing.Size(29, 13);
            this.lblCarColor.TabIndex = 26;
            this.lblCarColor.Text = "Rəng";
            // 
            // lblCarBanType
            // 
            this.lblCarBanType.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCarBanType.Appearance.Options.UseFont = true;
            this.lblCarBanType.Location = new System.Drawing.Point(11, 105);
            this.lblCarBanType.Name = "lblCarBanType";
            this.lblCarBanType.Size = new System.Drawing.Size(52, 13);
            this.lblCarBanType.TabIndex = 24;
            this.lblCarBanType.Text = "Ban növü";
            // 
            // lblCarYear
            // 
            this.lblCarYear.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCarYear.Appearance.Options.UseFont = true;
            this.lblCarYear.Location = new System.Drawing.Point(11, 81);
            this.lblCarYear.Name = "lblCarYear";
            this.lblCarYear.Size = new System.Drawing.Size(60, 13);
            this.lblCarYear.TabIndex = 16;
            this.lblCarYear.Text = "Buraxılış ili";
            // 
            // lblCarModel
            // 
            this.lblCarModel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCarModel.Appearance.Options.UseFont = true;
            this.lblCarModel.Location = new System.Drawing.Point(11, 57);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(34, 13);
            this.lblCarModel.TabIndex = 14;
            this.lblCarModel.Text = "Model";
            // 
            // lblCarBrand
            // 
            this.lblCarBrand.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCarBrand.Appearance.Options.UseFont = true;
            this.lblCarBrand.Location = new System.Drawing.Point(11, 33);
            this.lblCarBrand.Name = "lblCarBrand";
            this.lblCarBrand.Size = new System.Drawing.Size(36, 13);
            this.lblCarBrand.TabIndex = 6;
            this.lblCarBrand.Text = "Marka";
            // 
            // lblCity
            // 
            this.lblCity.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.Appearance.Options.UseFont = true;
            this.lblCity.Location = new System.Drawing.Point(11, 9);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(33, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "Şəhər";
            // 
            // pnlCtrlEquipment
            // 
            this.pnlCtrlEquipment.Controls.Add(this.lblCarEquipment);
            this.pnlCtrlEquipment.Controls.Add(this.lblCarInfo);
            this.pnlCtrlEquipment.Controls.Add(this.lblEquipment);
            this.pnlCtrlEquipment.Controls.Add(this.lblCatInfo);
            this.pnlCtrlEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCtrlEquipment.Location = new System.Drawing.Point(327, 226);
            this.pnlCtrlEquipment.Name = "pnlCtrlEquipment";
            this.pnlCtrlEquipment.Size = new System.Drawing.Size(473, 350);
            this.pnlCtrlEquipment.TabIndex = 2;
            // 
            // lblEquipment
            // 
            this.lblEquipment.Location = new System.Drawing.Point(16, 28);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(98, 13);
            this.lblEquipment.TabIndex = 26;
            this.lblEquipment.Text = "Avtomobilin təchizatı";
            // 
            // lblCatInfo
            // 
            this.lblCatInfo.Location = new System.Drawing.Point(16, 223);
            this.lblCatInfo.Name = "lblCatInfo";
            this.lblCatInfo.Size = new System.Drawing.Size(71, 13);
            this.lblCatInfo.TabIndex = 25;
            this.lblCatInfo.Text = "Əlavə məlumat";
            // 
            // lblCarInfo
            // 
            this.lblCarInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCarInfo.Appearance.Options.UseFont = true;
            this.lblCarInfo.Location = new System.Drawing.Point(16, 204);
            this.lblCarInfo.Name = "lblCarInfo";
            this.lblCarInfo.Size = new System.Drawing.Size(86, 13);
            this.lblCarInfo.TabIndex = 27;
            this.lblCarInfo.Text = "Əlavə məlumat";
            // 
            // lblCarEquipment
            // 
            this.lblCarEquipment.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCarEquipment.Appearance.Options.UseFont = true;
            this.lblCarEquipment.Location = new System.Drawing.Point(16, 9);
            this.lblCarEquipment.Name = "lblCarEquipment";
            this.lblCarEquipment.Size = new System.Drawing.Size(120, 13);
            this.lblCarEquipment.TabIndex = 28;
            this.lblCarEquipment.Text = "Avtomobilin təchizatı";
            // 
            // FrmCarInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.pnlCtrlEquipment);
            this.Controls.Add(this.pnlCtrlInfo);
            this.Controls.Add(this.pnlCtrlImages);
            this.Name = "FrmCarInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Elanı incələ";
            this.Load += new System.EventHandler(this.FrmCarInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtrlImages)).EndInit();
            this.pnlCtrlImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlAdsCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crdVwAdsCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtrlInfo)).EndInit();
            this.pnlCtrlInfo.ResumeLayout(false);
            this.pnlCtrlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtrlEquipment)).EndInit();
            this.pnlCtrlEquipment.ResumeLayout(false);
            this.pnlCtrlEquipment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlCtrlImages;
        private DevExpress.XtraEditors.PanelControl pnlCtrlInfo;
        private DevExpress.XtraEditors.PanelControl pnlCtrlEquipment;
        private DevExpress.XtraEditors.LabelControl lblCity;
        private DevExpress.XtraEditors.LabelControl lblCarBrand;
        private DevExpress.XtraEditors.LabelControl lblCarModel;
        private DevExpress.XtraEditors.LabelControl lblCarYear;
        private DevExpress.XtraEditors.LabelControl lblCarBanType;
        private DevExpress.XtraEditors.LabelControl lblCarColor;
        private DevExpress.XtraEditors.LabelControl lblEnginePower;
        private DevExpress.XtraEditors.LabelControl lblEngineCapacity;
        private DevExpress.XtraEditors.LabelControl lblCarFuelType;
        private DevExpress.XtraEditors.LabelControl lblCarKm;
        private DevExpress.XtraEditors.LabelControl lblCarGearbox;
        private DevExpress.XtraEditors.LabelControl lblCarConductive;
        private DevExpress.XtraEditors.LabelControl lblCarPrice;
        private DevExpress.XtraEditors.LabelControl lblCatPrice;
        private DevExpress.XtraEditors.LabelControl lblCatGearbox;
        private DevExpress.XtraEditors.LabelControl lblCatConductive;
        private DevExpress.XtraEditors.LabelControl lblCatKm;
        private DevExpress.XtraEditors.LabelControl lblCatFuelType;
        private DevExpress.XtraEditors.LabelControl lblCatEnginePower;
        private DevExpress.XtraEditors.LabelControl lblCatEngineCapacity;
        private DevExpress.XtraEditors.LabelControl lblCatColor;
        private DevExpress.XtraEditors.LabelControl lblCatBanType;
        private DevExpress.XtraEditors.LabelControl lblCatYear;
        private DevExpress.XtraEditors.LabelControl lblCatModel;
        private DevExpress.XtraEditors.LabelControl lblCatBrand;
        private DevExpress.XtraEditors.LabelControl lblCatCity;
        private DevExpress.XtraEditors.LabelControl lblCatInfo;
        private DevExpress.XtraEditors.LabelControl lblCreditBarter;
        private DevExpress.XtraEditors.LabelControl lblEquipment;
        private DevExpress.XtraGrid.GridControl grdCtrlAdsCar;
        private DevExpress.XtraGrid.Views.Card.CardView crdVwAdsCar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl lblCarEquipment;
        private DevExpress.XtraEditors.LabelControl lblCarInfo;
    }
}