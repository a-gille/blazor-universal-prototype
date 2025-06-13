using blazor_universal_prototype.Shared.Models;
using blazor_universal_prototype.Shared.Services;

namespace blazor_universal_maui_prototype.Services
{
    internal class AddAttachmentService : IAddAttachmentService
    {
        public Task<AttachmentDto?> CapturePhotoAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AttachmentDto?> PickFileAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AttachmentDto?> PickImageAsync()
        {
            throw new NotImplementedException();
        }
    }
}
