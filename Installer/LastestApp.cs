using System;

namespace Installer
{
    public class LastestApp
    {
        public virtual string SoftId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Version { get; set; }
        public virtual string Id { get; set; }
        public virtual string Url { get; set; }
        public virtual string Note { get; set; }
        public virtual string Build { get; set; }
        public virtual string GUID { get; set; }

        public virtual DateTime ReleasedAt { get; set; }
    }
}
