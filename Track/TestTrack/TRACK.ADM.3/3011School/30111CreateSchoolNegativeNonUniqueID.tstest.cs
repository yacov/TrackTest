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

    public class _0111CreateSchoolNegativeNonUniqueID : BaseWebAiiTest
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
    
        [CodedStep(@"GenerateUsername")]
        public void _3011CreateSchoolPositive_CodedStep()
        {
              Random random = new Random();
             int numDoc = random.Next(9999, 99999);
                                    var docName = "School"+numDoc;
                                    Log.WriteLine("Generated School name is "+ docName);
                                    SetExtractedValue("schoolId", docName);
            Utility.schoolId = docName;
        }
    
        [CodedStep(@"Pass variable SchoolId to local datastore")]
        public void _30111CreateSchoolPositive_1_CodedStep()
        {
            
             var _schoolId = Utility.schoolId;
            Log.WriteLine("SchoolId found is "+ _schoolId);
            SetExtractedValue("schoolId", _schoolId);
            object myData = GetExtractedValue("schoolId");
            var recorded = myData.ToString();
            Log.WriteLine("SchoolId recorded local is "+ recorded);
        }
    }
}
