# Docker-.NET-Core

This is an Hello World example of running ASP.NET Core in Docker.

Clone / download the files and execute the following command

docker build -t testapp .
docker run -d -p 8080:5000 testapp

After that start your browser and navigate to http://localhost:8080
