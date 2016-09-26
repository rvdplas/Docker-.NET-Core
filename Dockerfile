FROM microsoft/dotnet:latest
COPY /ConsoleApp1/src/ConsoleApp1/bin/Debug/netcoreapp1.0/publish/ /root/
EXPOSE 5000/tcp
ENTRYPOINT dotnet /root/ConsoleApp1.dll