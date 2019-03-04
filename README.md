# ClimaTempo-Classes

Implementação de classes do retorno da API Forecast do Clima Tempo (/api/v1/forecast/locale/:id/days/15?token=your-app-token), implementadas em C#.

Os arquivos podem ser utilizados para que você implemente em seus projetos.

A baseURL e a chave de autenticação do climaTempo, estão no arquivo web.config do meu projeto .WebAPI, no seguinte formato:

```
 <appSettings>
    <add key="ClimaTempoEndPoint" value="http://apiadvisor.climatempo.com.br/api/" />
    <add key="ClimaTempoKey" value="999xxx999xxxx999xxx999xxx9" />
 </appSettings>
```

Consta também a implementação de um ClientBase, que retirei de um artigo escrito por **Matthew Jones**, em https://exceptionnotfound.net/building-the-ultimate-restsharp-client-in-asp-net-and-csharp/


# Referências:

### ClimaTempo:
- https://advisor.climatempo.com.br/
- http://apiadvisor.climatempo.com.br/doc/index.html

### RestSharp Client:
- http://restsharp.org/
- https://exceptionnotfound.net/building-the-ultimate-restsharp-client-in-asp-net-and-csharp/
