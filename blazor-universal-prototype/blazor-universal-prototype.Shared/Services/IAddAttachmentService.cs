using blazor_universal_prototype.Shared.Models;

namespace blazor_universal_prototype.Shared.Services
{
    public interface IAddAttachmentService
    {
        public Task<AttachmentDto?> PickFileAsync();

        public Task<AttachmentDto?> PickImageAsync();

        public Task<AttachmentDto?> CapturePhotoAsync();
    }
}
