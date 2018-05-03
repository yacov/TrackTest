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
public static class Utility
{  
     public  static int valueHolder;
    public  static string  schoolId;
    public  static string  userID;
    public  static string  providerId;
    public  static string  username;
    public  static string  userpass;
    public  static string  providerUsername;
    
    
     public static void writeToFile(String path,String content)
          {
          // Write the string to a file.
          System.IO.StreamWriter file = new System.IO.StreamWriter(path);
          file.WriteLine(content);
          file.Close();
          }
          
          public static String createSchoolId (){
               Random random = new Random();
             int numDoc = random.Next(9999, 99999);
                                    var docName = "School"+numDoc;
                                    return docName;
          }
}
   
}
