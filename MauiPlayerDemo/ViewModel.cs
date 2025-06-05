using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiPlayerDemo;

public partial class ViewModel : ObservableObject
{
	public ObservableCollection<ItemInfo> UserItems { get; } =
	[
		new ItemInfo { Name = "Player 31415" },
		new ItemInfo { Name = "Player 92653" },
		new ItemInfo { Name = "Player 58979" }
	];

	public ObservableCollection<ItemInfo> SortedUserItems => new ObservableCollection<ItemInfo>(UserItems.OrderBy(item => item.Name));
	[ObservableProperty] public partial ItemInfo? SelectedItem { get; set; } = null;

	partial void OnSelectedItemChanged(ItemInfo? oldValue, ItemInfo? newValue)
	{
		if (oldValue is not null) oldValue.IsSelected = false;
		if (newValue is not null) newValue.IsSelected = true;
	}

	Random random = new Random();

	[RelayCommand]
	public void AddAndSort()
	{
		UserItems.Add(new ItemInfo { Name = $"Player {random.Next(0, 100000).ToString("D5")}" }); // Example of adding a new item
		OnPropertyChanged(nameof(SortedUserItems));
	}
}
