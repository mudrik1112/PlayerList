Dokumentasi

## Untuk menjalankan program buka terminal dan  masuk ke folder player list dengan cara type “cd playerlist.api” kemudian type  “dotnet run”
Untuk send request GET api/players buka file PlayerList.http dan send request dengan "GET http://localhost:5152/players"
Untuk menjalankan filter birthplace menggunakan :
"GET http://localhost:5152/players/birthplace/Europe"
Untuk mendapatkan Players by id menggunakan :
"GET http://localhost:5152/players/3"
Untuk Membuat player baru dengan POST menggunakan:

POST http://localhost:5152/players
Content-Type: application/json

{
    
	"name": "Marselino Ferdinan",
	"age": 19,
	"birthPlace": "South East Asia"
    
}

ConnectionString yang ada di appsettings.json adalah :
  "ConnectionStrings": {
	"GameStore":"Data Source=PlayerList.db"
  }
