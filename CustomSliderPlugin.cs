using System.Collections.Generic;
using System.IO;
using System.Web.Routing;
using Nop.Core;
using Nop.Core.Plugins;
using Nop.Services.Cms;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Media;

namespace Nop.Plugin.Widgets.CustomSlider
{
    /// <summary>
    /// PLugin
    /// </summary>
    public class CustomSliderPlugin : BasePlugin, IWidgetPlugin
    {
        private readonly IPictureService _pictureService;
        private readonly ISettingService _settingService;
        private readonly IWebHelper _webHelper;

        public CustomSliderPlugin(IPictureService pictureService, 
            ISettingService settingService, IWebHelper webHelper)
        {
            this._pictureService = pictureService;
            this._settingService = settingService;
            this._webHelper = webHelper;
        }

        /// <summary>
        /// Gets widget zones where this widget should be rendered
        /// </summary>
        /// <returns>Widget zones</returns>
        public IList<string> GetWidgetZones()
        {
            return new List<string>() { "home_page_top" };
        }

        /// <summary>
        /// Gets a route for provider configuration
        /// </summary>
        /// <param name="actionName">Action name</param>
        /// <param name="controllerName">Controller name</param>
        /// <param name="routeValues">Route values</param>
        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "WidgetsCustomSlider";
            routeValues = new RouteValueDictionary() { { "Namespaces", "Nop.Plugin.Widgets.CustomSlider.Controllers" }, { "area", null } };
        }

        /// <summary>
        /// Gets a route for displaying widget
        /// </summary>
        /// <param name="widgetZone">Widget zone where it's displayed</param>
        /// <param name="actionName">Action name</param>
        /// <param name="controllerName">Controller name</param>
        /// <param name="routeValues">Route values</param>
        public void GetDisplayWidgetRoute(string widgetZone, out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "PublicInfo";
            controllerName = "WidgetsCustomSlider";
            routeValues = new RouteValueDictionary()
            {
                {"Namespaces", "Nop.Plugin.Widgets.CustomSlider.Controllers"},
                {"area", null},
                {"widgetZone", widgetZone}
            };
        }
        
        /// <summary>
        /// Install plugin
        /// </summary>
        public override void Install()
        {
            //pictures
            var sampleImagesPath = _webHelper.MapPath("~/Plugins/Widgets.CustomSlider/Content/Customslider/sample-images/");


            //settings
            var settings = new CustomSliderSettings()
            {
                Picture1Id = _pictureService.InsertPicture(File.ReadAllBytes(sampleImagesPath + "banner1.jpg"), "image/pjpeg", "banner_1", true).Id,
                Title1 = "",
                ButtonText1="",
                ShortDescription1="",
                Link1 = _webHelper.GetStoreLocation(false),
                Picture2Id = _pictureService.InsertPicture(File.ReadAllBytes(sampleImagesPath + "banner2.jpg"), "image/pjpeg", "banner_2", true).Id,
                Title2 = "",
                ButtonText2 = "",
                ShortDescription2 = "",
                Link2 = _webHelper.GetStoreLocation(false),
                Picture3Id = _pictureService.InsertPicture(File.ReadAllBytes(sampleImagesPath + "banner3.jpg"), "image/pjpeg", "banner_3", true).Id,
                Title3 = "",
                ButtonText3 = "",
                ShortDescription3 = "",
                Link3 = _webHelper.GetStoreLocation(false),
                Picture4Id = _pictureService.InsertPicture(File.ReadAllBytes(sampleImagesPath + "banner4.jpg"), "image/pjpeg", "banner_4", true).Id,
                Title4 = "",
                ButtonText4 = "",
                ShortDescription4 = "",
                Link4 = _webHelper.GetStoreLocation(false),
                Picture5Id = _pictureService.InsertPicture(File.ReadAllBytes(sampleImagesPath + "banner5.jpg"), "image/pjpeg", "banner_4", true).Id,
                Title5 = "",
                ButtonText5 = "",
                ShortDescription5 = "",
                Link5 = _webHelper.GetStoreLocation(false),
                Picture6Id = _pictureService.InsertPicture(File.ReadAllBytes(sampleImagesPath + "banner6.jpg"), "image/pjpeg", "banner_4", true).Id,
                Title6 = "",
                ButtonText6 = "",
                ShortDescription6 = "",
                Link6 = _webHelper.GetStoreLocation(false),
            };
            _settingService.SaveSetting(settings);


            this.AddOrUpdatePluginLocaleResource("Plugins.Widgets.CustomSlider.slider1", "Slider 1");
            this.AddOrUpdatePluginLocaleResource("Plugins.Widgets.CustomSlider.slider2", "Slider1 2");
            this.AddOrUpdatePluginLocaleResource("Plugins.Widgets.CustomSlider.slider3", "Slider 3");
            this.AddOrUpdatePluginLocaleResource("Plugins.Widgets.CustomSlider.slider4", "Slider 4");
            this.AddOrUpdatePluginLocaleResource("Plugins.Widgets.CustomSlider.slider5", "Slider 5");
            this.AddOrUpdatePluginLocaleResource("Plugins.Widgets.CustomSlider.slider6", "Slider 6");
            this.AddOrUpdatePluginLocaleResource("Plugins.Widgets.CustomSlider.Picture", "Picture");
            this.AddOrUpdatePluginLocaleResource("Plugins.Widgets.CustomSlider.Picture.Hint", "Upload picture.");
            this.AddOrUpdatePluginLocaleResource("Plugins.Widgets.CustomSlider.Title", "Title");
            this.AddOrUpdatePluginLocaleResource("Plugins.Widgets.CustomSlider.ButtonText", "ButtonText");
            this.AddOrUpdatePluginLocaleResource("Plugins.Widgets.CustomSlider.ShortDescription", "Short Description"); 
            this.AddOrUpdatePluginLocaleResource("Plugins.Widgets.CustomSlider.Link", "URL");
            this.AddOrUpdatePluginLocaleResource("Plugins.Widgets.CustomSlider.Link.Hint", "Enter URL. Leave empty if don't want this picture to be clickable.");

            base.Install();
        }

        /// <summary>
        /// Uninstall plugin
        /// </summary>
        public override void Uninstall()
        {
            //settings
            _settingService.DeleteSetting<CustomSliderSettings>();

            //locales
            this.DeletePluginLocaleResource("Plugins.Widgets.CustomSlider.slider1");
            this.DeletePluginLocaleResource("Plugins.Widgets.CustomSlider.slider1");
            this.DeletePluginLocaleResource("Plugins.Widgets.CustomSlider.slider1");
            this.DeletePluginLocaleResource("Plugins.Widgets.CustomSlider.slider1");
            this.DeletePluginLocaleResource("Plugins.Widgets.CustomSlider.slider1");
            this.DeletePluginLocaleResource("Plugins.Widgets.CustomSlider.slider1");
            this.DeletePluginLocaleResource("Plugins.Widgets.CustomSlider.Picture");
            this.DeletePluginLocaleResource("Plugins.Widgets.CustomSlider.Picture.Hint");
            this.DeletePluginLocaleResource("Plugins.Widgets.CustomSlider.Title");
            this.DeletePluginLocaleResource("Plugins.Widgets.CustomSlider.ButtonText");
            this.DeletePluginLocaleResource("Plugins.Widgets.CustomSlider.ShortDescription"); 
            this.DeletePluginLocaleResource("Plugins.Widgets.CustomSlider.Link");
            this.DeletePluginLocaleResource("Plugins.Widgets.CustomSlider.Link.Hint");
            
            base.Uninstall();
        }
    }
}
