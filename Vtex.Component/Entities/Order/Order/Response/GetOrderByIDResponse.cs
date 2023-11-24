using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Order.Order.Response
{
    public class GetOrderByIDResponse : BaseOrderResponse
    {
        /// <summary>
        /// id do pedido,
        /// </summary>
        public string orderId { get; set; }
        /// <summary>
        ///sequecial do pedido, usando na concilacao de pagamento,
        /// </summary>
        public string sequence { get; set; }
        /// <summary>
        ///id do pedido no canal de vendas, caso pedido de canais externos,
        /// </summary>
        public string marketplaceOrderId { get; set; }
        /// <summary>
        ///service endpoint do canal de vendas, veja docs,
        /// </summary>
        public string marketplaceServicesEndpoint { get; set; }
        /// <summary>
        ///se pedido de seller, id do pedido no seller,
        /// </summary>
        public string sellerOrderId { get; set; }
        /// <summary>
        ///local, ou canal externo. [local=Marketplace] [esterno=Fulfillment],
        /// </summary>
        public string origin { get; set; }
        /// <summary>
        /// identificado do afiliado de vendas criado no OMS admin,
        /// </summary>
        public string affiliateId { get; set; }
        /// <summary>
        ///identificado do canal de vendas criado no admin,
        /// </summary>
        public string salesChannel { get; set; }
        /// <summary>
        ///no do gateway de pagamento,
        /// </summary>
        public string merchantName { get; set; }
        /// <summary>
        ///status do pedido no momento da consulta,
        /// </summary>
        public string status { get; set; }
        /// <summary>
        ///nome amigavel do status do pedido no momento da consulta,
        /// </summary>
        public string statusDescription { get; set; }


        public string orderFormId { get; set; } 

        /// <summary>
        ///valor total do pedido,
        /// </summary>
        public double value { get; set; }
        /// <summary>
        ///data de criacao do pedido,
        /// </summary>
        public DateTime? creationDate { get; set; }
        /// <summary>
        ///data de ultima mudanca,
        /// </summary>
        public string lastChange { get; set; }
        /// <summary>
        ///grupo do split, de pedio de split,
        /// </summary>
        public string orderGroup { get; set; }
        /// <summary>
        ///totais do pedido,
        /// </summary>
        public List<Total> totals { get; set; }
        /// <summary>
        /// SKUs do pedido,
        /// </summary>
        public List<Item> items { get; set; }
        /// <summary>
        /// ?
        /// </summary>
        public List<object> marketplaceItems { get; set; }
        /// <summary>
        ///dados do profile do cliente,
        /// </summary>
        public ClientProfileData clientProfileData { get; set; }
        /// <summary>
        ///?
        /// </summary>
        public string giftRegistryData { get; set; }
        /// <summary>
        ///?
        /// </summary>
        public MarketingData marketingData { get; set; }
        /// <summary>
        ///dados de descontos e beneficios,
        /// </summary>
        public RatesAndBenefitsData ratesAndBenefitsData { get; set; }
        /// <summary>
        ///dados de despacho,
        /// </summary>
        public ShippingData shippingData { get; set; }
        /// <summary>
        ///dados do pagamento
        /// </summary>
        public PaymentData paymentData { get; set; }
        /// <summary>
        ///dados de apcote
        /// </summary>
        public PackageAttachment packageAttachment { get; set; }
        /// <summary>
        ///lista de sellers
        /// </summary>
        public List<Seller> sellers { get; set; }
        /// <summary>
        ///dados de operador de televendas
        /// </summary>
        public CallCenterOperatorData callCenterOperatorData { get; set; }
        //public string callCenterOperatorData { get; set; }
        /// <summary>
        ///email rastreado
        /// </summary>
        public string followUpEmail { get; set; }
        /// <summary>
        ///ultima mensagem
        /// </summary>
        public string lastMessage { get; set; }
        /// <summary>
        ///host
        /// </summary>
        public string hostname { get; set; }
        /// <summary>
        ///?
        /// </summary>
        public ChangesAttachment changesAttachment { get; set; }
        /// <summary>
        ///texto livre
        /// </summary>
        public Opentextfield openTextField { get; set; }

        public Customdata customData { get; set; }

        public class Total
        {
            /// <summary>
            ///id do total,
            /// </summary>
            public string id { get; set; }
            /// <summary>
            /// nome do total,
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// valor do total
            /// </summary>
            public decimal value { get; set; }
        }

        public class Content
        {
        }

        public class ItemAttachment
        {
            /// <summary>
            ///
            /// </summary>
            public Content content { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string name { get; set; }
        }

        public class Dimension
        {
            /// <summary>
            ///cubagem
            /// </summary>
            public double cubicweight { get; set; }
            /// <summary>
            ///altura
            /// </summary>
            public double height { get; set; }
            /// <summary>
            ///comprimento
            /// </summary>
            public double length { get; set; }
            /// <summary>
            ///peso
            /// </summary>
            public double weight { get; set; }
            /// <summary>
            ///largura
            /// </summary>
            public double width { get; set; }
        }


        public class AdditionalInfo
        {
            /// <summary>
            ///nome marca fabricante
            /// </summary>
            public string brandName { get; set; }
            /// <summary>
            ///identificador marca fabricante,
            /// </summary>
            public string brandId { get; set; }
            /// <summary>
            ///identificador arvore categoria, ex.= [/1000018/1000019/1000020/],
            /// </summary>
            public string categoriesIds { get; set; }
            /// <summary>
            ///quais colecoes tem esse item,
            /// </summary>
            public string productClusterId { get; set; }
            /// <summary>
            ///identificador de cc,
            /// </summary>
            public string commercialConditionId { get; set; }
            /// <summary>
            ///dimensoes do item
            /// </summary>
            public Dimension dimension { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string offeringInfo { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string offeringType { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string offeringTypeId { get; set; }
        }


        public class Item
        {
            /// <summary>
            ///identificador do item,
            /// </summary>
            public int id { get; set; }
            /// <summary>
            ///identificador do produto generico
            /// </summary>
            public string productId { get; set; }
            /// <summary>
            ///codigo de barras,
            /// </summary>
            public string ean { get; set; }
            /// <summary>
            ///identificador da reserva,
            /// </summary>
            public string lockId { get; set; }
            /// <summary>
            ///anexos ao item, ex.= camisa numero 10,
            /// </summary>
            public ItemAttachment itemAttachment { get; set; }
            /// <summary>
            ///?
            /// </summary>
            public List<object> attachments { get; set; }
            /// <summary>
            ///quantidade do item,
            /// </summary>
            public int quantity { get; set; }
            /// <summary>
            ///dono do item,
            /// </summary>
            public string seller { get; set; }
            /// <summary>
            ///nome do item,
            /// </summary>
            public string name { get; set; }
            /// <summary>
            ///codigo de referencia do item,
            /// </summary>
            public string refId { get; set; }
            /// <summary>
            ///preco 'POR' do item,       
            /// </summary>
            public decimal price { get; set; }
            /// <summary>
            ///preco 'DE' do item,
            /// </summary>
            public decimal listPrice { get; set; }
            /// <summary>
            ///tags de preco,
            /// </summary>
            public List<PriceTag> priceTags { get; set; }
            /// <summary>
            ///url imagem do item,
            /// </summary>
            public string imageUrl { get; set; }
            /// <summary>
            ///url da pagina de detalhe do item,
            /// </summary>
            public string detailUrl { get; set; }
            /// <summary>
            ///caso naum nulo, item KIT, componentes do KIT
            /// </summary>
            public List<Component> components { get; set; }
            /// <summary>
            ///servicos de item de um pedido,
            /// </summary>
            public List<object> bundleItems { get; set; }
            /// <summary>
            ///?
            /// </summary>
            public List<object> @params { get; set; }
            /// <summary>
            ///?
            /// </summary>
            public List<object> offerings { get; set; }
            /// <summary>
            ///id sku do dono do produto,
            /// </summary>
            public string sellerSku { get; set; }
            /// <summary>
            /// validade do preco,
            /// </summary>
            public string priceValidUntil { get; set; }
            /// <summary>
            ///se revenda, comissao,
            /// </summary>
            public int commission { get; set; }
            /// <summary>
            ///imposto
            /// </summary>
            public int tax { get; set; }
            /// <summary>
            ///data de prevenda
            /// </summary>
            public DateTime preSaleDate { get; set; }
            /// <summary>
            ///informacoes adicionais do item,
            /// </summary>
            public AdditionalInfo additionalInfo { get; set; }
            /// <summary>
            ///unidade de venda - un=unidade,
            /// </summary>
            public string measurementUnit { get; set; }
            /// <summary>
            ///fator multiplicador - 1,
            /// </summary>
            public double unitMultiplier { get; set; }
            /// <summary>
            ///preco de venda,
            /// </summary>
            public decimal sellingPrice { get; set; }
            /// <summary>
            ///é presente
            /// </summary>
            public bool isGift { get; set; }
            /// <summary>
            ///?
            /// </summary>
            public string shippingPrice { get; set; }
        }

        public class ClientProfileData
        {
            /// <summary>
            ///identificador do cliente,
            /// </summary>
            public string id { get; set; }
            /// <summary>
            ///email do cliente,
            /// </summary>
            public string email { get; set; }
            /// <summary>
            ///nome,
            /// </summary>
            public string firstName { get; set; }
            /// <summary>
            /// sobrenome,
            /// </summary>
            public string lastName { get; set; }
            /// <summary>
            ///documento tipo,
            /// </summary>
            public string documentType { get; set; }
            /// <summary>
            ///identificador do documento,
            /// </summary>
            public string document { get; set; }
            /// <summary>
            ///numero do telefone,
            /// </summary>
            public string phone { get; set; }
            /// <summary>
            ///se empresa, nome da empresa,
            /// </summary>
            public string corporateName { get; set; }
            /// <summary>
            /// se empresa, nome fantasia,
            /// </summary>
            public string tradeName { get; set; }
            /// <summary>
            ///documento da empresa,
            /// </summary>
            public string corporateDocument { get; set; }
            /// <summary>
            /// inscricao estadual,
            /// </summary>
            public string stateInscription { get; set; }
            /// <summary>
            /// se empresa, telefone,
            /// </summary>
            public string corporatePhone { get; set; }
            /// <summary>
            ///e empresa?,
            /// </summary>
            public bool isCorporate { get; set; }
            /// <summary>
            /// identificador do profile do cliente
            /// </summary>
            public string userProfileId { get; set; }
        }


        public class RatesAndBenefitsData
        {
            /// <summary>
            ///identificador,
            /// </summary>
            public string id { get; set; }
            /// <summary>
            /// colecao de promocoes
            /// </summary>
            public List<object> rateAndBenefitsIdentifiers { get; set; }
        }


        public class Address
        {
            /// <summary>
            ///tipo do endereco,
            /// </summary>
            public string addressType { get; set; }
            /// <summary>
            /// nome do destinatario,
            /// </summary>
            public string receiverName { get; set; }
            /// <summary>
            ///identificador,
            /// </summary>
            public string addressId { get; set; }
            /// <summary>
            ///codigo postal,
            /// </summary>
            public string postalCode { get; set; }
            /// <summary>
            ///cidade,
            /// </summary>
            public string city { get; set; }
            /// <summary>
            ///unidade federativa,
            /// </summary>
            public string state { get; set; }
            /// <summary>
            ///pais,
            /// </summary>
            public string country { get; set; }
            /// <summary>
            ///logradouro,
            /// </summary>
            public string street { get; set; }
            /// <summary>
            ///numero do local,
            /// </summary>
            public string number { get; set; }
            /// <summary>
            ///bairro,
            /// </summary>
            public string neighborhood { get; set; }
            /// <summary>
            ///dados complementares,
            /// </summary>
            public string complement { get; set; }
            /// <summary>
            ///ponto de referencia,
            /// </summary>
            public string reference { get; set; }
        }


        public class Sla
        {
            /// <summary>
            /// identificador da sla,
            /// </summary>
            public string id { get; set; }
            /// <summary>
            /// nome da sla,
            /// </summary>
            public string name { get; set; }
            /// <summary>
            ///sla em dias uteis,
            /// </summary>
            public string shippingEstimate { get; set; }
            /// <summary>
            /// janela de entrega agendada,
            /// </summary>
            public string deliveryWindow { get; set; }
            /// <summary>
            /// custo da sla
            /// </summary>
            public int price { get; set; }
        }


        public class DeliveryId
        {
            /// <summary>
            /// indice do item no array de item,
            /// </summary>
            public int itemIndex { get; set; }

            /// <summary>
            ///identificador do entregador,
            /// </summary>
            public string courierId { get; set; }
            /// <summary>
            /// nome entregador,
            /// </summary>
            public string courierName { get; set; }
            /// <summary>
            ///identificador do entregador,
            /// </summary>
            public string dockId { get; set; }
            /// <summary>
            ///quantidade do item,
            /// </summary>
            public int quantity { get; set; }
            /// <summary>
            /// identificador do estoque
            /// </summary>
            public string warehouseId { get; set; }

            /// <summary>
            /// Temporario, para separar os pedidos com o comemrcial Conditional diferente
            /// </summary>
            public string commercialConditionId { get; set; }
        }


        public class LogisticsInfo
        {
            /// <summary>
            /// indice do item no array de item,
            /// </summary>
            public int itemIndex { get; set; }
            /// <summary>
            /// tipo da entrega,
            /// </summary>
            public string selectedSla { get; set; }
            /// <summary>
            ///tempo de timeout de reserva,
            /// </summary>
            public string lockTTL { get; set; }
            /// <summary>
            /// custo da entrega,
            /// </summary>
            public int price { get; set; }
            /// <summary>
            ///entrega agendada,
            /// </summary>
            public string deliveryWindow { get; set; }
            /// <summary>
            ///meio de entrega,
            /// </summary>
            public string deliveryCompany { get; set; }
            /// <summary>
            ///estimativa de entrega em dias uteis,
            /// </summary>
            public string shippingEstimate { get; set; }
            /// <summary>
            ///opcional, data da estimativa de entrega,
            /// </summary>
            public DateTime? shippingEstimateDate { get; set; }
            /// <summary>
            /// slas de entrega,
            /// </summary>
            public List<Sla> slas { get; set; }
            /// <summary>
            ///siglas dos paises de entrega,
            /// </summary>
            public List<string> shipsTo { get; set; }
            /// <summary>
            ///preco de venda,
            /// </summary>
            public int sellingPrice { get; set; }
            /// <summary>
            ///entregas
            /// </summary>
            public List<DeliveryId> deliveryIds { get; set; }
        }


        public class ShippingData
        {
            /// <summary>
            ///identificador,
            /// </summary>
            public string id { get; set; }
            /// <summary>
            ///endereco,
            /// </summary>
            public Address address { get; set; }
            /// <summary>
            ///formas e slas de entrega
            /// </summary>
            public List<LogisticsInfo> logisticsInfo { get; set; }
        }


        public class ConnectorResponses
        {
            /// <summary>
            /// 
            /// </summary>
            public string Tid { get; set; } //": "102087216800AC522002",
            /// <summary>
            /// 
            /// </summary>
            public string authId { get; set; } //": "169965",
            /// <summary>
            /// 
            /// </summary>
            public string ReturnCode { get; set; } //": "0",
            /// <summary>
            /// 
            /// </summary>
            public string Message { get; set; } //": "Sucesso",
            /// <summary>
            /// 
            /// </summary>
            public string Nsu { get; set; } //": "044114",
            /// <summary>
            /// 
            /// </summary>
            public string Arp { get; set; } //": "169965"

            public string Acquirer { get; set; }    
        }


        public class Payment
        {
            /// <summary>
            /// identificador do pagamento,
            /// </summary>
            public string id { get; set; }
            /// <summary>
            ///identificador da forma de pagamento [1|2|10],
            /// </summary>
            public string paymentSystem { get; set; }
            /// <summary>
            ///nome da forma de pagamento [visa|master|boleto],
            /// </summary>
            public string paymentSystemName { get; set; }
            /// <summary>
            ///valor do pagamento
            /// </summary>
            public decimal value { get; set; }
            /// <summary>
            ///numero de parcelas,
            /// </summary>
            public int installments { get; set; }
            /// <summary>
            ///valor referencia,
            /// </summary>
            public int referenceValue { get; set; }
            /// <summary>
            ///null,
            /// </summary>
            public string cardHolder { get; set; }
            /// <summary>
            /// null,
            /// </summary>
            public string cardNumber { get; set; }
            /// <summary>
            /// se cartao, cinco primeiro digittos do cartao,
            /// </summary>
            public string firstDigits { get; set; }
            /// <summary>
            ///se cartao, ultimos digittos do cartao,
            /// </summary>
            public string lastDigits { get; set; }
            /// <summary>
            /// se cartao, codigo de verificacao,
            /// </summary>
            public string cvv2 { get; set; }
            /// <summary>
            /// se cartao, mes da validade,
            /// </summary>
            public string expireMonth { get; set; }
            /// <summary>
            ///se cartao, ano da validade,
            /// </summary>
            public string expireYear { get; set; }
            /// <summary>
            ///url,
            /// </summary>
            public string url { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string giftCardId { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string giftCardName { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string giftCardCaption { get; set; }
            /// <summary>
            ///
            /// </summary>
            public string redemptionCode { get; set; }
            /// <summary>
            ///bandeira do cartao,
            /// </summary>
            public string group { get; set; }
            /// <summary>
            ///se cartao, identificador da transacao,
            /// </summary>
            public string tid { get; set; }
            /// <summary>
            ///data debito,
            /// </summary>
            public DateTime? dueDate { get; set; }
            /// <summary>
            /// resposta do conector
            /// </summary>
            public ConnectorResponses connectorResponses { get; set; }
        }


        public class Transaction
        {
            /// <summary>
            ///habilitada?,
            /// </summary>
            public bool isActive { get; set; }
            /// <summary>
            ///identificador da transacao,
            /// </summary>
            public string transactionId { get; set; }

            /// <summary>
            ///identificador da transacao,
            /// </summary>
            public string merchantName { get; set; }

            /// <summary>
            ///pagamentos
            /// </summary>
            public List<Payment> payments { get; set; }
        }


        public class PaymentData
        {
            /// <summary>
            /// transacoes de pagamento
            /// </summary>
            public List<Transaction> transactions { get; set; }
        }


        public class PackageAttachment
        {
            /// <summary>
            ///  pacotes do pedido
            /// </summary>
            public List<object> packages { get; set; }
        }


        public class Seller
        {
            /// <summary>
            ///identificador do dono do produto, loja principal = 1,
            /// </summary>
            public string id { get; set; }
            /// <summary>
            ///nome do dono do produto, loja principal,
            /// </summary>
            public string name { get; set; }
            /// <summary>
            ///logo do dono do produto, loja principal = 1
            /// </summary>
            public string logo { get; set; }
        }



        public class Opentextfield
        {
            public string value { get; set; }

        }


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


        public class ChangesAttachment
        {
            public string id { get; set; }
            public List<ChangesData> changesData { get; set; }
        }


        public class ChangesData
        {
            public string reason { get; set; }
            public int discountValue { get; set; }
            public int incrementValue { get; set; }
            public List<object> itemsAdded { get; set; }
            public List<ItemsRemoved> itemsRemoved { get; set; }
            public Receipt receipt { get; set; }
        }


        public class Receipt
        {
            public DateTime date { get; set; }
            public string orderId { get; set; }
            public string receipt { get; set; }
        }


        public class ItemsRemoved
        {
            public string id { get; set; }
            public string name { get; set; }
            public int quantity { get; set; }
            public decimal price { get; set; }
            public object unitMultiplier { get; set; }
        }



        public class MarketingData
        {
            public string id { get; set; }
            public string utmSource { get; set; }
            public object utmPartner { get; set; }
            public string utmMedium { get; set; }
            public string utmCampaign { get; set; }
            public object coupon { get; set; }
            public string utmiCampaign { get; set; }
            public object utmipage { get; set; }
            public object utmiPart { get; set; }
            public string[] marketingTags { get; set; }
        }


        public class Component
        {
            public string id { get; set; }
            public object productId { get; set; }
            public object ean { get; set; }
            public object lockId { get; set; }
            public ItemAttachment2 itemAttachment { get; set; }
            public List<object> attachments { get; set; }
            public decimal quantity { get; set; }
            public object seller { get; set; }
            public string name { get; set; }
            public string refId { get; set; }
            public decimal price { get; set; }
            public object listPrice { get; set; }
            public List<object> priceTags { get; set; }
            public object imageUrl { get; set; }
            public object detailUrl { get; set; }
            public List<object> components { get; set; }
            public List<object> bundleItems { get; set; }
            public List<object> @params { get; set; }
            public List<object> offerings { get; set; }
            public string sellerSku { get; set; }
            public object priceValidUntil { get; set; }
            public int commission { get; set; }
            public int tax { get; set; }
            public object preSaleDate { get; set; }
            public AdditionalInfo additionalInfo { get; set; }
            public string measurementUnit { get; set; }
            public double unitMultiplier { get; set; }
            public decimal sellingPrice { get; set; }
            public bool isGift { get; set; }
            public object shippingPrice { get; set; }
        }


        public class CallCenterOperatorData
        {
            public string id { get; set; }
            public string email { get; set; }
            public string userName { get; set; }
        }


        public class Content2
        {
        }


        public class ItemAttachment2
        {
            public Content2 content { get; set; }
            public object name { get; set; }
        }


        public class PriceTag
        {
            public string name { get; set; }
            public int value { get; set; }
            public bool isPercentual { get; set; }
            public string identifier { get; set; }
        }


        public class RootEmail
        {
            public string email { get; set; }
            public string alias { get; set; }
        }


        public class clsUpdateOrderTrackingStatus
        {
            public bool isDelivered { get; set; }
            public clsUpdateOrderTrackingStatusEvent[] events { get; set; }
        }

        public class clsUpdateOrderTrackingStatusEvent
        {
            public string city { get; set; }
            public string state { get; set; }
            public string description { get; set; }
            public string date { get; set; }
        }


        public class clsclsUpdateOrderTrackingStatusResponse
        {
            public DateTime date { get; set; }
            public string orderId { get; set; }
            public string receipt { get; set; }
        }
    }
}
