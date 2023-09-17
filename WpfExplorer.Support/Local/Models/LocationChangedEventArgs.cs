using System;

namespace WpfExplorer.Support.Local.Models
{
    public class LocationChangedEventArgs : EventArgs
    {
        public FileInfoBase Current { get; }
        public LocationChangedEventArgs(FileInfoBase current)
        {
            Current = current;
        }
    }
}