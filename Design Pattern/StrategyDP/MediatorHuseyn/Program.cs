

using MediatorHuseyn;

HaydarAliyevAirport heyderAliyevAirport = new();


EnglandAirlines englandAirline = new() { FlightNumber = "222", Airport = heyderAliyevAirport };
EnglandAirlines englandAirline2 = new() { FlightNumber = "111", Airport = heyderAliyevAirport };
NorwayAirlines norwayAirline = new() { FlightNumber = "444", Airport = heyderAliyevAirport };

heyderAliyevAirport.Register(englandAirline);
heyderAliyevAirport.Register(englandAirline2);
heyderAliyevAirport.Register(norwayAirline);

englandAirline.GetLandingPermission();
englandAirline2.GetLandingPermission();
norwayAirline.GetLandingPermission();



