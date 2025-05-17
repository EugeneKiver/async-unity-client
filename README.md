# async-unity-client

This project demonstrates a simple asynchronous TCP client used from a Unity
scene. The IP address and port used to connect to the server can now be
configured at runtime.

## Configuring the Network Settings

`GameManager` exposes two public fields, **ipAddress** and **port**, which can be
set from the Unity inspector. These values are assigned to
`AsynchronousClient` before the client connects. The defaults are
`127.0.0.1` and `11000`.

You can also modify these values from code prior to calling
`AsynchronousClient.StartClient()` if you need to load them from a separate
configuration file.
