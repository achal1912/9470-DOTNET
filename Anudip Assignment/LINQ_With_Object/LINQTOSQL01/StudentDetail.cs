namespace LINQTOSQL01
{
    internal class StudentDetail
    {
        private object sName;

        public object GetSName()
        {
            return sName;
        }

        internal void SetSName(object value)
        {
            sName = value;
        }

        public StudentDetail(object sName) => this.SetSName(sName);

        public object Sid { get; internal set; }
        public object Location { get; internal set; }
        public object Gender { get; internal set; }
        public object Age { get; internal set; }
    }
}