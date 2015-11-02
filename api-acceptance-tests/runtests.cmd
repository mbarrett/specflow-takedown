@pushd %~dp0

%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe "api-acceptance-tests.csproj"

@if ERRORLEVEL 1 goto end

@cd ..\packages\SpecRun.Runner.*\tools

@set profile=%1
@if "%profile%" == "" set profile=Default

SpecRun.exe run %profile%.srprofile "/baseFolder:%~dp0\bin\Debug" /log:specrun.log %2 %3 %4 %5

@cd ..\..\..\

packages\Pickles.CommandLine.1.2.3\tools\pickles.exe --feature-directory=api-acceptance-tests\Features --output-directory=Documentation --documentation-format=word

:end

@popd
