namespace Com.Ambassador.Service.Purchasing.Lib.Facades.GarmentPurchasingBookReport
{
    public class AutoCompleteDto
    {
        public AutoCompleteDto(string value)
        {
            Value = value;
        }

        public string Value { get; private set; }
    }
}