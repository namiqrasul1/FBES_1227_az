using MyMiddleWebServer.MyWebServer;

WebHost host = new(27001);
host.UseStartup<Startup>();
host.Run();