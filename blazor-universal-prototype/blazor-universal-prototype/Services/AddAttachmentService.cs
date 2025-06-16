using System.Diagnostics;
using blazor_universal_prototype.Shared.Models;
using blazor_universal_prototype.Shared.Services;

namespace blazor_universal_maui_prototype.Services
{
    internal class AddAttachmentService : IAddAttachmentService
    {
        public async Task<AttachmentDto?> CapturePhotoAsync()
        {
            try
            {
                var photo = await MediaPicker.CapturePhotoAsync();
                if (photo != null)
                {
                    return new AttachmentDto()
                    {
                        Id = 0,
                        FileName = photo.FileName,
                    };
                }
                else
                {
                    return null;
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine($"Fotoaufnahme fehlgeschlagen: {ex.Message}");
                return null;
            }
        }

        public async Task<AttachmentDto?> PickFileAsync()
        {
            try
            {
                var result = await FilePicker.PickAsync(new PickOptions
                {
                    PickerTitle = "Wähle eine Datei",
                    FileTypes = FilePickerFileType.Pdf
                });
                if (result != null)
                {
                    return new AttachmentDto()
                    {
                        Id = 0,
                        FileName = result.FileName,
                    };
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Dateiauswahl fehlgeschlagen: {ex.Message}");
                return null;
            }
        }

        public async Task<AttachmentDto?> PickImageAsync()
        {
            try
            {
                var photo = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
                {
                    Title = "Wähle ein Bild"
                });
                if (photo != null)
                {
                    return new AttachmentDto()
                    {
                        Id = 0,
                        FileName = photo.FileName,
                    };
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Bildausswahl fehlgeschlagen: {ex.Message}");
                return null;
            }
        }
    }
}
