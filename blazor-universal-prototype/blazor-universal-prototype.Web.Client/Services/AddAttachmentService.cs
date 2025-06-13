using blazor_universal_prototype.Shared.Models;
using blazor_universal_prototype.Shared.Services;
using Microsoft.JSInterop;

namespace blazor_universal_maui_prototype.Web.Client.Services
{
    internal class AddAttachmentService : IAddAttachmentService
    {
        private readonly IJSRuntime _jsRuntime;

        public AddAttachmentService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

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
