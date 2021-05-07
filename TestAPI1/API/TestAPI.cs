using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TestAPI1.Models;
using System.Net.Http.Json;
using TestAPI1.API.Response;
using TestAPI1.API.Request;

namespace TestAPI1.API
{
    public class TestAPI
    {
        private HttpClient restClient = new HttpClient();

        public async Task<JNewUserResponse> RegisterNewUser(string url, JCreateLoginUserRequest newRootUser)
        {
            var response = await restClient.PostAsJsonAsync(url, newRootUser);

            var responseString = await response.Content.ReadAsStringAsync();

            var newUser = new JNewUserResponse();

            newUser = JsonConvert.DeserializeObject<JNewUserResponse>(responseString);

            return newUser;
        }
        public async Task<JNewUserResponse> LoginWithAlreadyCreatedUser(string url, JCreateLoginUserRequest newRootUser)
        {
            var response = await restClient.PostAsJsonAsync(url, newRootUser);
            var responseString = await response.Content.ReadAsStringAsync();

            var newUser = new JNewUserResponse();

            newUser = JsonConvert.DeserializeObject<JNewUserResponse>(responseString);

            return newUser;
        }
        public async Task<JNewArticleResponse> CreateAnArticleWithAlreadyLogedInUser(string url, JNewUserResponse currentUser, JCreateArticleRequest jCreateArticle)
        {
            restClient.DefaultRequestHeaders.Add("Authorization", $"Token  { currentUser.User.Token}");

            var response = await restClient.PostAsJsonAsync(url, jCreateArticle);
            var responseString = await response.Content.ReadAsStringAsync();

            var jNewArticle = new JNewArticleResponse();

            jNewArticle = JsonConvert.DeserializeObject<JNewArticleResponse>(responseString);

            return jNewArticle;
        }
        public async Task<JNewCommentResponse> CreateAnCommentToNewlyCreatedArticle(string url, JNewUserResponse currentUser, JCreateCommentRequest jCreateCommentRequest)
        {
            restClient.DefaultRequestHeaders.Add("Authorization", $"Token  { currentUser.User.Token}");

            var response = await restClient.PostAsJsonAsync(url, jCreateCommentRequest);
            var responseString = await response.Content.ReadAsStringAsync();

            var jNewComment = new JNewCommentResponse();

            jNewComment = JsonConvert.DeserializeObject<JNewCommentResponse>(responseString);

            return jNewComment;
        }
    }
}
