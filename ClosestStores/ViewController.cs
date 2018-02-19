using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace ClosestStores
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public ViewController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var stores = new List<Stores>{
                new Stores{
                    Name = "Baileys Range",
                    PhoneNumber = "(314) 241-8121",
                    Latitude = "38.628583",
                    Longitude = "-90.194508"
                },
                new Stores{
                    Name = "Sushi Ai",
                    PhoneNumber = "(314) 588-7888",
                    Latitude = "38.628927",
                    Longitude = "-90.194057"
                },
                new Stores{
                    Name = "6 North Cafe",
                    PhoneNumber = "(314) 241-4333",
                    Latitude = "38.626966",
                    Longitude = "-90.192963"
                },
                new Stores{
                    Name = "Starbucks",
                    PhoneNumber = "(314) 231-2150",
                    Latitude = "38.628164",
                    Longitude = "-90.189960"
                },
                new Stores{
                    Name = "St. Louis Bread Co.",
                    PhoneNumber = "(314) 588-0423",
                    Latitude = "38.627128",
                    Longitude = "-90.190390"
                },
                new Stores{
                    Name = "Rooster",
                    PhoneNumber = "(314) 241-8118",
                    Latitude = "38.630065",
                    Longitude = "-90.195701"
                },
                new Stores{
                    Name = "Flamingo Bowl",
                    PhoneNumber = "(314) 436-6666",
                    Latitude = "38.631674",
                    Longitude = " -90.195566"
                },
                new Stores{
                    Name = "Mango Restaurant",
                    PhoneNumber = "(314) 621-9993",
                    Latitude = "38.631397",
                    Longitude = " -90.193924"
                },

            };

            StoresTableView.Source = new TableSource(stores);

            StoresTableView.RowHeight = UITableView.AutomaticDimension;
            StoresTableView.EstimatedRowHeight = 40f;
            StoresTableView.ReloadData();


        }

        partial void UIButton1212_TouchUpInside(UIButton sender)
        {
            
            string mapURL = "http://maps.google.com/maps?q=38.628834,-90.192788";
            UIApplication.SharedApplication.OpenUrl(new NSUrl(mapURL));
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
