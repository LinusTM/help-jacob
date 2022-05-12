namespace help_jacob;

public class SendMessage {
    private MessageCarrier type;
    private Message m;
    private bool isHTML;

    public SendMessage(MessageCarrier type, Message m, bool isHTML) {
        this.type = type;
        this.m = m;
        this.isHTML = isHTML;
    }

    public MessageCarrier Type { get => type; set => type = value; }
    public Message M { get => m; set => m = value; }
    public bool IsHTML { get => isHTML; set => isHTML = value; }

    public void sendMessage(MessageCarrier type, Message m, bool isHTML) {
        TextToHtml textToHtml = new TextToHtml(m.Body);
        //herinde sendes der en email ud til modtageren
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
