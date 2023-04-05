using AdapterPattern;

Socket socket = new();
Fridge fridge = new();
Dishwasher dishwasher = new();
socket.PowerGone(fridge);
socket.PowerGone(dishwasher);
Samsung samsung = new();
///socket.PowerGone(samsung);
Adapter adapter = new(samsung);
socket.PowerGone(adapter);
