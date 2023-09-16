﻿using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Mvvm;
using System.Collections.Generic;
using WpfExplorer.Support.Local.Helpers;
using WpfExplorer.Support.Local.Models;

namespace WpfExplorer.Main.Local.ViewModels
{
    public partial class MainContentViewModel : ObservableBase
    {
        private readonly FileService _fileService;

        public List<FolderInfo> Roots { get; init; }

        public MainContentViewModel(FileService fileService)
        {
            _fileService = fileService;

            Roots = fileService.GenerateRootNodes();
        }

        [RelayCommand]
        private void FolderChanged(FolderInfo folderInfo)
        {
            _fileService.RefreshSubdirectories(folderInfo);
        }
    }
}