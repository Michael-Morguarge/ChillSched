using System;

namespace Shared.Utility
{
    public enum ControlsType
    {
        None, Label, Forms, TextArea, RichTextArea, IconNotifier, DatePicker, Calendar, ListBox, UserForm
    }

    public enum CrudPurposes
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
