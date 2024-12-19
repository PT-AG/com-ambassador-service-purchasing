using System.Collections.Generic;

namespace Com.Ambassador.Service.Purchasing.Lib.Interfaces
{
    public interface IGarmentDOItemFacade
    {
        List<object> ReadForUnitDO(string Keyword = null, string Filter = "{}");
        List<object> ReadForUnitDOMore(string Keyword = null, string Filter = "{}", int size = 100);
        List<DOItemsViewModels> GetByPO(string productcode, string po, string unitcode);
        GarmentDOItems ReadById(int id);
        Task<int> Update(int id, DOItemsRackingViewModels viewModels);
        Task<List<StellingEndViewModels>> GetStellingQuery(int id, int offset);
        MemoryStream GenerateExcel(string productcode, string po, string unitcode);
        MemoryStream GeneratePdf(List<StellingEndViewModels> stellingEndViewModels);
        Task<List<PARackingViewModel>> GetPARackingQuery(string Keyword = null);
    }
}
