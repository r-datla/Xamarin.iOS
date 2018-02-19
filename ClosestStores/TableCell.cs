using Foundation;
using System;
using UIKit;

namespace ClosestStores
{
    public partial class TableCell : UITableViewCell
    {
        
        string phoneNumber;
       
        public TableCell (IntPtr handle) : base (handle)
        {
           
        }

        internal void updateCell(Stores store)
        {
            phoneNumber = store.PhoneNumber;
            NameLabel.Text = store.Name;
            CallButton.SetTitle("Ph: " + store.PhoneNumber, UIControlState.Normal);
        }

        public UIButton Callbutton{
            get{
                return CallButton;
            }
        }
       
    }
}