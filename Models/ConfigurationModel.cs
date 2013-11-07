using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc;

namespace Nop.Plugin.Widgets.CustomSlider.Models
{
    public class ConfigurationModel : BaseNopModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }


        [NopResourceDisplayName("Plugins.Widgets.CustomSlider.Picture")]
        [UIHint("Picture")]
        public int Picture1Id { get; set; }
        public bool Picture1Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.Customslider.Title")]
        [AllowHtml]
        public string Title1 { get; set; }
        public bool Title1_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.Customslider.ButtonText")]
        [AllowHtml]
        public string ButtonText1 { get; set; }
        public bool ButtonText1_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.Customslider.ShortDescription")]
        [AllowHtml]
        public string ShortDescription1 { get; set; }
        public bool ShortDescription1_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.CustomSlider.Link")]
        [AllowHtml]
        public string Link1 { get; set; }
        public bool Link1_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.CustomSlider.Picture")]
        [UIHint("Picture")]
        public int Picture2Id { get; set; }
        public bool Picture2Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.Customslider.Title")]
        [AllowHtml]
        public string Title2 { get; set; }
        public bool Title2_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.Customslider.ButtonText")]
        [AllowHtml]
        public string ButtonText2 { get; set; }
        public bool ButtonText2_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.Customslider.ShortDescription")]
        [AllowHtml]
        public string ShortDescription2 { get; set; }
        public bool ShortDescription2_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.CustomSlider.Link")]
        [AllowHtml]
        public string Link2 { get; set; }
        public bool Link2_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.CustomSlider.Picture")]
        [UIHint("Picture")]
        public int Picture3Id { get; set; }
        public bool Picture3Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.Customslider.Title")]
        [AllowHtml]
        public string Title3 { get; set; }
        public bool Title3_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.Customslider.ButtonText")]
        [AllowHtml]
        public string ButtonText3 { get; set; }
        public bool ButtonText3_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.Customslider.ShortDescription")]
        [AllowHtml]
        public string ShortDescription3 { get; set; }
        public bool ShortDescription3_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.CustomSlider.Link")]
        [AllowHtml]
        public string Link3 { get; set; }
        public bool Link3_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.CustomSlider.Picture")]
        [UIHint("Picture")]
        public int Picture4Id { get; set; }
        public bool Picture4Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.Customslider.Title")]
        [AllowHtml]
        public string Title4 { get; set; }
        public bool Title4_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.Customslider.ButtonText")]
        [AllowHtml]
        public string ButtonText4 { get; set; }
        public bool ButtonText4_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.Customslider.ShortDescription")]
        [AllowHtml]
        public string ShortDescription4 { get; set; }
        public bool ShortDescription4_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.CustomSlider.Link")]
        [AllowHtml]
        public string Link4 { get; set; }
        public bool Link4_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.CustomSlider.Picture")]
        [UIHint("Picture")]
        public int Picture5Id { get; set; }
        public bool Picture5Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.Customslider.Title")]
        [AllowHtml]
        public string Title5 { get; set; }
        public bool Title5_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.Customslider.ButtonText")]
        [AllowHtml]
        public string ButtonText5 { get; set; }
        public bool ButtonText5_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.Customslider.ShortDescription")]
        [AllowHtml]
        public string ShortDescription5 { get; set; }
        public bool ShortDescription5_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.CustomSlider.Link")]
        [AllowHtml]
        public string Link5 { get; set; }
        public bool Link5_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.CustomSlider.Picture")]
        [UIHint("Picture")]
        public int Picture6Id { get; set; }
        public bool Picture6Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.Customslider.Title")]
        [AllowHtml]
        public string Title6 { get; set; }
        public bool Title6_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.Customslider.ButtonText")]
        [AllowHtml]
        public string ButtonText6 { get; set; }
        public bool ButtonText6_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.Customslider.ShortDescription")]
        [AllowHtml]
        public string ShortDescription6 { get; set; }
        public bool ShortDescription6_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.CustomSlider.Link")]
        [AllowHtml]
        public string Link6 { get; set; }
        public bool Link6_OverrideForStore { get; set; }


    }
}