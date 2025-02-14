FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copy solution and project files
COPY ["ExamplosCurso.sln", "./"]
COPY ["Presentation.ExamplosCurso/Presentation.ExamplosCurso.Api.csproj", "Presentation.ExamplosCurso/"]
COPY ["ExemploCurso.Application/ExemploCurso.Application.csproj", "ExemploCurso.Application/"]
COPY ["ExemploCurso.Domain/ExemploCurso.Domain.csproj", "ExemploCurso.Domain/"]
COPY ["ExemploCurso.IoC/ExemploCurso.IoC.csproj", "ExemploCurso.IoC/"]
COPY ["ExemploCurso.Repository/ExemploCurso.Repository.csproj", "ExemploCurso.Repository/"]

# Restore dependencies
RUN dotnet restore "ExamplosCurso.sln"

# Copy everything and build
COPY . .
WORKDIR "/src/Presentation.ExamplosCurso"
RUN dotnet publish "Presentation.ExamplosCurso.Api.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app

# Configure the URL and expose port 54841
ENV ASPNETCORE_URLS=http://0.0.0.0:54841
EXPOSE 54841

COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Presentation.ExamplosCurso.Api.dll"]
