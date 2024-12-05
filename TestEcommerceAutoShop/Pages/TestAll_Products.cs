using Bunit;
using Microsoft.Extensions.DependencyInjection;
using EcommerceAutoShop.Pages;

namespace TestEcommerceAutoShop
{
	[Collection("EcommerceAutoShop")]
	public class TestAll_Products
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbDropdownModule),
				typeof(IgbDropdownItemModule),
				typeof(IgbCardModule),
				typeof(IgbButtonGroupModule),
				typeof(IgbToggleButtonModule));
			var componentUnderTest = ctx.RenderComponent<All_Products>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
