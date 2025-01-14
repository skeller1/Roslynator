@echo off

set _programFiles=%ProgramFiles%

"%_programFiles%\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\MSBuild" "..\src\VisualStudio.sln" ^
 /t:Clean,Build ^
 /p:Configuration=Debug,RunCodeAnalysis=false,DeployExtension=false ^
 /nr:false ^
 /v:normal ^
 /m

if errorlevel 1 (
 pause
 exit
)

set _vsixInstallerExe="%_programFiles%\Microsoft Visual Studio\2022\Enterprise\Common7\IDE\VSIXInstaller"

echo Uninstalling Roslynator...
%_vsixInstallerExe% /q /u:d42db039-5432-4399-bb62-67a9b4c3b838
echo Uninstalled Roslynator

if errorlevel 1 (
 pause
 exit
)

echo Installing Roslynator...
%_vsixInstallerExe% /q "..\src\VisualStudio\bin\Debug\Roslynator.VisualStudio.vsix"
echo Installed Roslynator

pause