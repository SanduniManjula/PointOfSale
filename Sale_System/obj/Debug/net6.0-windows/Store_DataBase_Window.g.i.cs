﻿#pragma checksum "..\..\..\Store_Database_Window.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F959CB94914744C23160D72A868257A5412EC393"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Sale_System;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Sale_System {
    
    
    /// <summary>
    /// Store_Database_Window
    /// </summary>
    public partial class Store_Database_Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\Store_Database_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_ProductId;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Store_Database_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_ProductName;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Store_Database_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_ProductPrice;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Store_Database_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Discount;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Store_Database_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Insert;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Store_Database_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Edit;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Store_Database_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Delete;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Store_Database_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Dataa;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\Store_Database_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Save;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Store_Database_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Logout;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Store_Database_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Return;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Sale_System;component/store_database_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Store_Database_Window.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tb_ProductId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tb_ProductName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tb_ProductPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tb_Discount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btn_Insert = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Store_Database_Window.xaml"
            this.btn_Insert.Click += new System.Windows.RoutedEventHandler(this.Insert_Click1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_Edit = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Store_Database_Window.xaml"
            this.btn_Edit.Click += new System.Windows.RoutedEventHandler(this.Edit_Click1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_Delete = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Store_Database_Window.xaml"
            this.btn_Delete.Click += new System.Windows.RoutedEventHandler(this.Delete_Click1);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Dataa = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.btn_Save = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\Store_Database_Window.xaml"
            this.btn_Save.Click += new System.Windows.RoutedEventHandler(this.Save_Click1);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_Logout = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\Store_Database_Window.xaml"
            this.btn_Logout.Click += new System.Windows.RoutedEventHandler(this.Logout_Click1);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btn_Return = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\Store_Database_Window.xaml"
            this.btn_Return.Click += new System.Windows.RoutedEventHandler(this.Return_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

