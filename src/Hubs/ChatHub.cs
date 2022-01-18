using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace SignalRChat.Hubs
{
    
        public class ChatHub : Hub
    {
       /* public override Task OnConnectedAsync()
        {
            using (var db = new UserContext())
            {
                // Retrieve user.
                var user = db.Users
                    .Include(u => u.Rooms)
                    .SingleOrDefault(u => u.UserName == Context.User.Identity.Name);

                // If user does not exist in database, must add.
                if (user == null)
                {
                    user = new User()
                    {
                        UserName = Context.User.Identity.Name
                    };
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                else
                {
                    // Add to each assigned group.
                    foreach (var item in user.Rooms)
                    {
                        Groups.AddToGroupAsync(Context.ConnectionId, item.RoomName);
                    }
                }
            }
            return base.OnConnectedAsync();
        }*/

        // public void AddToRoom(string roomName)
        // {
        //     using (var db = new src.DatabaseContext.Context())
        //     {
        //         // Retrieve room.
        //         var room = db.Rooms.Find(roomName);

        //         if (room != null)
        //         {
        //             var user = new User() { UserName = Context.User.Identity.Name};
        //             db.Users.Attach(user);

        //             room.Users.Add(user);
        //             db.SaveChanges();
        //             Groups.AddToGroupAsync(Context.ConnectionId, roomName);
        //         }
        //     }
        // }

        // public void RemoveFromRoom(string roomName)
        // {
        //     using (var db = new src.DatabaseContext.Context())
        //     {
        //         // Retrieve room.
        //         var room = db.Rooms.Find(roomName);
        //         if (room != null)
        //         {
        //             var user = new User() { UserName = Context.User.Identity.Name };
        //             db.Users.Attach(user);

        //             room.Users.Remove(user);
        //             db.SaveChanges();
                    
        //             Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
        //         }
        //     }
        // }
        
        public async Task JoinRoom(string room)
        {
            //Save new room to DB
            await Groups.AddToGroupAsync(Context.ConnectionId, room);
           
        }
        public Task LeaveRoom(string roomName)
        {
             return Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
        }

         public async Task SendMessage(string user, string room, string message, bool join)
        {
            // Save message in DB
            // ID
            // UserID
            // RoomID (FK)
            // Message (Encapsulate)
            // Likes (JSONlist[UserID])
            if (join)
            {
                await JoinRoom(room).ConfigureAwait(false);
                await Clients.Group(room).SendAsync("ReceiveMessage", user, " has joined " + room).ConfigureAwait(true);

            }
            else
            {
                await Clients.Group(room).SendAsync("ReceiveMessage", user, message).ConfigureAwait(true);

            }
        }
        public async Task SendMessageToCaller(string user, string message)
        {
        await Clients.Caller.SendAsync("ReceiveMessage", user, message);
        }
       
    }
}