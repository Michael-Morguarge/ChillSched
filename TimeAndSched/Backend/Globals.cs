using System;

namespace FrontEnd.Globals
{
    public enum ControlType
    {
        None, Label, Forms, TextArea, RichTextArea, IconNotifier, DatePicker, Calendar, ListBox
    }

    public enum CrudPurpose
    {
        None, Create, Edit, Error
    }

    public struct ControlGlobals
    {
        public static Guid CreateId()
        {
            return Guid.NewGuid();
        }
    }
}
