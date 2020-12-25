namespace Shell
{
    public class App
    {
        public virtual string DisplayName { get; set; }
        public virtual string DisplayVersion { get; set; }

        public virtual string Description { get; set; }

        public virtual string Publisher { get; set; }
        public virtual string HelpLink { get; set; }
        public virtual string HelpTelephone { get; set; }
        public virtual string UrlInfo { get; set; }
        public virtual string UrlUpdateInfo { get; set; }
        public virtual string ModifyPath { get; set; }

        public virtual string UninstallString { get; set; }
        public virtual string SettingsIdentifier { get; set; }
        public virtual string Executable { get; set; }
        public virtual string UninstallExecutable { get; set; }

        public virtual object InstallDate { get; set; }
        public virtual object InstallLocation { get; set; }
        public virtual object InstallSource { get; set; }

        public virtual object Comments { get; set; }
        public virtual object EstimatedSize { get; set; }
        public virtual object Language { get; set; }
        public virtual object DisplayIcon { get; set; }
        public virtual object ReadMe { get; set; }

        public virtual string Name
        {
            get { return DisplayName; }
            set { DisplayName = value; }
        }
        public virtual string Version
        {
            get { return DisplayVersion; }
            set { DisplayVersion = value; }
        }
        public virtual object Icon
        {
            get { return DisplayIcon; }
            set { DisplayIcon = value; }
        }
        public virtual string ExePath
        {
            get { return $@"{ InstallLocation }\{Executable}"; }
        }
    }
}
