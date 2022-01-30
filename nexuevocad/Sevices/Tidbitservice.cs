using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yardillocore.Models;
using yardillocore.DB;
using MongoDB.Driver;

namespace Tidbits.Sevices
{
    public class Tidbitservice
    {

        private DBClient _dBClient;
        //private IMongoCollection<Case> _touchpoints;
        private IMongoDatabase _masterdb;
       
        public Tidbitservice(IDatabaseSettings settings)
        {
            try
            {
                _dBClient = DBClientCon.GetDbClient(settings);
                _masterdb = _dBClient.MasterDatabase;
                 //_touchpoints = _dBClient.Client.GetDatabase("TouchPoints");

            }
            catch { throw; }
        }

        //public string Gettidbit(string searchword, string tag, string author)
        //{
        //    Case ocase = _touchpoints.Find<Case>(book => book._id == id).FirstOrDefault();
        //}
        public void Gettenant(string tenantid)
        {
            try
            {
                //TenantDatabase = helperservice.Gettenant(tenantid, _client, MBADDatabase, _settings);
                //_casecollection = TenantDatabase.GetCollection<Case>(_settings.CasesCollectionName);
                //_casetypecollection = TenantDatabase.GetCollection<CaseType>(_settings.CaseTypesCollectionName);
                //_casedbcollection = TenantDatabase.GetCollection<CaseDB>(_settings.CasesCollectionName);
                //_caseactivityhistorycollection = TenantDatabase.GetCollection<CaseActivityHistory>(_settings.Caseactivityhistorycollection);
                //_ActionAuthLogscollection = TenantDatabase.GetCollection<ActionAuthLogs>(_settings.ActionAuthLogscollection);
                //_Adapterscollection = TenantDatabase.GetCollection<Adapter>(_settings.Adapterscollection);
                //_AdapterLogscollection = TenantDatabase.GetCollection<AdapterMapLog>(_settings.AdapterLogscollection);
                //_tenantid = tenantid;

                //_casecollectionlist = TenantDatabase.GetCollection<BsonDocument>(_settings.CasesCollectionName);
            }
            catch { throw; };
        }
    }
}
