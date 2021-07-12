﻿namespace SophiApp.Helpers
{
    internal static class ActionsData
    {
        internal const string _100_DIAGTRACK_NAME = "DiagTrack";
        internal const string _101_MAX_TELEMETRY_NAME = "MaxTelemetryAllowed";
        internal const string _101_MAX_TELEMETRY_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\DataCollection";
        internal const string _101_TELEMETRY_NAME = "AllowTelemetry";
        internal const string _101_TELEMETRY_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\DataCollection";
        internal const byte _101_TELEMETRY_VALUE = 3;
        internal const string _101_TOAST_LEVEL_NAME = "ShowedToastAtLevel";
        internal const string _101_TOAST_LEVEL_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Diagnostics\DiagTrack";
        internal const string _104_CORE_EDITION_NAME = "Core";
        internal const string _104_QUEUE_REPORTING_NAME = "QueueReporting";
        internal const string _104_WER_DISABLED_NAME = "Disabled";
        internal const byte _104_WER_DISABLED_VALUE = 1;
        internal const string _104_WER_NAME = "Disabled";
        internal const string _104_WER_PATH = @"SOFTWARE\Microsoft\Windows\Windows Error Reporting";
        internal const string _104_WER_SVC_NAME = "WerSvc";
        internal const string _109_DATA_UPDATER_NAME = "ProgramDataUpdater";
        internal const string _110_PROXY_NAME = "Proxy";
        internal const string _111_CONSOLIDATOR_NAME = "Consolidator";
        internal const string _112_USB_CEIP_NAME = "UsbCeip";
        internal const string _113_DATA_COLLECTOR_NAME = "Microsoft-Windows-DiskDiagnosticDataCollector";
        internal const string _114_TOAST_TASK_NAME = "MapsToastTask";
        internal const string _115_UPDATE_TASK_NAME = "MapsUpdateTask";
        internal const string _116_SAFETY_MONITOR_NAME = "FamilySafetyMonitor";
        internal const string _117_SAFETY_REFRESH_NAME = "FamilySafetyRefreshTask";
        internal const string _118_GAME_SAVE_NAME = "XblGameSaveTask";
        internal const string _265_COMMAND_NAME = "Command";
        internal const string _265_COMMAND_PATH = @"Msi.Package\shell\Extract\Command";
        internal const string _265_EXTRACT_PATH = @"Msi.Package\shell\Extract";
        internal const string _265_EXTRACT_VALUE = "msiexec.exe /a \"%1\" /qb TARGETDIR=\"%1 extracted\"";
        internal const string _265_ICON_NAME = "Icon";
        internal const string _265_ICON_VALUE = "shell32.dll,-16817";
        internal const string _265_MUIVERB_NAME = "MUIVerb";
        internal const string _265_MUIVERB_VALUE = "@shell32.dll,-37514";
        internal const string _267_EXTENDED_NAME = "Extended";
        internal const string _267_RUNASUSER_PATH = @"exefile\shell\runasuser";
        internal const string _268_CAST_TO_DEVICE_NAME = "{7AD84985-87B4-4a16-BE58-8B72A5B390F7}";
        internal const string _268_CAST_TO_DEVICE_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Shell Extensions\Blocked";
        internal const string _268_CAST_TO_DEVICE_VALUE = "Play to menu";
        internal const string _269_SHARE_CONTENT_NAME = "{E2BF9676-5F8F-435C-97EB-11607A5BEDF7}";
        internal const string _269_SHARE_CONTENT_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Shell Extensions\Blocked";
        internal const string _271_3D_EDIT_BMP_PATH = @"SystemFileAssociations\.bmp\Shell\3D Edit";
        internal const string _272_3D_EDIT_GIF_PATH = @"SystemFileAssociations\.gif\Shell\3D Edit";
        internal const string _273_3D_EDIT_JPE_PATH = @"SystemFileAssociations\.jpe\Shell\3D Edit";
        internal const string _274_3D_EDIT_JPEG_PATH = @"SystemFileAssociations\.jpeg\Shell\3D Edit";
        internal const string _275_3D_EDIT_JPG_PATH = @"SystemFileAssociations\.jpg\Shell\3D Edit";
        internal const string _276_3D_EDIT_PNG_PATH = @"SystemFileAssociations\.png\Shell\3D Edit";
        internal const string _277_3D_EDIT_TIF_PATH = @"SystemFileAssociations\.tif\Shell\3D Edit";
        internal const string _278_3D_EDIT_TIFF_PATH = @"SystemFileAssociations\.tiff\Shell\3D Edit";
        internal const string _279_SHELL_EDIT_PATH = @"AppX43hnxtbyyps62jhe9sqpdzxn1790zetc\Shell\ShellEdit";
        internal const string _279_UWP_PHOTOS_NAME = "Microsoft.Windows.Photos";
        internal const string _280_SHELL_CREATE_PATH = @"AppX43hnxtbyyps62jhe9sqpdzxn1790zetc\Shell\ShellCreateVideo";
        internal const string _281_SHELL_EDIT_PATH = @"SystemFileAssociations\image\shell\edit";
        internal const string _282_BAT_PRINT_PATH = @"batfile\shell\print";
        internal const string _282_CMD_PRINT_PATH = @"cmdfile\shell\print";
        internal const string _283_LIBRARY_LOCATION_PATH = @"Folder\ShellEx\ContextMenuHandlers\Library Location";
        internal const string _283_LIBRARY_LOCATION_VALUE = "{3dad6c5d-2167-4cae-9914-f99e41c12cfa}";
        internal const string _284_SEND_TO_PATH = @"AllFilesystemObjects\shellex\ContextMenuHandlers\SendTo";
        internal const string _284_SEND_TO_VALUE = "{7BA4C740-9E81-11CF-99D3-00AA004AE837}";
        internal const string _285_ENCRYPT_BDE_ELEV_PATH = @"Drive\shell\encrypt-bde-elev";
        internal const string _285_ENCRYPT_BDE_PATH = @"Drive\shell\encrypt-bde";
        internal const string _285_ENT_EDITION = "Enterprise";
        internal const string _285_MANAGE_BDE_PATH = @"Drive\shell\manage-bde";
        internal const string _285_PRO_EDITION = "Professional";
        internal const string _285_RESUME_BDE_ELEV_PATH = @"Drive\shell\resume-bde-elev";
        internal const string _285_RESUME_BDE_PATH = @"Drive\shell\resume-bde";
        internal const string _285_UNLOCK_BDE_PATH = @"Drive\shell\unlock-bde";
        internal const string _286_ITEM_NAME = "ItemName";
        internal const string _286_ITEM_VALUE = @"%systemroot%\system32\mspaint.exe,-59414";
        internal const string _286_NULL_FILE_NAME = "NullFile";
        internal const string _286_SHELL_NEW_PATH = @".bmp\ShellNew";
        internal const string _287_CAPABILITY_WORDPAD_NAME = "Microsoft.Windows.WordPad";
        internal const string _287_DATA_NAME = "Data";
        internal const string _287_DATA_VALUE = @"{\rtf1}";
        internal const string _287_ITEM_NAME = "ItemName";
        internal const string _287_ITEM_VALUE = @"%ProgramFiles%\Windows NT\Accessories\WORDPAD.EXE,-213";
        internal const string _287_SHELL_NEW_PATH = @".rtf\ShellNew";
        internal const string _288_DATA_NAME = "Data";
        internal const string _288_ITEM_NAME = "ItemName";
        internal const string _288_ITEM_VALUE = @"@%SystemRoot%\system32\zipfldr.dll,-10194";
        internal const string _288_SHELL_NEW_PATH = @".zip\CompressedFolder\ShellNew";
        internal const string _289_EXPLORER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer";
        internal const string _289_PROMPT_MIN_NAME = "MultipleInvokePromptMinimum";
        internal const uint _289_PROMPT_MIN_VALUE = 300;
        internal const string _290_EXPLORER_PATH = @"SOFTWARE\Policies\Microsoft\Windows\Explorer";
        internal const string _290_OPEN_WITH_NAME = "NoUseStoreOpenWith";
        internal const byte _290_OPEN_WITH_VALUE = 1;
        internal const string CAPABILITY_PAINT_NAME = "Microsoft.Windows.MSPaint";
        internal const string CURRENT_VERSION = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";
        internal const string DISPLAY_VERSION_NAME = "DisplayVersion";
        internal const string EDITION_ID_NAME = "EditionID";
        internal const string EXCEPTION_BITLOCKER_IS_ENABLED = "BitLocker protection is enabled";
        internal const string EXCEPTION_CAPABILITY_NOT_FOUND = "not found in fod list";
        internal const string EXCEPTION_NOT_SUPPORTED_OS_VERSION = "Not supported version of windows";
        internal const string EXCEPTION_UWP_NOT_FOUND = "not found in uwp package list";
        internal const string PRODUCT_NAME = "ProductName";
        internal const string PROGRAMMATIC_ACCESS_ONLY_NAME = "ProgrammaticAccessOnly";
        internal const string REGISTRED_ORGANIZATION_NAME = "RegisteredOrganization";
        internal const string REGISTRED_OWNER_NAME = "RegisteredOwner";
        internal const string UWP_3D_PAINT_NAME = "Microsoft.MSPaint";
        internal static readonly string _283_LIBRARY_LOCATION_MINUS_VALUE = $"-{_283_LIBRARY_LOCATION_VALUE}";
        internal static readonly string _284_SEND_TO_MINUS_VALUE = $"-{_284_SEND_TO_VALUE}";
        internal static byte[] _288_DATA_VALUE = new byte[] { 80, 75, 5, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    }
}