﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace RobX.Library.Properties {
    
    
    [CompilerGenerated()]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("Black")]
        public Color DefaultLogItemColor {
            get {
                return ((Color)(this["DefaultLogItemColor"]));
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("DarkRed")]
        public Color ErrorLogItemColor {
            get {
                return ((Color)(this["ErrorLogItemColor"]));
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("LightSeaGreen")]
        public Color ReceiveLogItemColor {
            get {
                return ((Color)(this["ReceiveLogItemColor"]));
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("DodgerBlue")]
        public Color SendLogItemColor {
            get {
                return ((Color)(this["SendLogItemColor"]));
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("OrangeRed")]
        public Color WarningLogItemColor {
            get {
                return ((Color)(this["WarningLogItemColor"]));
            }
        }
        
        [ApplicationScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("White")]
        public Color DefaultLogItemBackColor {
            get {
                return ((Color)(this["DefaultLogItemBackColor"]));
            }
        }
    }
}
