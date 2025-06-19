# 🎵 ScreenSound_API

Uma aplicação em C# que consome uma API pública de músicas utilizando `HttpClient`, manipula os dados com LINQ e permite filtros por gênero, artista e tonalidade. O projeto também permite salvar músicas preferidas em um arquivo JSON personalizado.

---

## 📌 Objetivo

O objetivo do projeto é praticar conceitos de:
- Consumo de APIs REST com `HttpClient`
- Serialização e desserialização de JSON com `System.Text.Json`
- Uso do LINQ para filtragem, ordenação e projeção de dados
- Estruturação de classes com boas práticas de orientação a objetos em C#
- Geração de arquivos `.json` contendo listas de músicas preferidas

---

## ⚙️ Funcionalidades

- ✅ Listar todos os gêneros musicais disponíveis
- ✅ Filtrar artistas por gênero
- ✅ Listar músicas de um determinado artista
- ✅ Filtrar músicas com tonalidade "C#" (`C Sharp`)
- ✅ Ordenar os artistas por ordem alfabética
- ✅ Criar uma playlist de músicas preferidas e exportá-la para um arquivo JSON

---

## 🔧 Como executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/JoaoDevFullStack/ScreenSound_API.git
   cd ScreenSound_API/ScreenSound_API
2. Compile e execute o projeto:
  dotnet run

## 📦 Estrutura de Pastas:
ScreenSound_API/
│
├── Models/
│   ├── Music.cs               // Classe base que representa uma música
│   └── PreferredMusics.cs     // Classe que gerencia músicas preferidas e exporta para JSON
│
├── Filters/
│   ├── LINQ.cs                // Filtros usando LINQ: por gênero, artista, tonalidade
│   └── LinqOrder.cs           // Ordenação de artistas
│
└── Program.cs                 // Ponto de entrada do programa, consome a API e executa filtros

## 📥 API Consumida:
https://guilhermeonrails.github.io/api-csharp-songs/songs.json

## 🛠️ Tecnologias Utilizadas:
.NET 8.0
C#
LINQ
HttpClient
System.Text.Json
Programação orientada a objetos (POO)

## 🧪 Exemplos de uso

🔍 Filtrar músicas em C#:
LINQ.FilterMusicsInCSharp(musics);

🎤 Listar artistas por gênero:
LINQ.FilterArtistByGenre(musics, "rock");

💾 Gerar arquivo com músicas preferidas:
var preferred = new PreferredMusics("João");
preferred.AddMusic(musics[1]);
preferred.GenerateJsonArchive();

📄 Saída JSON Exemplo:
{
  "name": "João",
  "musics": [
    {
      "song": "Exemplo 1",
      "artist": "Artista 1",
      "duration_ms": 210000,
      "genre": "Rock",
      "key": 1
    }
  ]
}

## 🙋‍♂️ Autor:
Desenvolvido por João Domingues 🚀
