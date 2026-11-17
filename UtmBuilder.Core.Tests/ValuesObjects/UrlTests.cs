using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValuesObjects;

[TestClass]
public class UrlTests
{
	[TestMethod(DisplayName = "Dada uma URL inválida, deve lançar uma exceção")]
	[TestCategory("Teste de URL")]
	public void Dado_uma_url_invalida_deve_retornar_uma_excecao()
	{
		// Arrange
		var url = "ww.google.com";

		// Act
		var exception = Assert.ThrowsExactly<InvalidUrlException>(
			() => new Url(url)
		);

		// Assert
		Assert.AreEqual("URL inválida", exception.Message);
	}

	[TestMethod(DisplayName = "Dada uma URL válida, não deve lançar uma exceção")]
	[TestCategory("Teste de URL")]
	public void Dado_uma_url_valida_nao_deve_retornar_uma_excecao()
	{
		// Arrange
		var url = "https://www.google.com";

		// Act
		var urlObject = new Url(url);

		// Assert
		Assert.IsNotNull(urlObject);
	}
}