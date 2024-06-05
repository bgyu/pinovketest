# Debug .Net Code
## lauch mode
```json
{
    "name": ".NET Core Launch (console)",
    "type": "coreclr",
    "request": "launch",
    //"preLaunchTask": "build",
    "program": "${workspaceFolder}/MixedDebugExample/bin/Debug/net8.0/MixedDebugExample",
    "args": [],
    "cwd": "${workspaceFolder}",
    "stopAtEntry": false,
    "console": "internalConsole"
}
```
In this mode, you specify "request" type as "launch", "program" as the path your .net application. Then press Ctrl + Shift + D, select ".NET Core Launch (console)" in "RUN AND DEBUG" drop list. 
Then set a breakpoint in your code and F5.

## attach mode
```json
{
    "name": ".NET Core Attach Test",
    "type": "coreclr",
    "request": "attach",
    //"preLaunchTask": "RunTest",
    "processId": "${command:pickProcess}"
}
```
You can also use attach mode. In this mode, you attach to existing running process.

# Debug C++ code called via PInvoke
```
{
    "type": "lldb",
    "request": "launch",
    "name": "C++ Code Debug",
    "program": "${workspaceFolder}/MixedDebugExample/bin/Debug/net8.0/MixedDebugExample",
    "args": [],
    "cwd": "${workspaceFolder}"
}
```
As you can see here, we are using `lldb` here and the program we start is a .NET application which is calling C++ code via PInvoke.
We can set a breakpoint in C++ code and launch the C# program. If our C++ code gets called via PInvoke, the breakpoint will hit.


