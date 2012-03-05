@ECHO OFF
@REM Set command switch for building debug or release (default is to build debug)
@REM Type "GenerateAndBuild.bat -d" to build for debug

"C:\Program Files\Elency Solutions\FrameworkGen 4.1\FrameworkGen.exe" "C:\Users\Administrator\Documents\Visual Studio 2010\Projects\MicrodataSchema\Tester\Generated\SolutionItems\FrameworkGen.FrameworkGen" -s

@IF "%1"=="-d" GOTO BUILDDEBUG

GOTO BUILDRELEASE

:BUILDDEBUG
"%WINDIR%\Microsoft.NET\Framework\v3.5\msbuild.exe" "C:\Users\Administrator\Documents\Visual Studio 2010\Projects\MicrodataSchema\Tester\Generated\Microdata.sln" /t:Rebuild /verbosity:quiet /p:Configuration=Debug
GOTO END

:BUILDRELEASE
"%WINDIR%\Microsoft.NET\Framework\v3.5\msbuild.exe" "C:\Users\Administrator\Documents\Visual Studio 2010\Projects\MicrodataSchema\Tester\Generated\Microdata.sln" /t:Rebuild /verbosity:quiet /p:Configuration=Release
GOTO END

:END

