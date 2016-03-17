namespace LogicTrigger
{
    public sealed class ManualTriggerConfiguration
    {
        public string Endpoint { get; set; }
        public string Authorization { get; set; }
        public string TriggerName { get; set; }

        public ManualTriggerConfiguration()
        {
            Endpoint = "https://westeurope.logic.azure.com:443/subscriptions/401a2b4d-bfc6-4016-9ac3-a81bb74c52e6/resourcegroups/rg-logics/providers/Microsoft.Logic/workflows/la-snet2/run?api-version=2015-02-01-preview";
            Authorization = "Basic ZGVmYXVsdDpicmVrUlFzTjVDUHJyeVF4SzA3blBHV1pac1V2b1ByVklJVkluektXZUdF";
            TriggerName = "Proxy";
        }
    }
}