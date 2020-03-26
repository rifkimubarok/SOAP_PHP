﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Calculator.CalculateService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="webserviceSoap", Namespace="webservice")]
    public partial class webservice : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback helloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback TambahOperationCompleted;
        
        private System.Threading.SendOrPostCallback KurangOperationCompleted;
        
        private System.Threading.SendOrPostCallback kaliOperationCompleted;
        
        private System.Threading.SendOrPostCallback bagiOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public webservice() {
            this.Url = global::Calculator.Properties.Settings.Default.Calculator_CalculateService_webservice;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event helloWorldCompletedEventHandler helloWorldCompleted;
        
        /// <remarks/>
        public event TambahCompletedEventHandler TambahCompleted;
        
        /// <remarks/>
        public event KurangCompletedEventHandler KurangCompleted;
        
        /// <remarks/>
        public event kaliCompletedEventHandler kaliCompleted;
        
        /// <remarks/>
        public event bagiCompletedEventHandler bagiCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("webservice/helloWorld", RequestNamespace="webservice", ResponseNamespace="webservice", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string helloWorld() {
            object[] results = this.Invoke("helloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void helloWorldAsync() {
            this.helloWorldAsync(null);
        }
        
        /// <remarks/>
        public void helloWorldAsync(object userState) {
            if ((this.helloWorldOperationCompleted == null)) {
                this.helloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnhelloWorldOperationCompleted);
            }
            this.InvokeAsync("helloWorld", new object[0], this.helloWorldOperationCompleted, userState);
        }
        
        private void OnhelloWorldOperationCompleted(object arg) {
            if ((this.helloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.helloWorldCompleted(this, new helloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("webservice/Tambah", RequestNamespace="webservice", ResponseNamespace="webservice", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int Tambah(int a, int b) {
            object[] results = this.Invoke("Tambah", new object[] {
                        a,
                        b});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void TambahAsync(int a, int b) {
            this.TambahAsync(a, b, null);
        }
        
        /// <remarks/>
        public void TambahAsync(int a, int b, object userState) {
            if ((this.TambahOperationCompleted == null)) {
                this.TambahOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTambahOperationCompleted);
            }
            this.InvokeAsync("Tambah", new object[] {
                        a,
                        b}, this.TambahOperationCompleted, userState);
        }
        
        private void OnTambahOperationCompleted(object arg) {
            if ((this.TambahCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TambahCompleted(this, new TambahCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("webservice/Kurang", RequestNamespace="webservice", ResponseNamespace="webservice", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int Kurang(int a, int b) {
            object[] results = this.Invoke("Kurang", new object[] {
                        a,
                        b});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void KurangAsync(int a, int b) {
            this.KurangAsync(a, b, null);
        }
        
        /// <remarks/>
        public void KurangAsync(int a, int b, object userState) {
            if ((this.KurangOperationCompleted == null)) {
                this.KurangOperationCompleted = new System.Threading.SendOrPostCallback(this.OnKurangOperationCompleted);
            }
            this.InvokeAsync("Kurang", new object[] {
                        a,
                        b}, this.KurangOperationCompleted, userState);
        }
        
        private void OnKurangOperationCompleted(object arg) {
            if ((this.KurangCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.KurangCompleted(this, new KurangCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("webservice/kali", RequestNamespace="webservice", ResponseNamespace="webservice", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int kali(int a, int b) {
            object[] results = this.Invoke("kali", new object[] {
                        a,
                        b});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void kaliAsync(int a, int b) {
            this.kaliAsync(a, b, null);
        }
        
        /// <remarks/>
        public void kaliAsync(int a, int b, object userState) {
            if ((this.kaliOperationCompleted == null)) {
                this.kaliOperationCompleted = new System.Threading.SendOrPostCallback(this.OnkaliOperationCompleted);
            }
            this.InvokeAsync("kali", new object[] {
                        a,
                        b}, this.kaliOperationCompleted, userState);
        }
        
        private void OnkaliOperationCompleted(object arg) {
            if ((this.kaliCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.kaliCompleted(this, new kaliCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("webservice/bagi", RequestNamespace="webservice", ResponseNamespace="webservice", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double bagi(double a, double b) {
            object[] results = this.Invoke("bagi", new object[] {
                        a,
                        b});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void bagiAsync(double a, double b) {
            this.bagiAsync(a, b, null);
        }
        
        /// <remarks/>
        public void bagiAsync(double a, double b, object userState) {
            if ((this.bagiOperationCompleted == null)) {
                this.bagiOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbagiOperationCompleted);
            }
            this.InvokeAsync("bagi", new object[] {
                        a,
                        b}, this.bagiOperationCompleted, userState);
        }
        
        private void OnbagiOperationCompleted(object arg) {
            if ((this.bagiCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.bagiCompleted(this, new bagiCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void helloWorldCompletedEventHandler(object sender, helloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class helloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal helloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void TambahCompletedEventHandler(object sender, TambahCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TambahCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TambahCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void KurangCompletedEventHandler(object sender, KurangCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class KurangCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal KurangCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void kaliCompletedEventHandler(object sender, kaliCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class kaliCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal kaliCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void bagiCompletedEventHandler(object sender, bagiCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class bagiCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal bagiCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591