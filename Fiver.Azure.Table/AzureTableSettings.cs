using System;

namespace Fiver.Azure.Table
{
    public class AzureTableSettings
    {
        public AzureTableSettings(string storageAccount,
                                       string storageKey,
                                       string tableName,
                                       string connectionString)
        {
            if (string.IsNullOrEmpty(storageAccount) && string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("StorageAccount");

            if (string.IsNullOrEmpty(storageKey) && string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("StorageKey");

            if (string.IsNullOrEmpty(tableName))
                throw new ArgumentNullException("TableName");

            this.StorageAccount = storageAccount;
            this.StorageKey = storageKey;
            this.TableName = tableName;
            ConnectionString = connectionString;
        }

        public string StorageAccount { get; }
        public string StorageKey { get; }
        public string TableName { get; }
        public string ConnectionString { get; }
    }
}
