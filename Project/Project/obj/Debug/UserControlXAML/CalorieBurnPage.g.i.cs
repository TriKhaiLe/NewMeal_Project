﻿#pragma checksum "..\..\..\UserControlXAML\CalorieBurnPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1380625FABA6855BE7276B633BEFFE0D293122619FF63FD51EC352627D5EA986"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Project.UserControlXAML;
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


namespace Project.UserControlXAML {
    
    
    /// <summary>
    /// CalorieBurnPage
    /// </summary>
    public partial class CalorieBurnPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\UserControlXAML\CalorieBurnPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Project.UserControlXAML.CalorieBurnPage ap_profile;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\UserControlXAML\CalorieBurnPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CaloBox;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\UserControlXAML\CalorieBurnPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox1_Copy;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\UserControlXAML\CalorieBurnPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvCaloriesBurned;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\..\UserControlXAML\CalorieBurnPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CountdownTimer;
        
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
            System.Uri resourceLocater = new System.Uri("/Project;component/usercontrolxaml/calorieburnpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControlXAML\CalorieBurnPage.xaml"
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
            this.ap_profile = ((Project.UserControlXAML.CalorieBurnPage)(target));
            return;
            case 2:
            
            #line 40 "..\..\..\UserControlXAML\CalorieBurnPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Calculate_click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CaloBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TextBox1_Copy = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 80 "..\..\..\UserControlXAML\CalorieBurnPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Find_click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lvCaloriesBurned = ((System.Windows.Controls.ListView)(target));
            
            #line 87 "..\..\..\UserControlXAML\CalorieBurnPage.xaml"
            this.lvCaloriesBurned.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvCaloriesBurned_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 143 "..\..\..\UserControlXAML\CalorieBurnPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 155 "..\..\..\UserControlXAML\CalorieBurnPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Find_click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 156 "..\..\..\UserControlXAML\CalorieBurnPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Find_click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.CountdownTimer = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
