using System;

namespace FinalExam_Program_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MailBox box = new MailBox();
            MailNotifier notifier = new MailNotifier("Gauraang");
            notifier += box.receiveMail(box, notifier);

        }
    }

    class MailBox
    {
        public void receiveMail(object s, MailNotificationArgs args)
        {
            Console.WriteLine("Mail received from " + args._name);
        }
    }

    class MailNotifier
    {
        public event EventHandler<MailNotificationArgs> notify;

        public MailNotifier(String name)
        {
            if (notify != null)
            {
                notify(this, new MailNotificationArgs(name));
            }
        }
    }

    public class MailNotificationArgs : EventArgs
    {
        public String _name;
        public MailNotificationArgs(String name)
        {
            this._name = name;
        }
        
    }
}
