﻿#pragma checksum "..\..\..\Pages\EmployeePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1C8D480ECE406DCA4241D7F617A1F57CCE66A6644A836B9D6D7BCC11FF387784"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PraktikaVolkov.Pages;
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


namespace PraktikaVolkov.Pages {
    
    
    /// <summary>
    /// EmployeePage
    /// </summary>
    public partial class EmployeePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 16 "..\..\..\Pages\EmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid EmployeeBD;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\EmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addbtn;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Pages\EmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delbtn;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Pages\EmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button report;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\EmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button filter;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\EmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button calc;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Pages\EmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchtb;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\EmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backbtn;
        
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
            System.Uri resourceLocater = new System.Uri("/PraktikaVolkov;component/pages/employeepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\EmployeePage.xaml"
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
            
            #line 8 "..\..\..\Pages\EmployeePage.xaml"
            ((PraktikaVolkov.Pages.EmployeePage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EmployeeBD = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.addbtn = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Pages\EmployeePage.xaml"
            this.addbtn.Click += new System.Windows.RoutedEventHandler(this.addbtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.delbtn = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Pages\EmployeePage.xaml"
            this.delbtn.Click += new System.Windows.RoutedEventHandler(this.delbtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.report = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Pages\EmployeePage.xaml"
            this.report.Click += new System.Windows.RoutedEventHandler(this.report_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.filter = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Pages\EmployeePage.xaml"
            this.filter.Click += new System.Windows.RoutedEventHandler(this.filter_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.calc = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Pages\EmployeePage.xaml"
            this.calc.Click += new System.Windows.RoutedEventHandler(this.calc_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.searchtb = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\Pages\EmployeePage.xaml"
            this.searchtb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchtb_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.backbtn = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Pages\EmployeePage.xaml"
            this.backbtn.Click += new System.Windows.RoutedEventHandler(this.backbtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 36 "..\..\..\Pages\EmployeePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.editbtn_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

