const http = require('http');
const opn = require('opn');

const PORT = 8080;

// Uruchom serwer HTTP
http.createServer((req, res) => {
  res.writeHead(200, { 'Content-Type': 'text/html' });
  res.write(`
    <html>
      <body>
        <h1>Witaj w grze Kapitan Flip!</h1>
        <a href="javascript:openApp()">Uruchom aplikację</a>
      </body>
    </html>
  `);
  res.end();
}).listen(PORT);

console.log(`Serwer uruchomiony na http://localhost:${PORT}`);

// Funkcja otwierająca przeglądarkę
function openApp() {
  opn(`http://localhost:${PORT}`);
}