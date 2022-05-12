namespace help_jacob;

public class TextToHtml {
    private string plainText;

    public TextToHtml(string plainText) {
        this.plainText = plainText; 
    }

    public string PlainText { get => plainText; set => plainText = value; }
        
    public string ConvertBodyToHTML(string plainText) {
        return "" + plainText + "";
    }
}
