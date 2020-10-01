using System;
using System.Collections;
using ClaimRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClaimRepository_Tests
{
    [TestClass]
    public class ClaimRepositoryTests
    {
        [TestMethod]
        public void AddClaimToQueueTest()
        {
            //Arrange
            Claim claim = new Claim();
            ClaimRepositoryQueue claimRepositoryQueue = new ClaimRepositoryQueue();

            //ACT
            bool addedToQueue = claimRepositoryQueue.AddClaimToQueue(claim);

            //Assert
            Assert.IsTrue(addedToQueue);
            Console.WriteLine(addedToQueue);
        }

        [TestMethod]
        public void ReadClaimsTest()
        {
            //Arrange
            Claim claim = new Claim();
            ClaimRepositoryQueue claimRepositoryQueue = new ClaimRepositoryQueue();
            claimRepositoryQueue.AddClaimToQueue(claim);

            //ACT
            var claimQueue = claimRepositoryQueue.ReadClaims();

            //Assert
            bool queueHasClaims = claimQueue.Contains(claim);
            Assert.IsTrue(queueHasClaims);
            Console.WriteLine(queueHasClaims);
        }

        [TestMethod]
        public void RemoveClaimFromQueueTest()
        {
            //Arrange
            Claim claim = new Claim();
            ClaimRepositoryQueue claimRepositoryQueue = new ClaimRepositoryQueue();

            claimRepositoryQueue.AddClaimToQueue(claim);

            //ACT
            bool wasClaimDequeued = claimRepositoryQueue.RemoveClaimFromQueue(claim);

            //Assert
            Assert.IsTrue(wasClaimDequeued);
            Console.WriteLine(wasClaimDequeued);
        }
    }
}
