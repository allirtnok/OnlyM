﻿namespace OnlyM.Services.DragAndDrop
{
    using System;
    using System.Windows;
    using OnlyM.Models;

    internal interface IDragAndDropService
    {
        event EventHandler<FilesCopyProgressEventArgs> CopyingFilesProgressEvent;

        void Init(FrameworkElement targetElement);

        void Paste();
    }
}
