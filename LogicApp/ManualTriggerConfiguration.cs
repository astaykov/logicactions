namespace LogicApp
{
    public sealed class ManualTriggerConfiguration
    {
        public string Endpoint { get; set; }
        public string Authorization { get; set; }
        public string TriggerName { get; set; }

        public ManualTriggerConfiguration()
        {
            // Trigger endpoint - it is usually standard
            Endpoint = "https://westeurope.logic.azure.com:443/subscriptions/{your-subscription-id}/resourcegroups/{resource-group-name-goes-here}/providers/Microsoft.Logic/workflows/{name-of-logic-app-here}/run?api-version=2015-02-01-preview";
            Authorization = "Basic {contstruct your Basic Auth Header using the Key from the Portal}";
            TriggerName = "Proxy";
        }
    }
}