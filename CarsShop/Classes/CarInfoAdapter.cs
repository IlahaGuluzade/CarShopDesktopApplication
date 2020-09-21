using CarsShop.Utils;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Office.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShop.Classes
{
    class CarInfoAdapter
    {
        SqlUtils sqlUtils = SqlUtils.GetInstance();
        public DataTable GetCarBrand()
        {
            string query = $@"SELECT -1 ID, 'Bütün markalar' BRAND_NAME
                              UNION
                              SELECT ID, BRAND_NAME FROM CAR_BRANDS";
            return sqlUtils.GetDataWitAdapter(query);
        }

        public DataTable GetCarModel(string brandId)
        {
            string query = $"SELECT ID, MODEL_NAME FROM CAR_MODEL WHERE BRAND_ID={brandId}";
            return sqlUtils.GetDataWitAdapter(query);
        }

        public DataTable GetCarGeneralInfo(string typeId)
        {
            string query = $"SELECT ID, NAME FROM GENERAL_INFO WHERE TYPE_ID={typeId}";
            return sqlUtils.GetDataWitAdapter(query);
        }

        public DataTable GetCarImages(string adsId)
        {
            string query = $"SELECT [ID],[CAR_IMAGE],[ADS_ID] FROM[dbo].[TB_ADS_IMAGE] WHERE ADS_ID={adsId}";
            return SqlUtils.GetInstance().GetDataWitAdapter(query);
        }
    }
}
