@Echo Off
for /d /r . %%d in (bin,obj,.svn,.git) do @if exist "%%d" rd /s/q "%%d"
pause

