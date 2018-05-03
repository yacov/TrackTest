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

    public class AddProvider : BaseWebAiiTest
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
    
        [CodedStep(@"Generate ProviderID and username")]
        public void _3021AddProvider_CodedStep()
        {
              Random random = new Random();
             int numDoc = random.Next(9999, 99999);
             var provName = "Provider"+numDoc;
            var provID = "ID"+numDoc;
            Log.WriteLine("Generated Provider username is "+ provName);
            Log.WriteLine("Generated Provider id is "+ provID);
            SetExtractedValue("providerUsername", provName );
            SetExtractedValue("providerId", provID );
            Utility.providerUsername = provName;
            Utility.providerId = provID;
        }
    }
}
