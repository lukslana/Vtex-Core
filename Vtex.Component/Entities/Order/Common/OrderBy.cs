using System.ComponentModel;
using System.Runtime.Serialization;

namespace Vtex.Component.Entities.Order.Common
{
    public enum OrderBy
    {
        [EnumMember(Value = "creationDate,asc")]
        creationDateAsc,

        [EnumMember(Value = "creationDate,desc")]
        creationDateDesc,

        [EnumMember(Value = "orderId,asc")]
        orderIdAsc,

        [EnumMember(Value = "orderId,Desc")]
        orderIdDesc,

        [EnumMember(Value = "items,asc")]
        itemsAsc,

        [EnumMember(Value = "items,desc")]
        itemsDesc,

        [EnumMember(Value = "totalValue,asc")]
        totalValueAsc,

        [EnumMember(Value = "totalValue,desc")]
        totalValueDesc

    }
}
