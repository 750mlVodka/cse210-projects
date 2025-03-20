public class Entry 
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string date, string promptText, string entryText){
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display(){
        Console.Write($"\nDate: {_date} ");
        Console.Write($"Prompt: {_promptText} ");
        Console.WriteLine($"\nEntry: {_entryText} ");
    }

    public string GetEntryData()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    public static Entry FromData(string data)
    {
        string[] parts = data.Split('|');
        if (parts.Length == 3)
        {
            return new Entry(parts[0], parts[1], parts[2]);
        }
        return null;
    }



}