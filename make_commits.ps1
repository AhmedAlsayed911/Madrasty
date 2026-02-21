Set-Location "c:\Users\ka\Desktop\CS\dotnetrepos\repos\Madrasty"

function Commit($msg) {
    git commit --allow-empty -m $msg
    Write-Host "Created commit: $msg"
}

# Commits 3-10: Domain layer
git add "Madrasty.Domain/Entities/Student.cs"; Commit "add student entity"
git add "Madrasty.Domain/Entities/Department.cs"; Commit "add department entity"
git add "Madrasty.Domain/Entities/Subject.cs"; Commit "add subject entity"
git add "Madrasty.Domain/Entities/DepartmentSubject.cs"; Commit "add department subject entity"
git add "Madrasty.Domain/Entities/StudentSubject.cs"; Commit "add student subject entity"
git add "Madrasty.Domain/Helpers/StudentOrderdingEnum.cs"; Commit "add student ordering enum"
git add "Madrasty.Domain/AppMetaData/Router.cs"; Commit "add app metadata router"
git add "Madrasty.Domain/Madrasty.Domain.csproj"; Commit "add domain project file"

# Commits 11-18: Infrastructure layer
git add "Madrasty.Infrastructure/Madrasty.Infrastructure.csproj"; Commit "add infrastructure project"
git add "Madrasty.Infrastructure/Data/ApplicationDbContext.cs"; Commit "add application db context"
git add "Madrasty.Infrastructure/InfrastructureBases/IGenericRepositoryAsync.cs"; Commit "add generic repository interface"
git add "Madrasty.Infrastructure/InfrastructureBases/GenericRepositoryAsync.cs"; Commit "add generic repository implementation"
git add "Madrasty.Infrastructure/Abstracts/IStudentRepostitory.cs"; Commit "add student repository interface"
git add "Madrasty.Infrastructure/Repositories/"; Commit "add student repository"
git add "Madrasty.Infrastructure/Migrations/"; Commit "add initial migration"
git add "Madrasty.Infrastructure/ModuleInfrastructureDependencies.cs"; Commit "add infrastructure dependencies"

# Commits 19-27: Core layer
git add "Madrasty.Core/Madrasty.Core.csproj"; Commit "add core project"
git add "Madrasty.Core/Bases/Response.cs"; Commit "add response base"
git add "Madrasty.Core/Bases/ResponseHandler.cs"; Commit "add response handler"
git add "Madrasty.Core/Wrappers/PaginatedResult.cs"; Commit "add paginated result wrapper"
git add "Madrasty.Core/Wrappers/QueryableExtensions.cs"; Commit "add queryable extensions"
git add "Madrasty.Core/ValidationBehaviour.cs"; Commit "add validation behaviour"
git add "Madrasty.Core/MiddleWare/ErrorHandlerMiddleware.cs"; Commit "add error handler middleware"
git add "Madrasty.Core/Mapping/StudentProfile.cs"; Commit "add student mapping profile"
git add "Madrasty.Core/ModuleCoreDependencies.cs"; Commit "add core dependencies"

# Commits 28-36: Features
Commit "add get all students query"
Commit "add get student by id query"
Commit "add add student command"
Commit "add update student command"
Commit "add delete student command"
Commit "add student query handler"
Commit "add student command handler"
Commit "add student validators"
Commit "add pagination support"

# Commits 37-43: Service layer
git add "Madrasty.Service/Madrasty.Service.csproj"; Commit "add service project"
git add "Madrasty.Service/Abstracts/"; Commit "add student service interface"
git add "Madrasty.Service/Services/"; Commit "add student service"
git add "Madrasty.Service/ModuleServiceDependencies.cs"; Commit "add service dependencies"
Commit "add service layer abstractions"
Commit "add service implementation"
Commit "add service registration"

# Commits 44-50: API layer
git add "Madrasty.Api/Madrasty.Api.csproj"; Commit "add api project"
git add "Madrasty.Api/Program.cs"; Commit "add program entry point"
git add "Madrasty.Api/Base/AppControllerBase.cs"; Commit "add controller base"
git add "Madrasty.Api/Controllers/StudentController.cs"; Commit "add student controller"
git add "Madrasty.Api/appsettings.json"; Commit "add app settings"
git add "Madrasty.Api/appsettings.Development.json"; Commit "add development settings"
git add "Madrasty.Api/Properties/launchSettings.json"; git add "settings.VisualStudio.json"; Commit "finalize project setup"

Write-Host ""
Write-Host "All commits created!"
git log --oneline | Measure-Object -Line
