using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        // Arrange
        var texto = "Matrix";  // Corrigido de "a" para "Matrix"
        var resultadoEsperado = 6;  // Corrigido para 6, que é a quantidade de caracteres da palavra "Matrix"

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);  // Verifica se o número de caracteres é igual a 6
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);  // Corrigido a chamada do método

        // Assert
        Assert.True(resultado);  // Verifica se o método retornou verdadeiro, pois a palavra "qualquer" está presente
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.False(resultado);  // Verifica se o método retornou falso, pois a palavra "teste" não está presente
    }

    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        // Arrange
        var texto = "Começo, meio e fim do texto procurado";  // O texto completo
        var textoProcurado = "procurado";  // Corrigido para "procurado", que está no final do texto

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);  // Verifica se o texto termina com a palavra "procurado"
    }
}
