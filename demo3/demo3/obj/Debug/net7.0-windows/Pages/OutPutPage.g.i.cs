﻿#pragma checksum "..\..\..\..\Pages\OutPutPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4AE03C556EAC53AC62B15EDA213248A826C2F18F"
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
using demo3.Pages;


namespace demo3.Pages {
    
    
    /// <summary>
    /// OutPutPage
    /// </summary>
    public partial class OutPutPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Pages\OutPutPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UpDownCb;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Pages\OutPutPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DiscountCb;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Pages\OutPutPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CountTextbox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Pages\OutPutPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ProductPanel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/demo3;component/pages/outputpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\OutPutPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\Pages\OutPutPage.xaml"
            ((demo3.Pages.OutPutPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UpDownCb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\..\Pages\OutPutPage.xaml"
            this.UpDownCb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Discount_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DiscountCb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\..\Pages\OutPutPage.xaml"
            this.DiscountCb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.UpDown_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CountTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ProductPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

