using System;
using System.Collections.Generic;
using TestAPI1.API.Request;
using TestAPI1.API.Response;
using TestAPI1.Models;

namespace TestAPI1.Tests.DataFake
{
    public class DataFakeModels
    {
        public JCreateLoginUserRequest GetJCreateUSers()
        {
            return new JCreateLoginUserRequest()
            {
                createUser = GetCreateUser()
            };      
        }
        public CreateUserForRequest GetCreateUser()
        {
            return new CreateUserForRequest
            {
                Username = GetRandomUserName(),
                Email = GetRandomEmail(),
                Password = GetRandomPassword()
            };
        }
        public JCreateArticleRequest GetJCreateArticle()
        {
            return new JCreateArticleRequest
            {
                Article = GetCreateNewArticle()
            };
        }
        public CreateArticleForRequest GetCreateNewArticle()
        {
            return new CreateArticleForRequest
            {
                Title = "New Article Title Test",
                Description = "New Article Description Test",
                Body = "New Article Body Test",
                TagList = new List<string> { "Nikola", "12345"}
            };
        }
        public JNewUserResponse GetDefaultCurrentJNewUser()
        {
            return new JNewUserResponse
            {
                User = GetDefaultCurrentNewUser()
            };
        }
        public NewUserForResponse GetDefaultCurrentNewUser()
        {
            return new NewUserForResponse
            {
                Id = 167951,
                Email = "nikola12221@nikola.nikola",
                CreatedAt = new DateTime(2021, 05, 06, 19, 54, 39, 176),
                UpdatedAt = new DateTime(2021, 05, 06, 19, 54, 39, 182),
                Username = "Nikola1231",
                Bio = null,
                Image = null,
                Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpZCI6MTY3OTUxLCJ1c2VybmFtZSI6Ik5pa29sYTEyMzEiLCJleHAiOjE2MjU1OTM2MTh9.9JjHl85ro-etTb91rbs4WS1Bo-Tp2EwjIdugm304KWQ"
            };
        }
        public JCreateCommentRequest GetJCreateComment()
        {
            return new JCreateCommentRequest()
            {
                Comment = GetCreateComment()
            };
        }
        public CreateCommentForRequest GetCreateComment()
        {
            return new CreateCommentForRequest
            {
                Body = "New Comment Test"
            };
        }
        public JCreateLoginUserRequest GetDefaultLoginUserRequest()
        {
            return new JCreateLoginUserRequest
            {
                createUser = GetCreateNewDefaultUser()
            };
        }
        public CreateUserForRequest GetCreateNewDefaultUser()
        {
            return new CreateUserForRequest
            {
                Username = "Nikola1231",
                Email = "nikola12221@nikola.nikola",
                Password = "nikolanikola"
            };
        }
        public JNewArticleResponse GetJNewArticleResponse()
        {
            return new JNewArticleResponse
            {
                Article = GetNewArticleForResponse()
            };
        }
        public NewArticleForResponse GetNewArticleForResponse()
        {
            return new NewArticleForResponse
            {
                Author = GetNewAuthorForResponse(),
                Title = "New Article Title Test",
                Slug = "new-article-title-test-f2g5aa",
                Body = "New Article Body Test",
                Description = "New Article Description Test",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                TagList = new List<string> { "Nikola", "12345" }
            };
        }
        public NewAuthorForResponse GetNewAuthorForResponse()
        {
            return new NewAuthorForResponse
            {
                Username = "Nikola1231",
                Bio = null,
                Following = false,
                Image = "https://static.productionready.io/images/smiley-cyrus.jpg"
            };
        }
        public string GetRandomUserName()
        {
            var chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var randomUserName = new String(stringChars);
            return randomUserName;
        }
        public string GetRandomEmail()
        {
            var chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var radnomString = new String(stringChars);
            string randomEmail = radnomString + "@somemail.com";
            return randomEmail;
        }
        public string GetRandomPassword()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            string randomPassword = "password" + randomInt;

            return randomPassword;
        }
    }
}
