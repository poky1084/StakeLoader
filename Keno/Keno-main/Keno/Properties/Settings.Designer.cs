﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Keno.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string apikey {
            get {
                return ((string)(this["apikey"]));
            }
            set {
                this["apikey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"nextbet  = 0.00000000 --sets your first bet.
selected = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10} -- set selected tiles
risk     = ""low"" -- set risk level

function dobet()
    if (win) then
        print(""hit counts: "" .. lastBet.hits) 
        print(""multiplier: "" .. lastBet.multiplier .. ""x"")
    end
end")]
        public string code {
            get {
                return ((string)(this["code"]));
            }
            set {
                this["code"] = value;
            }
        }
    }
}