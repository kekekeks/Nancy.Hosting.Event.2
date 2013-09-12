#Nancy.Hosting.Event2

Simple libevent-based host for NancyFx. My benchmark shows that it twice faster than just using Nancy.Hosting.Self on Mono.

#How to use

1) Call Nancy.Hosting.Event2.LibLocator.Init(path) where path is a directory where `libevent_*-2.0.so.5` can be found. Or just null and it will try to use system one.
2) Pass your bootstrapper to Nancy.Hosting.Event2.NancyEvent2Host and call Start(host, port);
