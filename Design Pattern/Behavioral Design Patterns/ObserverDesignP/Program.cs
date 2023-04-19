using ObserverDesignP;

var user1 = new User
{
    Name = "John",
    Friends = new() { new Friend("Jane"), new Friend("Tom") }

};

var friend1 = new Friend("Jane");

user1.Attach(friend1);

var friend2 = new Friend("Tom");

user1.Attach(friend2);

user1.AddPost("Hakuna Matata");

user1.Detach(friend2);

user1.AddPost("Hello");

Console.ReadLine();