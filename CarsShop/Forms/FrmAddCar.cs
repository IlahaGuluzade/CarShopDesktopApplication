
using CarsShop.Classes;
using CarsShop.Utils;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsShop.Forms
{
    public partial class FrmAddCar : DevExpress.XtraEditors.XtraForm
    {
        CarInfoAdapter carInfoAdapter = new CarInfoAdapter();
        CommonMethods commonMethods = new CommonMethods();
        public FrmAddCar()
        {
            InitializeComponent();
        }
        private void FrmAddCar_Load(object sender, EventArgs e)
        {
            commonMethods.SetCarBrandData(lkUpEdtCarBrand);
            commonMethods.SetGeneralInfo(lkUpEdtCarBanType, "1");         //Ban növü
            commonMethods.SetGeneralInfo(lkUpEdtCarColor, "2");           //Reng
            commonMethods.SetGeneralInfo(lkUpEdtCarFuelType, "4");        //Yanacaq novu
            commonMethods.SetGeneralInfo(lkUpEdtCarConductive, "5");      //Oturucu
            commonMethods.SetGeneralInfo(lkUpEdtCarGearbox, "6");         //Suretler qutusu  
            commonMethods.SetGeneralInfo(lkUpEdtCity, "7");               //Sheherler 
            commonMethods.SetGeneralInfo(lkUpEdtEngineCapacity, "8");     //Muherrikin hecmi 
            commonMethods.SetCarYear(lkUpEdtCarYear);                     //Buraxılış ili
            grdCtrlImages.DataSource = carInfoAdapter.GetCarImages("-1");
        }
        private void SetGeneralInfo(LookUpEdit lookUpEdit, string typeId)
        {
            lookUpEdit.Properties.DataSource = carInfoAdapter.GetCarGeneralInfo(typeId);
            lookUpEdit.Properties.DisplayMember = "NAME";
            lookUpEdit.Properties.ValueMember = "ID";
        }
        private void lkUpEdtCarBrand_EditValueChanged(object sender, EventArgs e)
        {
            commonMethods.SetCarModelData(lkUpEdtCarModel, lkUpEdtCarBrand.EditValue.ToString());
        }
        private void btnAddAds_Click(object sender, EventArgs e)
        {
            if (EmptyControl() == true)
            {
                if (MessageBox.Show("Elanı yerləşdirmək istədiyinizə əminsiniz?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InsertAllInfo();
                }
            }
        }
        private bool EmptyControl()
        {
            bool control = true;
            if (lkUpEdtCarBrand.EditValue == null)
            {
                lkUpEdtCarBrand.ErrorText = "Markanı daxil edin!";
                control = false;
            }
            if (lkUpEdtCarModel.EditValue == null)
            {
                lkUpEdtCarModel.ErrorText = "Modeli daxil edin!";
                control = false;
            }
            if (lkUpEdtCarBanType.EditValue == null)
            {
                lkUpEdtCarBanType.ErrorText = "Ban növünü daxil edin!";
                control = false;
            }
            if ((decimal)spnEdtCarKm.EditValue == 0)
            {
                spnEdtCarKm.ErrorText = "YÜrüşü daxil edin!";
                control = false;
            }
            if (lkUpEdtCarColor.EditValue == null)
            {
                lkUpEdtCarColor.ErrorText = "Rəngi daxil edin!";
                control = false;
            }
            if ((decimal)spnEdtCarPrice.EditValue == 0)
            {
                spnEdtCarPrice.ErrorText = "Qiyməti daxil edin!";
                control = false;
            }
            if (lkUpEdtCarFuelType.EditValue == null)
            {
                lkUpEdtCarFuelType.ErrorText = "Yanacaq növünü daxil edin!";
                control = false;
            }
            if (lkUpEdtCarConductive.EditValue == null)
            {
                lkUpEdtCarConductive.ErrorText = "Ötürücünü daxil edin!";
                control = false;
            }
            if (lkUpEdtCarGearbox.EditValue == null)
            {
                lkUpEdtCarGearbox.ErrorText = "Sürətlər qutusunu daxil edin!";
                control = false;
            }
            if (lkUpEdtCarYear.EditValue == null)
            {
                lkUpEdtCarYear.ErrorText = "Buraxılış ilini daxil edin!";
                control = false;
            }
            if (lkUpEdtEngineCapacity.EditValue == null)
            {
                lkUpEdtEngineCapacity.ErrorText = "Mühərrikin həcmini daxil edin!";
                control = false;
            }
            if ((decimal)spnEdtEnginePower.EditValue == 0)
            {
                spnEdtEnginePower.ErrorText = "Mühərrikin gücünü daxil edin!";
                control = false;
            }
            if (txtOwnerName.Text.Trim() == "")
            {
                txtOwnerName.ErrorText = "Adınızı daxil edin!";
                control = false;
            }
            if (lkUpEdtCity.EditValue == null)
            {
                lkUpEdtCity.ErrorText = "Şəhəri daxil edin!";
                control = false;
            }
            if (txtOwnerEmail.Text.Trim() == "")
            {
                txtOwnerEmail.ErrorText = "E-mail daxil edin!";
                control = false;
            }
            if (crdVwImages.DataRowCount < 3)
            {
                MessageBox.Show("Minimum üç şəkil daxil edin!");
                control = false;
            }
            return control;
        }
        private void InsertAllInfo()
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(SqlUtils.GetInstance().conString);
                sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                string insertedId = InsertInfo(sqlTransaction);
                InsertAdsImage(sqlTransaction, insertedId);
                sqlTransaction.Commit();
                sqlConnection.Close();
                MessageBox.Show("Məlumat yadda saxlanıldı!");
                this.Close();
            }
            catch (Exception)
            {
                sqlTransaction.Rollback();
                MessageBox.Show("Məlumat yadda saxlanılan zaman xəta baş verdi!");
            }
        }
        private string InsertInfo(SqlTransaction sqlTransaction)
        {
            string query = @"INSERT INTO [dbo].[TB_ADS]
           ([MODEL_ID] 
           ,[BAN_TYPE_ID]
           ,[CAR_KM]
           ,[COLOR_ID]
           ,[PRICE]
           ,[CURRENCY_ID]
           ,[CREDIT]
           ,[BARTER]
           ,[FUEL_TYPE_ID]
           ,[CONDUCTIVE_ID]
           ,[GEARBOX_ID]
           ,[YEAR]
           ,[ENGINE_CAPACITY_ID]
           ,[ENGINE_POWER]
           ,[CAR_NOTE]
           ,[ALLOY_WHEELS]
           ,[CENTRAL_CLOSURE]
           ,[LEATHER_SALON]
           ,[SEAT_VENTILATION]
           ,[ABS]
           ,[PARKING_RADAR]
           ,[XENON_LAMPS]
           ,[LUKE]
           ,[CONDITIONER]
           ,[REAR_CAMERA]
           ,[RAIN_SENSOR]
           ,[SEAT_HEATING]
           ,[SIDE_CURTAINS]
           ,[NAME]
           ,[CITY_ID]
           ,[EMAIL])
     VALUES
           (@MODEL_ID
           , @BAN_TYPE_ID
           , @CAR_KM
           , @COLOR_ID
           , @PRICE
           , @CURRENCY_ID
           , @CREDIT
           , @BARTER
           , @FUEL_TYPE_ID
           , @CONDUCTIVE_ID
           , @GEARBOX_ID
           , @YEAR
           , @ENGINE_CAPACITY_ID
           , @ENGINE_POWER
           , @CAR_NOTE
           , @ALLOY_WHEELS
           , @CENTRAL_CLOSURE
           , @LEATHER_SALON
           , @SEAT_VENTILATION
           , @ABS
           , @PARKING_RADAR
           , @XENON_LAMPS
           , @LUKE
           , @CONDITIONER
           , @REAR_CAMERA
           , @RAIN_SENSOR
           , @SEAT_HEATING
           , @SIDE_CURTAINS
           , @NAME
           , @CITY_ID
           , @EMAIL); 
             SELECT SCOPE_IDENTITY();";

            SqlCommand sqlCommand = new SqlCommand(query, sqlTransaction.Connection);
            sqlCommand.Transaction = sqlTransaction;
            sqlCommand.Parameters.Add("MODEL_ID", SqlDbType.Int).Value = lkUpEdtCarModel.EditValue;
            sqlCommand.Parameters.Add("BAN_TYPE_ID", SqlDbType.Int).Value = lkUpEdtCarBanType.EditValue;
            sqlCommand.Parameters.Add("CAR_KM", SqlDbType.Int).Value = spnEdtCarKm.EditValue;
            sqlCommand.Parameters.Add("COLOR_ID", SqlDbType.Int).Value = lkUpEdtCarColor.EditValue;
            sqlCommand.Parameters.Add("PRICE", SqlDbType.Int).Value = spnEdtCarPrice.EditValue;
            sqlCommand.Parameters.Add("CURRENCY_ID", SqlDbType.Int).Value = rdGrpCarCurrency.EditValue;
            sqlCommand.Parameters.Add("CREDIT", SqlDbType.Bit).Value = chckEdtCarCredit.EditValue;
            sqlCommand.Parameters.Add("BARTER", SqlDbType.Bit).Value = chckEdtCarBarter.EditValue;
            sqlCommand.Parameters.Add("FUEL_TYPE_ID", SqlDbType.Int).Value = lkUpEdtCarFuelType.EditValue;
            sqlCommand.Parameters.Add("CONDUCTIVE_ID", SqlDbType.Int).Value = lkUpEdtCarConductive.EditValue;
            sqlCommand.Parameters.Add("GEARBOX_ID", SqlDbType.Int).Value = lkUpEdtCarGearbox.EditValue;
            sqlCommand.Parameters.Add("YEAR", SqlDbType.Int).Value = lkUpEdtCarYear.EditValue;
            sqlCommand.Parameters.Add("ENGINE_CAPACITY_ID", SqlDbType.Int).Value = lkUpEdtEngineCapacity.EditValue;
            sqlCommand.Parameters.Add("ENGINE_POWER", SqlDbType.Int).Value = spnEdtEnginePower.EditValue;
            sqlCommand.Parameters.Add("CAR_NOTE", SqlDbType.NVarChar).Value = mmEdtCarInfo.EditValue;
            sqlCommand.Parameters.Add("ALLOY_WHEELS", SqlDbType.Bit).Value = chckEdtAlloyWheels.EditValue;
            sqlCommand.Parameters.Add("CENTRAL_CLOSURE", SqlDbType.Bit).Value = chckEdtCentralClosure.EditValue;
            sqlCommand.Parameters.Add("LEATHER_SALON", SqlDbType.Bit).Value = chckEdtLeatherSalon.EditValue;
            sqlCommand.Parameters.Add("SEAT_VENTILATION", SqlDbType.Bit).Value = chckEdtSeatVentilation.EditValue;
            sqlCommand.Parameters.Add("ABS", SqlDbType.Bit).Value = chckEdtABS.EditValue;
            sqlCommand.Parameters.Add("PARKING_RADAR", SqlDbType.Bit).Value = chckEdtParkingRadar.EditValue;
            sqlCommand.Parameters.Add("XENON_LAMPS", SqlDbType.Bit).Value = chckEdtXenonLamps.EditValue;
            sqlCommand.Parameters.Add("LUKE", SqlDbType.Bit).Value = chckEdtLuke.EditValue;
            sqlCommand.Parameters.Add("CONDITIONER", SqlDbType.Bit).Value = chckEdtConditioner.EditValue;
            sqlCommand.Parameters.Add("REAR_CAMERA", SqlDbType.Bit).Value = chckEdtRearCamera.EditValue;
            sqlCommand.Parameters.Add("RAIN_SENSOR", SqlDbType.Bit).Value = chckEdtRainSensor.EditValue;
            sqlCommand.Parameters.Add("SEAT_HEATING", SqlDbType.Bit).Value = chckEdtSeatHeating.EditValue;
            sqlCommand.Parameters.Add("SIDE_CURTAINS", SqlDbType.Bit).Value = chckEdtSideCurtains.EditValue;
            sqlCommand.Parameters.Add("NAME", SqlDbType.NVarChar).Value = txtOwnerName.EditValue;
            sqlCommand.Parameters.Add("CITY_ID", SqlDbType.Int).Value = lkUpEdtCity.EditValue;
            sqlCommand.Parameters.Add("EMAIL", SqlDbType.NVarChar).Value = txtOwnerEmail.EditValue;
            return sqlCommand.ExecuteScalar().ToString();
        }
        private void InsertAdsImage(SqlTransaction sqlTransaction, string adsId)
        {
            DataTable dtTableImages = (DataTable)grdCtrlImages.DataSource;
            for (int i = 0; i < dtTableImages.Rows.Count; i++)
            {
                DataRow dtRowImages = dtTableImages.Rows[i];
                string query = @"INSERT INTO [dbo].[TB_ADS_IMAGE]
                              (CAR_IMAGE, ADS_ID)
                               VALUES
                              (@CAR_IMAGE, @ADS_ID)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlTransaction.Connection);
                sqlCommand.Transaction = sqlTransaction;
                sqlCommand.Parameters.Add("CAR_IMAGE", SqlDbType.VarBinary).Value = dtRowImages["CAR_IMAGE"];
                sqlCommand.Parameters.Add("ADS_ID", SqlDbType.Int).Value = adsId;
                sqlCommand.ExecuteNonQuery();
            }
        }
        private void grpCtrlImages_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button == grpCtrlCarImages.CustomHeaderButtons[0])
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Image files | *.jpg; *.png; *.jpeg";  //*.* olarsa all files
                DataTable dataTableImages = (DataTable)grdCtrlImages.DataSource;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var fileName in openFileDialog.FileNames)
                    {
                        dataTableImages.Rows.Add(0, GetByteImage(fileName));
                        GetByteImage(fileName);
                    }
                }
            }
            if (e.Button == grpCtrlCarImages.CustomHeaderButtons[1])
            {
                this.crdVwImages.SelectAll();
                this.crdVwImages.DeleteSelectedRows();
            }
        }
        private byte[] GetByteImage(string fileName)
        {
            byte[] imgByteArray = null;
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            imgByteArray = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();
            return imgByteArray;
        }       
    }
}
