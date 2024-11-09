@echo off
cd /d C:\Users\marek\Desktop\projekty gitHub\kapitanFlip\wwwroot
where http-server >nul 2>nul
if %errorlevel% neq 0 (
    npm install -g http-server
)
start "" cmd /c "timeout /t 2 /nobreak && start firefox http://127.0.0.1:8080"
cmd /k "http-server"