namespace WpfExplorer.Support.Local.Models
{
    public class Memento
    {
        private string _fullPath;

        public Memento(string fullPath)
        {
            _fullPath = fullPath;
        }

        public string GetSavedFullPath()
        {
            return _fullPath;
        }
    }
}