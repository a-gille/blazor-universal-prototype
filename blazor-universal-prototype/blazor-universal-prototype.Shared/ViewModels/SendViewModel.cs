using System.Collections.ObjectModel;
using blazor_universal_prototype.Shared.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace blazor_universal_prototype.Shared.ViewModels
{
    public partial class SendViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _isFabOpen = false;

        [ObservableProperty]
        private bool _isFabClosed = true;

        [ObservableProperty]
        private bool _hasNoAttachments = true;

        [ObservableProperty]
        private bool _hasAttachments = false;

        [ObservableProperty]
        private double _fabOpacity = 0;

        [ObservableProperty]
        private double _fabTranslationY = 20;

        [ObservableProperty]
        private DateTime _date = DateTime.Now;

        [ObservableProperty]
        private string _selectedCategory;

        [ObservableProperty]
        private ObservableCollection<AttachmentDto> _attachments = new();

        [ObservableProperty]
        private ObservableCollection<string> _categories = new() { "Allgemein", "Hilfe", "Fragen" };

        [RelayCommand]
        private async Task ToggleFabAsync()
        {
            if (!IsFabOpen)
            {
                IsFabOpen = true;
                IsFabClosed = false;
                await Task.WhenAll(
                    AnimateOpacity(1),
                    AnimateTranslation(0)
                );
            }
            else
            {
                IsFabOpen = false;
                IsFabClosed = true;
                await Task.WhenAll(
                    AnimateOpacity(0),
                    AnimateTranslation(20)
                );
            }
        }

        //[RelayCommand]
        //private async Task PickFileAsync()
        //{
        //    try
        //    {
        //        var result = await FilePicker.PickAsync(new PickOptions
        //        {
        //            PickerTitle = "Wähle eine Datei",
        //            FileTypes = FilePickerFileType.Pdf
        //        });
        //        if (result != null)
        //        {
        //            var newId = Attachments.Any() ? Attachments.Max(a => a.Id) + 1 : 1;
        //            Attachments.Add(new AttachmentDto()
        //            {
        //                Id = newId,
        //                FileName = result.FileName,
        //            });
        //        }
        //        CheckAttachments();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine($"Dateiauswahl fehlgeschlagen: {ex.Message}");
        //    }
        //}


        //[RelayCommand]
        //private async Task PickImageAsync()
        //{
        //    try
        //    {
        //        var photo = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
        //        {
        //            Title = "Wähle ein Bild"
        //        });
        //        if (photo != null)
        //        {
        //            var newId = Attachments.Any() ? Attachments.Max(a => a.Id) + 1 : 1;
        //            Attachments.Add(new AttachmentDto()
        //            {
        //                Id = newId,
        //                FileName = photo.FileName,
        //            });
        //        }
        //        CheckAttachments();

        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine($"Bildausswahl fehlgeschlagen: {ex.Message}");
        //    }
        //}

        //[RelayCommand]
        //private async Task CapturePhotoAsync()
        //{
        //    try
        //    {
        //        var photo = await MediaPicker.CapturePhotoAsync();
        //        if (photo != null)
        //        {
        //            var newId = Attachments.Any() ? Attachments.Max(a => a.Id) + 1 : 1;
        //            Attachments.Add(new AttachmentDto()
        //            {
        //                Id = newId,
        //                FileName = photo.FileName,
        //            });
        //        }
        //        CheckAttachments();
        //    }

        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine($"Fotoaufnahme fehlgeschlagen: {ex.Message}");
        //    }
        //}

        [RelayCommand]
        private void RemoveAttachment(int Id)
        {
            Attachments.Remove(Attachments.First(a => a.Id == Id));
            CheckAttachments();
        }

        private async Task AnimateOpacity(double value)
        {
            for (int i = 0; i <= 10; i++)
            {
                FabOpacity = FabOpacity + (value - FabOpacity) / 2;
                await Task.Delay(15);
            }
            FabOpacity = value;
        }

        private async Task AnimateTranslation(double value)
        {
            for (int i = 0; i <= 10; i++)
            {
                FabTranslationY = FabTranslationY + (value - FabTranslationY) / 2;
                await Task.Delay(15);
            }
            FabTranslationY = value;
        }
        [RelayCommand]
        private void CheckAttachments()
        {
            if (Attachments.Count <= 0)
            {
                HasNoAttachments = true;
                HasAttachments = false;
            }
            else
            {
                HasNoAttachments = false;
                HasAttachments = true;
            }
        }


    }
}
