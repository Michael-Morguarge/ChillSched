using Backend.Inferfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BackEnd.Model;
using Shared.Global;
using System;
using Shared.Model;
using Backend.Implementations;
using System.Collections.Generic;
using System.Linq;

namespace Testing.Backend
{
    [TestClass]
    public class MessageRepositoryTests
    {
        private IMessageRepository repository;

        [TestInitialize]
        public void Setup()
        {
            repository = new MessageRepository();
        }

        #region Get

        [TestMethod]
        public void WhenGettingTheMessage_ReturnsValidMessage()
        {
            #region Data

            Message actual = new Message
            {
                Id = "1",
                DateCreated = TimeAndDateUtility.ConvertDate_Date(DateTime.Today),
                TimeCreated = TimeAndDateUtility.ConvertTime_Time(DateTime.Today),
                Quote = "Test quote",
                Author = "Test author",
                Show = true,
                Source = "From somewhere"
            };

            #endregion Data

            bool testAdd = repository.AddMessage(actual);
            Message result = repository.GetMessage(actual.Id);

            Assert.IsTrue(testAdd);
            Assert.AreEqual(actual.Id, result.Id);
            Assert.AreEqual(
                TimeAndDateUtility.ConvertDateAndTime_Date(actual.DateCreated, actual.TimeCreated),
                TimeAndDateUtility.ConvertDateAndTime_Date(result.DateCreated, result.TimeCreated)
            );
            Assert.AreEqual(actual.Quote, result.Quote);
            Assert.AreEqual(actual.Author, result.Author);
            Assert.AreEqual(actual.Source, result.Source);
        }

