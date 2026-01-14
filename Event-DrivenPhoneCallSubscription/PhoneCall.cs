using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Event_DrivenPhoneCallSubscription
{
    public delegate void Notify();

    
    public class PhoneCall
    {
        public string Message 
        { get; private set; }
        public event  Notify PhoneCallEvent;
        

        private void OnSubscribe()
        {
            Message = "Subscribes to Call";
        }

        private void OnUnsubscribe()
        {
            Message = "UnSubscribes to Call";
        }

        public void MakeAPhoneCall(bool notify)
        {
            if(notify)
            {
                PhoneCallEvent = OnSubscribe;
            }
            else
            {
                PhoneCallEvent = OnUnsubscribe;
            }

            PhoneCallEvent();
        }

    }
}
