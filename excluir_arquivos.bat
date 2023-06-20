@echo off
set "caminho=C:\Users\klebe\Desktop\seraQuevai"
set "dias=30"

forfiles /p "%caminho%" /s /m * /d -%dias% /c "cmd /c if @isdir==FALSE echo Excluindo arquivo: @path & del @path /q"
