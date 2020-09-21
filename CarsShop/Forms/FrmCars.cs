using CarsShop.Classes;
using CarsShop.Utils;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Card.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsShop.Forms
{
    public partial class FrmCars : DevExpress.XtraEditors.XtraForm
    {
        CommonMethods commonMethods = new CommonMethods();
        public FrmCars()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddCar frmAddCar = new FrmAddCar();
            frmAddCar.ShowDialog();
            GetCars();
        }

        private void FrmCars_Load(object sender, EventArgs e)
        {
            commonMethods.SetCarBrandData(lkUpEdtCarBrand);
            commonMethods.SetGeneralInfo(lkUpEdtCarCurrency, "3");
            lkUpEdtCarCurrency.EditValue = 35;
            commonMethods.SetCarYear(lkUpEdtCarYearBegin);
            commonMethods.SetCarYear(lkUpEdtCarYearEnd);
            commonMethods.SetGeneralInfo(lkUpEdtCities, "7");
            GetCars();
        }

        private void lkUpEdtCarBrand_EditValueChanged(object sender, EventArgs e)
        {
            commonMethods.SetCarModelData(lkUpEdtCarModel, lkUpEdtCarBrand.EditValue.ToString());
        }

        private void btnCarSearch_Click(object sender, EventArgs e)
        {
            GetCars();
        }

        private void GetCars()
        {
            string query = $@"SELECT ADS.[ID]
            ,ADS.[PRICE]
	        ,(BRD.BRAND_NAME + '   ' + MDL.MODEL_NAME) CAR_NAME   
            ,ADS.[YEAR]
	        ,ADS.[CAR_KM]
            ,GN1.NAME ENGINE_CAPACITY
            ,GN.NAME CITY_NAME,
	         (SELECT TOP(1) IMG.CAR_IMAGE FROM TB_ADS_IMAGE IMG WHERE IMG.ADS_ID = ADS.ID) CAR_IMAGE
             FROM [dbo].[TB_ADS] ADS
             JOIN CAR_MODEL MDL ON MDL.ID = ADS.MODEL_ID	 
	         JOIN CAR_BRANDS BRD ON MDL.BRAND_ID = BRD.ID
	         JOIN GENERAL_INFO GN ON GN.ID = ADS.CITY_ID
	         JOIN GENERAL_INFO GN1 ON GN1.ID = ADS.ENGINE_CAPACITY_ID
             WHERE CURRENCY_ID = {lkUpEdtCarCurrency.EditValue}";   // ve ya WHERE 1=1; o zaman ki, default olaraq hec bir shey sechilmir

            if (lkUpEdtCarBrand.EditValue != null && (int)lkUpEdtCarBrand.EditValue != -1)
            {
                query += $" AND MDL.BRAND_ID = {lkUpEdtCarBrand.EditValue}";
            }
            if (lkUpEdtCarModel.EditValue != null)
            {
                query += $" AND ADS.[MODEL_ID] = {lkUpEdtCarModel.EditValue}";
            }
            if (txtMinPrice.EditValue != null)
            {
                query += $" AND ADS.[PRICE] >= {txtMinPrice.EditValue}";
            }
            if (txtMaxPrice.EditValue != null)
            {
                query += $" AND ADS.[PRICE] <= {txtMaxPrice.EditValue}";
            }
            if (lkUpEdtCarYearBegin.EditValue != null)
            {
                query += $" AND ADS.[YEAR] >= {lkUpEdtCarYearBegin.EditValue}";
            }
            if (lkUpEdtCarYearEnd.EditValue != null)
            {
                query += $" AND ADS.[YEAR] <= {lkUpEdtCarYearEnd.EditValue}";
            }
            if (lkUpEdtCities.EditValue != null)
            {
                query += $" AND ADS.[CITY_ID] = {lkUpEdtCities.EditValue}";
            }
            if ((short)chckEdtCredit.EditValue == 1)
            {
                query += $" AND ADS.[CREDIT] = {chckEdtCredit.EditValue}";
            }
            if ((short)chckEdtBarter.EditValue == 1)
            {
                query += $" AND ADS.[BARTER] = {chckEdtBarter.EditValue}";
            }

            DataTable dtTableCars = SqlUtils.GetInstance().GetDataWitAdapter(query);
            grdCtrlCars.DataSource = dtTableCars;
        }

        private void crdVwCars_MouseDown(object sender, MouseEventArgs e)
        {
            CardView cardView = (CardView)sender;
            CardHitInfo hInfo = cardView.CalcHitInfo(e.X, e.Y);
            if (hInfo.HitTest == CardHitTest.FieldValue || hInfo.HitTest == CardHitTest.FieldCaption || hInfo.InCard)
            {
                int rowHandle = hInfo.RowHandle;
                int id = (int)crdVwCars.GetRowCellValue(rowHandle, "ID");
                FrmCarInfo frmCarInfo = new FrmCarInfo(id);
                frmCarInfo.ShowDialog();               
            }
        }
    }
}