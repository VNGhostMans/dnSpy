﻿#pragma checksum "..\..\..\..\SaveModule\SaveMultiModuleDlg.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77FFEF4C3B5BAC48A2C74EBCF05FB406C65B7D60"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using System.Windows.Forms.Integration;
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
using dnSpy.AsmEditor.DnlibDialogs.Converters;
using dnSpy.AsmEditor.Properties;
using dnSpy.AsmEditor.SaveModule;


namespace dnSpy.AsmEditor.SaveModule {
    
    
    internal partial class SaveMultiModuleDlg : dnSpy.AsmEditor.SaveModule.SaveModuleWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\..\..\SaveModule\SaveMultiModuleDlg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBox;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\..\SaveModule\SaveMultiModuleDlg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button optionsButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/dnSpy.AsmEditor.x;V6.1.8.0;component/savemodule/savemultimoduledlg.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\SaveModule\SaveMultiModuleDlg.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.8.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 38 "..\..\..\..\SaveModule\SaveMultiModuleDlg.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Options_CanExecute);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\..\SaveModule\SaveMultiModuleDlg.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Options_Executed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 57 "..\..\..\..\SaveModule\SaveMultiModuleDlg.xaml"
            this.listBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.listBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.optionsButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            
            #line 173 "..\..\..\..\SaveModule\SaveMultiModuleDlg.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.okButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
