﻿using System.Resources;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("MVVMHelpers Core PCL")]
[assembly: AssemblyDescription("Core PCL library for MVVMHelpers")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("JulMar Technology, Inc.")]
[assembly: AssemblyProduct("MVVMHelpers")]
[assembly: AssemblyCopyright("Copyright ©  2014 JulMar Technology, Inc.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Allow platform-specific libraries to use some of the internals.
[assembly: InternalsVisibleTo("MvvmHelpers.Desktop")]
[assembly: InternalsVisibleTo("MvvmHelpers.WinRT")]
[assembly: InternalsVisibleTo("MvvmHelpers.iOS")]
[assembly: InternalsVisibleTo("MvvmHelpers.Android")]
[assembly: InternalsVisibleTo("MvvmHelpers.WP")]