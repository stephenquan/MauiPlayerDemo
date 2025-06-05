using CommunityToolkit.Maui.Markup;
using SQuan.Helpers.Maui.Mvvm;

namespace MauiPlayerDemo;

public partial class SelectableLabel : Label
{
	[BindableProperty] public partial bool IsSelected { get; set; } = false;

	public SelectableLabel() : base()
	{
		this.Bind(Label.BackgroundColorProperty, static (SelectableLabel ctx) => ctx.IsSelected, source: this, convert: (bool isSelected) => isSelected ? Colors.SkyBlue : Colors.Transparent);
	}
}
