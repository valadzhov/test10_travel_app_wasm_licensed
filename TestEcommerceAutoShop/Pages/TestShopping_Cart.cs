using Bunit;
using Microsoft.Extensions.DependencyInjection;
using EcommerceAutoShop.Pages;

namespace TestEcommerceAutoShop
{
	[Collection("EcommerceAutoShop")]
	public class TestShopping_Cart
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbButtonModule));
			var componentUnderTest = ctx.RenderComponent<Shopping_Cart>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
