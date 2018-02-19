
using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace ClosestStores
{
    class TableSource: UITableViewSource
    {
        List<Stores> stores;
        public TableSource(List<Stores> stores)
        {
            this.stores = stores;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (TableCell) tableView.DequeueReusableCell("cellID", indexPath);
            var store = stores[indexPath.Row];

            cell.updateCell(store);


            cell.Callbutton.TouchUpInside += CallNumber;
            return cell;
        }

        private void CallNumber(object sender, EventArgs e)
        {
            var button = sender as UIButton;
            var phoneNumber = button.Title(UIControlState.Normal);
            //var url = new Foundation.NSUrl("tel:" + phoneNumber);
            var alert = UIAlertController.Create("Alert", "Call " + phoneNumber +  " ?", UIAlertControllerStyle.Alert);

                   alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
                   alert.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, null));

               UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(alert, true, null);
           
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return stores.Count;
        }
       
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var Currentstore = stores[indexPath.Row];
            string mapURL = String.Format("http://maps.google.com/maps?q={0}+{1}", Currentstore.Latitude, Currentstore.Longitude);
            UIApplication.SharedApplication.OpenUrl(new NSUrl(mapURL));
        }
    }
}
