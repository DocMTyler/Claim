using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimRepository
{
    public class ClaimRepositoryQueue
    {
        Queue<Claim> claimItem = new Queue<Claim>();
        
        //Create a claim, add to queue 
        public bool AddClaimToQueue(Claim claim)
        {
            int beforeEnqueue = claimItem.Count;
            claimItem.Enqueue(claim);
            bool isAddedToQ = (claimItem.Count > beforeEnqueue);
            return isAddedToQ;
        }

        //Read all claims
        public Queue<Claim> ReadClaims()
        {
            return claimItem;
        }

        //Delete a claim, remove from queue
        public bool RemoveClaimFromQueue(Claim claim)
        {
            int beforeDequeue = claimItem.Count;
            claimItem.Dequeue();
            bool isRemovedFromQ = (claimItem.Count < beforeDequeue);
            return isRemovedFromQ;
        }

    }
}
