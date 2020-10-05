using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeRepository
{
    public class BadgeRepositoryDictionary
    {
        Dictionary<Badge, List<Access>> badgeAccess = new Dictionary<Badge, List<Access>>();
        List<Access> doorAccess = new List<Access>();

        //Add to access list
        public List<Access> AddDoorAccess(Access door)
        {
            int beforeAdded = doorAccess.Count;
            doorAccess.Add(door);
            Console.WriteLine(doorAccess);
            return doorAccess;
        }

        //Create a dictionary of Badge(key), Access(value) pairs
        public bool AddBadgeAccessToDict (Badge badge, List<Access> access)
        {
            int countBeforeAdded = badgeAccess.Count;
            badgeAccess[badge] = access;
            bool isAdded = (badgeAccess.Count > countBeforeAdded);
            return isAdded;
        }

        //Return all items in the dictionary
        public Dictionary<Badge,List<Access>> ListBadgeAccess()
        {
            return badgeAccess;
        } 

        //Remove from access list
        public List<Access> RemoveDoorAccess(Access door)
        {
            doorAccess.Remove(door);
            return doorAccess;
        }
        
        //Update the Access(value) of a specified Badge(key)
        public bool UpdateAccess(Badge badgeID, List<Access> access)
        {
            var beforeUpdate = badgeAccess[badgeID].Count;
            badgeAccess[badgeID] = access;
            bool wasUpdated = (badgeAccess[badgeID].Count != beforeUpdate);
            return wasUpdated;
        }
    }
}
