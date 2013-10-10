Moved here: https://github.com/kekekeks/evhttp-sharp (extracted libevent-based http listener to a separate assembly, probably will implement hosts for another frameworks)

#Nancy.Hosting.Event2

Simple libevent-based host for NancyFx. My benchmark shows that it's twice faster than just using Nancy.Hosting.Self when running under Mono.

#How to use

1) Call `Nancy.Hosting.Event2.LibLocator.Init(path)` where `path` is a directory where `libevent_*-2.0.so.5` can be found. 
Or just pass null and it will try to use system one.

2) Pass your bootstrapper to Nancy.Hosting.Event2.NancyEvent2Host and call Start(host, port);
