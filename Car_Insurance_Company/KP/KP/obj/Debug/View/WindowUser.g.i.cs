﻿#pragma checksum "..\..\..\View\WindowUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AB65F4DB1A58A75A29C7B54C665DDD3B57FC99F488D88AF68B1ACB4B87DB5367"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using KP.View;
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


namespace KP.View {
    
    
    /// <summary>
    /// WindowUser
    /// </summary>
    public partial class WindowUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\View\WindowUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_User1;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\View\WindowUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid UserGrid;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\WindowUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\View\WindowUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEdit;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\View\WindowUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/KP;component/view/windowuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\WindowUser.xaml"
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
            
            #line 10 "..\..\..\View\WindowUser.xaml"
            ((KP.View.WindowUser)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 29 "..\..\..\View\WindowUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Contract);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Btn_User1 = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\View\WindowUser.xaml"
            this.Btn_User1.Click += new System.Windows.RoutedEventHandler(this.Button_Click_Users);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 31 "..\..\..\View\WindowUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Exit);
            
            #line default
            #line hidden
            return;
            case 5:
            this.UserGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.BtnDel = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\View\WindowUser.xaml"
            this.BtnDel.Click += new System.Windows.RoutedEventHandler(this.Btn_Del);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\View\WindowUser.xaml"
            this.BtnEdit.Click += new System.Windows.RoutedEventHandler(this.Btn_Edit);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\View\WindowUser.xaml"
            this.BtnAdd.Click += new System.Windows.RoutedEventHandler(this.Btn_Add);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 45 "..\..\..\View\WindowUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Otchet);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

