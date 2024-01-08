using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.Attachment.Request
{
	public class CreateAttachmentRequest : BaseCatalogRequest
	{
		protected internal override string BaseUrl => "api/catalog/pvt/attachment";
		public override HttpMethod HttpMethod => HttpMethod.Post;

		/// <summary>
		/// Attachment name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Defines if the attachment is required or not.
		/// </summary>
		public bool IsRequired { get; set; }

		/// <summary>
		/// Defines if the attachment is active or not.
		/// </summary>
		public bool IsActive { get; set; }

		/// <summary>
		/// List of characteristics related to the attachment.
		/// </summary>
		public Domain[] Domains { get; set; }
		public class Domain
		{
			public string FieldName { get; set; }
			public string MaxCaracters { get; set; }
			public string DomainValues { get; set; }
		}
	}
}
