﻿#pragma checksum "..\..\DrawDiagramDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1855EC55495662D9450F740E2307E8C23B4EB34A"
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
using WDiagrams;


namespace WDiagrams {
    
    
    /// <summary>
    /// DrawDiagramDialog
    /// </summary>
    public partial class DrawDiagramDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\DrawDiagramDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TitleListBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\DrawDiagramDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxWithData;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\DrawDiagramDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListBoxWithData;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\DrawDiagramDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\DrawDiagramDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SeriesButton;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\DrawDiagramDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\DrawDiagramDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DrawButton;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\DrawDiagramDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas MainCanvas;
        
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
            System.Uri resourceLocater = new System.Uri("/WDiagrams;component/drawdiagramdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DrawDiagramDialog.xaml"
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
            this.TitleListBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TextBoxWithData = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ListBoxWithData = ((System.Windows.Controls.ListView)(target));
            
            #line 35 "..\..\DrawDiagramDialog.xaml"
            this.ListBoxWithData.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBoxWithData_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\DrawDiagramDialog.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButtonOnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SeriesButton = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\DrawDiagramDialog.xaml"
            this.SeriesButton.Click += new System.Windows.RoutedEventHandler(this.SeriesButtonOnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DeleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\DrawDiagramDialog.xaml"
            this.DeleteButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButtonOnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DrawButton = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\DrawDiagramDialog.xaml"
            this.DrawButton.Click += new System.Windows.RoutedEventHandler(this.DrawButtonOnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MainCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
