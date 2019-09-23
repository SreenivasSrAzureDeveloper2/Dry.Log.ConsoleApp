using System;

namespace Dry.Log
{
    public enum DryLogChoice
    {
        isFile = 0,
        isSqlDatabase = 1,
        isElasticSearch = 2,
        isAzureCosmosDb = 3,
        isExcel = 4
    }
}
