// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;

namespace MacToolbar
{
	public partial class WindowController : NSWindowController
	{
		#region Constructors
		public WindowController (IntPtr handle) : base (handle)
		{
		}
		#endregion

		#region Override Methods
		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();

			// Disable trash
			trashItem.Active = false;
		}
		#endregion

		#region Actions
		[Export ("trashDocument:")]
		void TrashDocument (NSObject sender) {

			var controller = ContentViewController as ViewController;
			controller.EraseDocument ();
		}
		#endregion
	}
}
