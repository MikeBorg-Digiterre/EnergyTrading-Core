﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace = "http://EnergyTradingVerificationFileDropService", ConfigurationName = "IFileDropService")]
public interface IFileDropService
{

    [System.ServiceModel.OperationContractAttribute(Action = "http://EnergyTradingVerificationFileDropService/IFileDropService/PlaceFile", ReplyAction = "http://EnergyTradingVerificationFileDropService/IFileDropService/PlaceFileResponse")]
    void PlaceFile(string fullPath, string fileContents);

    [System.ServiceModel.OperationContractAttribute(Action = "http://EnergyTradingVerificationFileDropService/IFileDropService/PublishMessage", ReplyAction = "http://EnergyTradingVerificationFileDropService/IFileDropService/PublishMessageResponse")]
    void PublishMessage(string payload, string eventHeaderText, string outputTopicName);

    [System.ServiceModel.OperationContractAttribute(Action = "http://EnergyTradingVerificationFileDropService/IFileDropService/WriteFileFromBytes", ReplyAction = "http://EnergyTradingVerificationFileDropService/IFileDropService/WriteFileFromBytesRespon" +
        "se")]
    void WriteFileFromBytes(string fullPath, byte[] fileContents);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IFileDropServiceChannel : IFileDropService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class FileDropServiceClient : System.ServiceModel.ClientBase<IFileDropService>, IFileDropService
{

    public FileDropServiceClient()
    {
    }

    public FileDropServiceClient(string endpointConfigurationName) :
        base(endpointConfigurationName)
    {
    }

    public FileDropServiceClient(string endpointConfigurationName, string remoteAddress) :
        base(endpointConfigurationName, remoteAddress)
    {
    }

    public FileDropServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
        base(endpointConfigurationName, remoteAddress)
    {
    }

    public FileDropServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
        base(binding, remoteAddress)
    {
    }

    public void PlaceFile(string fullPath, string fileContents)
    {
        base.Channel.PlaceFile(fullPath, fileContents);
    }

    public void PublishMessage(string payload, string eventHeaderText, string outputTopicName)
    {
        base.Channel.PublishMessage(payload, eventHeaderText, outputTopicName);
    }

    public void WriteFileFromBytes(string fullPath, byte[] fileContents)
    {
        base.Channel.WriteFileFromBytes(fullPath, fileContents);
    }
}
