﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Housework {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Help {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Help() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Housework.Help", typeof(Help).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command input which is a path to a file. Simple patterns in file names are supported i.e. c:\tmp\*.txt. Input can be an absolute or relative path. When path is relative it&apos;s calculated from the current directory..
        /// </summary>
        internal static string Argument_input {
            get {
                return ResourceManager.GetString("Argument_input", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path to a settings file (optional). Settings file is an .ini file that contains variable definitions..
        /// </summary>
        internal static string Argument_settings {
            get {
                return ResourceManager.GetString("Argument_settings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This command is designed to author popular file formats by replacing information in them. Supported formats are:
        ///
        ///.csproj (modern .net core format):
        ///Replaces values with variables if found. Supports following tags: Version, FileVersion, AssemblyVersion, Authors, Copyright, PackageIconUrl, PackageProjectUrl, RepositoryUrl, PackageLicenseUrl, RepositoryType, Company, Tags, ReleaseNotes.
        ///
        ///.appxmanifest (windows 10 packaging project)
        ///Replaces Package/Identity/Version with a value from AppxVersion variable [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Command_author {
            get {
                return ResourceManager.GetString("Command_author", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prints echo..
        /// </summary>
        internal static string Command_Echo {
            get {
                return ResourceManager.GetString("Command_Echo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Used to &quot;push&quot; variables outside. At the moment is used to print variables in Azure Pipelines format, so that you can set variables on a CI server..
        /// </summary>
        internal static string Command_pushvars {
            get {
                return ResourceManager.GetString("Command_pushvars", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This command tries to change the build number when running on major CI agents. It supports Azure Pipelines and TeamCity..
        /// </summary>
        internal static string Command_setbuildnumber {
            get {
                return ResourceManager.GetString("Command_setbuildnumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prints a list of all variables and their current values. Does not include variables from settings file..
        /// </summary>
        internal static string Command_vars {
            get {
                return ResourceManager.GetString("Command_vars", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use recursive file scanning if wildcard is specified in the input path..
        /// </summary>
        internal static string Option_recurse {
            get {
                return ResourceManager.GetString("Option_recurse", resourceCulture);
            }
        }
    }
}
