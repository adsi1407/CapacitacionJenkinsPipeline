FROM microsoft/aspnetcore:2.0
WORKDIR /app
RUN mkdir data
COPY /bin/Release/netcoreapp2.0 .
ENTRYPOINT ["dotnet", "Calculadora.dll"]