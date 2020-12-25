using System;

namespace Vendstor.Backend.Objects
{
    [Serializable()]
    public class File
    {
        public virtual string BlobId { get; set; }

        public virtual string SystemFileName { get; set; }
        public virtual string ServerFolder { get; set; }
        public virtual string SaveName { get; set; }
        public virtual string Extension { get; set; }

        public virtual string Path { get; set; }
        public virtual string FullPath { get; set; }

        public virtual bool UseCustomName { get; set; }

        public virtual DateTime CreatedAt { get; set; }
    }
}
