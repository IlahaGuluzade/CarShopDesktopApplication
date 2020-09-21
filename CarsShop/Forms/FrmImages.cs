using CarsShop.Utils;
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
    public partial class FrmImages : DevExpress.XtraEditors.XtraForm
    {
        public int id { get; set; }
        public FrmImages(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FrmImages_Load(object sender, EventArgs e)
        {
            GetImages();
        }

        private void GetImages()
        {
            string queryImage = $@"SELECT IMG.CAR_IMAGE FROM TB_ADS_IMAGE IMG 
                                   JOIN TB_ADS ADS ON ADS.ID = IMG.ADS_ID
                                   WHERE IMG.ID={id}";
            
            DataTable dtTableImg = SqlUtils.GetInstance().GetDataWitAdapter(queryImage);
            if (dtTableImg.Rows.Count > 0)
            {
                byte[] MyData;
                MyData = (byte[])dtTableImg.Rows[0]["CAR_IMAGE"];
                MemoryStream stream = new MemoryStream(MyData);

                Image img = Image.FromStream(stream);              
                byte[] data = DevExpress.XtraEditors.Controls.ByteImageConverter.ToByteArray(img, img.RawFormat);
                picEdtImage.EditValue = data;
            }
            
        }
    }
}
