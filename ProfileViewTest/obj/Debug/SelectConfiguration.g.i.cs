﻿#pragma checksum "..\..\SelectConfiguration.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21F30DF47227B58B1984C088BE69F636C7CA31ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProfileViewTest;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ProfileViewTest {
    
    
    /// <summary>
    /// SelectConfiguration
    /// </summary>
    public partial class SelectConfiguration : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\SelectConfiguration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuItemNew;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\SelectConfiguration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuItemSave;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\SelectConfiguration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuItemOpen;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\SelectConfiguration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuItemExit;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\SelectConfiguration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView fileView;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\SelectConfiguration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonRefresh;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\SelectConfiguration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonSelect;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProfileViewTest;component/selectconfiguration.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SelectConfiguration.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.menuItemNew = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 2:
            this.menuItemSave = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 3:
            this.menuItemOpen = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 4:
            this.menuItemExit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 26 "..\..\SelectConfiguration.xaml"
            this.menuItemExit.Click += new System.Windows.RoutedEventHandler(this.menuItemExit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 35 "..\..\SelectConfiguration.xaml"
            ((System.Windows.Controls.ScrollViewer)(target)).PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.ScrollViewer_PreviewMouseWheel);
            
            #line default
            #line hidden
            return;
            case 6:
            this.fileView = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.buttonRefresh = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\SelectConfiguration.xaml"
            this.buttonRefresh.Click += new System.Windows.RoutedEventHandler(this.buttonRefresh_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonSelect = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