        [TestMethod]
        public void WhenGettingTheMessage_HandlesInvalidId()
        {
            #region Data

            Message actual = new Message
            {
                Id = "1",
                DateCreated = TimeAndDateUtility.ConvertDate_Date(DateTime.Today),
                TimeCreated = TimeAndDateUtility.ConvertTime_Time(DateTime.Today),
                Quote = "Test quote",
                Author = "Test author",
                Show = true,
                Source = "From somewhere"
            };

            #endregion Data

            bool testAdd = repository.AddMessage(actual);
            Message result = repository.GetMessage("2");

            Assert.IsTrue(testAdd);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void WhenGettingTheMessage_HandlesNullParam()
        {
            #region Data

            Message actual = new Message
            {
                Id = "1",
                DateCreated = TimeAndDateUtility.ConvertDate_Date(DateTime.Today),
                TimeCreated = TimeAndDateUtility.ConvertTime_Time(DateTime.Today),
                Quote = "Test quote",
                Author = "Test author",
                Show = true,
                Source = "From somewhere"
            };

            #endregion Data

            bool testAdd = repository.AddMessage(actual);
            Message result = repository.GetMessage(null);

            Assert.IsTrue(testAdd);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void WhenGettingTheMessages_ReturnsValidMessages()
        {
            #region Data

            Message actual1 = new Message
            {
                Id = "1",
                DateCreated = TimeAndDateUtility.ConvertDate_Date(DateTime.Today),
                TimeCreated = TimeAndDateUtility.ConvertTime_Time(DateTime.Today),
                Quote = "Test quote",
                Author = "Test author",
                Show = true,
                Source = "From somewhere"
            };

            Message actual2 = new Message
            {
                Id = "2",
                DateCreated = TimeAndDateUtility.ConvertDate_Date(DateTime.Today),
                TimeCreated = TimeAndDateUtility.ConvertTime_Time(DateTime.Today),
                Quote = "Test quote",
                Author = "Test author",
                Show = true,
                Source = "From somewhere"
            };

            #endregion Data

            bool testAdd = repository.AddMessage(actual1) && repository.AddMessage(actual2);
            List<Message> result = repository.GetMessages().ToList();

            Assert.IsTrue(testAdd);
            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void WhenGettingTheMessages_ReturnsValidMessage()
        {
            #region Data

            Message actual1 = new Message
            {
                Id = "1",
                DateCreated = TimeAndDateUtility.ConvertDate_Date(DateTime.Today),
                TimeCreated = TimeAndDateUtility.ConvertTime_Time(DateTime.Today),
                Quote = "Test quote 1",
                Author = "Test author",
                Show = true,
                Source = "From somewhere"
            };

            Message actual2 = new Message
            {
                Id = "2",
                DateCreated = TimeAndDateUtility.ConvertDate_Date(DateTime.Today),
                TimeCreated = TimeAndDateUtility.ConvertTime_Time(DateTime.Today),
                Quote = "Test quote 2",
                Author = "Test author",
                Show = true,
                Source = "From somewhere"
            };

            #endregion Data

            bool testAdd = repository.AddMessage(actual1) && repository.AddMessage(actual2);
            List<Message> result = repository.GetMessages("1").ToList();

            Assert.IsTrue(testAdd);
            Assert.AreEqual(1, result.Count());
        }

        [TestMethod]
        public void WhenGettingTheMessages_HandlesInvalidSearchParam()
        {
            #region Data

            Message actual1 = new Message
            {
                Id = "1",
                DateCreated = TimeAndDateUtility.ConvertDate_Date(DateTime.Today),
                TimeCreated = TimeAndDateUtility.ConvertTime_Time(DateTime.Today),
                Quote = "Test quote",
                Author = "Test author",
                Show = true,
                Source = "From somewhere"
            };

            Message actual2 = new Message
            {
                Id = "2",
                DateCreated = TimeAndDateUtility.ConvertDate_Date(DateTime.Today),
                TimeCreated = TimeAndDateUtility.ConvertTime_Time(DateTime.Today),
                Quote = "Test quote",
                Author = "Test author",
                Show = false,
                Source = "From somewhere"
            };

            #endregion Data

            bool testAdd = repository.AddMessage(actual1) && repository.AddMessage(actual2);
            List<Message> result = repository.GetMessages(null).ToList();

            Assert.IsTrue(testAdd);
            Assert.AreEqual(0, result.Count());
        }

        #endregion Get

        #region Add

        [TestMethod]
        public void WhenAddingTheMessage_AddsSuccessful()
        {
            #region Data

            Message actual = new Message
            {
                Id = "1",
                DateCreated = TimeAndDateUtility.ConvertDate_Date(DateTime.Today),
                TimeCreated = TimeAndDateUtility.ConvertTime_Time(DateTime.Today),
                Quote = "Test quote",
                Author = "Test author",
                Show = true,
                Source = "From somewhere"
            };

            #endregion Data

            bool testAdd = repository.AddMessage(actual);

            Assert.IsTrue(testAdd);
        }

        [TestMethod]
        public void WhenAddingTheMessage_AddsUnsuccessful()
        {
            bool testAdd = repository.AddMessage(null);

            Assert.IsFalse(testAdd);
        }

        #endregion Add

        #region Update

        [TestMethod]
        public void WhenUpdatingTheMessage_UpdatesSuccessful()
        {
            #region Data

            Message actual = new Message
            {
                Id = "1",
                DateCreated = TimeAndDateUtility.ConvertDate_Date(DateTime.Today),
                TimeCreated = TimeAndDateUtility.ConvertTime_Time(DateTime.Today),
                Quote = "Test quote",
                Author = "Test author",
                Show = true,
                Source = "From somewhere"
            };

            Message actual2 = new Message
            {
                Id = "1",
                DateCreated = actual.DateCreated,
                TimeCreated = actual.TimeCreated,
                Quote = "Quote test",
                Author = "Author test",
                Show = false,
                Source = "Somewhere from"
            };

            #endregion Data

            bool testAdd = repository.AddMessage(actual);

            Assert.IsTrue(testAdd);

            bool testUpdate = repository.UpdateMessage(actual2);

            Assert.IsTrue(testUpdate);

            Message result = repository.GetMessage(actual2.Id);

            Assert.AreEqual(actual2.Id, result.Id);
            Assert.AreEqual(
                TimeAndDateUtility.ConvertDateAndTime_Date(actual2.DateCreated, actual2.TimeCreated),
                TimeAndDateUtility.ConvertDateAndTime_Date(result.DateCreated, result.TimeCreated)
            );
            Assert.AreEqual(actual2.Quote, result.Quote);
            Assert.AreEqual(actual2.Author, result.Author);
            Assert.AreEqual(actual2.Source, result.Source);
        }

        [TestMethod]
        public void WhenUpdatingTheMessage_HandlesInvalidId()
        {
            #region Data

            Message actual = new Message
            {
                Id = "1",
                DateCreated = TimeAndDateUtility.ConvertDate_Date(DateTime.Today),
                TimeCreated = TimeAndDateUtility.ConvertTime_Time(DateTime.Today),
                Quote = "Test quote",
                Author = "Test author",
                Show = true,
                Source = "From somewhere"
            };

            Message actual2 = new Message
            {
                Id = "2",
                DateCreated = TimeAndDateUtility.ConvertDate_Date(DateTime.Today),
                TimeCreated = TimeAndDateUtility.ConvertTime_Time(DateTime.Today),
                Quote = "Quote test",
                Author = "Author test",
                Show = false,
                Source = "Somewhere from"
            };

            #endregion Data

            bool testAdd = repository.AddMessage(actual);

            Assert.IsTrue(testAdd);

            bool testUpdate = repository.UpdateMessage(actual2);

            Assert.IsFalse(testUpdate);
        }

        [TestMethod]
        public void WhenUpdatingTheMessage_UpdateUnsuccessful()
        {
            bool testUpdate = repository.UpdateMessage(null);

            Assert.IsFalse(testUpdate);
        }

        #endregion Update

        #region Delete

        [TestMethod]
        public void WhenDeletingTheMessage_DeleteSuccessful()
        {
            #region Data

            Message actual1 = new Message
            {
                Id = "1",
                DateCreated = TimeAndDateUtility.ConvertDate_Date(DateTime.Today),
                TimeCreated = TimeAndDateUtility.ConvertTime_Time(DateTime.Today),
                Quote = "Test quote",
                Author = "Test author",
                Show = true,
                Source = "From somewhere"
            };

            Message actual2 = new Message
            {
                Id = "2",
                DateCreated = TimeAndDateUtility.ConvertDate_Date(DateTime.Today),
                TimeCreated = TimeAndDateUtility.ConvertTime_Time(DateTime.Today),
                Quote = "Quote test",
                Author = "Author test",
                Show = false,
                Source = "Somewhere from"
            };

            #endregion Data

            bool testAdd = repository.AddMessage(actual1) && repository.AddMessage(actual2);
            bool testDelete = repository.DeleteMessage(actual1.Id);
            Message result = repository.GetMessage(actual1.Id);

            Assert.IsTrue(testAdd);
            Assert.IsTrue(testDelete);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void WhenDeletingTheMessage_HandlesInvalidId()
        {
            #region Data

            Message actual1 = new Message
            {
                Id = "1",
                DateCreated = TimeAndDateUtility.ConvertDate_Date(DateTime.Today),
                TimeCreated = TimeAndDateUtility.ConvertTime_Time(DateTime.Today),
                Quote = "Test quote",
                Author = "Test author",
                Show = true,
                Source = "From somewhere"
            };

            Message actual2 = new Message
            {
                Id = "2",
                DateCreated = TimeAndDateUtility.ConvertDate_Date(DateTime.Today),
                TimeCreated = TimeAndDateUtility.ConvertTime_Time(DateTime.Today),
                Quote = "Quote test",
                Author = "Author test",
                Show = false,
                Source = "Somewhere from"
            };

            #endregion Data

            bool testAdd = repository.AddMessage(actual1);
            bool testDelete = repository.DeleteMessage(actual2.Id);

            Assert.IsTrue(testAdd);
            Assert.IsFalse(testDelete);
        }

        [TestMethod]
        public void WhenDeletingTheMessage_DeleteUnsuccessful()
        {
            bool testDelete = repository.DeleteMessage(null);

            Assert.IsFalse(testDelete);
        }

        #endregion Delete
    }
}
