public class Journal 
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveFile(string file)
    {
        using(StreamWriter writer = new StreamWriter(file))
        {
            foreach(var entry in _entries)
            {
                writer.WriteLine(entry.GetEntryData());
            }
        }
    }

    public void LoadFromFile(string file)
    {
        if(File.Exists(file))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);
            foreach(string line in lines)
            {
                Entry entry = Entry.FromData(line);
                if (entry != null){
                    _entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}