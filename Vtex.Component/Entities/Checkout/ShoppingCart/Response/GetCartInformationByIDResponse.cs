using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Checkout.ShoppingCart.Response
{
    public class GetCartInformationByIDResponse: BaseResponse
    {
        public string orderFormId { get; set; }
        public Customdata customData { get; set; }

        public class Customdata
        {
            public Customapp[] customApps { get; set; }
        }

        public class Customapp
        {
            public Fields fields { get; set; }
            public string id { get; set; }
            public int major { get; set; }
        }

        public class Fields
        {
            public string tpo_Cliente { get; set; }
            public string num_Cliente { get; set; }
            public string num_TipoCliente { get; set; }
            public string num_Documento { get; set; }
            public string nom_Cliente { get; set; }
            public string flg_SituacaoCadastro { get; set; }
            public string flg_SituacaoVenda { get; set; }
        }
    }
}
