@if "%~1"=="" goto :badend
@echo "%~d0%~p0"
@echo "%~f1\Modules"
mklink /j "%~f1\Modules\oforms" "%~d0%~p0oforms"
mklink /j "%~f1\Modules\ExtendOrchard.MediaPlus" "%~d0%~p0ExtendOrchard.MediaPlus"
goto :end

:badend
@echo This will create symlinks for the projects into your Orchard Modules folder.
@echo It has to be run from the command line with Administrative permissions.
@echo "Syntax: CreateSymbolicLinks <path-to-Orchard.Web>"
:end
pause