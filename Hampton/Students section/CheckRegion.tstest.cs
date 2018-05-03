using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace AccelliTrackUni
{

    public class CheckRegion : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        //[CodedStep(@"New Coded Step")]
        //public void CheckRegionCodedStep()
        //{
            //int coun = 0;
            //string count = coun.ToString();
            //SetExtractedValue("count", count);
        //}
    
        //[CodedStep(@"Add new step")]
        //public void ChangeCounter()
        //{
            //object countt = GetExtractedValue("count");
            //string count = countt.ToString();
            //int coun = int.Parse(count);
            //coun = coun + 1;
            //count = coun.ToString();
            //SetExtractedValue("count", count);
        //}
    
        [CodedStep(@"SplitName")]
        public void CheckRegion_CodedStep()
        {
            object myData = GetExtractedValue("ProviderFullName");
            string fullname = Convert.ToString(myData);
            Log.WriteLine("Full Name is "+fullname);
            string[] name = fullname.Split(',');
            string FirstName = name[1];
            FirstName = FirstName.Trim();
            string LastName = name[0];
            SetExtractedValue("FirstName", FirstName);
            Log.WriteLine("First Name is "+FirstName);
            SetExtractedValue("LastName", LastName);
            Log.WriteLine("Last Name is "+LastName);
        }
    }
}
