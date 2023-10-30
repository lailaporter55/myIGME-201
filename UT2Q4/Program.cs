using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UT2Q4
{
    
    internal class Program
    {
        public abstract class Phone
        {
            private string phoneNumber;
            public string address;
            public string PhoneNumber()
            {
                get{
                    return this.phoneNumber;
                }
                set{
                    this.phoneNumber = value;
                }
            }
            public abstract void Connect();
            public abstract void Disconnect();
        }
        public interface PhoneInterface
        {
            void Answer();
            void MakeCall();
            void HangUp();
        }
        public class RotaryPhone : Phone, PhoneInterface
        {
            public void Answer()
            {
                throw new NotImplementedException();
            }

            public override void Connect()
            {
                throw new NotImplementedException();
            }

            public override void Disconnect()
            {
                throw new NotImplementedException();
            }

            public void HangUp()
            {
                throw new NotImplementedException();
            }

            public void MakeCall()
            {
                throw new NotImplementedException();
            }
        }

        public class PushButtonPhone : Phone, PhoneInterface
        {
            public void Answer()
            {
                throw new NotImplementedException();
            }

            public override void Connect()
            {
                throw new NotImplementedException();
            }

            public override void Disconnect()
            {
                throw new NotImplementedException();
            }

            public void HangUp()
            {
                throw new NotImplementedException();
            }

            public void MakeCall()
            {
                throw new NotImplementedException();
            }
        }

        public class Tardis : RotaryPhone
        {
            private bool sonicScrewdriver;
            private byte whichDrWho;
            private string femaleSideKick;
            public double exteriorSurface;
            public double interiorVolume;

            public byte WhichDrWho
            {
                get
                {
                    if (this == 10)
                    {
                        return this.whichDrWho;
                    }
                    else if (this != 11)
                    {
                        return this.sonicScrewdriver;
                    }
                    else if (this < 10)
                    {
                        return this.exteriorSurface;
                    }
                    else if (this > 10)
                    {
                        return this.interiorVolume;
                    }
                    else
                    {
                        return femaleSideKick;
                    }
                }
            }
            public string FemaleSideKick
            {
                get
                {
                    return this.femaleSideKick;
                }
            }
            public void TimeTravel()
            {

            }
        }

        public class PhoneBooth : PushButtonPhone
        {
            private bool superMan;
            public double costPerCall;
            public bool phoneBook;

            public void OpenDoor()
            {

            }
            public void CloseDoor()
            {

            }
        }
        static CodeIdentifier UsePhone(object obj)
        {
            PhoneInterface phone = new PhoneInterface();
            if (obj is Tardis tardis)
            {
                tardis.MakeCall(); 
                tardis.HangUp();
            }
            if (obj is PhoneBooth booth)
            {
                booth.MakeCall();
                booth.HangUp();
            }

        }
        static void Main(string[] args)
        {
            Tardis tardis = new Tardis();
            PhoneBooth phoneBooth = new PhoneBooth();
            UsePhone(tardis); 
            UsePhone(phoneBooth);
        }
    }
}
