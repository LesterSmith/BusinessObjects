using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using BusinessObjects;


namespace BusinessObjects
{
    /// <summary>
    /// determines if the file path matches a known project path and
    /// thereby denotes whether the file is of interest to us
    /// if the currentapp is devenv we have a file being used by VS
    /// That being the case we can either use the path to find an existing project
    /// in the table of VS projects or record the new project
    /// </summary>
    public class FileAnalyzer
    {
        #region public and private members
        public string FullPath { get; set; }
        public string CurrentApp { get; set; } // app current running from window watcheer
        public string ChangeType { get; set; }
        public string ProjectName { get; set; }
        public string[] SubPaths { get; set; }
        /// <summary>
        /// If CurrentApp = denenv (Dev Environment) VS is trying to save and we want to 
        /// parse to the path to the project files
        /// when this file activity was done by VS, the project is known
        /// this path[s] will contain the solution/project file
        /// it will be in the form x:\...\PrjName[\PrjName] and will be used
        /// to tell if a non development is within a VS project subpath,
        /// implying that it is part of the development even thought it could
        /// be doc, docx, xls, xlsx, txt, xml, xlst,  etc.
        /// If the file falls w/i the project subpath, then the app that changed
        /// it and is running (as determined by the window event tracker), then
        /// the time of the window event tracker can be charged to the project
        /// for example, if Word is the active window, and a file is changed in 
        /// a project subpath, we assume the user is working on the project in a
        /// non VS application but the time can safely be charged to the project
        /// Therefore there is an obvious relationship between the filewather and
        /// the Window Watcher...
        /// </summary>
        public string ProjectPath { get; set; }
        #endregion

        #region ..ctor

        #endregion

        #region private methods
        public string GetProjectPath()
        {
            string pattDrive = @"(?<drive>[a-zA-Z]:\)";
            string pattPaths = @"(?<slash>\)(?<name>.*?)";

            var drive = string.Empty;

            if ()
            var k = Regex.Match(FullPath, pattDrive, RegexOptions.IgnoreCase);
            if (k.Success)
                drive = k.Groups["drive"].Value;
            else
                return string.Empty;
            var prjPath = drive;

            var m = Regex.Match(FullPath, pattPaths, RegexOptions.IgnoreCase | RegexOptions.RightToLeft);
            if (m.Success)
            {
                // in a normal file path, the file will be the last token and its
                // slash will proceed it, we are not interested in it
                // c:\VS 2015 Projects\My Project\My Project\file.cs
                // NOTE we are going from end to beginning of path
                for (var i = m.Groups.Count -1; i >=0; i--)
                {
                    var name = m.Groups["name"];
                    var slash = m.Groups["slash"];

                    if (slash.Value != null && name.Value != null)
                    {
                        if (slash.Index < name.Index)
                        {
                            // the name is the last value in the path, i.e. 
                            // the path does not end with a \
                            if (i == m.Groups.Count - 1)
                                continue; // bypass the file name
                        }
                    }
                    else if (slash.Value != null)
                    {
                        // 
                    }

                    if (m2.["name"].Value != null && j < m.Groups.Count)
                    {
                        prjPath += @"\" + m2.Groups["name"].Value;
                    }
                    else
                        break;
                }
            }
            return prjPath;
        }
        #endregion
    }
}
