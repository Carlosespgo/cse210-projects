public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                string newEntry = $"{entry._date} -- {entry._promptText} -- {entry._entryText}";
                outputFile.WriteLine(newEntry);
            }
        }
    }

    public void LoadFromFile(string file)
    {
        try
        {
            string[] entries = System.IO.File.ReadAllLines(file);
            _entries.Clear();

            foreach (string line in entries)
            {
                string[] model = line.Split(new string[] { "--" }, StringSplitOptions.None);

                Entry entry = new Entry();
                entry._date = model[0];
                entry._promptText = model[1];
                entry._entryText = model[2];

                _entries.Add(entry);
            }
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine($"// El archivo {file} no fue encontrado. //");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"// Ocurrio un error al cargar el archivo: {ex.Message}");
        }
        
    }
}