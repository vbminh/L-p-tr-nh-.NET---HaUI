﻿#pragma checksum "..\..\..\NhapKhoa.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9A6DA8E2539392B44A9B8D8AD8B8A8D945DEB2B7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bài_TH_Minh;
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


namespace Bài_TH_Minh {
    
    
    /// <summary>
    /// NhapKhoa
    /// </summary>
    public partial class NhapKhoa : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\NhapKhoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtID;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\NhapKhoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\NhapKhoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTKhoa;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\NhapKhoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVPhong;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\NhapKhoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btThemK;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\NhapKhoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btXoaK;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\NhapKhoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btHuyK;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Bài_TH_Minh;component/nhapkhoa.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\NhapKhoa.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtTKhoa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtVPhong = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btThemK = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\NhapKhoa.xaml"
            this.btThemK.Click += new System.Windows.RoutedEventHandler(this.btThemK_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btXoaK = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\NhapKhoa.xaml"
            this.btXoaK.Click += new System.Windows.RoutedEventHandler(this.btXoaK_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btHuyK = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\NhapKhoa.xaml"
            this.btHuyK.Click += new System.Windows.RoutedEventHandler(this.btHuyK_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

