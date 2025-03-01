﻿using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Navigation;

namespace Windows.UI.Xaml.Controls
{
	public partial class Page : UserControl
	{
		public Page()
		{

		}

		protected internal virtual void OnNavigatedFrom(NavigationEventArgs e) { }

		protected internal virtual void OnNavigatedTo(NavigationEventArgs e) { }

		protected internal virtual void OnNavigatingFrom(NavigatingCancelEventArgs e) { }

		#region TopAppBar

		public AppBar TopAppBar
		{
			get => (AppBar)this.GetValue(TopAppBarProperty);
			set => this.SetValue(TopAppBarProperty, value);
		}
		
		public static DependencyProperty TopAppBarProperty { get; } =
			DependencyProperty.Register(
				"TopAppBar",
				typeof(AppBar),
				typeof(Page),
				new FrameworkPropertyMetadata(
					default(AppBar),
					FrameworkPropertyMetadataOptions.ValueInheritsDataContext
				)
			);

		#endregion

		#region BottomAppBar

		public AppBar BottomAppBar
		{
			get => (AppBar)this.GetValue(BottomAppBarProperty);
			set => this.SetValue(BottomAppBarProperty, value);
		}

		public static DependencyProperty BottomAppBarProperty { get; } =
			DependencyProperty.Register(
				"BottomAppBar",
				typeof(AppBar),
				typeof(Page),
				new FrameworkPropertyMetadata(
					default(AppBar), 
					FrameworkPropertyMetadataOptions.ValueInheritsDataContext
				)
			);

		#endregion

		#region Frame

		public
		
#if __IOS__ || __MACOS__
		
		[global::Uno.NotImplemented]
		public  object BottomAppBar
		{
			get
			{
				return (object)this.GetValue(BottomAppBarProperty);
			}
			set
			{
				this.SetValue(BottomAppBarProperty, value);
			}
		}
#endif

			Frame Frame
		{
			get => (Frame)this.GetValue(FrameProperty);
			internal set => this.SetValue(FrameProperty, value);
		}

		public static DependencyProperty FrameProperty { get; } =
			DependencyProperty.Register(
				"Frame",
				typeof(Frame),
				typeof(Page),
				new FrameworkPropertyMetadata(
					default(Frame),
					FrameworkPropertyMetadataOptions.ValueDoesNotInheritDataContext
				)
			);

		#endregion

		public NavigationCacheMode NavigationCacheMode { get; set; }
	}
}
