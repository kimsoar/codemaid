#region CodeMaid is Copyright 2007-2012 Steve Cadwallader.

// CodeMaid is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License version 3
// as published by the Free Software Foundation.
//
// CodeMaid is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details <http://www.gnu.org/licenses/>.

#endregion CodeMaid is Copyright 2007-2012 Steve Cadwallader.

namespace SteveCadwallader.CodeMaid.Options.Cleaning
{
    /// <summary>
    /// The view model for cleaning options - a parent to more specific view models.
    /// </summary>
    public class CleaningParentViewModel : OptionsPageViewModel
    {
        #region Base Members

        /// <summary>
        /// Gets the header.
        /// </summary>
        public override string Header
        {
            get { return "Cleaning"; }
        }

        /// <summary>
        /// Loads the settings.
        /// </summary>
        public override void LoadSettings()
        {
        }

        /// <summary>
        /// Saves the settings.
        /// </summary>
        public override void SaveSettings()
        {
        }

        #endregion Base Members
    }
}