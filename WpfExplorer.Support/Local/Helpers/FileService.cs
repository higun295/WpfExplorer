using Jamesnet.Wpf.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using WpfExplorer.Support.Local.Models;

namespace WpfExplorer.Support.Local.Helpers
{
    public class FileService
    {
        private readonly DirectoryManager _directoryManager;
        private readonly NavigatorService _navigatorService;

        public FileService(DirectoryManager directoryManager, NavigatorService navigatorService)
        {
            _directoryManager = directoryManager;
            _navigatorService = navigatorService;
        }

        public List<FolderInfo> GenerateRootNodes()
        {
            List<FolderInfo> roots = new()
            {
                CreateFolderInfo(1, "Download", IconType.ArrowDownBox, _directoryManager.DownloadDirectory),
                CreateFolderInfo(1, "Documents", IconType.TextBox, _directoryManager.DocumentsDirectory),
                CreateFolderInfo(1, "Pictures", IconType.Image, _directoryManager.PicturesDirectory)
            };

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                var name = $"{drive.VolumeLabel} ({drive.RootDirectory.FullName.Replace("\\", "")})";
                roots.Add(CreateFolderInfo(1, name, IconType.MicrosoftWindows, drive.Name));
            }

            return roots;
        }

        private static FolderInfo CreateFolderInfo
            (int depth, string name, IconType iconType, string fullPath)
        {
            return new FolderInfo
            {
                Depth = depth,
                Name = name,
                IconType = iconType,
                FullPath = fullPath,
                Children = new()
            };
        }

        public void RefreshSubdirectories(FolderInfo parent)
        {
            var newChildren = FetchSubdirectories(parent);

            var oldChildrenDict = parent.Children.ToDictionary(c => c.FullPath);
            var newChildrenDict = newChildren.ToDictionary(c => c.FullPath);

            var added = newChildren.Where(c => !oldChildrenDict.ContainsKey(c.FullPath)).ToList();
            var removed = parent.Children.Where(c => !newChildrenDict.ContainsKey(c.FullPath)).ToList();

            parent.Children.AddRange(added);
            foreach (var child in removed)
            {
                parent.Children.Remove(child);
            }
        }

        private static List<FolderInfo> FetchSubdirectories(FolderInfo parent)
        {
            var children = new List<FolderInfo>();
            try
            {
                var subDirs = Directory.GetDirectories(parent.FullPath);
                foreach (var dir in subDirs)
                {
                    children.Add(new FolderInfo
                    {
                        Depth = parent.Depth + 1,
                        Name = Path.GetFileName(dir),
                        IconType = IconType.Folder,
                        FullPath = dir,
                        Children = new()
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return children;
        }

        public void TryRefreshFiles(ObservableCollection<FolderInfo> files, out bool isAccessDenied)
        {
            var path = _navigatorService.Current.FullPath;
            isAccessDenied = !Directory.Exists(path) || !IsAccessible(path);

            if (!isAccessDenied)
            {
                files.Clear();
                files.AddRange(FetchFilesAndDirectories(path));
            }
        }

        private static bool IsAccessible(string path)
        {
            try
            {
                Directory.GetDirectories(path);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static List<FolderInfo> FetchFilesAndDirectories(string path)
        {
            return Directory.GetFileSystemEntries(path)
                .Select(entry => new FolderInfo
                {
                    Name = Path.GetFileName(entry),
                    IconType = Directory.Exists(entry) ? IconType.Folder : DetermineIconType(entry),
                    FullPath = entry,
                    Length = Directory.Exists(entry) ? 0 : new FileInfo(entry).Length
                })
                .OrderBy(info => info.IconType == IconType.Folder ? 0 : 1)
                .ToList();
        }

        private static IconType DetermineIconType(string file)
        {
            var ext = Path.GetExtension(file).ToUpper();
            return ext switch
            {
                ".JPG" or ".JPEG" or ".GIF" or ".BMP" or ".PNG" => IconType.FileImage,
                ".PDF" => IconType.FilePdf,
                ".ZIP" => IconType.FileZip,
                ".EXE" => IconType.FileCheck,
                ".DOCX" or ".DOC" => IconType.FileWord,
                _ => IconType.File,
            };
        }
    }
}