#if !UNITY_EDITOR

using BepInEx;
using GamePanelHUDCore.Attributes;
using GamePanelHUDCore.Models;
using KmyTarkovUtils;
using SettingsModel = GamePanelHUDWeapon.Models.SettingsModel;

namespace GamePanelHUDWeapon
{
    [BepInPlugin(
        "com.kmyuhkyuk.GamePanelHUDWeapon",
        "GamePanelHUDWeapon",
        "3.4.0")]
    [BepInDependency(
        "com.kmyuhkyuk.GamePanelHUDCore",
        "3.4.0")]
    [EFTConfigurationPluginAttributes(
        "",
        @"localized\weapon")]
    public class GamePanelHUDWeaponPlugin : BaseUnityPlugin
    {
        private void Awake()
        {
            SettingsModel.Create(Config);
        }

        private void Start()
        {
            foreach (var value in HUDCoreModel.Instance
                         .LoadHUD(
                             "gamepanelweaponhud.bundle",
                             "GamePanelWeaponHUD")
                         .Init.Values)
            {
                value.ReplaceAllFont(EFTFontHelper.BenderNormal);
            }
        }
    }
}

#endif