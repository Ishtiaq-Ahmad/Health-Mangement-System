﻿#pragma checksum "..\..\Employee List.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A62E18635FFA11AB714D1827027F63FFB1CDD403B88D47AD39A1DA4556D4DD89"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HealthManagementSystem;
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


namespace HealthManagementSystem {
    
    
    /// <summary>
    /// Employee_List
    /// </summary>
    public partial class Employee_List : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Employee List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridEmployeeList;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Employee List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxEmployeeSearch;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Employee List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Employee List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonShowAllEmployee;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Employee List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonUpdate;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Employee List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDelete;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Employee List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonback;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Employee List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageUpdate;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Employee List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imagedelete;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Employee List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageback;
        
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
            System.Uri resourceLocater = new System.Uri("/HealthManagementSystem;component/employee%20list.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Employee List.xaml"
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
            this.dataGridEmployeeList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.textBoxEmployeeSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\Employee List.xaml"
            this.textBoxEmployeeSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textSearch);
            
            #line default
            #line hidden
            return;
            case 3:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.buttonShowAllEmployee = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Employee List.xaml"
            this.buttonShowAllEmployee.Click += new System.Windows.RoutedEventHandler(this.buttonShowAllEmployee_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Employee List.xaml"
            this.buttonUpdate.Click += new System.Windows.RoutedEventHandler(this.buttonUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Employee List.xaml"
            this.buttonDelete.Click += new System.Windows.RoutedEventHandler(this.buttonDelete_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonback = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Employee List.xaml"
            this.buttonback.Click += new System.Windows.RoutedEventHandler(this.buttonback_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.imageUpdate = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.imagedelete = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.imageback = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

