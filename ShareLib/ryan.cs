﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18063
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// 此源代码由 wsdl 自动生成, Version=4.0.30319.1。
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="ryanBinding", Namespace="urn:ryan")]
public partial class ryan : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback initOperationCompleted;
    
    private System.Threading.SendOrPostCallback sayOperationCompleted;
    
    private System.Threading.SendOrPostCallback ZCHN_MM_PO_GR_REC_ACP_REVOperationCompleted;
    
    private System.Threading.SendOrPostCallback jsonOperationCompleted;
    
    private System.Threading.SendOrPostCallback ZCHN_SD_PGI_DETAIL_POSTOperationCompleted;
    
    private System.Threading.SendOrPostCallback ZCHN_SD_PGI_CANCELOperationCompleted;
    
    /// <remarks/>
    public ryan()
    {
        this.Url = "http://support.td-tech.com/webservice/wsdl/server.php?wsdl";
    }
    
    /// <remarks/>
    public event initCompletedEventHandler initCompleted;
    
    /// <remarks/>
    public event sayCompletedEventHandler sayCompleted;
    
    /// <remarks/>
    public event ZCHN_MM_PO_GR_REC_ACP_REVCompletedEventHandler ZCHN_MM_PO_GR_REC_ACP_REVCompleted;
    
    /// <remarks/>
    public event jsonCompletedEventHandler jsonCompleted;
    
    /// <remarks/>
    public event ZCHN_SD_PGI_DETAIL_POSTCompletedEventHandler ZCHN_SD_PGI_DETAIL_POSTCompleted;
    
    /// <remarks/>
    public event ZCHN_SD_PGI_CANCELCompletedEventHandler ZCHN_SD_PGI_CANCELCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ryan#ryan#init", RequestNamespace="urn:ryan", ResponseNamespace="urn:ryan")]
    [return: System.Xml.Serialization.SoapElementAttribute("init")]
    public string init() {
        object[] results = this.Invoke("init", new object[0]);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult Begininit(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("init", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public string Endinit(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void initAsync() {
        this.initAsync(null);
    }
    
    /// <remarks/>
    public void initAsync(object userState) {
        if ((this.initOperationCompleted == null)) {
            this.initOperationCompleted = new System.Threading.SendOrPostCallback(this.OninitOperationCompleted);
        }
        this.InvokeAsync("init", new object[0], this.initOperationCompleted, userState);
    }
    
    private void OninitOperationCompleted(object arg) {
        if ((this.initCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.initCompleted(this, new initCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ryan#ryan#say", RequestNamespace="urn:ryan", ResponseNamespace="urn:ryan")]
    [return: System.Xml.Serialization.SoapElementAttribute("say")]
    public string say() {
        object[] results = this.Invoke("say", new object[0]);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult Beginsay(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("say", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public string Endsay(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void sayAsync() {
        this.sayAsync(null);
    }
    
    /// <remarks/>
    public void sayAsync(object userState) {
        if ((this.sayOperationCompleted == null)) {
            this.sayOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsayOperationCompleted);
        }
        this.InvokeAsync("say", new object[0], this.sayOperationCompleted, userState);
    }
    
    private void OnsayOperationCompleted(object arg) {
        if ((this.sayCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.sayCompleted(this, new sayCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ryan#ryan#ZCHN_MM_PO_GR_REC_ACP_REV", RequestNamespace="urn:ryan", ResponseNamespace="urn:ryan")]
    [return: System.Xml.Serialization.SoapElementAttribute("ZCHN_MM_PO_GR_REC_ACP_REV")]
    public string ZCHN_MM_PO_GR_REC_ACP_REV(string arr) {
        object[] results = this.Invoke("ZCHN_MM_PO_GR_REC_ACP_REV", new object[] {
                    arr});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginZCHN_MM_PO_GR_REC_ACP_REV(string arr, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("ZCHN_MM_PO_GR_REC_ACP_REV", new object[] {
                    arr}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndZCHN_MM_PO_GR_REC_ACP_REV(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void ZCHN_MM_PO_GR_REC_ACP_REVAsync(string arr) {
        this.ZCHN_MM_PO_GR_REC_ACP_REVAsync(arr, null);
    }
    
    /// <remarks/>
    public void ZCHN_MM_PO_GR_REC_ACP_REVAsync(string arr, object userState) {
        if ((this.ZCHN_MM_PO_GR_REC_ACP_REVOperationCompleted == null)) {
            this.ZCHN_MM_PO_GR_REC_ACP_REVOperationCompleted = new System.Threading.SendOrPostCallback(this.OnZCHN_MM_PO_GR_REC_ACP_REVOperationCompleted);
        }
        this.InvokeAsync("ZCHN_MM_PO_GR_REC_ACP_REV", new object[] {
                    arr}, this.ZCHN_MM_PO_GR_REC_ACP_REVOperationCompleted, userState);
    }
    
    private void OnZCHN_MM_PO_GR_REC_ACP_REVOperationCompleted(object arg) {
        if ((this.ZCHN_MM_PO_GR_REC_ACP_REVCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.ZCHN_MM_PO_GR_REC_ACP_REVCompleted(this, new ZCHN_MM_PO_GR_REC_ACP_REVCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ryan#ryan#json", RequestNamespace="urn:ryan", ResponseNamespace="urn:ryan")]
    [return: System.Xml.Serialization.SoapElementAttribute("json")]
    public string json(string arr) {
        object[] results = this.Invoke("json", new object[] {
                    arr});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult Beginjson(string arr, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("json", new object[] {
                    arr}, callback, asyncState);
    }
    
    /// <remarks/>
    public string Endjson(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void jsonAsync(string arr) {
        this.jsonAsync(arr, null);
    }
    
    /// <remarks/>
    public void jsonAsync(string arr, object userState) {
        if ((this.jsonOperationCompleted == null)) {
            this.jsonOperationCompleted = new System.Threading.SendOrPostCallback(this.OnjsonOperationCompleted);
        }
        this.InvokeAsync("json", new object[] {
                    arr}, this.jsonOperationCompleted, userState);
    }
    
    private void OnjsonOperationCompleted(object arg) {
        if ((this.jsonCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.jsonCompleted(this, new jsonCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ryan#ryan#ZCHN_SD_PGI_DETAIL_POST", RequestNamespace="urn:ryan", ResponseNamespace="urn:ryan")]
    [return: System.Xml.Serialization.SoapElementAttribute("ZCHN_SD_PGI_DETAIL_POST")]
    public string ZCHN_SD_PGI_DETAIL_POST(string arr) {
        object[] results = this.Invoke("ZCHN_SD_PGI_DETAIL_POST", new object[] {
                    arr});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginZCHN_SD_PGI_DETAIL_POST(string arr, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("ZCHN_SD_PGI_DETAIL_POST", new object[] {
                    arr}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndZCHN_SD_PGI_DETAIL_POST(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void ZCHN_SD_PGI_DETAIL_POSTAsync(string arr) {
        this.ZCHN_SD_PGI_DETAIL_POSTAsync(arr, null);
    }
    
    /// <remarks/>
    public void ZCHN_SD_PGI_DETAIL_POSTAsync(string arr, object userState) {
        if ((this.ZCHN_SD_PGI_DETAIL_POSTOperationCompleted == null)) {
            this.ZCHN_SD_PGI_DETAIL_POSTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnZCHN_SD_PGI_DETAIL_POSTOperationCompleted);
        }
        this.InvokeAsync("ZCHN_SD_PGI_DETAIL_POST", new object[] {
                    arr}, this.ZCHN_SD_PGI_DETAIL_POSTOperationCompleted, userState);
    }
    
    private void OnZCHN_SD_PGI_DETAIL_POSTOperationCompleted(object arg) {
        if ((this.ZCHN_SD_PGI_DETAIL_POSTCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.ZCHN_SD_PGI_DETAIL_POSTCompleted(this, new ZCHN_SD_PGI_DETAIL_POSTCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ryan#ryan#ZCHN_SD_PGI_CANCEL", RequestNamespace="urn:ryan", ResponseNamespace="urn:ryan")]
    [return: System.Xml.Serialization.SoapElementAttribute("ZCHN_SD_PGI_CANCEL")]
    public string ZCHN_SD_PGI_CANCEL(string arr) {
        object[] results = this.Invoke("ZCHN_SD_PGI_CANCEL", new object[] {
                    arr});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginZCHN_SD_PGI_CANCEL(string arr, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("ZCHN_SD_PGI_CANCEL", new object[] {
                    arr}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndZCHN_SD_PGI_CANCEL(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void ZCHN_SD_PGI_CANCELAsync(string arr) {
        this.ZCHN_SD_PGI_CANCELAsync(arr, null);
    }
    
    /// <remarks/>
    public void ZCHN_SD_PGI_CANCELAsync(string arr, object userState) {
        if ((this.ZCHN_SD_PGI_CANCELOperationCompleted == null)) {
            this.ZCHN_SD_PGI_CANCELOperationCompleted = new System.Threading.SendOrPostCallback(this.OnZCHN_SD_PGI_CANCELOperationCompleted);
        }
        this.InvokeAsync("ZCHN_SD_PGI_CANCEL", new object[] {
                    arr}, this.ZCHN_SD_PGI_CANCELOperationCompleted, userState);
    }
    
    private void OnZCHN_SD_PGI_CANCELOperationCompleted(object arg) {
        if ((this.ZCHN_SD_PGI_CANCELCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.ZCHN_SD_PGI_CANCELCompleted(this, new ZCHN_SD_PGI_CANCELCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
public delegate void initCompletedEventHandler(object sender, initCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class initCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal initCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
public delegate void sayCompletedEventHandler(object sender, sayCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class sayCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal sayCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
public delegate void ZCHN_MM_PO_GR_REC_ACP_REVCompletedEventHandler(object sender, ZCHN_MM_PO_GR_REC_ACP_REVCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ZCHN_MM_PO_GR_REC_ACP_REVCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal ZCHN_MM_PO_GR_REC_ACP_REVCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
public delegate void jsonCompletedEventHandler(object sender, jsonCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class jsonCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal jsonCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
public delegate void ZCHN_SD_PGI_DETAIL_POSTCompletedEventHandler(object sender, ZCHN_SD_PGI_DETAIL_POSTCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ZCHN_SD_PGI_DETAIL_POSTCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal ZCHN_SD_PGI_DETAIL_POSTCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
public delegate void ZCHN_SD_PGI_CANCELCompletedEventHandler(object sender, ZCHN_SD_PGI_CANCELCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ZCHN_SD_PGI_CANCELCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal ZCHN_SD_PGI_CANCELCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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