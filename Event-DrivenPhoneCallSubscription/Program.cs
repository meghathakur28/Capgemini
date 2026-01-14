
using System;
using Event_DrivenPhoneCallSubscription;

PhoneCall pc = new PhoneCall();
pc.MakeAPhoneCall(true);
Console.WriteLine(pc.Message);
pc.MakeAPhoneCall(false);
Console.WriteLine(pc.Message);

