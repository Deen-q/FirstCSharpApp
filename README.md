# FirstCSharpApp
Hi, thanks for visiting. This is a very, very simple app to help find my way around .NET and Azure. There's a lot of moving pieces concerning Visual Studio (compared to VS Code) and other Microsoft-related services! I work on this regularly where time permits.
<br>
<br>
<b>End goal:</b> use Azure Storage Emulator and Explorer to queue messages. The queued messages should then trigger a local Azure function, leading to a log to the console.
<br>
<br>
This will ultimately set me up for a more advanced app where I utilise Azure Service Bus and any other relevant Azure services. This should ideally help me secure my knowledge on this front, which is something I aim to do across the scope software engineering (within reason of course!). This is just my personal ethos of 'be at least competent in most things'.
<br>
<br>
<b>Current Stage:</b>
<br>
Getting Azure Storage Explorer to help enqueue messages. No luck so far, neither with the command line.
<br>
Running the code does work somewhat: received logs of timestamped messages every 1 minute (I did this to see if code itself was the problem - it correctly recieves messages. Just need the queue).
