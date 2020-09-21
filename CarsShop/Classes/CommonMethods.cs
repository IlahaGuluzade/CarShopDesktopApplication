using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShop.Classes
{
    class CommonMethods
    {
        CarInfoAdapter carInfoAdapter = new CarInfoAdapter();
        public void SetGeneralInfo(LookUpEdit lookUpEdit, string typeId)
        {
            lookUpEdit.Properties.DataSource = carInfoAdapter.GetCarGeneralInfo(typeId);
            lookUpEdit.Properties.DisplayMember = "NAME";
            lookUpEdit.Properties.ValueMember = "ID";
        }
        public void SetCarBrandData(LookUpEdit lkUpEdtCarBrand)
        {
            lkUpEdtCarBrand.Properties.DataSource = carInfoAdapter.GetCarBrand();
            lkUpEdtCarBrand.Properties.DisplayMember = "BRAND_NAME";
            lkUpEdtCarBrand.Properties.ValueMember = "ID";
        }
        public void SetCarModelData(LookUpEdit lkUpEdtCarModel,string brandId)
        {           
                lkUpEdtCarModel.Properties.DataSource = carInfoAdapter.GetCarModel(brandId);
                lkUpEdtCarModel.Properties.DisplayMember = "MODEL_NAME";
                lkUpEdtCarModel.Properties.ValueMember = "ID";
        }
        public void SetCarYear(LookUpEdit lkUpEdtCarYear)
        {
            List<int> yearList = new List<int>();
            for (int i = DateTime.Now.Year; i >= 1960; i--)
            {
                yearList.Add(i);
            }
            lkUpEdtCarYear.Properties.DataSource = yearList;
        }
    }
}
