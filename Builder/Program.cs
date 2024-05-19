using Builder;

public class Program()
{
    public static void Main()
    {
        static void Main(string[] args)
        {
            SMTP smtp = new SMTP(new MailConstructor());

            smtp.SendNoReplyMail();
        }
    }
}