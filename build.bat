:start
SETLOCAL
set Action=%~1
set Config=%~2

:startthebuild

SET LogFile=%~dp0compile_%Action%.log
SET ErrLogFile=%~dp0compile_%Action%_errors.log
@ECHO ON
"%ProgramFiles(x86)%\MSBuild\12.0\Bin\MSBUILD.EXE" /m /nologo "%~dp0ReadSecurePassword.sln" /p:Configuration=%Config% /p:Platform="Any CPU" /t:%Action% /flp:"LogFile=%LogFile%" /flp:"errorsonly;LogFile=%ErrLogFile%"
@ECHO.
@ECHO Build log file: %LogFile%
