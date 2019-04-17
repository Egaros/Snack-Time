#!/bin/sh

docker run --rm -i \
-v $(pwd):/app \
-w /app \
mcr.microsoft.com/dotnet/core/sdk:3.0.100-preview3-alpine3.9 \
dotnet build -c Release -r win-x64 -o ./webapi ./SnackTime.WebApi/SnackTime.WebApi.csproj 

docker run --rm -i \
-v $(pwd):/app \
-w /app \
mcr.microsoft.com/dotnet/core/sdk:3.0.100-preview3-alpine3.9 \
dotnet build -c Release -r win-x64 -o ./media-server ./SnackTime.MediaServer.Runner/SnackTime.MediaServer.Runner.csproj

