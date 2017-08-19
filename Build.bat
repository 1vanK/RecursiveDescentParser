set "PATH=c:\Windows\Microsoft.NET\Framework\v2.0.50727\"
del Interpreter.exe
csc /target:exe /out:Interpreter.exe *.cs
pause
