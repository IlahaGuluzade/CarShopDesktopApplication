using CarsShop.Classes;
using CarsShop.Utils;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Card.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsShop.Forms
{
    public partial class FrmCarInfo : DevExpress.XtraEditors.XtraForm
    {
        public int id { get; set; }
        CarInfoAdapter carInfoAdapter = new CarInfoAdapter();
        public FrmCarInfo(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FrmCarInfo_Load(object sender, EventArgs e)
        {
            GetCarData();
        }

        private void GetCarData()
        {
            string query = $@"SELECT GN.NAME CITY_NAME
                ,BRD.BRAND_NAME
                ,MDL.MODEL_NAME 
                ,ADS.[YEAR]
                ,GN2.NAME BAN_TYPE 
                ,GN3.NAME COLOR
                ,GN1.NAME ENGINE_CAPACITY
                ,ADS.[ENGINE_POWER]
                ,GN5.NAME FUEL_TYPE
                ,ADS.[CAR_KM]
                ,GN7.NAME GEARBOX
                ,GN6.NAME CONDUCTIVE
                ,ADS.[PRICE]
                ,GN4.NAME CURRENCY
                ,ADS.[CREDIT]
                ,ADS.[BARTER]
                ,ADS.[CAR_NOTE]
                ,ADS.[ALLOY_WHEELS]
                ,ADS.[CENTRAL_CLOSURE]
                ,ADS.[LEATHER_SALON]
                ,ADS.[SEAT_VENTILATION]
                ,ADS.[ABS]
                ,ADS.[PARKING_RADAR]
                ,ADS.[XENON_LAMPS]
                ,ADS.[LUKE]
                ,ADS.[CONDITIONER]
                ,ADS.[REAR_CAMERA]
                ,ADS.[RAIN_SENSOR]
                ,ADS.[SEAT_HEATING]
                ,ADS.[SIDE_CURTAINS]                
                FROM [dbo].[TB_ADS] ADS 
                JOIN GENERAL_INFO GN ON GN.ID = ADS.CITY_ID
                JOIN CAR_MODEL MDL ON MDL.ID = ADS.MODEL_ID	 
                JOIN CAR_BRANDS BRD ON MDL.BRAND_ID = BRD.ID
                JOIN GENERAL_INFO GN1 ON GN1.ID = ADS.ENGINE_CAPACITY_ID
                JOIN GENERAL_INFO GN2 ON GN2.ID = ADS.BAN_TYPE_ID
                JOIN GENERAL_INFO GN3 ON GN3.ID = ADS.COLOR_ID
                JOIN GENERAL_INFO GN4 ON GN4.ID = ADS.CURRENCY_ID
                JOIN GENERAL_INFO GN5 ON GN5.ID = ADS.FUEL_TYPE_ID
                JOIN GENERAL_INFO GN6 ON GN6.ID = ADS.CONDUCTIVE_ID
                JOIN GENERAL_INFO GN7 ON GN7.ID = ADS.GEARBOX_ID
                WHERE ADS.ID = {id}";

            DataTable dtTableCarInfo = SqlUtils.GetInstance().GetDataWitAdapter(query);

            lblCatCity.Text = dtTableCarInfo.Rows[0]["CITY_NAME"].ToString();
            lblCatBrand.Text = dtTableCarInfo.Rows[0]["BRAND_NAME"].ToString();
            lblCatModel.Text = dtTableCarInfo.Rows[0]["MODEL_NAME"].ToString();
            lblCatYear.Text = dtTableCarInfo.Rows[0]["YEAR"].ToString();
            lblCatBanType.Text = dtTableCarInfo.Rows[0]["BAN_TYPE"].ToString();
            lblCatColor.Text = dtTableCarInfo.Rows[0]["COLOR"].ToString();
            lblCatEngineCapacity.Text = dtTableCarInfo.Rows[0]["ENGINE_CAPACITY"].ToString();
            lblCatEnginePower.Text = dtTableCarInfo.Rows[0]["ENGINE_POWER"].ToString();
            lblCatFuelType.Text = dtTableCarInfo.Rows[0]["FUEL_TYPE"].ToString();
            lblCatKm.Text = dtTableCarInfo.Rows[0]["CAR_KM"].ToString();
            lblCatGearbox.Text = dtTableCarInfo.Rows[0]["GEARBOX"].ToString();
            lblCatConductive.Text = dtTableCarInfo.Rows[0]["CONDUCTIVE"].ToString();
            lblCatPrice.Text = dtTableCarInfo.Rows[0]["PRICE"].ToString() + " " + dtTableCarInfo.Rows[0]["CURRENCY"].ToString();

            string credit = null;
            if (dtTableCarInfo.Rows[0]["CREDIT"].ToString() == "True")
            {
                credit = "Kreditdədir";
            }
            if (dtTableCarInfo.Rows[0]["BARTER"].ToString() == "True")
            {
                credit = credit != null ? "Kreditdədir və barter mümkündür" : "Barter mümkündür";
            }
            lblCreditBarter.Text = credit;

            string equipment = null;
            if (dtTableCarInfo.Rows[0]["ALLOY_WHEELS"].ToString() == "True")
            {
                equipment = "* Yüngül lehimli disklər";
            }
            if (dtTableCarInfo.Rows[0]["CENTRAL_CLOSURE"].ToString() == "True")
            {
                equipment = equipment != null ? equipment + Environment.NewLine + "* Mərkəzi qapanma" : "* Mərkəzi qapanma";
            }
            if (dtTableCarInfo.Rows[0]["LEATHER_SALON"].ToString() == "True")
            {
                equipment = equipment != null ? equipment + Environment.NewLine + "* Dəri salon" : "* Dəri salon";
            }
            if (dtTableCarInfo.Rows[0]["SEAT_VENTILATION"].ToString() == "True")
            {
                equipment = equipment != null ? equipment + Environment.NewLine + "* Oturacaqların ventilyasiyası" : "* Oturacaqların ventilyasiyası";
            }
            if (dtTableCarInfo.Rows[0]["ABS"].ToString() == "True")
            {
                equipment = equipment != null ? equipment + Environment.NewLine + "* ABS" : "* ABS";
            }
            if (dtTableCarInfo.Rows[0]["PARKING_RADAR"].ToString() == "True")
            {
                equipment = equipment != null ? equipment + Environment.NewLine + "* Park radarı" : "* Park radarı";
            }
            if (dtTableCarInfo.Rows[0]["XENON_LAMPS"].ToString() == "True")
            {
                equipment = equipment != null ? equipment + Environment.NewLine + "* Ksenon lampalar" : "* Ksenon lampalar";
            }
            if (dtTableCarInfo.Rows[0]["LUKE"].ToString() == "True")
            {
                equipment = equipment != null ? equipment + Environment.NewLine + "* Lyuk" : "* Lyuk";
            }
            if (dtTableCarInfo.Rows[0]["CONDITIONER"].ToString() == "True")
            {
                equipment = equipment != null ? equipment + Environment.NewLine + "* Kondisioner" : "* Kondisioner";
            }
            if (dtTableCarInfo.Rows[0]["REAR_CAMERA"].ToString() == "True")
            {
                equipment = equipment != null ? equipment + Environment.NewLine + "* Arxa görüntü kamerası" : "* Arxa görüntü kamerası";
            }
            if (dtTableCarInfo.Rows[0]["RAIN_SENSOR"].ToString() == "True")
            {
                equipment = equipment != null ? equipment + Environment.NewLine + "* Yağış sensoru" : "* Yağış sensoru";
            }
            if (dtTableCarInfo.Rows[0]["SEAT_HEATING"].ToString() == "True")
            {
                equipment = equipment != null ? equipment + Environment.NewLine + "* Oturacaqların isidilməsi" : "* Oturacaqların isidilməsi";
            }
            if (dtTableCarInfo.Rows[0]["SIDE_CURTAINS"].ToString() == "True")
            {
                equipment = equipment != null ? equipment + Environment.NewLine + "* Yan pərdələr" : "* Yan pərdələr";
            }
            lblEquipment.Text = equipment;

            lblCatInfo.Text = dtTableCarInfo.Rows[0]["CAR_NOTE"].ToString();

            string queryImage = $@"SELECT IMG.CAR_IMAGE, IMG.ID FROM TB_ADS_IMAGE IMG 
                                   JOIN TB_ADS ADS ON ADS.ID = IMG.ADS_ID
                                   WHERE ADS.ID={id}";
            DataTable dtTableImage = SqlUtils.GetInstance().GetDataWitAdapter(queryImage);
            grdCtrlAdsCar.DataSource = dtTableImage;
        }   
        
        private void crdVwAdsCar_MouseDown(object sender, MouseEventArgs e)
        {
            CardView cardView = sender as CardView;
            CardHitInfo hInfo = cardView.CalcHitInfo(e.X, e.Y);
            if (hInfo.HitTest == CardHitTest.FieldCaption || hInfo.InCard)
            {
                int rowHandle = hInfo.RowHandle;
                int id = (int)crdVwAdsCar.GetRowCellValue(rowHandle, "ID");
                FrmImages frmImages = new FrmImages(id);
                frmImages.ShowDialog();
            }
        }
    }
}
