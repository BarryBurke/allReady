﻿using System.Threading.Tasks;
using Microsoft.AspNet.Http;

namespace AllReady.Services
{
    public interface IImageService
    {
        Task<string> UploadActivityImageAsync(int organizationId, int activityId, IFormFile image);
        Task<string> UploadCampaignImageAsync(int organizationId, int campaignId, IFormFile image);
        Task<string> UploadImageAsync(IFormFile image);
        Task<string> UploadOrganizationImageAsync(int organizationId, IFormFile image);
    }
}
