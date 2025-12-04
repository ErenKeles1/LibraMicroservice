namespace Kitap.Catalog.Settings
{
    public interface IDatabaseSettings
    {
        public string CategoryCollectionName { get; set; }
        public string BookCollectionName { get; set; }
        public string BookImageCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string BookDetailCollectionName { get; set; }
    }
}
