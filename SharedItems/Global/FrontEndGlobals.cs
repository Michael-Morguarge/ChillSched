using System;

namespace Shared.Utility
{
    /// <summary>
    /// Control types
    /// </summary>
    public enum ControlsType
    {
        None, Label, Forms, TextArea, RichTextArea, IconNotifier, DatePicker, Calendar, ListBox, UserForm
    }

    /// <summary>
    /// Crud purpose
    /// </summary>
    public enum CrudPurposes
    {
        None, Create, Edit, Error
    }

    /// <summary>
    /// Control globals
    /// </summary>
    public struct ControlGlobals
    {
        /// <summary>
        /// Creates a new control id
        /// </summary>
        /// <returns>The id</returns>
        public static Guid CreateId()
        {
            return Guid.NewGuid();
        }
    }
}
