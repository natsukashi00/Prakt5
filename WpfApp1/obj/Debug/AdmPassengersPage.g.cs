﻿#pragma checksum "..\..\AdmPassengersPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EF8EB80E71DEDEA415A204A09DC43EA1B1152B142B524F1E421339633141365A"
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
    /// AdmPassengersPage
    /// </summary>
    public partial class AdmPassengersPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\AdmPassengersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid1;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AdmPassengersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt1;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AdmPassengersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt2;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AdmPassengersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt3;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AdmPassengersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt4;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AdmPassengersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back_button;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AdmPassengersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add_button;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AdmPassengersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button edit_button;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AdmPassengersPage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/admpassengerspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdmPassengersPage.xaml"
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
            this.txt4 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.back_button = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\AdmPassengersPage.xaml"
            this.back_button.Click += new System.Windows.RoutedEventHandler(this.back_button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.add_button = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\AdmPassengersPage.xaml"
            this.add_button.Click += new System.Windows.RoutedEventHandler(this.add_button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.edit_button = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\AdmPassengersPage.xaml"
            this.edit_button.Click += new System.Windows.RoutedEventHandler(this.edit_button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.delete_button = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\AdmPassengersPage.xaml"
            this.delete_button.Click += new System.Windows.RoutedEventHandler(this.delete_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

