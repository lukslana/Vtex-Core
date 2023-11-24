using Vtex.Component.Entities.Order.Common;

namespace Vtex.Component.Entities.Order.Extensions
{
    public static class OrderByExtensions
    {
        public static string OrderToString(this OrderBy orderBy)
        {
            switch (orderBy)
            {
                case OrderBy.creationDateDesc:
                    return "creationDate,desc";

                case OrderBy.creationDateAsc:
                    return "creationDate,asc";

                case OrderBy.itemsDesc:
                    return "items,desc";

                case OrderBy.itemsAsc:
                    return "items,asc";

                case OrderBy.orderIdDesc:
                    return "orderId,desc";

                case OrderBy.orderIdAsc:
                    return "orderId,asc";

                case OrderBy.totalValueAsc:
                    return "totalValue,asc";

                case OrderBy.totalValueDesc:
                    return "totalValue,desc";
                default:
                    return "";
            }
        }
    }
}
