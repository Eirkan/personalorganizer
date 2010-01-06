using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using PO.Types.CustomTypes;
using PO.Types.Enumerations;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.Collections;
using PO.Services;

namespace IB.EBakanlik.Services.Tools
{
    internal class ErrorHandlerBehavior :  BusinessBase, IServiceBehavior, IErrorHandler
    {
        #region IServiceBehavior Members

        public void AddBindingParameters(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
            return;
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase)
        {
            foreach (ChannelDispatcher chDispatcher in serviceHostBase.ChannelDispatchers)
            {
                chDispatcher.ErrorHandlers.Add(this);
            }
        }

        public void Validate(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase)
        {
            return;
        }

        #endregion

        #region IErrorHandler Members

        public bool HandleError(Exception error)
        {
            // Ayrı threadde calısır. 
            if (error.Message.Contains("There was an error reading from the pipe: The pipe has been ended."))
            {
                return true;
            }

            return true; 
        }

        public void ProvideFault(Exception error, System.ServiceModel.Channels.MessageVersion version, ref System.ServiceModel.Channels.Message fault)
        {   
            // Serviste olusan hataların tamamı FaultException olarak sunulur. 
            CEOrganizerException oError = new CEOrganizerException(EnumExceptionType.SystemException, error.Message, "Server");
             
            if (error is ApplicationException)
            {
                oError.ExType = EnumExceptionType.ApplicationException;
                if (error.InnerException != null)
                {
                    oError.InnerExceptionString = error.InnerException.Message;
                }
            }

            FaultException<CEOrganizerException> fe = new FaultException<CEOrganizerException>(oError, new FaultReason(oError.ErrorMessage), new FaultCode(oError.ErrorCode));
            MessageFault mFault = fe.CreateMessageFault();
            fault = Message.CreateMessage(version, mFault, fe.Action);

        }

        #endregion
    }


    public class ErrorHandlerBehaviorExtension : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(ErrorHandlerBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new ErrorHandlerBehavior();
        }
    }

}
