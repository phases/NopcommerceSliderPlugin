using System.Web.Mvc;
using Nop.Core;
using Nop.Plugin.Widgets.CustomSlider.Models;
using Nop.Services.Configuration;
using Nop.Services.Media;
using Nop.Services.Stores;
using Nop.Web.Framework.Controllers;

namespace Nop.Plugin.Widgets.CustomSlider.Controllers
{
    public class WidgetsCustomSliderController : Controller
    {
        private readonly IWorkContext _workContext;
        private readonly IStoreContext _storeConButtonText;
        private readonly IStoreService _storeService;
        private readonly IPictureService _pictureService;
        private readonly ISettingService _settingService;

        public WidgetsCustomSliderController(IWorkContext workConButtonText,
            IStoreContext storeConButtonText, IStoreService storeService, 
            IPictureService pictureService, ISettingService settingService)
        {
            this._workContext = workConButtonText;
            this._storeConButtonText = storeConButtonText;
            this._storeService = storeService;
            this._pictureService = pictureService;
            this._settingService = settingService;
        }
        
        [AdminAuthorize]
        [ChildActionOnly]
        public ActionResult Configure()
        {
            //load settings for a chosen store scope
            var storeScope = this.GetActiveStoreScopeConfiguration(_storeService,_workContext);
            var CustomSliderSettings = _settingService.LoadSetting<CustomSliderSettings>(storeScope);
            var model = new ConfigurationModel();
            model.Picture1Id = CustomSliderSettings.Picture1Id;
            model.Title1 = CustomSliderSettings.Title1;
            model.ShortDescription1 = CustomSliderSettings.ShortDescription1;
            model.ButtonText1 = CustomSliderSettings.ButtonText1;
            model.Link1 = CustomSliderSettings.Link1;

            model.Picture2Id = CustomSliderSettings.Picture2Id;
            model.Title2 = CustomSliderSettings.Title2;
            model.ShortDescription2 = CustomSliderSettings.ShortDescription2;
            model.ButtonText2 = CustomSliderSettings.ButtonText2;
            model.Link2 = CustomSliderSettings.Link2;

            model.Picture3Id = CustomSliderSettings.Picture3Id;
            model.Title3 = CustomSliderSettings.Title3;
            model.ShortDescription3 = CustomSliderSettings.ShortDescription3;
            model.ButtonText3 = CustomSliderSettings.ButtonText3;
            model.Link3 = CustomSliderSettings.Link3;

            model.Picture4Id = CustomSliderSettings.Picture4Id;
            model.Title4 = CustomSliderSettings.Title3;
            model.ShortDescription4 = CustomSliderSettings.ShortDescription4;
            model.ButtonText4 = CustomSliderSettings.ButtonText4;
            model.Link4 = CustomSliderSettings.Link4;

            model.Picture5Id = CustomSliderSettings.Picture5Id;
            model.Title5 = CustomSliderSettings.Title5;
            model.ShortDescription5 = CustomSliderSettings.ShortDescription5;
            model.ButtonText5 = CustomSliderSettings.ButtonText5;
            model.Link5 = CustomSliderSettings.Link5;

            model.Picture6Id = CustomSliderSettings.Picture6Id;
            model.Title6 = CustomSliderSettings.Title6;
            model.ShortDescription6 = CustomSliderSettings.ShortDescription6;
            model.ButtonText6 = CustomSliderSettings.ButtonText6;
            model.Link6 = CustomSliderSettings.Link6;

            model.ActiveStoreScopeConfiguration = storeScope;
            if (storeScope > 0)
            {
                model.Picture1Id_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.Picture1Id, storeScope);
                model.Title1_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.Title1, storeScope);
                model.ShortDescription1_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.ShortDescription1, storeScope);
                model.ButtonText1_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.ButtonText1, storeScope);
                model.Link1_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.Link1, storeScope);

                model.Picture2Id_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.Picture2Id, storeScope);
                model.Title2_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.Title2, storeScope);
                model.ShortDescription2_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.ShortDescription2, storeScope);
                model.ButtonText2_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.ButtonText2, storeScope);
                model.Link2_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.Link2, storeScope);

                model.Picture3Id_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.Picture3Id, storeScope);
                model.Title3_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.Title3, storeScope);
                model.ShortDescription3_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.ShortDescription3, storeScope);
                model.ButtonText3_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.ButtonText3, storeScope);
                model.Link3_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.Link3, storeScope);

                model.Picture4Id_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.Picture4Id, storeScope);
                model.Title4_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.Title4, storeScope);
                model.ShortDescription4_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.ShortDescription4, storeScope);
                model.ButtonText4_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.ButtonText4, storeScope);
                model.Link4_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.Link4, storeScope);

                model.Picture5Id_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.Picture5Id, storeScope);
                model.Title5_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.Title5, storeScope);
                model.ShortDescription5_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.ShortDescription5, storeScope);
                model.ButtonText5_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.ButtonText5, storeScope);
                model.Link5_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.Link5, storeScope);

                model.Picture6Id_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.Picture6Id, storeScope);
                model.Title6_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.Title6, storeScope);
                model.ShortDescription6_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.ShortDescription6, storeScope);
                model.ButtonText6_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.ButtonText4, storeScope);
                model.Link4_OverrideForStore = _settingService.SettingExists(CustomSliderSettings, x => x.Link6, storeScope);
            }

            return View("Nop.Plugin.Widgets.CustomSlider.Views.WidgetsCustomSlider.Configure", model);
        }

        [HttpPost]
        [AdminAuthorize]
        [ChildActionOnly]
        public ActionResult Configure(ConfigurationModel model)
        {
            //load settings for a chosen store scope
            var storeScope = this.GetActiveStoreScopeConfiguration(_storeService, _workContext);
            var CustomSliderSettings = _settingService.LoadSetting<CustomSliderSettings>(storeScope);
            CustomSliderSettings.Picture1Id = model.Picture1Id;
            CustomSliderSettings.Title1 = model.Title1;
            CustomSliderSettings.ShortDescription1 = model.ShortDescription1;
            CustomSliderSettings.ButtonText1 = model.ButtonText1;
            CustomSliderSettings.Link1 = model.Link1;

            CustomSliderSettings.Picture2Id = model.Picture2Id;
            CustomSliderSettings.Title2 = model.Title2;
            CustomSliderSettings.ShortDescription2 = model.ShortDescription2;
            CustomSliderSettings.ButtonText2 = model.ButtonText2;
            CustomSliderSettings.Link2 = model.Link2;

            CustomSliderSettings.Picture3Id = model.Picture3Id;
            CustomSliderSettings.Title3 = model.Title3;
            CustomSliderSettings.ShortDescription3 = model.ShortDescription3;
            CustomSliderSettings.ButtonText3 = model.ButtonText3;
            CustomSliderSettings.Link3 = model.Link3;

            CustomSliderSettings.Picture4Id = model.Picture4Id;
            CustomSliderSettings.Title4 = model.Title4;
            CustomSliderSettings.ShortDescription4 = model.ShortDescription4;
            CustomSliderSettings.ButtonText4 = model.ButtonText4;
            CustomSliderSettings.Link4 = model.Link4;

            CustomSliderSettings.Picture5Id = model.Picture5Id;
            CustomSliderSettings.Title5 = model.Title5;
            CustomSliderSettings.ShortDescription5 = model.ShortDescription5;
            CustomSliderSettings.ButtonText5 = model.ButtonText5;
            CustomSliderSettings.Link5 = model.Link5;

            CustomSliderSettings.Picture6Id = model.Picture6Id;
            CustomSliderSettings.Title6 = model.Title6;
            CustomSliderSettings.ShortDescription6 = model.ShortDescription6;
            CustomSliderSettings.ButtonText6 = model.ButtonText6;
            CustomSliderSettings.Link6 = model.Link6;

            /* We do not clear cache after each setting update.
             * This behavior can increase performance because cached settings will not be cleared 
             * and loaded from database after each update */
            if (model.Picture1Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.Picture1Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.Picture1Id, storeScope);
            
            if (model.Title1_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.Title1, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.Title1, storeScope);

            if (model.ShortDescription1_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.ShortDescription1, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.ShortDescription1, storeScope);

            if (model.ButtonText1_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.ButtonText1, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.ButtonText1, storeScope);


            if (model.Link1_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.Link1, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.Link1, storeScope);
            
            if (model.Picture2Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.Picture2Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.Picture2Id, storeScope);
            
            if (model.Title2_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.Title2, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.Title2, storeScope);

            if (model.ShortDescription2_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.ShortDescription2, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.ShortDescription2, storeScope);

            if (model.ButtonText2_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.ButtonText2, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.ButtonText2, storeScope);


            if (model.Link2_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.Link2, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.Link2, storeScope);
            
            if (model.Picture3Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.Picture3Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.Picture3Id, storeScope);
            
            if (model.Title3_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.Title3, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.Title3, storeScope);

            if (model.ShortDescription3_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.ShortDescription3, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.ShortDescription3, storeScope);

            if (model.ButtonText3_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.ButtonText3, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.ButtonText3, storeScope);

            if (model.Link3_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.Link3, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.Link3, storeScope);
            
            if (model.Picture4Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.Picture4Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.Picture4Id, storeScope);

            if (model.Title4_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.Title4, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.Title4, storeScope);

            if (model.ShortDescription4_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.ShortDescription4, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.ShortDescription4, storeScope);

            if (model.ButtonText4_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.ButtonText4, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.ButtonText4, storeScope);

            if (model.Link4_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.Link4, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.Link4, storeScope);

            if (model.Picture5Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.Picture5Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.Picture5Id, storeScope);

            if (model.Title5_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.Title5, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.Title5, storeScope);

            if (model.ShortDescription5_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.ShortDescription5, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.ShortDescription5, storeScope);

            if (model.ButtonText5_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.ButtonText5, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.ButtonText5, storeScope);

            if (model.Link5_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.Link5, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.Link5, storeScope);

            if (model.Picture6Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.Picture6Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.Picture6Id, storeScope);

            if (model.Title6_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.Title6, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.Title6, storeScope);

            if (model.ShortDescription6_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.ShortDescription6, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.ShortDescription6, storeScope);

            if (model.ButtonText6_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.ButtonText6, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.ButtonText6, storeScope);

            if (model.Link5_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(CustomSliderSettings, x => x.Link6, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(CustomSliderSettings, x => x.Link6, storeScope);
            
            //now clear settings cache
            _settingService.ClearCache();
            
            return Configure();
        }

        [ChildActionOnly]
        public ActionResult PublicInfo(string widgetZone)
        {
            var CustomSliderSettings = _settingService.LoadSetting<CustomSliderSettings>(_storeConButtonText.CurrentStore.Id);

            var model = new PublicInfoModel();
            model.Picture1Url = _pictureService.GetPictureUrl(CustomSliderSettings.Picture1Id, showDefaultPicture: false);
            model.Title1 = CustomSliderSettings.Title1;
            model.ShortDescription1 = CustomSliderSettings.ShortDescription1;
            model.ButtonText1 = CustomSliderSettings.ButtonText1;
            model.Link1 = CustomSliderSettings.Link1;

            model.Picture2Url = _pictureService.GetPictureUrl(CustomSliderSettings.Picture2Id, showDefaultPicture: false);
            model.Title2 = CustomSliderSettings.Title2;
            model.ShortDescription2 = CustomSliderSettings.ShortDescription2;
            model.ButtonText2 = CustomSliderSettings.ButtonText2;
            model.Link2 = CustomSliderSettings.Link2;

            model.Picture3Url = _pictureService.GetPictureUrl(CustomSliderSettings.Picture3Id, showDefaultPicture: false);
            model.Title3 = CustomSliderSettings.Title3;
            model.ShortDescription3 = CustomSliderSettings.ShortDescription3;
            model.ButtonText3 = CustomSliderSettings.ButtonText3;
            model.Link3 = CustomSliderSettings.Link3;

            model.Picture4Url = _pictureService.GetPictureUrl(CustomSliderSettings.Picture4Id, showDefaultPicture: false);
            model.Title4 = CustomSliderSettings.Title4;
            model.ShortDescription4 = CustomSliderSettings.ShortDescription4;
            model.ButtonText4 = CustomSliderSettings.ButtonText4;
            model.Link4 = CustomSliderSettings.Link4;

            model.Picture5Url = _pictureService.GetPictureUrl(CustomSliderSettings.Picture5Id, showDefaultPicture: false);
            model.Title5 = CustomSliderSettings.Title5;
            model.ShortDescription5 = CustomSliderSettings.ShortDescription5;
            model.ButtonText5 = CustomSliderSettings.ButtonText5;
            model.Link5 = CustomSliderSettings.Link4;

            model.Picture6Url = _pictureService.GetPictureUrl(CustomSliderSettings.Picture6Id, showDefaultPicture: false);
            model.Title6 = CustomSliderSettings.Title6;
            model.ShortDescription6 = CustomSliderSettings.ShortDescription6;
            model.ButtonText6 = CustomSliderSettings.ButtonText6;
            model.Link6 = CustomSliderSettings.Link4;

            if (string.IsNullOrEmpty(model.Picture1Url) && string.IsNullOrEmpty(model.Picture2Url) &&
                string.IsNullOrEmpty(model.Picture3Url) && string.IsNullOrEmpty(model.Picture4Url))
                //no pictures uploaded
                return Content("");
            

            return View("Nop.Plugin.Widgets.CustomSlider.Views.WidgetsCustomSlider.PublicInfo", model);
        }
    }
}