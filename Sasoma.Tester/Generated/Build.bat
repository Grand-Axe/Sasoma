@ECHO OFF
@REM Set command switch for building debug or release (default is to build debug)
@REM Type "Build.bat -d" to build for release

@IF "%1"=="-d" GOTO BUILDDEBUG

GOTO BUILDRELEASE

:BUILDDEBUG
"%WINDIR%\Microsoft.NET\Framework\v3.5\msbuild.exe" "C:\Users\Administrator\Documents\Visual Studio 2010\Projects\MicrodataSchema\Tester\Generated\Microdata.sln" /t:Rebuild /verbosity:quiet /p:Configuration=Debug
GOTO END

:BUILDRELEASE
"%WINDIR%\Microsoft.NET\Framework\v3.5\msbuild.exe" "C:\Users\Administrator\Documents\Visual Studio 2010\Projects\MicrodataSchema\Tester\Generated\Microdata.sln" /t:Rebuild /verbosity:quiet /p:Configuration=Release
GOTO END

:END