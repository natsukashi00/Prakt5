﻿#pragma checksum "..\..\AdmBusesPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5D240DE5A364084642A013E556C2E7301F694C97619038A7E91ABE8F9A38218B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// AdmBusesPage
    /// </summary>
    public partial class AdmBusesPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\AdmBusesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid1;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AdmBusesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt1;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AdmBusesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt2;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AdmBusesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt3;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AdmBusesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back_button;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AdmBusesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add_button;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AdmBusesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button edit_button;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AdmBusesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete_button;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/admbusespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdmBusesPage.xaml"
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
            this.datagrid1 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.txt1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt3 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.back_button = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\AdmBusesPage.xaml"
            this.back_button.Click += new System.Windows.RoutedEventHandler(this.back_button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.add_button = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\AdmBusesPage.xaml"
            this.add_button.Click += new System.Windows.RoutedEventHandler(this.add_button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.edit_button = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\AdmBusesPage.xaml"
            this.edit_button.Click += new System.Windows.RoutedEventHandler(this.edit_button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.delete_button = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\AdmBusesPage.xaml"
            this.delete_button.Click += new System.Windows.RoutedEventHandler(this.delete_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

