﻿#pragma checksum "..\..\..\Pages\PageEditNew.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FB55AA1C58B3083FD58367ED8C805B62B44650B92854082FFD8838337E0790E3"
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
using WpfApp4.Pages;


namespace WpfApp4.Pages {
    
    
    /// <summary>
    /// PageEditNew
    /// </summary>
    public partial class PageEditNew : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Pages\PageEditNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtTitle;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\PageEditNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCost;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\PageEditNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtDescription;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\PageEditNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtImage;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\PageEditNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbxOwner;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pages\PageEditNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RbActive;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Pages\PageEditNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RbNotActive;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\PageEditNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp4;component/pages/pageeditnew.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageEditNew.xaml"
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
            this.TxtTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TxtCost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TxtDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxtImage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CmbxOwner = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.RbActive = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.RbNotActive = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.BtnSave = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\Pages\PageEditNew.xaml"
            this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

