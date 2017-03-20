﻿using System.Collections.Generic;
using Xeromatic.Models;

namespace Xeromatic.Services
{
    public interface ITweetService
    {
        IEnumerable<TweetOutput> GetAllTweets();
        IEnumerable<TweetOutput> GetTweetsByUser(string author);
        void InsertTweet(TweetInput tweet);
        void DeleteTweet(string tweetId);
    }
}