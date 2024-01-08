
namespace Vtex.Component.Entities.Catalog.Attachment.Response
{
	public class GetAttachmentByIDResponse : BaseCatalogResponse
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool IsRequired { get; set; }
		public bool IsActive { get; set; }
		public Domain[] Domains { get; set; }
		public class Domain
		{
			public string FieldName { get; set; }
			public string MaxCaracters { get; set; }
			public string DomainValues { get; set; }
		}
	}
}
