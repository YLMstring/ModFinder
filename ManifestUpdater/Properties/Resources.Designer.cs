﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManifestUpdater.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ManifestUpdater.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {
        ///    /*
        ///    Templates
        ///        Modtypes
        ///            0 = Owlcat
        ///            1 = UMM
        ///        Mod Sources
        ///            0 = Github
        ///            1 = Nexus
        ///            2 = Other
        ///            3 = ModDB
        ///
        ///            Important notes
        ///            Name needs to be the DisplayName from your Info.json/OwlcatModificationManifest.json
        ///            
        ///            //Very important to have OwnerName and RepoName set properly or it will not work
        ///            Github Hosted mod 
        ///            {
        ///            &quot;Name&quot;: &quot;&quot;,         /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string internal_manifest {
            get {
                return ResourceManager.GetString("internal_manifest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;m_AllMods&quot;: [
        ///    {
        ///      &quot;Author&quot;: &quot;Barley&quot;,
        ///      &quot;Description&quot;: &quot;A respec mod for Pathfinder: Wrath of the Righteous&quot;,
        ///      &quot;DownloadLink&quot;: &quot;https://github.com/BarleyFlour/RespecMod/releases/download/v1.09.2/RespecWrath.zip&quot;,
        ///      &quot;GithubOwner&quot;: &quot;BarleyFlour&quot;,
        ///      &quot;GithubRepo&quot;: &quot;RespecMod&quot;,
        ///      &quot;ModId&quot;: {
        ///        &quot;Identifier&quot;: &quot;RespecWrath&quot;,
        ///        &quot;ModType&quot;: &quot;UMM&quot;
        ///      },
        ///      &quot;Latest&quot;: {
        ///        &quot;Major&quot;: 1,
        ///        &quot;Minor&quot;: 9,
        ///        &quot;Patch&quot;: 2,
        ///        &quot;Suffix&quot;: &quot;\u0000&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Master_Manifest {
            get {
                return ResourceManager.GetString("Master_Manifest", resourceCulture);
            }
        }
    }
}
