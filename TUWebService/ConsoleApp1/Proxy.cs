﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name = "WebService1Soap", Namespace = "http://tempuri.org/")]
public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol
{

    private System.Threading.SendOrPostCallback ReadPathOperationCompleted;

    /// <remarks/>
    public WebService1()
    {
        this.Url = "http://localhost/TUWebService/WebService1.asmx";
    }

    /// <remarks/>
    public event ReadPathCompletedEventHandler ReadPathCompleted;

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ReadPath", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string ReadPath(string fileName)
    {
        object[] results = this.Invoke("ReadPath", new object[] {
                    fileName});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginReadPath(string fileName, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("ReadPath", new object[] {
                    fileName}, callback, asyncState);
    }

    /// <remarks/>
    public string EndReadPath(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void ReadPathAsync(string fileName)
    {
        this.ReadPathAsync(fileName, null);
    }

    /// <remarks/>
    public void ReadPathAsync(string fileName, object userState)
    {
        if ((this.ReadPathOperationCompleted == null))
        {
            this.ReadPathOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReadPathOperationCompleted);
        }
        this.InvokeAsync("ReadPath", new object[] {
                    fileName}, this.ReadPathOperationCompleted, userState);
    }

    private void OnReadPathOperationCompleted(object arg)
    {
        if ((this.ReadPathCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.ReadPathCompleted(this, new ReadPathCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    public new void CancelAsync(object userState)
    {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void ReadPathCompletedEventHandler(object sender, ReadPathCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ReadPathCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal ReadPathCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public string Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}
