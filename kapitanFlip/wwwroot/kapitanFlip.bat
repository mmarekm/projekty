@echo off
echo Running npm install...
cd /d "C:\Users\marek\Desktop\projekty gitHub\kapitanFlip\wwwroot"
"C:\Program Files\nodejs\npm.cmd" install

echo Starting http-server...
start "" "C:\Users\marek\AppData\Roaming\npm\node_modules\http-server\bin\http-server" . -p 8080

echo Waiting for server to start...
timeout /t 10

echo Opening Firefox...
start "" "C:\Program Files\Mozilla Firefox\firefox.exe" http://127.0.0.1:8080

pause
