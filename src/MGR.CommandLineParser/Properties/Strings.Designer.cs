﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MGR.CommandLineParser.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MGR.CommandLineParser.Properties.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Help.
        /// </summary>
        public static string Command_HelpOption_DescriptionMessage {
            get {
                return ResourceManager.GetString("Command_HelpOption_DescriptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ?.
        /// </summary>
        public static string Command_HelpOption_ShortNameMessage {
            get {
                return ResourceManager.GetString("Command_HelpOption_ShortNameMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WARNING: {0}.
        /// </summary>
        public static string Console_WarningFormat {
            get {
                return ResourceManager.GetString("Console_WarningFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Command help :.
        /// </summary>
        public static string HelpCommand_CommandTitleFormat {
            get {
                return ResourceManager.GetString("HelpCommand_CommandTitleFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: {0} {1} {2}.
        /// </summary>
        public static string HelpCommand_CommandUsageFormat {
            get {
                return ResourceManager.GetString("HelpCommand_CommandUsageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} &lt;command&gt;.
        /// </summary>
        public static string HelpCommand_GlobalCommandLineCommandFormat {
            get {
                return ResourceManager.GetString("HelpCommand_GlobalCommandLineCommandFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Available commands:.
        /// </summary>
        public static string HelpCommand_GlobalHelp_AvailableCommands {
            get {
                return ResourceManager.GetString("HelpCommand_GlobalHelp_AvailableCommands", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0} &lt;command&gt;&apos; for help on a specific command..
        /// </summary>
        public static string HelpCommand_GlobalHelpCommandUsageFormat {
            get {
                return ResourceManager.GetString("HelpCommand_GlobalHelpCommandUsageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: {0} [args] [options].
        /// </summary>
        public static string HelpCommand_GlobalUsageFormat {
            get {
                return ResourceManager.GetString("HelpCommand_GlobalUsageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Options:.
        /// </summary>
        public static string HelpCommand_OptionsListTitle {
            get {
                return ResourceManager.GetString("HelpCommand_OptionsListTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Version: {1}.
        /// </summary>
        public static string ParserOptions_LogoFormat {
            get {
                return ResourceManager.GetString("ParserOptions_LogoFormat", resourceCulture);
            }
        }
    }
}
