using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}