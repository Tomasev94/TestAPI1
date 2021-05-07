using NUnit.Framework;
using System.Threading.Tasks;
using TestAPI1.API;
using TestAPI1.Tests.DataFake;

namespace TestAPI1.Tests
{
    public class Test
    {
        private string _registerUserURL = "https://conduit.productionready.io/api/users";
        private string _loginWithNewUser = "https://conduit.productionready.io/api/users/login";
        private string _createArticle = "https://conduit.productionready.io/api/articles";
        DataFakeModels dataFake = new DataFakeModels();


        [Category("Test")]

        [Test]
        public async Task RegisterNewUser_Test()
        {
            var newUserJson = dataFake.GetJCreateUSers();

            var api = new TestAPI();

            var response = await api.RegisterNewUser($"{_registerUserURL}", newUserJson);

            Assert.NotNull(response);
            Assert.AreEqual(newUserJson.createUser.Username, response.User.Username);
            Assert.AreEqual(newUserJson.createUser.Email, response.User.Email);
        }
        [Test]
        public async Task LoginWithNewRegistratedUser_Test()
        {
            var newUserJson = dataFake.GetJCreateUSers();

            var api = new TestAPI();

            var registerNewUserResponse = await api.RegisterNewUser($"{_registerUserURL}", newUserJson);

            var loginWithNewUserResponse = await api.LoginWithAlreadyCreatedUser($"{_loginWithNewUser}", newUserJson);

            Assert.NotNull(loginWithNewUserResponse);
            Assert.AreEqual(registerNewUserResponse.User.Id, loginWithNewUserResponse.User.Id);
            Assert.AreEqual(registerNewUserResponse.User.Username, loginWithNewUserResponse.User.Username);
            Assert.AreEqual(registerNewUserResponse.User.Email, loginWithNewUserResponse.User.Email);
            Assert.AreEqual(registerNewUserResponse.User.Bio, loginWithNewUserResponse.User.Bio);           
            Assert.AreEqual(registerNewUserResponse.User.Image, loginWithNewUserResponse.User.Image);
            Assert.AreEqual(registerNewUserResponse.User.UpdatedAt, loginWithNewUserResponse.User.UpdatedAt);
            Assert.AreEqual(registerNewUserResponse.User.CreatedAt, loginWithNewUserResponse.User.CreatedAt);
        }
        [Test]
        public async Task LoginWithAlreadyCreatedUser_Test()
        {
            var newUserJson = dataFake.GetDefaultLoginUserRequest();
            var api = new TestAPI();

            var loginWithNewUserResponse = await api.LoginWithAlreadyCreatedUser($"{_loginWithNewUser}", newUserJson);

            Assert.NotNull(loginWithNewUserResponse);
            Assert.AreEqual(newUserJson.createUser.Username, loginWithNewUserResponse.User.Username);
            Assert.AreEqual(newUserJson.createUser.Email, loginWithNewUserResponse.User.Email);
        }
        [Test]
        public async Task CreateAnArticleWithAlreadyLogedInUser_Test()
        {
            var currentUser = dataFake.GetDefaultCurrentJNewUser();

            var newArticle = dataFake.GetJCreateArticle();

            var api = new TestAPI();

            var newlyCreatedArticleResponse = await api.CreateAnArticleWithAlreadyLogedInUser($"{_createArticle}", currentUser, newArticle);

            Assert.NotNull(newlyCreatedArticleResponse);
            Assert.AreEqual(currentUser.User.Username, newlyCreatedArticleResponse.Article.Author.Username);
            Assert.AreEqual(newArticle.Article.Body, newlyCreatedArticleResponse.Article.Body);
            Assert.AreEqual(newArticle.Article.Description, newlyCreatedArticleResponse.Article.Description);
            Assert.AreEqual(newArticle.Article.Title, newlyCreatedArticleResponse.Article.Title);
            Assert.AreEqual(newArticle.Article.TagList, newlyCreatedArticleResponse.Article.TagList);
        }
        [Test]
        public async Task CreateAnCommentToNewlyCreatedArticle_Test()
        {
            var newlyCreatedArticle = dataFake.GetNewArticleForResponse();

            var currentUser = dataFake.GetDefaultCurrentJNewUser();

            var slug = newlyCreatedArticle.Slug;

            var newComment = dataFake.GetJCreateComment();

            var api = new TestAPI();

            var newlyCreatedCommentResponse = await api.CreateAnCommentToNewlyCreatedArticle($"{_createArticle}/{slug}/comments", currentUser, newComment);

            Assert.NotNull(newlyCreatedCommentResponse);
            Assert.AreEqual(currentUser.User.Username, newlyCreatedCommentResponse.Comment.Author.Username);
            Assert.AreEqual(newComment.Comment.Body, newlyCreatedCommentResponse.Comment.Body);
        }

    }
}
