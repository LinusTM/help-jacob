namespace help_jacob;

public class SendMessageToAll {
    private MessageCarrier type;
    private string[] to;
    private Message m;
    private bool isHTML;

    public SendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML) {
        this.type = type;
        this.to = to;
        this.m = m;
        this.isHTML = isHTML;
    }

    public MessageCarrier Type { get => type; set => type = value; }
    public string[] To { get => to; set => to = value; }
    public Message M { get => m; set => m = value; }
    public bool IsHTML { get => isHTML; set => isHTML = value; }


    public void sendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML) {
        TextToHtml textToHtml = new TextToHtml(m.Body);
        if (type.Equals(MessageCarrier.Smtp)) {
            if (isHTML)
                m.Body = textToHtml.ConvertBodyToHTML(m.Body);
            //her implementeres alt koden til at sende via Smtp
        }

        if (type.Equals(MessageCarrier.VMessage)) {
            if (isHTML)
                m.Body = textToHtml.ConvertBodyToHTML(m.Body);
            //her implementeres alt koden til at sende via VMessage
        }
    }
}
