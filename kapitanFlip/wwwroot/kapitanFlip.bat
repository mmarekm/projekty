@echo off
cd /d C:\Users\marek\Desktop\projekty gitHub\kapitanFlip\wwwroot

REM Sprawdz czy http-server jest juz zainstalowany
where http-server >nul 2>nul
if %errorlevel% neq 0 (
    echo Instalowanie http-server...
    npm install -g http-server
)

echo Uruchamianie serwera i przegladarki...

REM Uruchom Firefox w nowym oknie po 2 sekundach opoznienia
start "" cmd /c "timeout /t 2 /nobreak && start firefox http://127.0.0.1:8080"

REM Uruchom serwer
cmd /k "http-server"