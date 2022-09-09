using MVCDemo.Models;

namespace MVCDemo.FriendsService
{
    public class FriendServices
    {
        static List<Friend> Friends { get; }
        static int nextId = 3;
        static FriendServices()
        {
            Friends = new List<Friend>
                {
                    new Friend { FriendID = 123, FName = "Vishwanath ", FPlace = " Belgaum " },
                    new Friend { FriendID = 246, FName = " abc" , FPlace = " def"  }

                };
        }

        public static List<Friend> GetAll() => Friends;

        public static Friend? Get(int id) => Friends.FirstOrDefault(f => f.FriendID == id);

        public static void Add(Friend friends)
        {
            friends.FriendID = nextId++;
            Friends.Add(friends);
        }

        public static void Delete(int id)
        {
            var friends = Get(id);
            if (friends is null)
                return;

            Friends.Remove(friends);
        }

        public static void Update(Friend friends)
        {
            var index = Friends.FindIndex(f => f.FriendID == friends.FriendID);
            if (index == -1)
                return;

            Friends[index] = friends;
        }
    }
}
