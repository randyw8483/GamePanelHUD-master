# GamePanelHUD SPT 4.1.3 test port

- Game assemblies resolve from `C:\SPT`.
- Kmy dependencies resolve from `C:\SPT\BepInEx\plugins\kmyuhkyuk-KmyTarkovApi`.
- Private strong-name signing was disabled.
- Known EFT 4.1.3 renames were applied for launcher, damage, main-menu, and airdrop APIs.
- Unload `Build`, `GamePanelHUDDebug`, and `GamePanelHUDMap` before compiling the runtime HUD projects.
