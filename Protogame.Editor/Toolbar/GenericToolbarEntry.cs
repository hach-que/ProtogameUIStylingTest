﻿namespace Protogame.Editor.Toolbar
{
    public class GenericToolbarEntry
    {
        public GenericToolbarEntry(long id, string icon, bool toggled, bool enabled, ToolbarClickHandler handler, object userdata)
        {
            Id = id;
            Icon = icon;
            Toggled = toggled;
            Enabled = enabled;
            Handler = handler;
            Userdata = userdata;
        }

        public long Id { get; set; }

        public string Icon { get; set; }

        public bool Toggled { get; set; }

        public bool Enabled { get; set; }

        public ToolbarClickHandler Handler { get; set; }

        public object Userdata { get; set; }
    }

    public delegate void ToolbarClickHandler(GenericToolbarEntry toolbarEntry);
}
