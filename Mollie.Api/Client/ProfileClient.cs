﻿using System.Threading.Tasks;
using Mollie.Api.Client.Abstract;
using Mollie.Api.Models.List;
using Mollie.Api.Models.List.Specific;
using Mollie.Api.Models.Profile.Request;
using Mollie.Api.Models.Profile.Response;

namespace Mollie.Api.Client {
    public class ProfileClient : BaseMollieClient, IProfileClient {
        public ProfileClient(string apiKey) : base(apiKey) {
        }

        public async Task<ProfileResponse> CreateProfileAsync(ProfileRequest request) {
            return await this.PostAsync<ProfileResponse>("profiles", request).ConfigureAwait(false);
        }

        public async Task<ProfileResponse> GetProfileAsync(string profileId) {
            return await this.GetAsync<ProfileResponse>($"profiles/{profileId}").ConfigureAwait(false);
        }

        public async Task<ListResponse<ProfileListData>> GetProfileListAsync(string from = null, int? limit = null) {
            return await this.GetListAsync<ListResponse<ProfileListData>>("profiles", from, limit).ConfigureAwait(false);
        }

        public async Task<ProfileResponse> UpdateProfileAsync(string profileId, ProfileRequest request) {
            return await this.PostAsync<ProfileResponse>($"profiles/{profileId}", request).ConfigureAwait(false);
        }

        public async Task DeleteProfileAsync(string profileId) {
            await this.DeleteAsync($"profiles/{profileId}").ConfigureAwait(false);
        }
    }
}