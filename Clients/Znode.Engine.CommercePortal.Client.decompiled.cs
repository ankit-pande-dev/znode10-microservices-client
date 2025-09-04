using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Znode.Libraries.Abstract.Client;
using Znode.Libraries.Abstract.Helper;
using Znode.Libraries.Common.Exceptions;
using Znode.Libraries.ECommerce.Utilities;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: TargetFramework(".NETCoreApp,Version=v8.0", FrameworkDisplayName = ".NET 8.0")]
[assembly: AssemblyCompany("Znode")]
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyCopyright("2023")]
[assembly: AssemblyDescription("Znode10.Engine.CommercePortal.Client")]
[assembly: AssemblyFileVersion("10.0.0.0")]
[assembly: AssemblyInformationalVersion("10.0.0-rc-22+35f23fa8d544ba50d2ee602105809fa77d08f526")]
[assembly: AssemblyProduct("Znode.Engine.CommercePortal.Client")]
[assembly: AssemblyTitle("Znode.Engine.CommercePortal.Client")]
[assembly: AssemblyVersion("10.0.0.0")]
[module: RefSafetyRules(11)]
namespace Znode.Engine.CommercePortal.Client;

[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SelectListGroup
{
	public bool Disabled { get; set; }

	public string? Name { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SelectListItem
{
	public bool Disabled { get; set; }

	public SelectListGroup Group { get; set; }

	public bool Selected { get; set; }

	public string? Text { get; set; }

	public string? Value { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum HttpStatusCode
{
	_100 = 100,
	_101 = 101,
	_102 = 102,
	_103 = 103,
	_200 = 200,
	_201 = 201,
	_202 = 202,
	_203 = 203,
	_204 = 204,
	_205 = 205,
	_206 = 206,
	_207 = 207,
	_208 = 208,
	_226 = 226,
	_300 = 300,
	_301 = 301,
	_302 = 302,
	_303 = 303,
	_304 = 304,
	_305 = 305,
	_306 = 306,
	_307 = 307,
	_308 = 308,
	_400 = 400,
	_401 = 401,
	_402 = 402,
	_403 = 403,
	_404 = 404,
	_405 = 405,
	_406 = 406,
	_407 = 407,
	_408 = 408,
	_409 = 409,
	_410 = 410,
	_411 = 411,
	_412 = 412,
	_413 = 413,
	_414 = 414,
	_415 = 415,
	_416 = 416,
	_417 = 417,
	_421 = 421,
	_422 = 422,
	_423 = 423,
	_424 = 424,
	_426 = 426,
	_428 = 428,
	_429 = 429,
	_431 = 431,
	_451 = 451,
	_500 = 500,
	_501 = 501,
	_502 = 502,
	_503 = 503,
	_504 = 504,
	_505 = 505,
	_506 = 506,
	_507 = 507,
	_508 = 508,
	_510 = 510,
	_511 = 511
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateOrderTemplateRequestModel
{
	public string? OrderTemplateName { get; set; }

	public int AccountId { get; set; }

	[Range(1, int.MaxValue)]
	public int UserId { get; set; }

	public ICollection<SkuDetailsRequestModel>? SkuDetails { get; set; }

	public string? OrderOrigin { get; set; }

	public string? CatalogCode { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateOrderTemplateResponseModel
{
	public string? OrderTemplateNumber { get; set; }

	public bool IsSuccess { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ApproversModel
{
	public int ApproverOrder { get; set; }

	public string? ApproverName { get; set; }

	public string? StatusCode { get; set; }

	public DateTime? ApprovalDate { get; set; }

	public bool IsMultiLevel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class BooleanResponseModel
{
	public bool IsSuccess { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CouponDetailsEngineModel
{
	public string? Coupon { get; set; }

	public string? DiscountType { get; set; }

	public bool CouponValid { get; set; }

	public bool CouponApplied { get; set; }

	public string? CouponMessage { get; set; }

	public string? PromotionName { get; set; }

	public double DiscountAmountApplied { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderLogCollectionDetailsModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public string? ActionMode { get; set; }

	public string? Custom1 { get; set; }

	public string? Custom2 { get; set; }

	public string? Custom3 { get; set; }

	public string? Custom4 { get; set; }

	public string? Custom5 { get; set; }

	public string? Note { get; set; }

	public string? PrefixNote { get; set; }

	public Guid OrderNoteId { get; set; }

	public string? CreatedByFullName { get; set; }

	public bool IsSystemDefine { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderValidationMessageModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public string? ActionMode { get; set; }

	public string? Custom1 { get; set; }

	public string? Custom2 { get; set; }

	public string? Custom3 { get; set; }

	public string? Custom4 { get; set; }

	public string? Custom5 { get; set; }

	public ICollection<string>? ValidationMessages { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderClassButtonModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public string? ActionMode { get; set; }

	public string? Custom1 { get; set; }

	public string? Custom2 { get; set; }

	public string? Custom3 { get; set; }

	public string? Custom4 { get; set; }

	public string? Custom5 { get; set; }

	public int CPOrderClassButtonId { get; set; }

	public string? ButtonText { get; set; }

	public int WhenOmsOrderStateId { get; set; }

	public int CPOrderClassId { get; set; }

	public int SetToOmsOrderStateId { get; set; }

	public int DisplayOrder { get; set; }

	public string? OrderStateName { get; set; }

	public int? ToClassId { get; set; }

	public string? ToClass { get; set; }

	public string? WhenStatusIs { get; set; }

	public string? SetStatusTo { get; set; }

	public ICollection<OrderClassModel>? OrderClassModels { get; set; }

	public ICollection<SelectListItem>? WhenOmsOrderStateIdList { get; set; }

	public ICollection<SelectListItem>? CPOrderClassIdList { get; set; }

	public ICollection<OrderClassButtonModel>? OrderClassButtonModels { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderClassModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public string? ActionMode { get; set; }

	public string? Custom1 { get; set; }

	public string? Custom2 { get; set; }

	public string? Custom3 { get; set; }

	public string? Custom4 { get; set; }

	public string? Custom5 { get; set; }

	public int CPOrderClassId { get; set; }

	[Required]
	public string ClassCode { get; set; }

	[Required]
	public string ClassName { get; set; }

	public int NextNumber { get; set; }

	[Required]
	public string NumberFormat { get; set; }

	[Required]
	public string DigitLength { get; set; }

	public string? ProductAttribute { get; set; }

	public string? ParentProductAttribute { get; set; }

	public string? UserOrderType { get; set; }

	public string? ApproverOrderType { get; set; }

	public bool IsSavedCalculationDetails { get; set; }

	public bool IsExcludePromotionAndVoucher { get; set; }

	public bool IsRequired { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class QuickOrderCartModel
{
	public int Id { get; set; }

	public string? SKU { get; set; }

	public double Quantity { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReceiptDetailsResponseModel
{
	public string? MessageText { get; set; }

	public bool IsSendEmail { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class RemoveShippingResponseModel
{
	public string? ClassNumber { get; set; }

	public bool IsSuccess { get; set; }

	public string? ErrorMessage { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AddChildItemRequestModel
{
	public string? Sku { get; set; }

	public double Quantity { get; set; }

	public ICollection<AddOnSkuListRequestModel>? AddOnSkuListModel { get; set; }

	public ICollection<PersonalizedDetailsRequestModel>? PersonalizedDetails { get; set; }

	public ICollection<AdditionalCostRequestModel>? AdditionalCost { get; set; }

	public ICollection<CustomDataRequestModel>? CustomData { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AddLineItemsRequestModel
{
	public string? Origin { get; set; }

	[Required]
	public string ClassNumber { get; set; }

	[Required]
	public string CatalogCode { get; set; }

	public int UserId { get; set; }

	public int? AccountId { get; set; }

	public ICollection<LineItemSkuDetailsRequestModel>? SkuDetails { get; set; }

	public string? Notes { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AddOnSkuListRequestModel
{
	public string? Sku { get; set; }

	public string? GroupName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AddToCartChildItemRequestModel
{
	public string? Sku { get; set; }

	public double Quantity { get; set; }

	public ICollection<AddOnSkuListRequestModel>? AddOnSkuListModel { get; set; }

	public ICollection<PersonalizedDetailsRequestModel>? PersonalizedDetails { get; set; }

	public ICollection<AdditionalCostRequestModel>? AdditionalCost { get; set; }

	public ICollection<CustomDataRequestModel>? CustomData { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AddToCartRequestModel
{
	public Guid CartId { get; set; }

	public int UserId { get; set; }

	public int? AccountId { get; set; }

	public ICollection<SkuDetailsRequestModel>? SkuDetails { get; set; }

	public string? OrderOrigin { get; set; }

	public string? Notes { get; set; }

	[Required]
	public string CatalogCode { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AdditionalCostRequestModel
{
	public string? Code { get; set; }

	public string? Value { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AdditionalInstructionRequestModel
{
	public string? Name { get; set; }

	public string? Information { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class BulkUpdateCustomDataRequestModel
{
	public string? LineItemId { get; set; }

	public CustomDataRequestModel CustomData { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CalculateSummaryRequestModel
{
	public ICollection<DiscountRequestModel>? DiscountDetails { get; set; }

	public bool IsTaxExempt { get; set; }

	public double SubTotal { get; set; }

	public double Total { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CompleteOrderRequestModel
{
	public Guid OrderId { get; set; }

	[Required]
	public string PaymentData { get; set; }

	[Required]
	public string ProductDetail { get; set; }

	public int OrderStateId { get; set; }

	public bool IsFinalized { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ConvertClassRequestModel
{
	public string? TargetClassNumber { get; set; }

	[StringLength(100)]
	public string? TargetClassName { get; set; }

	public Guid ItemId { get; set; }

	public AdditionalInstructionRequestModel AdditionalInstructions { get; set; }

	public string? Origin { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ConvertToOrderRequestModel
{
	[Range(1, int.MaxValue)]
	public int UserId { get; set; }

	public string? StatusCode { get; set; }

	public bool? SkipSentEmail { get; set; }

	public string? TargetClassType { get; set; }

	public bool? SkipReCalculation { get; set; }

	public AdditionalInstructionRequestModel AdditionalInstruction { get; set; }

	public PaymentDetailsRequestModel PaymentDetails { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CostDetailRequestModel
{
	public double? RemainingOrderAmount { get; set; }

	public double? PaidAmount { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateClassRequestModel
{
	public int CreatedBy { get; set; }

	public int CPOrderClassButtonId { get; set; }

	public string? ButtonText { get; set; }

	public int WhenOmsOrderStateId { get; set; }

	public int CPOrderClassId { get; set; }

	public int SetToOmsOrderStateId { get; set; }

	public int DisplayOrder { get; set; }

	public string? OrderStateName { get; set; }

	public int? ToClassId { get; set; }

	public string? ToClass { get; set; }

	public string? WhenStatusIs { get; set; }

	public string? SetStatusTo { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateLineItemsRequestModel
{
	public int CreatedBy { get; set; }

	[Required(AllowEmptyStrings = true)]
	public Guid OrderId { get; set; }

	public int VersionId { get; set; }

	public ICollection<OrderProductVariantRequestModel>? ProductVariantDetails { get; set; }

	public int UserId { get; set; }

	public string? OrderProductAttributeValueId { get; set; }

	public string? SKU { get; set; }

	public string? ConfigurableProductSKU { get; set; }

	public string? LineitemId { get; set; }

	public int OmsOrderStateId { get; set; }

	public bool IsNAAttributeAvailable { get; set; }

	public string? Custom1 { get; set; }

	public string? Custom2 { get; set; }

	public string? Custom3 { get; set; }

	public string? Custom4 { get; set; }

	public string? Custom5 { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateLogsRequestModel
{
	public string? ClassNumber { get; set; }

	public string? ClassType { get; set; }

	public string? Note { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateOrderFlagRequestModel
{
	public int CreatedBy { get; set; }

	[Required]
	[StringLength(50, MinimumLength = 1)]
	[RegularExpression("^[a-zA-Z0-9]*$")]
	public string FlagCode { get; set; }

	[Required]
	[StringLength(50, MinimumLength = 1)]
	public string NameUnchecked { get; set; }

	[Required]
	[StringLength(50, MinimumLength = 1)]
	public string NameChecked { get; set; }

	public bool IsCanOveride { get; set; }

	[StringLength(50)]
	public string? NameOverridden { get; set; }

	[Range(1, 9999)]
	public int DisplayOrder { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateOrderLogRequestModel
{
	public int CreatedBy { get; set; }

	public int ClassId { get; set; }

	public Guid MappingId { get; set; }

	public string? Note { get; set; }

	public string? TypeOfMapping { get; set; }

	public bool IsDeleted { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateOrderPaymentRequestModel
{
	[Required]
	public string ClassNumber { get; set; }

	public int BillingAddressId { get; set; }

	public PaymentDetailsRequestModel PaymentDetails { get; set; }

	public CostDetailRequestModel CostDetails { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateOrderRequestModel
{
	public int CreatedBy { get; set; }

	public string? ClassCode { get; set; }

	public int UserId { get; set; }

	public int? AccountId { get; set; }

	public int PortalId { get; set; }

	public string? OrderTypeCode { get; set; }

	public string? OrderOrigin { get; set; }

	public DateTime? OrderDate { get; set; }

	public int? AssignTo { get; set; }

	public string? Custom1 { get; set; }

	public string? Custom2 { get; set; }

	public string? Custom3 { get; set; }

	public string? Custom4 { get; set; }

	public string? Custom5 { get; set; }

	public string? CatalogCode { get; set; }

	public string? LocaleCode { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateOrderTypeRequestModel
{
	[Required]
	public string TypeCode { get; set; }

	[Required]
	public string TypeName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateStatusButtonRequestModel
{
	public int CreatedBy { get; set; }

	public int OmsOrderStateId { get; set; }

	[Required(AllowEmptyStrings = true)]
	[StringLength(100)]
	public string ButtonText { get; set; }

	[Range(1, 99999)]
	public int DisplayOrder { get; set; }

	[Required]
	public string Status { get; set; }

	[Required]
	public string RequiredPermission { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateStatusRequestModel
{
	public int CreatedBy { get; set; }

	[Required(AllowEmptyStrings = true)]
	[StringLength(100)]
	[RegularExpression("^[a-zA-Z0-9]*$")]
	public string OrderStateName { get; set; }

	[Required(AllowEmptyStrings = true)]
	[StringLength(50)]
	[RegularExpression("^[a-zA-Z0-9]*$")]
	public string StatusCode { get; set; }

	public bool IsShowToCustomer { get; set; }

	[Range(1, 99999)]
	public int DisplayOrder { get; set; }

	public bool IsEdit { get; set; }

	public bool IsSendEmail { get; set; }

	public bool IsOrderState { get; set; }

	public bool IsOrderLineItemState { get; set; }

	[Required]
	public string CPBackColor { get; set; }

	[Required]
	public string CPTextColor { get; set; }

	public bool IsCPRequireCompleteness { get; set; }

	public bool IsCPWorkingNotShipped { get; set; }

	public bool IsCPTimeLineOnlyIfActive { get; set; }

	public string? WillDisplayAs { get; set; }

	public bool IsCPTriggerFulfilledData { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateUserGroupRequestModel
{
	public int CreatedBy { get; set; }

	[Required]
	[StringLength(100, MinimumLength = 1)]
	[RegularExpression("^[a-zA-Z0-9]*$")]
	public string GroupCode { get; set; }

	[Required]
	[StringLength(100, MinimumLength = 1)]
	public string GroupName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateUserProfileCpRoleRequestModel
{
	public int CreatedBy { get; set; }

	public int UserId { get; set; }

	public string? GlobalAttributeCode { get; set; }

	public string? GlobalAttributeValue { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomDataRequestModel
{
	[StringLength(65535)]
	public string? Custom1 { get; set; }

	[StringLength(65535)]
	public string? Custom2 { get; set; }

	[StringLength(65535)]
	public string? Custom3 { get; set; }

	[StringLength(65535)]
	public string? Custom4 { get; set; }

	[StringLength(65535)]
	public string? Custom5 { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DeleteLineItemsRequestModel
{
	[Required(AllowEmptyStrings = true)]
	public Guid OrderId { get; set; }

	public int ClassId { get; set; }

	[Required]
	public string LineitemId { get; set; }

	public bool IsDeleteAll { get; set; }

	public int UserId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DeleteOrderLogRequestModel
{
	public Guid OrderId { get; set; }

	public int ClassId { get; set; }

	public string? TypeOfMapping { get; set; }

	public string? Note { get; set; }

	public Guid OrderNoteIds { get; set; }

	public bool IsDeleted { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DiscountRequestModel
{
	[Required]
	public string DiscountType { get; set; }

	public string? DiscountCode { get; set; }

	public double Amount { get; set; }

	public ICollection<string>? Expands { get; set; }

	public bool? IsDiscountValid { get; set; }

	public string? DiscountMessage { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DuplicateLineItemRequestModel
{
	[Required(AllowEmptyStrings = true)]
	public Guid OrderId { get; set; }

	[Required(AllowEmptyStrings = true)]
	public Guid LineitemId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DuplicateOrderRequestModel
{
	public Guid OrderId { get; set; }

	public bool IsCopyOrderShipment { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EntityDetailsRequestModel
{
	public string? ParentKey { get; set; }

	public ICollection<KeyValueEntityRequestModel>? KeyValueDetails { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FlagAndUserGroupRequestModel
{
	public string? CPUserGroupIds { get; set; }

	public int CPOrderFlagId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class KeyValueEntityRequestModel
{
	public string? Key { get; set; }

	public string? Value { get; set; }

	public string? LinkedItemKey { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LineItemDetailsStatusRequestModel
{
	public Guid ItemId { get; set; }

	public string? StatusCode { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LineItemSkuDetailsRequestModel
{
	[Required]
	public string Sku { get; set; }

	public double? Quantity { get; set; }

	public ICollection<AddOnSkuListRequestModel>? AddOnSkuListModel { get; set; }

	public ICollection<PersonalizedDetailsRequestModel>? PersonalizedDetails { get; set; }

	public ICollection<AddChildItemRequestModel>? AddToCartChildItems { get; set; }

	public ICollection<CustomDataRequestModel>? CustomData { get; set; }

	public string? GroupCode { get; set; }

	public ICollection<AdditionalCostRequestModel>? AdditionalCost { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LineItemsResetPriceRequestModel
{
	[Required(AllowEmptyStrings = true)]
	public Guid OrderId { get; set; }

	[Required(AllowEmptyStrings = true)]
	public Guid LineitemId { get; set; }

	public double Quantity { get; set; }

	public bool IsPriceUpdated { get; set; }

	public bool IsPriceReset { get; set; }

	[Required]
	public string SKU { get; set; }

	public string? SkuQuantityDetails { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MergeCartRequestModel
{
	[Required]
	public string GuestUserCartNumber { get; set; }

	public string? LoginUserCartNumber { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderDetailsRequestModel
{
	public string? ClassNumber { get; set; }

	public int PortalId { get; set; }

	public string? OrderStateName { get; set; }

	public string? OrderTotal { get; set; }

	public string? Category { get; set; }

	public string? Account { get; set; }

	public string? OperatorClassNumber { get; set; }

	public string? OperatorAccountName { get; set; }

	public string? OperatorUserName { get; set; }

	public string? OperatorOrderStateName { get; set; }

	public string? OperatorOrderTotal { get; set; }

	public string? GlobalSearch { get; set; }

	public string? AssignToFullName { get; set; }

	public string? UserFullName { get; set; }

	public string? OperatorAssignToFullName { get; set; }

	public string? ColumnSorting { get; set; }

	public int ClassId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderFlagMappingRequestModel
{
	public int CreatedBy { get; set; }

	public Guid OrderId { get; set; }

	public Guid OrderFlagId { get; set; }

	public string? CPOrderFlagId { get; set; }

	public int UserId { get; set; }

	public string? OrderTypeCode { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderFollowerRequestModel
{
	public string? OrderIds { get; set; }

	public int UserId { get; set; }

	public int AssignTo { get; set; }

	public bool IsDeleted { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderItemsPriceResetRequestModel
{
	[Required]
	public string ClassNumber { get; set; }

	[Required]
	[MinLength(1)]
	public ICollection<OrderLineItemRequestModel> LineItems { get; set; } = new Collection<OrderLineItemRequestModel>();
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderLineItemRequestModel
{
	[Required(AllowEmptyStrings = true)]
	public Guid LineitemId { get; set; }

	[Required]
	public string SkuQuantityDetails { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderLogsRequestModel
{
	public Guid OrderId { get; set; }

	public string? ViewFilter { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderOwnerDetailsRequestModel
{
	public string? OrderIds { get; set; }

	public int AssignTo { get; set; }

	public int? CPUserGroupId { get; set; }

	public int UserId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderOwnerDetailsRquestModel
{
	public string? OrderIds { get; set; }

	public int AssignTo { get; set; }

	public int UserId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderPaymentDetailsDiscountRequestModel
{
	public Guid? OrderId { get; set; }

	public int ClassId { get; set; }

	public ICollection<OrderPaymentDiscountsRequestModel>? DiscountData { get; set; }

	public int UserId { get; set; }

	public bool? IsTaxExemption { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderPaymentDiscountsRequestModel
{
	public Guid? OrderDiscountId { get; set; }

	public string? Code { get; set; }

	public string? Value { get; set; }

	public double Amount { get; set; }

	public bool? IsDeleted { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderProductVariantRequestModel
{
	public int ZnodeProductId { get; set; }

	public string? GroupingCode { get; set; }

	public bool IsAddOn { get; set; }

	public string? ParentDetail { get; set; }

	public string? Customization { get; set; }

	public int Quantity { get; set; }

	public double? Price { get; set; }

	public string? ProductNote { get; set; }

	public ICollection<OrderProductVarientDetailsRequestModel>? NAAttribute { get; set; }

	public int ParentProductId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderProductVarientDetailsRequestModel
{
	public string? AttributeCode { get; set; }

	public string? AttributeValues { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ParameterOrderFlagRequestModel
{
	[Required]
	public string CPOrderFlagIds { get; set; }

	public int CPOrderTypeId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ParameterUserGroupRequestModel
{
	public int CPOrderFlagId { get; set; }

	[Required]
	public string CPUserGroupIds { get; set; }

	public int CPOrderTypeId { get; set; }

	public int UserId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PaymentDetailsRequestModel
{
	public string? PaymentSubTypeCode { get; set; }

	public string? ConfigurationSetCode { get; set; }

	public string? PaymentTransactionToken { get; set; }

	public string? PaymentStatusCode { get; set; }

	public string? PurchaseOrderNumber { get; set; }

	public string? PurchaseOrderDocumentFilePath { get; set; }

	public string? ExternalTransactionId { get; set; }

	public string? SubTypeCode { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PersonalizedDetailsRequestModel
{
	public string? Code { get; set; }

	public string? Value { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReorderRequestModel
{
	public string? OrderNumber { get; set; }

	public string? OrderOrigin { get; set; }

	public Guid? ItemId { get; set; }

	public int? CustomerId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReturnCalculateLineItemRequestModel
{
	public string? OrderProductId { get; set; }

	public double Quantity { get; set; }

	public int ReasonForReturnId { get; set; }

	public string? ReasonForReturn { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReturnLineItemRequestModel
{
	public string? StatusCode { get; set; }

	public ICollection<ValidateReturnRequestModel>? LineItemDetails { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReturnRequestLineItemModel
{
	[Required(AllowEmptyStrings = true)]
	public Guid LineItemId { get; set; }

	public double Quantity { get; set; }

	[Range(1, int.MaxValue)]
	public int ReasonForReturnId { get; set; }

	public string? ReasonForReturn { get; set; }

	public string? Note { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReturnRequestModel
{
	public string? ReturnStateCode { get; set; }

	public ICollection<ReturnRequestLineItemModel>? ReturnLineItems { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SavedViewRequestModel
{
	public string? ListViewIds { get; set; }

	public int ListViewUserGroupId { get; set; }

	public int? ListViewId { get; set; }

	public int? UserGroupId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ShippingDetailsRequestModel
{
	[Required]
	[RegularExpression("^[1-9][0-9]*$")]
	public string AddressId { get; set; }

	public string? ShippingConstraintCode { get; set; }

	[Range(1, int.MaxValue)]
	public int ShippingId { get; set; }

	public string? ShipDate { get; set; }

	public string? TrackingNumber { get; set; }

	public DateTime? InHandDate { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SkuDetailsRequestModel
{
	[Required]
	public string Sku { get; set; }

	public double? Quantity { get; set; }

	public ICollection<AddOnSkuListRequestModel>? AddOnSkuListModel { get; set; }

	public ICollection<PersonalizedDetailsRequestModel>? PersonalizedDetails { get; set; }

	public ICollection<AddToCartChildItemRequestModel>? AddToCartChildItems { get; set; }

	public ICollection<CustomDataRequestModel>? CustomData { get; set; }

	public string? GroupCode { get; set; }

	public ICollection<AdditionalCostRequestModel>? AdditionalCost { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StatusClassRequestModel
{
	public int CreatedBy { get; set; }

	public string? CPOrderClassIds { get; set; }

	public int OmsOrderStateId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateAllClassDetailRequestModel
{
	[Required]
	public string ClassNumber { get; set; }

	public DateTime? ExpirationDate { get; set; }

	public string? ClassStatusCode { get; set; }

	public ShippingDetailsRequestModel ShippingDetails { get; set; }

	public ICollection<UpdateLineItemDetailsRequestModel>? LineItemDetails { get; set; }

	public CalculateSummaryRequestModel CalculateSummary { get; set; }

	public AdditionalInstructionRequestModel AdditionalInstructions { get; set; }

	public CustomDataRequestModel CustomData { get; set; }

	public string? ExternalId { get; set; }

	public bool IsReCalculate { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateClassButtonRequestModel
{
	public int ModifiedBy { get; set; }

	public int CPOrderClassButtonId { get; set; }

	public string? ButtonText { get; set; }

	public int WhenOmsOrderStateId { get; set; }

	public int CPOrderClassId { get; set; }

	public int SetToOmsOrderStateId { get; set; }

	public int DisplayOrder { get; set; }

	public string? OrderStateName { get; set; }

	public int? ToClassId { get; set; }

	public string? ToClass { get; set; }

	public string? WhenStatusIs { get; set; }

	public string? SetStatusTo { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateClassItemBulkQuantityRequestModel
{
	[Required]
	public string Sku { get; set; }

	public double Quantity { get; set; }

	[Required(AllowEmptyStrings = true)]
	public Guid ItemId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateClassItemQuantityRequestModel
{
	[Required]
	public string Sku { get; set; }

	public double Quantity { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateClassRequestModel
{
	public int ModifiedBy { get; set; }

	public int CPOrderClassId { get; set; }

	[Required(AllowEmptyStrings = true)]
	[StringLength(100)]
	public string ClassCode { get; set; }

	[Required(AllowEmptyStrings = true)]
	[StringLength(100)]
	public string ClassName { get; set; }

	public int NextNumber { get; set; }

	[Required]
	[StringLength(35, MinimumLength = 1)]
	[RegularExpression("^([1-9]|[1-9][0-9]|20)$")]
	public string NumberFormat { get; set; }

	[Required]
	public string DigitLength { get; set; }

	public string? ProductAttribute { get; set; }

	public string? ParentProductAttribute { get; set; }

	public string? UserOrderType { get; set; }

	public string? ApproverOrderType { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateClassStatusRequestModel
{
	[Required]
	public string StatusCode { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateEntityRequestModel
{
	public ICollection<EntityDetailsRequestModel>? EntityDetails { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateLineItemDetailsRequestModel
{
	public Guid ItemId { get; set; }

	public double? Quantity { get; set; }

	public double? UnitPrice { get; set; }

	public double? ShippingPrice { get; set; }

	public string? LineItemStatusCode { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateLineItemStatusRequestModel
{
	public ICollection<LineItemDetailsStatusRequestModel>? LineItemDetailsStatuses { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateLineItemsPriceMappingRequestModel
{
	public Guid? OrderId { get; set; }

	[Required]
	public string LineitemId { get; set; }

	public double Price { get; set; }

	public double OldPrice { get; set; }

	public string? ProductNote { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateLineItemsStatusMappingRequestModel
{
	public Guid? OrderId { get; set; }

	public string? SKU { get; set; }

	[Required]
	public string LineitemId { get; set; }

	public int OmsOrderStateId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateOrderFlagMappingRequestModel
{
	public int ModifiedBy { get; set; }

	public Guid OrderFlagId { get; set; }

	public int UserId { get; set; }

	public bool IsChecked { get; set; }

	public bool IsActiveOverridden { get; set; }

	public bool IsCallForOverrideUserGroup { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateOrderFlagRequestModel
{
	public int ModifiedBy { get; set; }

	public int CPOrderFlagId { get; set; }

	[Required]
	[StringLength(50, MinimumLength = 1)]
	[RegularExpression("^[a-zA-Z0-9]*$")]
	public string FlagCode { get; set; }

	[Required]
	[StringLength(50, MinimumLength = 1)]
	public string NameUnchecked { get; set; }

	[Required]
	[StringLength(50, MinimumLength = 1)]
	public string NameChecked { get; set; }

	public bool IsCanOveride { get; set; }

	[StringLength(50)]
	public string? NameOverridden { get; set; }

	[Range(1, 9999)]
	public int DisplayOrder { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateOrderLogRequestModel
{
	public int ModifiedBy { get; set; }

	public Guid OrderId { get; set; }

	public int ClassId { get; set; }

	public Guid OrderNoteId { get; set; }

	public string? TypeOfMapping { get; set; }

	public string? Note { get; set; }

	public string? OrderNoteIds { get; set; }

	public bool IsDeleted { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateOrderPaymentRequestModel
{
	public int ModifiedBy { get; set; }

	[Required]
	public string ClassNumber { get; set; }

	public int BillingAddressId { get; set; }

	public int? UserId { get; set; }

	public PaymentDetailsRequestModel PaymentDetails { get; set; }

	public bool? IsTaxExemption { get; set; }

	public CostDetailRequestModel CostDetails { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateOrderRequestModel
{
	public int ModifiedBy { get; set; }

	public Guid OrderId { get; set; }

	public int OmsOrderStateId { get; set; }

	public int? AccountId { get; set; }

	public int PortalId { get; set; }

	public string? OrderTypeCode { get; set; }

	public string? OrderOrigin { get; set; }

	public int? AssignTo { get; set; }

	public bool IsSendEmail { get; set; }

	public bool IsOrderTypeChanged { get; set; }

	public bool IsAccountTypeChanged { get; set; }

	public bool IsAssignedUserChanged { get; set; }

	public string? CatalogCode { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateOrderShipmentRequestModel
{
	[Required]
	public string ClassNumber { get; set; }

	public Guid? OrderAddressId { get; set; }

	public int? ShippingId { get; set; }

	public DateTime? ShipDate { get; set; }

	public string? ShippingConstraintCode { get; set; }

	public bool? IsShipCompletely { get; set; }

	public int UserId { get; set; }

	public int? ShippingAddressId { get; set; }

	public string? TrackingNumber { get; set; }

	public string? ShippingNotes { get; set; }

	public string? PhoneNumber { get; set; }

	public DateTime? InHandDate { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateOrderStatusRequestModel
{
	public int ModifiedBy { get; set; }

	[Required(AllowEmptyStrings = true)]
	public Guid OrderId { get; set; }

	public bool IsOrderFinalized { get; set; }

	public bool IsSendEmail { get; set; }

	public bool IsSetOrderLineItem { get; set; }

	public int UserId { get; set; }

	public int OmsOrderStateId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateOrderTemplateRequestModel
{
	[Required]
	public string OrderTemplateNumber { get; set; }

	public int AccountId { get; set; }

	[Range(1, int.MaxValue)]
	public int UserId { get; set; }

	public ICollection<SkuDetailsRequestModel>? SkuDetails { get; set; }

	public string? OrderOrigin { get; set; }

	public string? CatalogCode { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateOrderTypeRequestModel
{
	public int ModifiedBy { get; set; }

	public int CPOrderTypeId { get; set; }

	[Required]
	public string TypeCode { get; set; }

	[Required]
	public string TypeName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateQuantityMappingRequestModel
{
	public Guid? OrderId { get; set; }

	[Required]
	public string LineItemId { get; set; }

	public double Quantity { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateStatusButtonRequestModel
{
	public int ModifiedBy { get; set; }

	public int CPOrderStatusButtonId { get; set; }

	public int OmsOrderStateId { get; set; }

	[Required(AllowEmptyStrings = true)]
	[StringLength(100)]
	public string ButtonText { get; set; }

	[Range(1, 99999)]
	public int DisplayOrder { get; set; }

	[Required]
	public string Status { get; set; }

	[Required]
	public string RequiredPermission { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateStatusRequestModel
{
	public int ModifiedBy { get; set; }

	public int OmsOrderStateId { get; set; }

	[Required(AllowEmptyStrings = true)]
	[StringLength(100)]
	[RegularExpression("^[a-zA-Z0-9]*$")]
	public string OrderStateName { get; set; }

	[Required(AllowEmptyStrings = true)]
	[StringLength(50)]
	[RegularExpression("^[a-zA-Z0-9]*$")]
	public string StatusCode { get; set; }

	public bool IsShowToCustomer { get; set; }

	[Range(1, 99999)]
	public int DisplayOrder { get; set; }

	public bool IsEdit { get; set; }

	public bool IsSendEmail { get; set; }

	public bool IsOrderState { get; set; }

	public bool IsOrderLineItemState { get; set; }

	[Required]
	public string CPBackColor { get; set; }

	[Required]
	public string CPTextColor { get; set; }

	public bool IsCPRequireCompleteness { get; set; }

	public bool IsCPWorkingNotShipped { get; set; }

	public bool IsCPTimeLineOnlyIfActive { get; set; }

	public string? WillDisplayAs { get; set; }

	public bool IsCPTriggerFulfilledData { get; set; }

	public bool IsSystemDefined { get; set; }

	public bool IsQuoteState { get; set; }

	public bool IsAccountStatus { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateUserGroupRequestModel
{
	public int ModifiedBy { get; set; }

	public int CPUserGroupId { get; set; }

	[Required]
	[StringLength(100, MinimumLength = 1)]
	[RegularExpression("^[a-zA-Z0-9]*$")]
	public string GroupCode { get; set; }

	[Required]
	[StringLength(100, MinimumLength = 1)]
	public string GroupName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateUserInGroupRequestModel
{
	public int ModifiedBy { get; set; }

	public int CPUsersInGroupId { get; set; }

	public int CPUserGroupId { get; set; }

	public int UserId { get; set; }

	public int Priority { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UserProfileCpRoleListRequestModel
{
	public int UserId { get; set; }

	public string? UserName { get; set; }

	public string? RoleName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UsersAndUserGroupsRequestModel
{
	public string? CPUserGroupIds { get; set; }

	public int UserId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ValidateReturnRequestModel
{
	public Guid LineItemId { get; set; }

	public int Quantity { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ActionButtonDetailsResponseModel
{
	public ActionButtonResultResponseModel ActionButtonResultResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ActionButtonListResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<ActionButtonResponseModel>? ActionButtonResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ActionButtonResponseModel
{
	public int ButtonId { get; set; }

	public string? ButtonText { get; set; }

	public int OmsOrderStateId { get; set; }

	public string? PermissionCode { get; set; }

	public string? TypeOfPermission { get; set; }

	public int DisplayOrder { get; set; }

	public bool IsClassButton { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ActionButtonResultResponseModel
{
	public int ButtonId { get; set; }

	public string? ButtonText { get; set; }

	public int OmsOrderStateId { get; set; }

	public string? PermissionCode { get; set; }

	public string? TypeOfPermission { get; set; }

	public int DisplayOrder { get; set; }

	public bool IsClassButton { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ActiveClassResponseModel
{
	public string? ClassNumber { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AddLineItemsResponseModel
{
	public Guid ItemId { get; set; }

	public bool? Status { get; set; }

	public string? ClassNumber { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AddOnSkuResponseModel
{
	public string? Sku { get; set; }

	public string? ProductName { get; set; }

	public string? GroupName { get; set; }

	public double? UnitPrice { get; set; }

	public ICollection<ValidationsResponseModel>? ValidationDetails { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AddToCartResponseModel
{
	public Guid CartId { get; set; }

	public Guid CartItemId { get; set; }

	public bool? Status { get; set; }

	public string? CartNumber { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AdditionalCostResponseModel
{
	public string? Code { get; set; }

	public string? Value { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AdditionalInstructionResponseModel
{
	public string? Name { get; set; }

	public string? Information { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AddressDetailsResponseModel
{
	public int AddressId { get; set; }

	public string? FirstName { get; set; }

	public string? LastName { get; set; }

	public string? CityName { get; set; }

	public string? StateName { get; set; }

	public double StateCode { get; set; }

	public string? PostalCode { get; set; }

	public string? CompanyName { get; set; }

	public string? PhoneNumber { get; set; }

	public string? CountryName { get; set; }

	public string? Address1 { get; set; }

	public string? Address2 { get; set; }

	public bool IsBilling { get; set; }

	public bool IsShipping { get; set; }

	public string? DisplayName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ApproversResponseModel
{
	public ICollection<ApproversModel>? ApproverList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AttributesResponseModel
{
	public string? AttributeValue { get; set; }

	public string? AttributeCode { get; set; }

	public ICollection<SelectedValueResponseModel>? SelectValues { get; set; }

	public bool IsConfigurable { get; set; }

	public string? AttributeDefaultValueCode { get; set; }

	public string? OrderProductId { get; set; }

	public string? AttributeName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CPAddressResponseModel
{
	public int AddressId { get; set; }

	public int AccountId { get; set; }

	public string? Address1 { get; set; }

	public string? Address2 { get; set; }

	[StringLength(600)]
	public string? DisplayName { get; set; }

	[StringLength(300)]
	public string? FirstName { get; set; }

	[StringLength(300)]
	public string? LastName { get; set; }

	public string? CountryName { get; set; }

	public string? StateName { get; set; }

	public string? CityName { get; set; }

	[StringLength(50)]
	public string? PostalCode { get; set; }

	[StringLength(50)]
	public string? PhoneNumber { get; set; }

	public bool IsDefaultBilling { get; set; }

	public bool IsDefaultShipping { get; set; }

	public bool IsActive { get; set; }

	public bool IsGuest { get; set; }

	public bool IsShipping { get; set; }

	public bool IsBilling { get; set; }

	public bool IsShippingBillingDifferent { get; set; }

	public string? EmailAddress { get; set; }

	public string? CountryCode { get; set; }

	public bool IsAddressBook { get; set; }

	[StringLength(300)]
	public string? CompanyName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CalculateResponseModel
{
	public double Discount { get; set; }

	public double OrderLevelDiscount { get; set; }

	public double OrderLevelShipping { get; set; }

	public double OrderLevelTaxes { get; set; }

	public double ShippingCost { get; set; }

	public double ShippingDiscount { get; set; }

	public double ShippingDifference { get; set; }

	public double TaxCost { get; set; }

	public double TaxRate { get; set; }

	public double SalesTax { get; set; }

	public double CSRDiscountAmount { get; set; }

	public bool CSRDiscountApplied { get; set; }

	public string? CSRDiscountMessage { get; set; }

	public double? SubTotal { get; set; }

	public double? Total { get; set; }

	public double HandlingFee { get; set; }

	public double VoucherAmount { get; set; }

	public ICollection<VoucherDetailsEngineModel>? VoucherDetails { get; set; }

	public ICollection<CouponDetailsEngineModel>? CouponDetails { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CalculateSummeryResponseModel
{
	public string? CartId { get; set; }

	public ICollection<CostFactorResponse>? CostFactorResponse { get; set; }

	public ICollection<DiscountFactorResponse>? DiscountFactorResponse { get; set; }

	public double SubTotal { get; set; }

	public double Total { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CartCountResponseModel
{
	public string? ClassNumber { get; set; }

	public int CartCount { get; set; }

	public bool IsSuccess { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CartItemListResponseModel
{
	public int ZnodeProductId { get; set; }

	public string? CartItemId { get; set; }

	public string? ProductName { get; set; }

	public string? ProductDescription { get; set; }

	public string? Sku { get; set; }

	public bool HasAddOn { get; set; }

	public double Quantity { get; set; }

	public double? UnitPrice { get; set; }

	public ICollection<PersonalizedDetailResponseModel>? PersonalizedDetails { get; set; }

	public ICollection<AttributesResponseModel>? Attributes { get; set; }

	public ICollection<AddOnSkuResponseModel>? AddOnSkuList { get; set; }

	public CustomDataResponseModel CustomData { get; set; }

	public ICollection<ChildItemListResponseModel>? ChildItemList { get; set; }

	public ICollection<ValidationsResponseModel>? ValidationDetails { get; set; }

	public ICollection<AdditionalCostResponseModel>? AdditionalCost { get; set; }

	public string? SEOUrl { get; set; }

	public string? ProductType { get; set; }

	public double TotalPrice { get; set; }

	public double ItemPrice { get; set; }

	public string? ProductImagePath { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CartListResponseModel
{
	public string? CartId { get; set; }

	public string? CartNumber { get; set; }

	public string? ClassTypeCode { get; set; }

	public ICollection<CartItemListResponseModel>? CartItemList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CartValidationResponseModel
{
	public string? ErrorCode { get; set; }

	public string? ErrorMessage { get; set; }

	public string? Sku { get; set; }

	public int Priority { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ChildItemDetailsResponseModel
{
	public string? ItemId { get; set; }

	public string? SKU { get; set; }

	public string? ProductName { get; set; }

	public string? ProductDescription { get; set; }

	public double Quantity { get; set; }

	public double? UnitPrice { get; set; }

	public int ZnodeProductId { get; set; }

	public ICollection<AddOnSkuResponseModel>? AddOnSkuList { get; set; }

	public ICollection<PersonalizedDetailResponseModel>? PersonalizedDetails { get; set; }

	public ICollection<AttributesResponseModel>? Attributes { get; set; }

	public CustomDataResponseModel CustomData { get; set; }

	public ICollection<ValidationsResponseModel>? ValidationDetails { get; set; }

	public ICollection<AdditionalCostResponseModel>? AdditionalCost { get; set; }

	public string? SEOUrl { get; set; }

	public string? ProductType { get; set; }

	public double TotalPrice { get; set; }

	public double ItemPrice { get; set; }

	public string? ProductImagePath { get; set; }

	public double? ShippingCost { get; set; }

	public string? StatusCode { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ChildItemListResponseModel
{
	public string? CartItemId { get; set; }

	public string? SKU { get; set; }

	public string? ProductName { get; set; }

	public string? ProductDescription { get; set; }

	public double Quantity { get; set; }

	public double? UnitPrice { get; set; }

	public int ZnodeProductId { get; set; }

	public ICollection<AddOnSkuResponseModel>? AddOnSkuList { get; set; }

	public ICollection<PersonalizedDetailResponseModel>? PersonalizedDetails { get; set; }

	public ICollection<AttributesResponseModel>? Attributes { get; set; }

	public CustomDataResponseModel CustomData { get; set; }

	public ICollection<ValidationsResponseModel>? ValidationDetails { get; set; }

	public ICollection<AdditionalCostResponseModel>? AdditionalCost { get; set; }

	public string? SEOUrl { get; set; }

	public string? ProductType { get; set; }

	public double TotalPrice { get; set; }

	public double ItemPrice { get; set; }

	public string? ProductImagePath { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ClassButtonDetailsListResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public ICollection<ClassButtonResultResponseModel>? OrderClassButtonModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ClassButtonDetailsResponseModel
{
	public int CPOrderClassButtonId { get; set; }

	public string? ButtonText { get; set; }

	public int WhenOmsOrderStateId { get; set; }

	public int CPOrderClassId { get; set; }

	public int SetToOmsOrderStateId { get; set; }

	public int DisplayOrder { get; set; }

	public string? OrderStateName { get; set; }

	public int? ToClassId { get; set; }

	public string? ToClass { get; set; }

	public string? WhenStatusIs { get; set; }

	public string? SetStatusTo { get; set; }

	public ICollection<OrderClassModel>? OrderClassModels { get; set; }

	public ICollection<SelectListItem>? WhenOmsOrderStateIdList { get; set; }

	public ICollection<SelectListItem>? CPOrderClassIdList { get; set; }

	public ICollection<OrderClassButtonModel>? OrderClassButtonModels { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ClassButtonListResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ClassButtonDetailsListResponseModel ClassButtonDetailsListResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ClassButtonResponseModel
{
	public ClassButtonDetailsResponseModel ClassButtonDetailsResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ClassButtonResultResponseModel
{
	public int CPOrderClassButtonId { get; set; }

	public string? ButtonText { get; set; }

	public int WhenOmsOrderStateId { get; set; }

	public int CPOrderClassId { get; set; }

	public int SetToOmsOrderStateId { get; set; }

	public int DisplayOrder { get; set; }

	public string? OrderStateName { get; set; }

	public int? ToClassId { get; set; }

	public string? ToClass { get; set; }

	public string? WhenStatusIs { get; set; }

	public string? SetStatusTo { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ClassDetailsListResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public int CPOrderClassId { get; set; }

	public string? ClassCode { get; set; }

	public string? ClassName { get; set; }

	public int NextNumber { get; set; }

	public string? NumberFormat { get; set; }

	public string? DigitLength { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ClassDetailsResponseModel
{
	public int CPOrderClassId { get; set; }

	public string? ClassCode { get; set; }

	public string? ClassName { get; set; }

	public int NextNumber { get; set; }

	public string? NumberFormat { get; set; }

	public string? DigitLength { get; set; }

	public string? ProductAttribute { get; set; }

	public string? ParentProductAttribute { get; set; }

	public string? UserOrderType { get; set; }

	public string? ApproverOrderType { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ClassItemDetailsResponseModel
{
	public string? ItemId { get; set; }

	public string? ProductName { get; set; }

	public string? ProductDescription { get; set; }

	public ICollection<PersonalizedDetailResponseModel>? PersonalizedDetails { get; set; }

	public double Quantity { get; set; }

	public double UnitPrice { get; set; }

	public ICollection<AddOnSkuResponseModel>? AddOnSkuList { get; set; }

	public string? Sku { get; set; }

	public ICollection<ChildItemDetailsResponseModel>? ChildItemList { get; set; }

	public string? GroupCode { get; set; }

	public ICollection<AttributesResponseModel>? Attributes { get; set; }

	public CustomDataResponseModel CustomData { get; set; }

	public ICollection<ValidationsResponseModel>? ValidationDetails { get; set; }

	public ICollection<AdditionalCostResponseModel>? AdditionalCost { get; set; }

	public string? ProductImagePath { get; set; }

	public string? ProductType { get; set; }

	public string? SEOUrl { get; set; }

	public double ItemPrice { get; set; }

	public double TotalPrice { get; set; }

	public int ZnodeProductId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ClassItemListResponseModel
{
	public string? ClassNumber { get; set; }

	public ICollection<ClassItemDetailsResponseModel>? ItemList { get; set; }

	public string? ClassTypeCode { get; set; }

	public string? ClassName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ClassListResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<ClassDetailsListResponseModel>? ClassDetailsListResponseModels { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ClassNumberResponseModel
{
	public Guid Id { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ClassResponseModel
{
	public ClassDetailsResponseModel ClassDetailsResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CollectionDetailsResponseModel
{
	public double Quantity { get; set; }

	public DateTime CreatedDate { get; set; }

	public DateTime ModifiedDate { get; set; }

	public double Total { get; set; }

	public string? ClassNumber { get; set; }

	public DateTime ExpirationDate { get; set; }

	public string? ClassStatus { get; set; }

	public string? CustomerName { get; set; }

	public string? StoreName { get; set; }

	public string? PaymentStatus { get; set; }

	public string? PaymentName { get; set; }

	public string? SubTypeCode { get; set; }

	public string? ApplicationType { get; set; }

	public DateTime OrderDate { get; set; }

	public string? ClassName { get; set; }

	public string? CreatedByEmailId { get; set; }

	public string? PhoneNumber { get; set; }

	public double SubTotal { get; set; }

	public double TaxCost { get; set; }

	public double ShippingCost { get; set; }

	public string? BillingPostalCode { get; set; }

	public string? Origin { get; set; }

	public string? CreatedByName { get; set; }

	public string? ModifiedByName { get; set; }

	public string? OrderType { get; set; }

	public string? LinkedClassNumber { get; set; }

	public string? CultureCode { get; set; }

	public string? AccountCode { get; set; }

	public string? AccountName { get; set; }

	public int? CustomerId { get; set; }

	public int? CreatedByUserId { get; set; }

	public string? ExternalId { get; set; }

	public string? CurrencySuffix { get; set; }

	public string? CurrencyCode { get; set; }

	public double? RemainingOrderAmount { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CollectionResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public bool? HasParentAccounts { get; set; }

	public ICollection<CollectionDetailsResponseModel>? CollectionDetails { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CommerceCollectionClassDetailListResponseModel
{
	public ICollection<CommerceCollectionClassDetailResponseModel>? CommerceCollectionClassDetailList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CommerceCollectionClassDetailResponseModel
{
	public string? ClassTypeCode { get; set; }

	public string? ClassNumber { get; set; }

	public int? AccountId { get; set; }

	public string? Type { get; set; }

	public string? Origin { get; set; }

	public DateTime CreatedDate { get; set; }

	public string? ClassStateName { get; set; }

	public string? UserName { get; set; }

	public string? CreatedByUserName { get; set; }

	public string? StoreName { get; set; }

	public string? Total { get; set; }

	public string? CreatedByFullName { get; set; }

	public string? ModifiedByFullName { get; set; }

	public string? AssignToFullName { get; set; }

	public string? CultureCode { get; set; }

	public ICollection<LineItemDetailsResponseModel>? LineItemDetails { get; set; }

	public ShipmentDetailsResponseModel OrderShipments { get; set; }

	public ICollection<DiscountFactorResponse>? OrderDiscounts { get; set; }

	public ICollection<CostFactorResponse>? CostFactorResponse { get; set; }

	public ICollection<AddressDetailsResponseModel>? Address { get; set; }

	public DateTime ExpirationDate { get; set; }

	public string? PhoneNumber { get; set; }

	public DateTime? InHandDate { get; set; }

	public PaymentDetailsResponseModel PaymentDetails { get; set; }

	public AdditionalInstructionResponseModel AdditionalInstructions { get; set; }

	public int AssignToUserId { get; set; }

	public string? LinkedClassNumber { get; set; }

	public string? ConvertedClassNumber { get; set; }

	public CustomDataResponseModel CustomData { get; set; }

	public string? ExternalId { get; set; }

	public string? LocaleCode { get; set; }

	public string? PortalCode { get; set; }

	public string? PublishCatalogCode { get; set; }

	public string? PublishCatalogName { get; set; }

	public double? SubTotal { get; set; }

	public string? CurrencySuffix { get; set; }

	public string? CurrencyCode { get; set; }

	public string? StatusCode { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ConvertedClassResponseMode
{
	public string? ConvertedClassNumber { get; set; }

	public bool IsSuccess { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ConvertedToOrderResponseModel
{
	public bool IsSuccess { get; set; }

	public string? OrderNumber { get; set; }

	public string? OrderStatusCode { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CopiedClassResponseModel
{
	public string? CopiedClassNumber { get; set; }

	public bool IsSuccess { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CostFactorResponse
{
	public string? Name { get; set; }

	public string? Value { get; set; }

	public string? Description { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateClassButtonDetailsResponseModel
{
	public int CPOrderClassButtonId { get; set; }

	public string? ButtonText { get; set; }

	public int WhenOmsOrderStateId { get; set; }

	public int CPOrderClassId { get; set; }

	public int SetToOmsOrderStateId { get; set; }

	public int DisplayOrder { get; set; }

	public int? ToClassId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateClassButtonResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public CreateClassButtonDetailsResponseModel CreateClassButtonDetailsResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateLogsResponseModel
{
	public string? ClassNumber { get; set; }

	public bool IsSuccess { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateOrderFlagResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int CPOrderFlagId { get; set; }

	public string? FlagCode { get; set; }

	public string? NameUnchecked { get; set; }

	public string? NameChecked { get; set; }

	public bool IsCanOveride { get; set; }

	public string? NameOverridden { get; set; }

	public int? DisplayOrder { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateOrderTypeResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public OrderTypeResponseModel OrderTypeResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreatePaymentResponseModel
{
	public string? ClassNumber { get; set; }

	public bool IsSuccess { get; set; }

	public string? ErrorMessage { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateReturnResponseModel
{
	public string? ClassNumber { get; set; }

	public bool IsSuccess { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateStatusButtonResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int OmsOrderStateId { get; set; }

	public string? ButtonText { get; set; }

	public int? DisplayOrder { get; set; }

	public string? Status { get; set; }

	public string? RequiredPermission { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateStatusResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int OmsOrderStateId { get; set; }

	public string? OrderStateName { get; set; }

	public string? StatusCode { get; set; }

	public bool IsShowToCustomer { get; set; }

	public int DisplayOrder { get; set; }

	public bool IsEdit { get; set; }

	public bool IsSendEmail { get; set; }

	public bool IsOrderState { get; set; }

	public bool IsOrderLineItemState { get; set; }

	public string? CPBackColor { get; set; }

	public string? CPTextColor { get; set; }

	public bool IsCPRequireCompleteness { get; set; }

	public bool IsCPWorkingNotShipped { get; set; }

	public bool IsCPTimeLineOnlyIfActive { get; set; }

	public string? WillDisplayAs { get; set; }

	public bool IsCPTriggerFulfilledData { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateUserGroupResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public string? GroupCode { get; set; }

	public string? GroupName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomDataResponseModel
{
	public string? Custom1 { get; set; }

	public string? Custom2 { get; set; }

	public string? Custom3 { get; set; }

	public string? Custom4 { get; set; }

	public string? Custom5 { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DeleteResponseModel
{
	public bool IsSuccess { get; set; }

	public string? ClassNumber { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DiscountFactorResponse
{
	public string? Name { get; set; }

	public string? DiscountType { get; set; }

	public string? DiscountCode { get; set; }

	public string? IsApplied { get; set; }

	public string? IsValid { get; set; }

	public string? ExpiryDate { get; set; }

	public string? Message { get; set; }

	public double AppliedAmount { get; set; }

	public double TotalAmount { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DiscountStatusResponseModel
{
	public Guid DiscountId { get; set; }

	public bool IsSuccess { get; set; }

	public bool IsValid { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DiscountedDetailsResponseModel
{
	public DiscountStatusResponseModel DiscountStatus { get; set; }

	public CalculateSummeryResponseModel CalculatedDetails { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EmailSendResponseModel
{
	public string? ClassNumber { get; set; }

	public bool IsSendEmail { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class GenerateFinalizeNumberResponseModel
{
	public string? FinalClassNumber { get; set; }

	public string? ClassType { get; set; }

	public bool Status { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ItemLevelPermissionDetailsResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public bool IsEdit { get; set; }

	public bool IsView { get; set; }

	public bool IsDelete { get; set; }

	public bool IsDelegatedToMe { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ItemLevelPermissionResponseModel
{
	public ItemLevelPermissionDetailsResponseModel ItemLevelPermissions { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LineItemDetailsResponseModel
{
	public string? ItemId { get; set; }

	public string? ProductName { get; set; }

	public string? ProductDescription { get; set; }

	public ICollection<PersonalizedDetailResponseModel>? PersonalizedDetails { get; set; }

	public double Quantity { get; set; }

	public double UnitPrice { get; set; }

	public ICollection<AddOnSkuResponseModel>? AddOnSkuList { get; set; }

	public string? Sku { get; set; }

	public ICollection<ChildItemDetailsResponseModel>? ChildItemList { get; set; }

	public string? GroupCode { get; set; }

	public ICollection<AttributesResponseModel>? Attributes { get; set; }

	public CustomDataResponseModel CustomData { get; set; }

	public ICollection<ValidationsResponseModel>? ValidationDetails { get; set; }

	public ICollection<AdditionalCostResponseModel>? AdditionalCost { get; set; }

	public string? ProductImagePath { get; set; }

	public string? ProductType { get; set; }

	public string? SEOUrl { get; set; }

	public double ItemPrice { get; set; }

	public double TotalPrice { get; set; }

	public string? StatusCode { get; set; }

	public double? ShippingCost { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LineItemPriceResponseModel
{
	public string? Sku { get; set; }

	public double CartItemPrice { get; set; }

	public double TotalPrice { get; set; }

	public ICollection<PriceBySkuResponseModel>? PriceBySkuDetails { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LineItemsDetailResponseModel
{
	public Guid OrderId { get; set; }

	public Guid LineitemId { get; set; }

	public double Quantity { get; set; }

	public double? Price { get; set; }

	public int OmsOrderStateId { get; set; }

	public string? OrderStateName { get; set; }

	public string? ProductNote { get; set; }

	public int PortalId { get; set; }

	public int ZnodeCatalogId { get; set; }

	public int LocaleId { get; set; }

	public int PublishProductId { get; set; }

	public int ParentPublishProductId { get; set; }

	public string? ProductFlags { get; set; }

	public int VersionId { get; set; }

	public string? ProductDetails { get; set; }

	public bool IsNAAttributeAvailable { get; set; }

	public string? OrderDetail { get; set; }

	public ICollection<SkuStatusDetailsResponseModel>? SkuStatusList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LineItemsPriceDetailsResponseModel
{
	public string? SKU { get; set; }

	public double Quantity { get; set; }

	public double? Price { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LineItemsPriceMappingResponseModel
{
	public Guid? OrderId { get; set; }

	public string? LineitemId { get; set; }

	public double Price { get; set; }

	public double OldPrice { get; set; }

	public string? ProductNote { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LineItemsResetPriceResponseModel
{
	public ICollection<LineItemsPriceDetailsResponseModel>? OrderProductPriceDetailsResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LineItemsResponseModel
{
	public LineItemsDetailResponseModel OrderProductDetailResponse { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LineItemsStatusMappingResponseModel
{
	public Guid? OrderId { get; set; }

	public string? SKU { get; set; }

	public string? LineitemId { get; set; }

	public int OmsOrderStateId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MergeCartResponseModel
{
	public string? MergedCartNumber { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MultipleDeleteResponseModel
{
	public ICollection<DeleteResponseModel>? DeletedItems { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NotesDetailsResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<OrderLogCollectionDetailsModel>? Notes { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderAddressResponseModel
{
	public CPAddressResponseModel CPAddressModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderDetailsResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public Guid OrderId { get; set; }

	public int ClassId { get; set; }

	public string? ClassNumber { get; set; }

	public string? OrderDetail { get; set; }

	public int? AccountId { get; set; }

	public string? AccountName { get; set; }

	public int PortalId { get; set; }

	public string? OrderType { get; set; }

	public string? OrderOrigin { get; set; }

	public DateTime? OrderDate { get; set; }

	public string? OrderStateName { get; set; }

	public string? UserName { get; set; }

	public string? StoreName { get; set; }

	public string? OrderTotal { get; set; }

	public string? FullName { get; set; }

	public string? CreatedByFullName { get; set; }

	public string? ModifiedByFullName { get; set; }

	public string? AssignToFullName { get; set; }

	public string? OrderTypeName { get; set; }

	public int LocaleId { get; set; }

	public string? OrderPermission { get; set; }

	public string? CPBackColor { get; set; }

	public string? CPTextColor { get; set; }

	public int UserId { get; set; }

	public int OmsOrderStateId { get; set; }

	public string? PurchaseOrderNumber { get; set; }

	public string? UserFullName { get; set; }

	public string? Custom1 { get; set; }

	public string? Custom2 { get; set; }

	public string? Custom3 { get; set; }

	public string? Custom4 { get; set; }

	public string? Custom5 { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderFlagDetailsResponseModel
{
	public OrderFlagResponseModel OrderFlagResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderFlagListResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<OrderFlagResponseModel>? OrderFlagResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderFlagResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public int CPOrderFlagId { get; set; }

	public string? FlagCode { get; set; }

	public string? NameUnchecked { get; set; }

	public string? NameChecked { get; set; }

	public bool IsCanOveride { get; set; }

	public string? NameOverridden { get; set; }

	public int DisplayOrder { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderLineItemsResponseModel
{
	public Guid OrderId { get; set; }

	public int ClassId { get; set; }

	public string? ClassCode { get; set; }

	public string? ClassNumber { get; set; }

	public int OmsOrderStateId { get; set; }

	public int UserId { get; set; }

	public string? OrderDetail { get; set; }

	public int? AccountId { get; set; }

	public int PortalId { get; set; }

	public string? OrderType { get; set; }

	public string? OrderOrigin { get; set; }

	public DateTime? OrderDate { get; set; }

	public string? OrderStateName { get; set; }

	public string? UserName { get; set; }

	public string? StoreName { get; set; }

	public string? OrderTotal { get; set; }

	public string? CreatedByFullName { get; set; }

	public string? ModifiedByFullName { get; set; }

	public string? AssignToFullName { get; set; }

	public string? OrderTypeName { get; set; }

	public int LocaleId { get; set; }

	public string? UserFullName { get; set; }

	public string? OperatorAssignToFullName { get; set; }

	public string? OrderPermission { get; set; }

	public string? CultureCode { get; set; }

	public ICollection<SkuStatusDetailsResponseModel>? SkuStatusList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderLogFiltersListResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<OrderLogFiltersResponseModel>? OrderLogFilters { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderLogFiltersResponseModel
{
	public int OrderNotes { get; set; }

	public int OrderStatusChanges { get; set; }

	public int OwnerShipChanges { get; set; }

	public int FlagChanges { get; set; }

	public int PriceChanges { get; set; }

	public int AllChanges { get; set; }

	public int ViewAll { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderLogListResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<OrderLogResponseModel>? OrderLogs { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderLogResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public string? Note { get; set; }

	public string? TypeOfMapping { get; set; }

	public Guid OrderNoteId { get; set; }

	public string? CreatedByFullName { get; set; }

	public bool IsSystemDefine { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderOwnerDetailsResponseModel
{
	public OrderOwnerDetailsReturnResponseModel AssignTo { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderOwnerDetailsReturnResponseModel
{
	public OrderUserGroupListResponseModel UserGroupsList { get; set; }

	public string? AssignToFullName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderPaymentDiscountsResponseModel
{
	public Guid? OrderDiscountId { get; set; }

	public string? Code { get; set; }

	public string? Value { get; set; }

	public double Amount { get; set; }

	public bool? IsDeleted { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderPaymentResponseModel
{
	public Guid OrderAddressId { get; set; }

	public Guid? OrderId { get; set; }

	public int ClassId { get; set; }

	public ICollection<OrderPaymentDiscountsResponseModel>? DiscountData { get; set; }

	public int UserId { get; set; }

	public int AddressId { get; set; }

	public bool? IsTaxExemption { get; set; }

	public string? OrderDetail { get; set; }

	public string? PurchaseOrderNumber { get; set; }

	public ICollection<StatusResponseModel>? StatusModelList { get; set; }

	public string? CardNumber { get; set; }

	public int? Amount { get; set; }

	public DateTime ExpirationDate { get; set; }

	public string? PromoCode { get; set; }

	public int? Discount { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderProductCatalogProfileResponseModel
{
	public OrderProductCatalogProfileResultResponseModel OrderProductCatalogProfileResultResponse { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderProductCatalogProfileResultResponseModel
{
	public int CatalogId { get; set; }

	public int ProfileId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<OrderDetailsResponseModel>? OrderDetailsResponseModels { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderShipmentDetailsResponseModel
{
	public Guid? OrderId { get; set; }

	public int UserId { get; set; }

	public string? OrderDetail { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderShipmentResponseModel
{
	public OrderShipmentDetailsResponseModel OrderShipmentDetailsResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderStatusDetailResponseModel
{
	public OrderStatusDetailResultResponseModel OrderStatusDetailResultResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderStatusDetailResultResponseModel
{
	public int OmsOrderStateId { get; set; }

	public string? OrderStateName { get; set; }

	public bool IsCPTriggerFulfilledData { get; set; }

	public bool IsCPRequireCompleteness { get; set; }

	public bool IsEdit { get; set; }

	public bool IsOrderLineItemState { get; set; }

	public bool IsSendEmail { get; set; }

	public bool IsSystemDefined { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderTypeDetailResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public OrderTypeResponseModel OrderTypeResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderTypeListResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<OrderTypeResponseModel>? OrderTypeResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderTypeResponseModel
{
	public int CPOrderTypeId { get; set; }

	public string? TypeCode { get; set; }

	public string? TypeName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderUserGroupListResponseModel
{
	public ICollection<OrderUserGroupResponseModel>? OrderUserGroupResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderValidationMessageResponseModel
{
	public OrderValidationResultResponseModel OrderValidationMessageModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderValidationResultResponseModel
{
	public ICollection<string>? ValidationMessages { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PaymentDetailsResponseModel
{
	public string? PaymentSubTypeCode { get; set; }

	public string? ConfigurationSetCode { get; set; }

	public string? PaymentTransactionToken { get; set; }

	public string? PaymentStatusCode { get; set; }

	public string? PurchaseOrderNumber { get; set; }

	public string? PaymentName { get; set; }

	public string? PurchaseOrderDocumentFilePath { get; set; }

	public string? ExternalTransactionId { get; set; }

	public bool? IsBillingAddressOptional { get; set; }

	public double? RemainingOrderAmount { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PaymentHistoryResponseModel
{
	public ICollection<PaymentTransactionHistoryResponseModel>? PaymentHistory { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PaymentTransactionHistoryResponseModel
{
	public Guid OrderId { get; set; }

	public string? SubTypeDisplayName { get; set; }

	public string? ConfigurationSetCode { get; set; }

	public string? PaymentStatusName { get; set; }

	public double? RemainingOrderAmount { get; set; }

	public DateTime PaymentDate { get; set; }

	public double? PaidAmount { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PersonalizedDetailResponseModel
{
	public Guid PersonalizedId { get; set; }

	public string? Value { get; set; }

	public string? Code { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PriceBySkuResponseModel
{
	public double Price { get; set; }

	public string? Sku { get; set; }

	public ICollection<ValidationDetailsModel>? ValidationDetails { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class QuickViewDetailsResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public string? ActionMode { get; set; }

	public string? Custom1 { get; set; }

	public string? Custom2 { get; set; }

	public string? Custom3 { get; set; }

	public string? Custom4 { get; set; }

	public string? Custom5 { get; set; }

	public Guid OrderId { get; set; }

	public string? ClassCode { get; set; }

	public string? ClassNumber { get; set; }

	public int OmsOrderStateId { get; set; }

	public int UserId { get; set; }

	public string? OrderDetail { get; set; }

	public int PortalId { get; set; }

	public string? OrderType { get; set; }

	public string? OrderOrigin { get; set; }

	public DateTime? OrderDate { get; set; }

	public string? OrderStateName { get; set; }

	public string? UserName { get; set; }

	public string? StoreName { get; set; }

	public string? OrderTotal { get; set; }

	public string? FullName { get; set; }

	public string? CreatedByFullName { get; set; }

	public string? ModifiedByFullName { get; set; }

	public string? AssignToFullName { get; set; }

	public string? OrderTypeName { get; set; }

	public int LocaleId { get; set; }

	public int ClassId { get; set; }

	public string? AccountName { get; set; }

	public DateTime? FinalizedDate { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReorderResponseModel
{
	public string? OrderNumber { get; set; }

	public bool IsSuccess { get; set; }

	public string? NewClassNumber { get; set; }

	public string? ErrorMessage { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReturnCalculateLineItemSummaryResponseModel
{
	public string? OrderProductId { get; set; }

	public int ReasonForReturnId { get; set; }

	public string? ReasonForReturn { get; set; }

	public double ExpectedReturnQuantity { get; set; }

	public double UnitPrice { get; set; }

	public double TotalLineItemPrice { get; set; }

	public Guid OmsOrderLineItemId { get; set; }

	public string? ErrorMessage { get; set; }

	public bool HasError { get; set; }

	public double TaxCost { get; set; }

	public string? CultureCode { get; set; }

	public bool IsShippingReturn { get; set; }

	public double? ShippingCost { get; set; }

	public double? ReturnedQuantity { get; set; }

	public int RmaReturnLineItemsId { get; set; }

	public double PerQuantityLineItemDiscount { get; set; }

	public double PerQuantityCSRDiscount { get; set; }

	public double PerQuantityShippingDiscount { get; set; }

	public double PerQuantityShippingCost { get; set; }

	public double PerQuantityOrderLevelDiscountOnLineItem { get; set; }

	public int? PaymentStatusId { get; set; }

	public double PerQuantityVoucherAmount { get; set; }

	public int? ParentOmsOrderLineItemsId { get; set; }

	public double ImportDuty { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReturnCalculateSummaryResponseModel
{
	public Guid OrderId { get; set; }

	public int UserId { get; set; }

	public ICollection<ReturnCalculateLineItemSummaryResponseModel>? ReturnCalculateLineItem { get; set; }

	public double ReturnSubTotal { get; set; }

	public double ReturnTaxCost { get; set; }

	public double? ReturnShippingCost { get; set; }

	public string? CultureCode { get; set; }

	public bool IsAdminRequest { get; set; }

	public double Discount { get; set; }

	public double CSRDiscount { get; set; }

	public double ReturnShippingDiscount { get; set; }

	public double ReturnCharges { get; set; }

	public double VoucherAmount { get; set; }

	public double ReturnTotal { get; set; }

	public int PaymentStatusId { get; set; }

	public double ReturnImportDuty { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class RoleAndPermissionDetailsResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public int UserId { get; set; }

	public string? Object { get; set; }

	public string? PermissionCode { get; set; }

	public string? PermissionName { get; set; }

	public bool IsAllowed { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class RoleAndPermissionListResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<RoleAndPermissionDetailsResponseModel>? RoleAndPermissionList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SavedViewDetailsResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<SavedViewResultResponseModel>? SavedViewResultResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SavedViewResultResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public string? ListViewIds { get; set; }

	public int ListViewUserGroupId { get; set; }

	public int? ListViewId { get; set; }

	public int? UserGroupId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SelectedValueResponseModel
{
	public string? Value { get; set; }

	public string? Code { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ShipmentDetailsResponseModel
{
	public Guid OrderShipmentId { get; set; }

	public Guid OrderAddressId { get; set; }

	public int ShippingId { get; set; }

	public string? ShipDate { get; set; }

	public bool IsShipCompletely { get; set; }

	public string? ShippingConstraintCode { get; set; }

	public string? PhoneNumber { get; set; }

	public int AddressId { get; set; }

	public string? ShippingMethodName { get; set; }

	public string? TrackingNumber { get; set; }

	public string? InHandDate { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ShipmentResponseModel
{
	public string? ClassNumber { get; set; }

	public Guid OrderShipmentId { get; set; }

	public bool IsSuccess { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ShippingEstimatesResponseModel
{
	public string? Description { get; set; }

	public string? DestinationCountryCode { get; set; }

	public int DisplayOrder { get; set; }

	public string? EstimateDate { get; set; }

	public double HandlingCharge { get; set; }

	public string? HandlingChargeBasedOn { get; set; }

	public string? ImportedSkus { get; set; }

	public bool IsActive { get; set; }

	public bool IsExpedited { get; set; }

	public bool IsHandlingChargeInPercent { get; set; }

	public string? ShippingCode { get; set; }

	public double ShippingHandlingCharge { get; set; }

	public double ShippingDiscount { get; set; }

	public int ShippingId { get; set; }

	public string? ShippingName { get; set; }

	public double ShippingRateWithoutDiscount { get; set; }

	public int ShippingServiceCodeId { get; set; }

	public int ShippingTypeId { get; set; }

	public string? ShippingTypeName { get; set; }

	public string? ZipCode { get; set; }

	public string? StateCode { get; set; }

	public string? DeliveryTimeframe { get; set; }

	public string? CountyFIPS { get; set; }

	public string? ClassName { get; set; }

	public double? ShippingRate { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SkuStatusDetailsResponseModel
{
	public string? Sku { get; set; }

	public bool? Status { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StatusButtonDetailsResponseModel
{
	public StatusButtonResultResponseModel OrderStatusButtonModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StatusButtonDetailsResultResponseModel
{
	public string? RequiredPermission { get; set; }

	public string? TypeOfPermission { get; set; }

	public string? PermissionCode { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StatusButtonListResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<StatusButtonResultResponseModel>? StatusButtonList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StatusButtonResultDetailsResponseModel
{
	public ICollection<StatusButtonDetailsResultResponseModel>? OrderStatusButtonModel { get; set; }

	public ICollection<StatusDetailsResultResponseModel>? ManageOrdeStatusModel { get; set; }

	public ICollection<SelectListItem>? StatusList { get; set; }

	public ICollection<SelectListItem>? PermissionList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StatusButtonResultResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public int CPOrderStatusButtonId { get; set; }

	public int OmsOrderStateId { get; set; }

	public int? ButtonStatusId { get; set; }

	public string? ButtonText { get; set; }

	public int? DisplayOrder { get; set; }

	public string? RequiredPermission { get; set; }

	public string? TypeOfPermission { get; set; }

	public string? Status { get; set; }

	public ICollection<StatusButtonDetailsResultResponseModel>? OrderStatusButtonModel { get; set; }

	public ICollection<StatusDetailsResultResponseModel>? ManageOrdeStatusModel { get; set; }

	public ICollection<SelectListItem>? StatusList { get; set; }

	public ICollection<SelectListItem>? PermissionList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StatusClassListResponseModel
{
	public ZnodeErrorDetail ErrorDetail { get; set; }

	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<StatusClassResponseModel>? OrderClassList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StatusClassResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public int CPOrderClassId { get; set; }

	public string? ClassCode { get; set; }

	public string? ClassName { get; set; }

	public int NextNumber { get; set; }

	public string? NumberFormat { get; set; }

	public string? DigitLength { get; set; }

	public bool IsRequired { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StatusDetailsResponseModel
{
	public StatusResultDetailsResponseModel ZnodeOmsStatusModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StatusDetailsResultResponseModel
{
	public int OmsOrderStateId { get; set; }

	public string? OrderStateName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StatusListResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<StatusResultDetailsResponseModel>? StatusList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StatusResponseModel
{
	public StatusResultResponseModel StatusModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StatusResultDetailsResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public int OmsOrderStateId { get; set; }

	public string? OrderStateName { get; set; }

	public string? StatusCode { get; set; }

	public bool IsShowToCustomer { get; set; }

	public bool IsAccountStatus { get; set; }

	public int DisplayOrder { get; set; }

	public string? Description { get; set; }

	public bool IsEdit { get; set; }

	public bool IsSendEmail { get; set; }

	public bool IsOrderState { get; set; }

	public bool IsOrderLineItemState { get; set; }

	public bool IsQuoteState { get; set; }

	public string? CPBackColor { get; set; }

	public string? CPTextColor { get; set; }

	public bool IsCPRequireCompleteness { get; set; }

	public bool IsCPWorkingNotShipped { get; set; }

	public bool IsCPTimeLineOnlyIfActive { get; set; }

	public bool IsCPTriggerFulfilledData { get; set; }

	public bool IsSystemDefined { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StatusResultResponseModel
{
	public Guid Id { get; set; }

	public bool? Status { get; set; }

	public string? ClassNumber { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UnProcessOrderDetailsResponseModel
{
	public string? OrderDetailJson { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UnProcessedOrderListResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<UnProcessOrderDetailsResponseModel>? UnProcessedOrderDetails { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateBillingDetailsResponseModel
{
	public string? ClassNumber { get; set; }

	public bool IsSuccess { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateBulkItemQuantityResponseModel
{
	public string? ClassNumber { get; set; }

	public bool IsSuccess { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateClassButtonDetailsResponseModel
{
	public int CPOrderClassButtonId { get; set; }

	public string? ButtonText { get; set; }

	public int WhenOmsOrderStateId { get; set; }

	public int CPOrderClassId { get; set; }

	public int SetToOmsOrderStateId { get; set; }

	public int DisplayOrder { get; set; }

	public string? OrderStateName { get; set; }

	public int? ToClassId { get; set; }

	public string? ToClass { get; set; }

	public string? WhenStatusIs { get; set; }

	public string? SetStatusTo { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateClassButtonResponseModel
{
	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public UpdateClassButtonDetailsResponseModel UpdateClassButtonUpdateResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateClassDetailsReponseModel
{
	public int CPOrderClassId { get; set; }

	public string? ClassCode { get; set; }

	public string? ClassName { get; set; }

	public int NextNumber { get; set; }

	public string? NumberFormat { get; set; }

	public string? DigitLength { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateClassDetailsResponseModel
{
	public string? ClassNumber { get; set; }

	public bool IsSuccess { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateClassResponseModel
{
	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public UpdateClassDetailsReponseModel UpdateClassDetailsReponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateClassStatusResponseModel
{
	public string? ClassNumber { get; set; }

	public bool IsSuccess { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateEntityResponseModel
{
	public string? ClassNumber { get; set; }

	public bool IsSuccess { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateItemQuantityResponseModel
{
	public string? ClassNumber { get; set; }

	public Guid ItemId { get; set; }

	public bool IsSuccess { get; set; }

	public double Quantity { get; set; }

	public ICollection<ValidationDetailsModel>? ValidationDetails { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateLineItemStatusResponseModel
{
	public string? ClassNumber { get; set; }

	public bool IsSuccess { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateLineItemsPriceResponseModel
{
	public LineItemsPriceMappingResponseModel OrderProductPriceMappingResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateLineItemsStatusResponseModel
{
	public LineItemsStatusMappingResponseModel OrderProductStatusMappingResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateOrderFlagResponseModel
{
	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public int CPOrderFlagId { get; set; }

	public string? FlagCode { get; set; }

	public string? NameUnchecked { get; set; }

	public string? NameChecked { get; set; }

	public bool IsCanOveride { get; set; }

	public string? NameOverridden { get; set; }

	public int? DisplayOrder { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateOrderFlagStatusDetailsResponseModel
{
	public bool IsSuccess { get; set; }

	public bool IsAllowFlagOverride { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateOrderFlagStatusResponseModel
{
	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public UpdateOrderFlagStatusDetailsResponseModel UpdateOrderFlagStatusDetailsResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateOrderPaymentResponseModel
{
	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public OrderPaymentResponseModel OrderPaymentModel { get; set; }

	public ICollection<StatusResultResponseModel>? StatusResultResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateOrderTemplateResponseModel
{
	public string? OrderTemplateNumber { get; set; }

	public bool IsSuccess { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateOrderTypeResponseModel
{
	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public OrderTypeResponseModel OrderTypeResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateQuantityMappingResponseModel
{
	public double Quantity { get; set; }

	public string? SKU { get; set; }

	public double? Price { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateQuantityResponseModel
{
	public ICollection<UpdateQuantityMappingResponseModel>? UpdateQuantityMappingResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateStatusButtonResponseModel
{
	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public int CPOrderStatusButtonId { get; set; }

	public int OmsOrderStateId { get; set; }

	public string? ButtonText { get; set; }

	public int? DisplayOrder { get; set; }

	public string? Status { get; set; }

	public string? RequiredPermission { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateStatusResponseModel
{
	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public int ZnodeOmsStatusModel { get; set; }

	public string? OrderStateName { get; set; }

	public string? StatusCode { get; set; }

	public bool IsShowToCustomer { get; set; }

	public int DisplayOrder { get; set; }

	public bool IsEdit { get; set; }

	public bool IsSendEmail { get; set; }

	public bool IsOrderState { get; set; }

	public bool IsOrderLineItemState { get; set; }

	public string? CPBackColor { get; set; }

	public string? CPTextColor { get; set; }

	public bool IsCPRequireCompleteness { get; set; }

	public bool IsCPWorkingNotShipped { get; set; }

	public bool IsCPTimeLineOnlyIfActive { get; set; }

	public string? WillDisplayAs { get; set; }

	public bool IsCPTriggerFulfilledData { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateUserGroupResponseModel
{
	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public int CPUserGroupId { get; set; }

	public string? GroupCode { get; set; }

	public string? GroupName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateUserInGroupResponseModel
{
	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public int CPUserGroupId { get; set; }

	public int CPUsersInGroupId { get; set; }

	public int UserId { get; set; }

	public int Priority { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UserGroupDetailsForFlagResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public int CPUserGroupId { get; set; }

	public string? GroupCode { get; set; }

	public string? GroupName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UserGroupDetailsForUsersResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public int CPUserGroupId { get; set; }

	public int CPUsersInGroupId { get; set; }

	public int UserId { get; set; }

	public string? GroupCode { get; set; }

	public string? GroupName { get; set; }

	public int Priority { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UserGroupDetailsListResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<UserGroupResponseModel>? UserGroupList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UserGroupListForFlagResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<UserGroupDetailsForFlagResponseModel>? UserGroupList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UserGroupListForUsersResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<UserGroupDetailsForUsersResponseModel>? UserGroupList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UserGroupListResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<UserGroupResponseModel>? UserGroupResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UserGroupResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public int CPUserGroupId { get; set; }

	public string? GroupCode { get; set; }

	public string? GroupName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UserProfileCpRoleListResponseModel
{
	public ICollection<UserProfileResponseModel>? CpUsersRole { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UserProfileResponseModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public int UserId { get; set; }

	public string? UserName { get; set; }

	public string? FullName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UsersInMyTeamListResponseModel
{
	public ICollection<UsersInMyTeamResponseModel>? UsersInMyTeamResponseModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UsersInMyTeamResponseModel
{
	public int UserId { get; set; }

	public string? UserName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ValidationResponseModel
{
	public ICollection<ValidationsResponseModel>? ValidationDetails { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ValidationsResponseModel
{
	public int ErrorCode { get; set; }

	public string? ErrorMessage { get; set; }

	public int Priority { get; set; }

	public string? SKU { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomDataBooleanResponse
{
	public bool IsSuccess { get; set; }

	public string? SuccessMessage { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderUserGroupResponseModel
{
	public Guid? OrderUserGroupId { get; set; }

	public int CPUserGroupId { get; set; }

	public string? GroupName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderValidationMessageResponse
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public string? ActionMode { get; set; }

	public string? Custom1 { get; set; }

	public string? Custom2 { get; set; }

	public string? Custom3 { get; set; }

	public string? Custom4 { get; set; }

	public string? Custom5 { get; set; }

	public int? ErrorCode { get; set; }

	public string? ErrorMessage { get; set; }

	public bool HasError { get; set; }

	public IDictionary<string, string>? CustomModelState { get; set; }

	public IDictionary<string, string>? ErrorDetailList { get; set; }

	public OrderValidationMessageModel OrderValidationMessageModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StateListResponseModel
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<StateResponseModel>? StatusList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StateResponseModel
{
	public string? StatusName { get; set; }

	public string? Description { get; set; }

	public bool IsEdit { get; set; }

	public string? StatusCode { get; set; }

	public int StatusId { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReturnCalculateRequestModel
{
	[Required]
	public string ClassNumber { get; set; }

	public int UserId { get; set; }

	public ICollection<ReturnCalculateLineItemRequestModel>? ReturnCalculateLineItem { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ValidationDetailsModel
{
	public int ErrorCode { get; set; }

	public string? ErrorMessage { get; set; }

	public int Priority { get; set; }

	public string? Sku { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class VoucherDetailsEngineModel
{
	public string? DiscountType { get; set; }

	public string? VoucherMessage { get; set; }

	public string? VoucherNumber { get; set; }

	public bool IsVoucherValid { get; set; }

	public DateTime? ExpirationDate { get; set; }

	public bool IsVoucherApplied { get; set; }

	public string? VoucherName { get; set; }

	public double VoucherAmountApplied { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class QuickOrderCartResponse
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public string? ActionMode { get; set; }

	public string? Custom1 { get; set; }

	public string? Custom2 { get; set; }

	public string? Custom3 { get; set; }

	public string? Custom4 { get; set; }

	public string? Custom5 { get; set; }

	public int? ErrorCode { get; set; }

	public string? ErrorMessage { get; set; }

	public bool HasError { get; set; }

	public IDictionary<string, string>? CustomModelState { get; set; }

	public IDictionary<string, string>? ErrorDetailList { get; set; }

	public ICollection<QuickOrderCartModel>? QuickOrderCartItems { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ZnodeErrorDetail
{
	public int? ErrorCode { get; set; }

	public string? ErrorMessage { get; set; }

	public bool HasError { get; set; }

	public HttpStatusCode StatusCode { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ZnodePaginationDetail
{
	public int? PageIndex { get; set; }

	public int? PageSize { get; set; }

	public int? TotalPages { get; set; }

	public int? TotalResults { get; set; }
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IAddressesClient : IBaseClient
{
	[Obsolete]
	Task<OrderAddressResponseModel> GetAddressesByAddressIdAsync(int addressId);

	[Obsolete]
	OrderAddressResponseModel GetAddressesByAddressId(int addressId);

	[Obsolete]
	Task<OrderAddressResponseModel> GetAddressesByAddressIdAsync(int addressId, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AddressesClient : BaseClient, IAddressesClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public AddressesClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<OrderAddressResponseModel> GetAddressesByAddressIdAsync(int addressId)
	{
		return GetAddressesByAddressIdAsync(addressId, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderAddressResponseModel GetAddressesByAddressId(int addressId)
	{
		return Task.Run(async () => await GetAddressesByAddressIdAsync(addressId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderAddressResponseModel> GetAddressesByAddressIdAsync(int addressId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/addresses/{addressId}";
		znodeApiGateway = znodeApiGateway.Replace("{addressId}", Uri.EscapeDataString(ConvertToString(addressId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderAddressResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderAddressResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderAddressResponseModel orderAddressResponseModel = JsonConvert.DeserializeObject<OrderAddressResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderAddressResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IApprovalRoutingsClient : IBaseClient
{
	Task<ApproversResponseModel> GetApproverListByClassNumberAsync(string classNumber, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	ApproversResponseModel GetApproverListByClassNumber(string classNumber, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	Task<ApproversResponseModel> GetApproverListByClassNumberAsync(string classNumber, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ApprovalRoutingsClient : BaseClient, IApprovalRoutingsClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public ApprovalRoutingsClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	public virtual Task<ApproversResponseModel> GetApproverListByClassNumberAsync(string classNumber, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetApproverListByClassNumberAsync(classNumber, filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	public virtual ApproversResponseModel GetApproverListByClassNumber(string classNumber, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetApproverListByClassNumberAsync(classNumber, filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<ApproversResponseModel> GetApproverListByClassNumberAsync(string classNumber, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/approvalroutings/approver-list/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ApproversResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ApproversResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ApproversResponseModel approversResponseModel = JsonConvert.DeserializeObject<ApproversResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)approversResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface ICalculateClient : IBaseClient
{
	[Obsolete]
	Task<CalculateResponseModel> GetCalculateByOrderIdAsync(Guid orderId, IEnumerable<string> expand);

	[Obsolete]
	CalculateResponseModel GetCalculateByOrderId(Guid orderId, IEnumerable<string> expand);

	[Obsolete]
	Task<CalculateResponseModel> GetCalculateByOrderIdAsync(Guid orderId, IEnumerable<string> expand, CancellationToken cancellationToken);

	Task<DiscountedDetailsResponseModel> PostApplyDiscountByClassNumberAsync(string classNumber, IEnumerable<string> expand, DiscountRequestModel body);

	DiscountedDetailsResponseModel PostApplyDiscountByClassNumber(string classNumber, IEnumerable<string> expand, DiscountRequestModel body);

	Task<DiscountedDetailsResponseModel> PostApplyDiscountByClassNumberAsync(string classNumber, IEnumerable<string> expand, DiscountRequestModel body, CancellationToken cancellationToken);

	Task<DiscountedDetailsResponseModel> DeleteRemoveDiscountByClassNumberAsync(string classNumber, IEnumerable<string> expand, DiscountRequestModel body);

	DiscountedDetailsResponseModel DeleteRemoveDiscountByClassNumber(string classNumber, IEnumerable<string> expand, DiscountRequestModel body);

	Task<DiscountedDetailsResponseModel> DeleteRemoveDiscountByClassNumberAsync(string classNumber, IEnumerable<string> expand, DiscountRequestModel body, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CalculateClient : BaseClient, ICalculateClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public CalculateClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<CalculateResponseModel> GetCalculateByOrderIdAsync(Guid orderId, IEnumerable<string> expand)
	{
		return GetCalculateByOrderIdAsync(orderId, expand, CancellationToken.None);
	}

	[Obsolete]
	public virtual CalculateResponseModel GetCalculateByOrderId(Guid orderId, IEnumerable<string> expand)
	{
		return Task.Run(async () => await GetCalculateByOrderIdAsync(orderId, expand, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<CalculateResponseModel> GetCalculateByOrderIdAsync(Guid orderId, IEnumerable<string> expand, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/calculate/{orderId}";
		znodeApiGateway = znodeApiGateway.Replace("{orderId}", Uri.EscapeDataString(ConvertToString(orderId, CultureInfo.InvariantCulture)));
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString(expand, (IEnumerable<FilterTuple>)null, (IDictionary<string, string>)null, (int?)null, (int?)null, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CalculateResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CalculateResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CalculateResponseModel calculateResponseModel = JsonConvert.DeserializeObject<CalculateResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)calculateResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<DiscountedDetailsResponseModel> PostApplyDiscountByClassNumberAsync(string classNumber, IEnumerable<string> expand, DiscountRequestModel body)
	{
		return PostApplyDiscountByClassNumberAsync(classNumber, expand, body, CancellationToken.None);
	}

	public virtual DiscountedDetailsResponseModel PostApplyDiscountByClassNumber(string classNumber, IEnumerable<string> expand, DiscountRequestModel body)
	{
		return Task.Run(async () => await PostApplyDiscountByClassNumberAsync(classNumber, expand, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<DiscountedDetailsResponseModel> PostApplyDiscountByClassNumberAsync(string classNumber, IEnumerable<string> expand, DiscountRequestModel body, CancellationToken cancellationToken)
	{
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/calculate/apply-discount/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<DiscountedDetailsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<DiscountedDetailsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new DiscountedDetailsResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				DiscountedDetailsResponseModel discountedDetailsResponseModel = JsonConvert.DeserializeObject<DiscountedDetailsResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)discountedDetailsResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<DiscountedDetailsResponseModel> DeleteRemoveDiscountByClassNumberAsync(string classNumber, IEnumerable<string> expand, DiscountRequestModel body)
	{
		return DeleteRemoveDiscountByClassNumberAsync(classNumber, expand, body, CancellationToken.None);
	}

	public virtual DiscountedDetailsResponseModel DeleteRemoveDiscountByClassNumber(string classNumber, IEnumerable<string> expand, DiscountRequestModel body)
	{
		return Task.Run(async () => await DeleteRemoveDiscountByClassNumberAsync(classNumber, expand, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<DiscountedDetailsResponseModel> DeleteRemoveDiscountByClassNumberAsync(string classNumber, IEnumerable<string> expand, DiscountRequestModel body, CancellationToken cancellationToken)
	{
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/calculate/remove-discount/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString(expand, (IEnumerable<FilterTuple>)null, (IDictionary<string, string>)null, (int?)null, (int?)null, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<DiscountedDetailsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<DiscountedDetailsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new DiscountedDetailsResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				DiscountedDetailsResponseModel discountedDetailsResponseModel = JsonConvert.DeserializeObject<DiscountedDetailsResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)discountedDetailsResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface ICartsClient : IBaseClient
{
	Task<CartListResponseModel> GetCartItemListByClassTypeAsync(string classType, string cartNumber);

	CartListResponseModel GetCartItemListByClassType(string classType, string cartNumber);

	Task<CartListResponseModel> GetCartItemListByClassTypeAsync(string classType, string cartNumber, CancellationToken cancellationToken);

	Task<AddToCartResponseModel> PostAddToCartAsync(AddToCartRequestModel body);

	AddToCartResponseModel PostAddToCart(AddToCartRequestModel body);

	Task<AddToCartResponseModel> PostAddToCartAsync(AddToCartRequestModel body, CancellationToken cancellationToken);

	Task<CartCountResponseModel> GetCountByClassTypeAsync(string classType, string cartNumber);

	CartCountResponseModel GetCountByClassType(string classType, string cartNumber);

	Task<CartCountResponseModel> GetCountByClassTypeAsync(string classType, string cartNumber, CancellationToken cancellationToken);

	Task<MergeCartResponseModel> PostMergeCartAsync(MergeCartRequestModel body);

	MergeCartResponseModel PostMergeCart(MergeCartRequestModel body);

	Task<MergeCartResponseModel> PostMergeCartAsync(MergeCartRequestModel body, CancellationToken cancellationToken);

	Task<CalculateSummeryResponseModel> GetCalculateCartByCartNumberAsync(string cartNumber, IEnumerable<string> expand);

	CalculateSummeryResponseModel GetCalculateCartByCartNumber(string cartNumber, IEnumerable<string> expand);

	Task<CalculateSummeryResponseModel> GetCalculateCartByCartNumberAsync(string cartNumber, IEnumerable<string> expand, CancellationToken cancellationToken);

	Task<ShippingEstimatesResponseModel> GetShippingEstimatesByClassTypeAsync(string classType, string cartNumber, string postalCode);

	ShippingEstimatesResponseModel GetShippingEstimatesByClassType(string classType, string cartNumber, string postalCode);

	Task<ShippingEstimatesResponseModel> GetShippingEstimatesByClassTypeAsync(string classType, string cartNumber, string postalCode, CancellationToken cancellationToken);

	[Obsolete]
	Task<ShippingEstimatesResponseModel> GetShippingEstimatesByClassTypeAsync(string classType, string cartNumber, string postalCode, int addressId);

	[Obsolete]
	ShippingEstimatesResponseModel GetShippingEstimatesByClassType(string classType, string cartNumber, string postalCode, int addressId);

	[Obsolete]
	Task<ShippingEstimatesResponseModel> GetShippingEstimatesByClassTypeAsync(string classType, string cartNumber, string postalCode, int addressId, CancellationToken cancellationToken);

	Task<PriceBySkuResponseModel> GetPriceBySkuAsync(string sku, double quantity);

	PriceBySkuResponseModel GetPriceBySku(string sku, double quantity);

	Task<PriceBySkuResponseModel> GetPriceBySkuAsync(string sku, double quantity, CancellationToken cancellationToken);

	Task<CartValidationResponseModel> GetValidateCartByCartNumberAsync(string cartNumber);

	CartValidationResponseModel GetValidateCartByCartNumber(string cartNumber);

	Task<CartValidationResponseModel> GetValidateCartByCartNumberAsync(string cartNumber, CancellationToken cancellationToken);

	Task<LineItemPriceResponseModel> GetItemPriceByClassTypeAsync(string classType, string classNumber, string sku);

	LineItemPriceResponseModel GetItemPriceByClassType(string classType, string classNumber, string sku);

	Task<LineItemPriceResponseModel> GetItemPriceByClassTypeAsync(string classType, string classNumber, string sku, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CartsClient : BaseClient, ICartsClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public CartsClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	public virtual Task<CartListResponseModel> GetCartItemListByClassTypeAsync(string classType, string cartNumber)
	{
		return GetCartItemListByClassTypeAsync(classType, cartNumber, CancellationToken.None);
	}

	public virtual CartListResponseModel GetCartItemListByClassType(string classType, string cartNumber)
	{
		return Task.Run(async () => await GetCartItemListByClassTypeAsync(classType, cartNumber, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CartListResponseModel> GetCartItemListByClassTypeAsync(string classType, string cartNumber, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (cartNumber == null)
		{
			throw new ArgumentNullException("cartNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/cart-item-list/{cartNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{cartNumber}", Uri.EscapeDataString(ConvertToString(cartNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CartListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CartListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CartListResponseModel cartListResponseModel = JsonConvert.DeserializeObject<CartListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)cartListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<AddToCartResponseModel> PostAddToCartAsync(AddToCartRequestModel body)
	{
		return PostAddToCartAsync(body, CancellationToken.None);
	}

	public virtual AddToCartResponseModel PostAddToCart(AddToCartRequestModel body)
	{
		return Task.Run(async () => await PostAddToCartAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<AddToCartResponseModel> PostAddToCartAsync(AddToCartRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/carts/add-to-cart";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<AddToCartResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<AddToCartResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new AddToCartResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				AddToCartResponseModel addToCartResponseModel = JsonConvert.DeserializeObject<AddToCartResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)addToCartResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<CartCountResponseModel> GetCountByClassTypeAsync(string classType, string cartNumber)
	{
		return GetCountByClassTypeAsync(classType, cartNumber, CancellationToken.None);
	}

	public virtual CartCountResponseModel GetCountByClassType(string classType, string cartNumber)
	{
		return Task.Run(async () => await GetCountByClassTypeAsync(classType, cartNumber, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CartCountResponseModel> GetCountByClassTypeAsync(string classType, string cartNumber, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (cartNumber == null)
		{
			throw new ArgumentNullException("cartNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/count/{cartNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{cartNumber}", Uri.EscapeDataString(ConvertToString(cartNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CartCountResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CartCountResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CartCountResponseModel cartCountResponseModel = JsonConvert.DeserializeObject<CartCountResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)cartCountResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<MergeCartResponseModel> PostMergeCartAsync(MergeCartRequestModel body)
	{
		return PostMergeCartAsync(body, CancellationToken.None);
	}

	public virtual MergeCartResponseModel PostMergeCart(MergeCartRequestModel body)
	{
		return Task.Run(async () => await PostMergeCartAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<MergeCartResponseModel> PostMergeCartAsync(MergeCartRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/carts/merge-cart";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<MergeCartResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<MergeCartResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new MergeCartResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				MergeCartResponseModel mergeCartResponseModel = JsonConvert.DeserializeObject<MergeCartResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)mergeCartResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<CalculateSummeryResponseModel> GetCalculateCartByCartNumberAsync(string cartNumber, IEnumerable<string> expand)
	{
		return GetCalculateCartByCartNumberAsync(cartNumber, expand, CancellationToken.None);
	}

	public virtual CalculateSummeryResponseModel GetCalculateCartByCartNumber(string cartNumber, IEnumerable<string> expand)
	{
		return Task.Run(async () => await GetCalculateCartByCartNumberAsync(cartNumber, expand, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CalculateSummeryResponseModel> GetCalculateCartByCartNumberAsync(string cartNumber, IEnumerable<string> expand, CancellationToken cancellationToken)
	{
		if (cartNumber == null)
		{
			throw new ArgumentNullException("cartNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/carts/calculate-cart/{cartNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{cartNumber}", Uri.EscapeDataString(ConvertToString(cartNumber, CultureInfo.InvariantCulture)));
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString(expand, (IEnumerable<FilterTuple>)null, (IDictionary<string, string>)null, (int?)null, (int?)null, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CalculateSummeryResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CalculateSummeryResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CalculateSummeryResponseModel calculateSummeryResponseModel = JsonConvert.DeserializeObject<CalculateSummeryResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)calculateSummeryResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<ShippingEstimatesResponseModel> GetShippingEstimatesByClassTypeAsync(string classType, string cartNumber, string postalCode)
	{
		return GetShippingEstimatesByClassTypeAsync(classType, cartNumber, postalCode, CancellationToken.None);
	}

	public virtual ShippingEstimatesResponseModel GetShippingEstimatesByClassType(string classType, string cartNumber, string postalCode)
	{
		return Task.Run(async () => await GetShippingEstimatesByClassTypeAsync(classType, cartNumber, postalCode, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<ShippingEstimatesResponseModel> GetShippingEstimatesByClassTypeAsync(string classType, string cartNumber, string postalCode, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (cartNumber == null)
		{
			throw new ArgumentNullException("cartNumber");
		}
		if (postalCode == null)
		{
			throw new ArgumentNullException("postalCode");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/shipping-estimates/{cartNumber}/{postalCode}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{cartNumber}", Uri.EscapeDataString(ConvertToString(cartNumber, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{postalCode}", Uri.EscapeDataString(ConvertToString(postalCode, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ShippingEstimatesResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ShippingEstimatesResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ShippingEstimatesResponseModel shippingEstimatesResponseModel = JsonConvert.DeserializeObject<ShippingEstimatesResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)shippingEstimatesResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<ShippingEstimatesResponseModel> GetShippingEstimatesByClassTypeAsync(string classType, string cartNumber, string postalCode, int addressId)
	{
		return GetShippingEstimatesByClassTypeAsync(classType, cartNumber, postalCode, addressId, CancellationToken.None);
	}

	[Obsolete]
	public virtual ShippingEstimatesResponseModel GetShippingEstimatesByClassType(string classType, string cartNumber, string postalCode, int addressId)
	{
		return Task.Run(async () => await GetShippingEstimatesByClassTypeAsync(classType, cartNumber, postalCode, addressId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<ShippingEstimatesResponseModel> GetShippingEstimatesByClassTypeAsync(string classType, string cartNumber, string postalCode, int addressId, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (cartNumber == null)
		{
			throw new ArgumentNullException("cartNumber");
		}
		if (postalCode == null)
		{
			throw new ArgumentNullException("postalCode");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/shipping-estimates/{cartNumber}/{postalCode}/{addressId}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{cartNumber}", Uri.EscapeDataString(ConvertToString(cartNumber, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{postalCode}", Uri.EscapeDataString(ConvertToString(postalCode, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{addressId}", Uri.EscapeDataString(ConvertToString(addressId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ShippingEstimatesResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ShippingEstimatesResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ShippingEstimatesResponseModel shippingEstimatesResponseModel = JsonConvert.DeserializeObject<ShippingEstimatesResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)shippingEstimatesResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<PriceBySkuResponseModel> GetPriceBySkuAsync(string sku, double quantity)
	{
		return GetPriceBySkuAsync(sku, quantity, CancellationToken.None);
	}

	public virtual PriceBySkuResponseModel GetPriceBySku(string sku, double quantity)
	{
		return Task.Run(async () => await GetPriceBySkuAsync(sku, quantity, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<PriceBySkuResponseModel> GetPriceBySkuAsync(string sku, double quantity, CancellationToken cancellationToken)
	{
		if (sku == null)
		{
			throw new ArgumentNullException("sku");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/carts/price/{sku}/{quantity}";
		znodeApiGateway = znodeApiGateway.Replace("{sku}", Uri.EscapeDataString(ConvertToString(sku, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{quantity}", Uri.EscapeDataString(ConvertToString(quantity, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<PriceBySkuResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<PriceBySkuResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new PriceBySkuResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				PriceBySkuResponseModel priceBySkuResponseModel = JsonConvert.DeserializeObject<PriceBySkuResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)priceBySkuResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<CartValidationResponseModel> GetValidateCartByCartNumberAsync(string cartNumber)
	{
		return GetValidateCartByCartNumberAsync(cartNumber, CancellationToken.None);
	}

	public virtual CartValidationResponseModel GetValidateCartByCartNumber(string cartNumber)
	{
		return Task.Run(async () => await GetValidateCartByCartNumberAsync(cartNumber, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CartValidationResponseModel> GetValidateCartByCartNumberAsync(string cartNumber, CancellationToken cancellationToken)
	{
		if (cartNumber == null)
		{
			throw new ArgumentNullException("cartNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/carts/validate-cart/{cartNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{cartNumber}", Uri.EscapeDataString(ConvertToString(cartNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CartValidationResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CartValidationResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CartValidationResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CartValidationResponseModel cartValidationResponseModel = JsonConvert.DeserializeObject<CartValidationResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)cartValidationResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<LineItemPriceResponseModel> GetItemPriceByClassTypeAsync(string classType, string classNumber, string sku)
	{
		return GetItemPriceByClassTypeAsync(classType, classNumber, sku, CancellationToken.None);
	}

	public virtual LineItemPriceResponseModel GetItemPriceByClassType(string classType, string classNumber, string sku)
	{
		return Task.Run(async () => await GetItemPriceByClassTypeAsync(classType, classNumber, sku, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<LineItemPriceResponseModel> GetItemPriceByClassTypeAsync(string classType, string classNumber, string sku, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		if (sku == null)
		{
			throw new ArgumentNullException("sku");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/item-price/{classNumber}/{sku}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{sku}", Uri.EscapeDataString(ConvertToString(sku, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<LineItemPriceResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new LineItemPriceResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				LineItemPriceResponseModel lineItemPriceResponseModel = JsonConvert.DeserializeObject<LineItemPriceResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)lineItemPriceResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IClassChangeButtonsClient : IBaseClient
{
	[Obsolete]
	Task<ClassButtonListResponseModel> GetListByCpOrderClassIdAsync(int cpOrderClassId, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	ClassButtonListResponseModel GetListByCpOrderClassId(int cpOrderClassId, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<ClassButtonListResponseModel> GetListByCpOrderClassIdAsync(int cpOrderClassId, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<CreateClassButtonResponseModel> PostCreateAsync(CreateClassRequestModel body);

	[Obsolete]
	CreateClassButtonResponseModel PostCreate(CreateClassRequestModel body);

	[Obsolete]
	Task<CreateClassButtonResponseModel> PostCreateAsync(CreateClassRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<UpdateClassButtonResponseModel> PutUpdateAsync(UpdateClassButtonRequestModel body);

	[Obsolete]
	UpdateClassButtonResponseModel PutUpdate(UpdateClassButtonRequestModel body);

	[Obsolete]
	Task<UpdateClassButtonResponseModel> PutUpdateAsync(UpdateClassButtonRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<ClassButtonResponseModel> GetChangebuttonByOrderClassButtonIdAsync(int orderClassButtonId);

	[Obsolete]
	ClassButtonResponseModel GetChangebuttonByOrderClassButtonId(int orderClassButtonId);

	[Obsolete]
	Task<ClassButtonResponseModel> GetChangebuttonByOrderClassButtonIdAsync(int orderClassButtonId, CancellationToken cancellationToken);

	[Obsolete]
	Task<ClassButtonResponseModel> GetClassbuttonByOrderClassButtonIdAsync(int orderClassButtonId);

	[Obsolete]
	ClassButtonResponseModel GetClassbuttonByOrderClassButtonId(int orderClassButtonId);

	[Obsolete]
	Task<ClassButtonResponseModel> GetClassbuttonByOrderClassButtonIdAsync(int orderClassButtonId, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ClassChangeButtonsClient : BaseClient, IClassChangeButtonsClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public ClassChangeButtonsClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<ClassButtonListResponseModel> GetListByCpOrderClassIdAsync(int cpOrderClassId, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetListByCpOrderClassIdAsync(cpOrderClassId, filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual ClassButtonListResponseModel GetListByCpOrderClassId(int cpOrderClassId, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetListByCpOrderClassIdAsync(cpOrderClassId, filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<ClassButtonListResponseModel> GetListByCpOrderClassIdAsync(int cpOrderClassId, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/classchangebuttons/list/{cpOrderClassId}";
		znodeApiGateway = znodeApiGateway.Replace("{cpOrderClassId}", Uri.EscapeDataString(ConvertToString(cpOrderClassId, CultureInfo.InvariantCulture)));
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ClassButtonListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ClassButtonListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ClassButtonListResponseModel classButtonListResponseModel = JsonConvert.DeserializeObject<ClassButtonListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)classButtonListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<CreateClassButtonResponseModel> PostCreateAsync(CreateClassRequestModel body)
	{
		return PostCreateAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual CreateClassButtonResponseModel PostCreate(CreateClassRequestModel body)
	{
		return Task.Run(async () => await PostCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<CreateClassButtonResponseModel> PostCreateAsync(CreateClassRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/classchangebuttons/create";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CreateClassButtonResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CreateClassButtonResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CreateClassButtonResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CreateClassButtonResponseModel createClassButtonResponseModel = JsonConvert.DeserializeObject<CreateClassButtonResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)createClassButtonResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UpdateClassButtonResponseModel> PutUpdateAsync(UpdateClassButtonRequestModel body)
	{
		return PutUpdateAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual UpdateClassButtonResponseModel PutUpdate(UpdateClassButtonRequestModel body)
	{
		return Task.Run(async () => await PutUpdateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UpdateClassButtonResponseModel> PutUpdateAsync(UpdateClassButtonRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/classchangebuttons/update";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateClassButtonResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<UpdateClassButtonResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateClassButtonResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateClassButtonResponseModel updateClassButtonResponseModel = JsonConvert.DeserializeObject<UpdateClassButtonResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateClassButtonResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<ClassButtonResponseModel> GetChangebuttonByOrderClassButtonIdAsync(int orderClassButtonId)
	{
		return GetChangebuttonByOrderClassButtonIdAsync(orderClassButtonId, CancellationToken.None);
	}

	[Obsolete]
	public virtual ClassButtonResponseModel GetChangebuttonByOrderClassButtonId(int orderClassButtonId)
	{
		return Task.Run(async () => await GetChangebuttonByOrderClassButtonIdAsync(orderClassButtonId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<ClassButtonResponseModel> GetChangebuttonByOrderClassButtonIdAsync(int orderClassButtonId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/classchangebuttons/changebutton/{orderClassButtonId}";
		znodeApiGateway = znodeApiGateway.Replace("{orderClassButtonId}", Uri.EscapeDataString(ConvertToString(orderClassButtonId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ClassButtonResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ClassButtonResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ClassButtonResponseModel classButtonResponseModel = JsonConvert.DeserializeObject<ClassButtonResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)classButtonResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<ClassButtonResponseModel> GetClassbuttonByOrderClassButtonIdAsync(int orderClassButtonId)
	{
		return GetClassbuttonByOrderClassButtonIdAsync(orderClassButtonId, CancellationToken.None);
	}

	[Obsolete]
	public virtual ClassButtonResponseModel GetClassbuttonByOrderClassButtonId(int orderClassButtonId)
	{
		return Task.Run(async () => await GetClassbuttonByOrderClassButtonIdAsync(orderClassButtonId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<ClassButtonResponseModel> GetClassbuttonByOrderClassButtonIdAsync(int orderClassButtonId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/classchangebuttons/classbutton/{orderClassButtonId}";
		znodeApiGateway = znodeApiGateway.Replace("{orderClassButtonId}", Uri.EscapeDataString(ConvertToString(orderClassButtonId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ClassButtonResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ClassButtonResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ClassButtonResponseModel classButtonResponseModel = JsonConvert.DeserializeObject<ClassButtonResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)classButtonResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IClassesClient : IBaseClient
{
	[Obsolete]
	Task<ClassListResponseModel> GetListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	ClassListResponseModel GetList(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<ClassListResponseModel> GetListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<UpdateClassResponseModel> PutUpdateAsync(UpdateClassRequestModel body);

	[Obsolete]
	UpdateClassResponseModel PutUpdate(UpdateClassRequestModel body);

	[Obsolete]
	Task<UpdateClassResponseModel> PutUpdateAsync(UpdateClassRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> DeleteDeleteByCpOrderClassButtonIdAsync(string cpOrderClassButtonId);

	[Obsolete]
	BooleanResponseModel DeleteDeleteByCpOrderClassButtonId(string cpOrderClassButtonId);

	[Obsolete]
	Task<BooleanResponseModel> DeleteDeleteByCpOrderClassButtonIdAsync(string cpOrderClassButtonId, CancellationToken cancellationToken);

	[Obsolete]
	Task<ClassResponseModel> GetOrderclassByOrderClassIdAsync(int orderClassId);

	[Obsolete]
	ClassResponseModel GetOrderclassByOrderClassId(int orderClassId);

	[Obsolete]
	Task<ClassResponseModel> GetOrderclassByOrderClassIdAsync(int orderClassId, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ClassesClient : BaseClient, IClassesClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public ClassesClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<ClassListResponseModel> GetListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetListAsync(filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual ClassListResponseModel GetList(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetListAsync(filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<ClassListResponseModel> GetListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/classes/list";
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ClassListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ClassListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ClassListResponseModel classListResponseModel = JsonConvert.DeserializeObject<ClassListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)classListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UpdateClassResponseModel> PutUpdateAsync(UpdateClassRequestModel body)
	{
		return PutUpdateAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual UpdateClassResponseModel PutUpdate(UpdateClassRequestModel body)
	{
		return Task.Run(async () => await PutUpdateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UpdateClassResponseModel> PutUpdateAsync(UpdateClassRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/classes/update";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateClassResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<UpdateClassResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateClassResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateClassResponseModel updateClassResponseModel = JsonConvert.DeserializeObject<UpdateClassResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateClassResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> DeleteDeleteByCpOrderClassButtonIdAsync(string cpOrderClassButtonId)
	{
		return DeleteDeleteByCpOrderClassButtonIdAsync(cpOrderClassButtonId, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel DeleteDeleteByCpOrderClassButtonId(string cpOrderClassButtonId)
	{
		return Task.Run(async () => await DeleteDeleteByCpOrderClassButtonIdAsync(cpOrderClassButtonId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> DeleteDeleteByCpOrderClassButtonIdAsync(string cpOrderClassButtonId, CancellationToken cancellationToken)
	{
		if (cpOrderClassButtonId == null)
		{
			throw new ArgumentNullException("cpOrderClassButtonId");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/classes/delete/{cpOrderClassButtonId}";
		znodeApiGateway = znodeApiGateway.Replace("{cpOrderClassButtonId}", Uri.EscapeDataString(ConvertToString(cpOrderClassButtonId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).DeleteResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<ClassResponseModel> GetOrderclassByOrderClassIdAsync(int orderClassId)
	{
		return GetOrderclassByOrderClassIdAsync(orderClassId, CancellationToken.None);
	}

	[Obsolete]
	public virtual ClassResponseModel GetOrderclassByOrderClassId(int orderClassId)
	{
		return Task.Run(async () => await GetOrderclassByOrderClassIdAsync(orderClassId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<ClassResponseModel> GetOrderclassByOrderClassIdAsync(int orderClassId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/classes/orderclass/{orderClassId}";
		znodeApiGateway = znodeApiGateway.Replace("{orderClassId}", Uri.EscapeDataString(ConvertToString(orderClassId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ClassResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ClassResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ClassResponseModel classResponseModel = JsonConvert.DeserializeObject<ClassResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)classResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface ICommerceCollectionsClient : IBaseClient
{
	Task<ClassItemListResponseModel> GetItemListByClassTypeAsync(string classType, string classNumber);

	ClassItemListResponseModel GetItemListByClassType(string classType, string classNumber);

	Task<ClassItemListResponseModel> GetItemListByClassTypeAsync(string classType, string classNumber, CancellationToken cancellationToken);

	Task<CollectionResponseModel> GetListByClassTypeAsync(string classType, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	CollectionResponseModel GetListByClassType(string classType, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	Task<CollectionResponseModel> GetListByClassTypeAsync(string classType, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	Task<CommerceCollectionClassDetailResponseModel> GetClassDetailsByClassTypeAsync(string classType, string classNumber);

	CommerceCollectionClassDetailResponseModel GetClassDetailsByClassType(string classType, string classNumber);

	Task<CommerceCollectionClassDetailResponseModel> GetClassDetailsByClassTypeAsync(string classType, string classNumber, CancellationToken cancellationToken);

	Task<ConvertedClassResponseMode> PutConvertByClassTypeAsync(string classType, string classNumber, string targetClassType, ConvertClassRequestModel body);

	ConvertedClassResponseMode PutConvertByClassType(string classType, string classNumber, string targetClassType, ConvertClassRequestModel body);

	Task<ConvertedClassResponseMode> PutConvertByClassTypeAsync(string classType, string classNumber, string targetClassType, ConvertClassRequestModel body, CancellationToken cancellationToken);

	Task<CopiedClassResponseModel> PostCopyByClassTypeAsync(string classType, string classNumber, string targetClassType, string body);

	CopiedClassResponseModel PostCopyByClassType(string classType, string classNumber, string targetClassType, string body);

	Task<CopiedClassResponseModel> PostCopyByClassTypeAsync(string classType, string classNumber, string targetClassType, string body, CancellationToken cancellationToken);

	Task<UpdateClassDetailsResponseModel> PutUpdateAllDetailsByClassTypeAsync(string classType, UpdateAllClassDetailRequestModel body);

	UpdateClassDetailsResponseModel PutUpdateAllDetailsByClassType(string classType, UpdateAllClassDetailRequestModel body);

	Task<UpdateClassDetailsResponseModel> PutUpdateAllDetailsByClassTypeAsync(string classType, UpdateAllClassDetailRequestModel body, CancellationToken cancellationToken);

	Task<MultipleDeleteResponseModel> DeleteV1ByClassTypeAsync(string classType, string classNumbers);

	MultipleDeleteResponseModel DeleteV1ByClassType(string classType, string classNumbers);

	Task<MultipleDeleteResponseModel> DeleteV1ByClassTypeAsync(string classType, string classNumbers, CancellationToken cancellationToken);

	Task<DeleteResponseModel> DeleteDeleteItemByClassTypeAsync(string classType, string classNumber, Guid itemId);

	DeleteResponseModel DeleteDeleteItemByClassType(string classType, string classNumber, Guid itemId);

	Task<DeleteResponseModel> DeleteDeleteItemByClassTypeAsync(string classType, string classNumber, Guid itemId, CancellationToken cancellationToken);

	Task<DeleteResponseModel> DeleteRemoveAllByClassTypeAsync(string classType, string classNumber);

	DeleteResponseModel DeleteRemoveAllByClassType(string classType, string classNumber);

	Task<DeleteResponseModel> DeleteRemoveAllByClassTypeAsync(string classType, string classNumber, CancellationToken cancellationToken);

	Task<UpdateItemQuantityResponseModel> PutQuantityByClassTypeAsync(string classType, string classNumber, Guid itemId, UpdateClassItemQuantityRequestModel body);

	UpdateItemQuantityResponseModel PutQuantityByClassType(string classType, string classNumber, Guid itemId, UpdateClassItemQuantityRequestModel body);

	Task<UpdateItemQuantityResponseModel> PutQuantityByClassTypeAsync(string classType, string classNumber, Guid itemId, UpdateClassItemQuantityRequestModel body, CancellationToken cancellationToken);

	Task<UpdateBulkItemQuantityResponseModel> PutBulkQuantityByClassTypeAsync(string classType, string classNumber, IEnumerable<UpdateClassItemBulkQuantityRequestModel> body);

	UpdateBulkItemQuantityResponseModel PutBulkQuantityByClassType(string classType, string classNumber, IEnumerable<UpdateClassItemBulkQuantityRequestModel> body);

	Task<UpdateBulkItemQuantityResponseModel> PutBulkQuantityByClassTypeAsync(string classType, string classNumber, IEnumerable<UpdateClassItemBulkQuantityRequestModel> body, CancellationToken cancellationToken);

	Task<BooleanResponseModel> PutFinalizeDetailsByClassTypeAsync(string classType, string classNumber, IEnumerable<string> expand);

	BooleanResponseModel PutFinalizeDetailsByClassType(string classType, string classNumber, IEnumerable<string> expand);

	Task<BooleanResponseModel> PutFinalizeDetailsByClassTypeAsync(string classType, string classNumber, IEnumerable<string> expand, CancellationToken cancellationToken);

	Task<ConvertedToOrderResponseModel> PostPlaceOrderByClassTypeAsync(string classType, string classNumber, ConvertToOrderRequestModel body);

	ConvertedToOrderResponseModel PostPlaceOrderByClassType(string classType, string classNumber, ConvertToOrderRequestModel body);

	Task<ConvertedToOrderResponseModel> PostPlaceOrderByClassTypeAsync(string classType, string classNumber, ConvertToOrderRequestModel body, CancellationToken cancellationToken);

	Task<ClassNumberResponseModel> GetClassidByClassnumberByClassTypeAsync(string classType, string classNumber);

	ClassNumberResponseModel GetClassidByClassnumberByClassType(string classType, string classNumber);

	Task<ClassNumberResponseModel> GetClassidByClassnumberByClassTypeAsync(string classType, string classNumber, CancellationToken cancellationToken);

	Task<ActiveClassResponseModel> GetActiveClassNumberByClassTypeAsync(string classType, int? customerId);

	ActiveClassResponseModel GetActiveClassNumberByClassType(string classType, int? customerId);

	Task<ActiveClassResponseModel> GetActiveClassNumberByClassTypeAsync(string classType, int? customerId, CancellationToken cancellationToken);

	Task<UpdateClassStatusResponseModel> PutStatusByClassTypeAsync(string classType, string classNumber, UpdateClassStatusRequestModel body);

	UpdateClassStatusResponseModel PutStatusByClassType(string classType, string classNumber, UpdateClassStatusRequestModel body);

	Task<UpdateClassStatusResponseModel> PutStatusByClassTypeAsync(string classType, string classNumber, UpdateClassStatusRequestModel body, CancellationToken cancellationToken);

	Task<ReceiptDetailsResponseModel> GetReceiptDetailsByClassTypeAsync(string classType, string classNumber, string statusCode);

	ReceiptDetailsResponseModel GetReceiptDetailsByClassType(string classType, string classNumber, string statusCode);

	Task<ReceiptDetailsResponseModel> GetReceiptDetailsByClassTypeAsync(string classType, string classNumber, string statusCode, CancellationToken cancellationToken);

	Task<ActiveClassResponseModel> PutClassNameByClassTypeAsync(string classType, string classNumber, string updatedClassName);

	ActiveClassResponseModel PutClassNameByClassType(string classType, string classNumber, string updatedClassName);

	Task<ActiveClassResponseModel> PutClassNameByClassTypeAsync(string classType, string classNumber, string updatedClassName, CancellationToken cancellationToken);

	Task<UpdateEntityResponseModel> PutEntityFieldsByClassTypeAsync(string classType, string classNumber, UpdateEntityRequestModel body);

	UpdateEntityResponseModel PutEntityFieldsByClassType(string classType, string classNumber, UpdateEntityRequestModel body);

	Task<UpdateEntityResponseModel> PutEntityFieldsByClassTypeAsync(string classType, string classNumber, UpdateEntityRequestModel body, CancellationToken cancellationToken);

	Task<CommerceCollectionClassDetailListResponseModel> GetMultipleClassDetailsByClassTypeAsync(string classType, string classNumbers);

	CommerceCollectionClassDetailListResponseModel GetMultipleClassDetailsByClassType(string classType, string classNumbers);

	Task<CommerceCollectionClassDetailListResponseModel> GetMultipleClassDetailsByClassTypeAsync(string classType, string classNumbers, CancellationToken cancellationToken);

	Task<UpdateLineItemStatusResponseModel> PutLineItemStatusByClassTypeAsync(string classType, string classNumber, UpdateLineItemStatusRequestModel body);

	UpdateLineItemStatusResponseModel PutLineItemStatusByClassType(string classType, string classNumber, UpdateLineItemStatusRequestModel body);

	Task<UpdateLineItemStatusResponseModel> PutLineItemStatusByClassTypeAsync(string classType, string classNumber, UpdateLineItemStatusRequestModel body, CancellationToken cancellationToken);

	Task<GenerateFinalizeNumberResponseModel> PutGenerateFinalizeNumberByClassTypeAsync(string classType, string classNumber);

	GenerateFinalizeNumberResponseModel PutGenerateFinalizeNumberByClassType(string classType, string classNumber);

	Task<GenerateFinalizeNumberResponseModel> PutGenerateFinalizeNumberByClassTypeAsync(string classType, string classNumber, CancellationToken cancellationToken);

	Task<EmailSendResponseModel> PostSendEmailByClassTypeAsync(string classType, string classNumber, string emailTemplate);

	EmailSendResponseModel PostSendEmailByClassType(string classType, string classNumber, string emailTemplate);

	Task<EmailSendResponseModel> PostSendEmailByClassTypeAsync(string classType, string classNumber, string emailTemplate, CancellationToken cancellationToken);

	Task<CustomDataBooleanResponse> PutLineItemCustomdataByClassNumberAsync(string classNumber, Guid lineItemId, string classType, CustomDataRequestModel body);

	CustomDataBooleanResponse PutLineItemCustomdataByClassNumber(string classNumber, Guid lineItemId, string classType, CustomDataRequestModel body);

	Task<CustomDataBooleanResponse> PutLineItemCustomdataByClassNumberAsync(string classNumber, Guid lineItemId, string classType, CustomDataRequestModel body, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CommerceCollectionsClient : BaseClient, ICommerceCollectionsClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public CommerceCollectionsClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	public virtual Task<ClassItemListResponseModel> GetItemListByClassTypeAsync(string classType, string classNumber)
	{
		return GetItemListByClassTypeAsync(classType, classNumber, CancellationToken.None);
	}

	public virtual ClassItemListResponseModel GetItemListByClassType(string classType, string classNumber)
	{
		return Task.Run(async () => await GetItemListByClassTypeAsync(classType, classNumber, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<ClassItemListResponseModel> GetItemListByClassTypeAsync(string classType, string classNumber, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/item-list/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ClassItemListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ClassItemListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ClassItemListResponseModel classItemListResponseModel = JsonConvert.DeserializeObject<ClassItemListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)classItemListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<CollectionResponseModel> GetListByClassTypeAsync(string classType, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetListByClassTypeAsync(classType, filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	public virtual CollectionResponseModel GetListByClassType(string classType, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetListByClassTypeAsync(classType, filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CollectionResponseModel> GetListByClassTypeAsync(string classType, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/list";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CollectionResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CollectionResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CollectionResponseModel collectionResponseModel = JsonConvert.DeserializeObject<CollectionResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)collectionResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<CommerceCollectionClassDetailResponseModel> GetClassDetailsByClassTypeAsync(string classType, string classNumber)
	{
		return GetClassDetailsByClassTypeAsync(classType, classNumber, CancellationToken.None);
	}

	public virtual CommerceCollectionClassDetailResponseModel GetClassDetailsByClassType(string classType, string classNumber)
	{
		return Task.Run(async () => await GetClassDetailsByClassTypeAsync(classType, classNumber, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CommerceCollectionClassDetailResponseModel> GetClassDetailsByClassTypeAsync(string classType, string classNumber, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/class-details/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CommerceCollectionClassDetailResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CommerceCollectionClassDetailResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CommerceCollectionClassDetailResponseModel commerceCollectionClassDetailResponseModel = JsonConvert.DeserializeObject<CommerceCollectionClassDetailResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)commerceCollectionClassDetailResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<ConvertedClassResponseMode> PutConvertByClassTypeAsync(string classType, string classNumber, string targetClassType, ConvertClassRequestModel body)
	{
		return PutConvertByClassTypeAsync(classType, classNumber, targetClassType, body, CancellationToken.None);
	}

	public virtual ConvertedClassResponseMode PutConvertByClassType(string classType, string classNumber, string targetClassType, ConvertClassRequestModel body)
	{
		return Task.Run(async () => await PutConvertByClassTypeAsync(classType, classNumber, targetClassType, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<ConvertedClassResponseMode> PutConvertByClassTypeAsync(string classType, string classNumber, string targetClassType, ConvertClassRequestModel body, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		if (targetClassType == null)
		{
			throw new ArgumentNullException("targetClassType");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/convert/{classNumber}/{targetClassType}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{targetClassType}", Uri.EscapeDataString(ConvertToString(targetClassType, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ConvertedClassResponseMode>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ConvertedClassResponseMode();
			case 409:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult4 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult4.Object.ErrorCode, objectResponseResult4.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ConvertedClassResponseMode convertedClassResponseMode = JsonConvert.DeserializeObject<ConvertedClassResponseMode>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)convertedClassResponseMode, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<CopiedClassResponseModel> PostCopyByClassTypeAsync(string classType, string classNumber, string targetClassType, string body)
	{
		return PostCopyByClassTypeAsync(classType, classNumber, targetClassType, body, CancellationToken.None);
	}

	public virtual CopiedClassResponseModel PostCopyByClassType(string classType, string classNumber, string targetClassType, string body)
	{
		return Task.Run(async () => await PostCopyByClassTypeAsync(classType, classNumber, targetClassType, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CopiedClassResponseModel> PostCopyByClassTypeAsync(string classType, string classNumber, string targetClassType, string body, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/copy/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway + "?targetClassType=" + targetClassType;
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CopiedClassResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CopiedClassResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CopiedClassResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CopiedClassResponseModel copiedClassResponseModel = JsonConvert.DeserializeObject<CopiedClassResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)copiedClassResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<UpdateClassDetailsResponseModel> PutUpdateAllDetailsByClassTypeAsync(string classType, UpdateAllClassDetailRequestModel body)
	{
		return PutUpdateAllDetailsByClassTypeAsync(classType, body, CancellationToken.None);
	}

	public virtual UpdateClassDetailsResponseModel PutUpdateAllDetailsByClassType(string classType, UpdateAllClassDetailRequestModel body)
	{
		return Task.Run(async () => await PutUpdateAllDetailsByClassTypeAsync(classType, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<UpdateClassDetailsResponseModel> PutUpdateAllDetailsByClassTypeAsync(string classType, UpdateAllClassDetailRequestModel body, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/update-all-details";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateClassDetailsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateClassDetailsResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateClassDetailsResponseModel updateClassDetailsResponseModel = JsonConvert.DeserializeObject<UpdateClassDetailsResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateClassDetailsResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<MultipleDeleteResponseModel> DeleteV1ByClassTypeAsync(string classType, string classNumbers)
	{
		return DeleteV1ByClassTypeAsync(classType, classNumbers, CancellationToken.None);
	}

	public virtual MultipleDeleteResponseModel DeleteV1ByClassType(string classType, string classNumbers)
	{
		return Task.Run(async () => await DeleteV1ByClassTypeAsync(classType, classNumbers, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<MultipleDeleteResponseModel> DeleteV1ByClassTypeAsync(string classType, string classNumbers, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumbers == null)
		{
			throw new ArgumentNullException("classNumbers");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/{classNumbers}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumbers}", Uri.EscapeDataString(ConvertToString(classNumbers, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).DeleteResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<MultipleDeleteResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new MultipleDeleteResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				MultipleDeleteResponseModel multipleDeleteResponseModel = JsonConvert.DeserializeObject<MultipleDeleteResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)multipleDeleteResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<DeleteResponseModel> DeleteDeleteItemByClassTypeAsync(string classType, string classNumber, Guid itemId)
	{
		return DeleteDeleteItemByClassTypeAsync(classType, classNumber, itemId, CancellationToken.None);
	}

	public virtual DeleteResponseModel DeleteDeleteItemByClassType(string classType, string classNumber, Guid itemId)
	{
		return Task.Run(async () => await DeleteDeleteItemByClassTypeAsync(classType, classNumber, itemId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<DeleteResponseModel> DeleteDeleteItemByClassTypeAsync(string classType, string classNumber, Guid itemId, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/{classNumber}/delete-item/{itemId}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{itemId}", Uri.EscapeDataString(ConvertToString(itemId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).DeleteResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<DeleteResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new DeleteResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				DeleteResponseModel deleteResponseModel = JsonConvert.DeserializeObject<DeleteResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)deleteResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<DeleteResponseModel> DeleteRemoveAllByClassTypeAsync(string classType, string classNumber)
	{
		return DeleteRemoveAllByClassTypeAsync(classType, classNumber, CancellationToken.None);
	}

	public virtual DeleteResponseModel DeleteRemoveAllByClassType(string classType, string classNumber)
	{
		return Task.Run(async () => await DeleteRemoveAllByClassTypeAsync(classType, classNumber, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<DeleteResponseModel> DeleteRemoveAllByClassTypeAsync(string classType, string classNumber, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/remove-all/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).DeleteResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<DeleteResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new DeleteResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				DeleteResponseModel deleteResponseModel = JsonConvert.DeserializeObject<DeleteResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)deleteResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<UpdateItemQuantityResponseModel> PutQuantityByClassTypeAsync(string classType, string classNumber, Guid itemId, UpdateClassItemQuantityRequestModel body)
	{
		return PutQuantityByClassTypeAsync(classType, classNumber, itemId, body, CancellationToken.None);
	}

	public virtual UpdateItemQuantityResponseModel PutQuantityByClassType(string classType, string classNumber, Guid itemId, UpdateClassItemQuantityRequestModel body)
	{
		return Task.Run(async () => await PutQuantityByClassTypeAsync(classType, classNumber, itemId, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<UpdateItemQuantityResponseModel> PutQuantityByClassTypeAsync(string classType, string classNumber, Guid itemId, UpdateClassItemQuantityRequestModel body, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/{classNumber}/quantity/{itemId}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{itemId}", Uri.EscapeDataString(ConvertToString(itemId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateItemQuantityResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateItemQuantityResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateItemQuantityResponseModel updateItemQuantityResponseModel = JsonConvert.DeserializeObject<UpdateItemQuantityResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateItemQuantityResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<UpdateBulkItemQuantityResponseModel> PutBulkQuantityByClassTypeAsync(string classType, string classNumber, IEnumerable<UpdateClassItemBulkQuantityRequestModel> body)
	{
		return PutBulkQuantityByClassTypeAsync(classType, classNumber, body, CancellationToken.None);
	}

	public virtual UpdateBulkItemQuantityResponseModel PutBulkQuantityByClassType(string classType, string classNumber, IEnumerable<UpdateClassItemBulkQuantityRequestModel> body)
	{
		return Task.Run(async () => await PutBulkQuantityByClassTypeAsync(classType, classNumber, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<UpdateBulkItemQuantityResponseModel> PutBulkQuantityByClassTypeAsync(string classType, string classNumber, IEnumerable<UpdateClassItemBulkQuantityRequestModel> body, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/bulk-quantity/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateBulkItemQuantityResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateBulkItemQuantityResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateBulkItemQuantityResponseModel updateBulkItemQuantityResponseModel = JsonConvert.DeserializeObject<UpdateBulkItemQuantityResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateBulkItemQuantityResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<BooleanResponseModel> PutFinalizeDetailsByClassTypeAsync(string classType, string classNumber, IEnumerable<string> expand)
	{
		return PutFinalizeDetailsByClassTypeAsync(classType, classNumber, expand, CancellationToken.None);
	}

	public virtual BooleanResponseModel PutFinalizeDetailsByClassType(string classType, string classNumber, IEnumerable<string> expand)
	{
		return Task.Run(async () => await PutFinalizeDetailsByClassTypeAsync(classType, classNumber, expand, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<BooleanResponseModel> PutFinalizeDetailsByClassTypeAsync(string classType, string classNumber, IEnumerable<string> expand, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/finalize-details/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)expand), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<ConvertedToOrderResponseModel> PostPlaceOrderByClassTypeAsync(string classType, string classNumber, ConvertToOrderRequestModel body)
	{
		return PostPlaceOrderByClassTypeAsync(classType, classNumber, body, CancellationToken.None);
	}

	public virtual ConvertedToOrderResponseModel PostPlaceOrderByClassType(string classType, string classNumber, ConvertToOrderRequestModel body)
	{
		return Task.Run(async () => await PostPlaceOrderByClassTypeAsync(classType, classNumber, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<ConvertedToOrderResponseModel> PostPlaceOrderByClassTypeAsync(string classType, string classNumber, ConvertToOrderRequestModel body, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/place-order/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ConvertedToOrderResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<ConvertedToOrderResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ConvertedToOrderResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ConvertedToOrderResponseModel convertedToOrderResponseModel = JsonConvert.DeserializeObject<ConvertedToOrderResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)convertedToOrderResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<ClassNumberResponseModel> GetClassidByClassnumberByClassTypeAsync(string classType, string classNumber)
	{
		return GetClassidByClassnumberByClassTypeAsync(classType, classNumber, CancellationToken.None);
	}

	public virtual ClassNumberResponseModel GetClassidByClassnumberByClassType(string classType, string classNumber)
	{
		return Task.Run(async () => await GetClassidByClassnumberByClassTypeAsync(classType, classNumber, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<ClassNumberResponseModel> GetClassidByClassnumberByClassTypeAsync(string classType, string classNumber, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/classid-by-classnumber/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{ClassNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ClassNumberResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ClassNumberResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ClassNumberResponseModel classNumberResponseModel = JsonConvert.DeserializeObject<ClassNumberResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)classNumberResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<ActiveClassResponseModel> GetActiveClassNumberByClassTypeAsync(string classType, int? customerId)
	{
		return GetActiveClassNumberByClassTypeAsync(classType, customerId, CancellationToken.None);
	}

	public virtual ActiveClassResponseModel GetActiveClassNumberByClassType(string classType, int? customerId)
	{
		return Task.Run(async () => await GetActiveClassNumberByClassTypeAsync(classType, customerId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<ActiveClassResponseModel> GetActiveClassNumberByClassTypeAsync(string classType, int? customerId, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/active-class-number";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<FilterTuple>)null, (IDictionary<string, string>)null, (int?)null, (int?)null, Array.Empty<string>());
		string text = znodeApiGateway;
		int? num = customerId;
		znodeApiGateway = text + "&customerId=" + num;
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ActiveClassResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ActiveClassResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text2 = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ActiveClassResponseModel activeClassResponseModel = JsonConvert.DeserializeObject<ActiveClassResponseModel>(text2, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)activeClassResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<UpdateClassStatusResponseModel> PutStatusByClassTypeAsync(string classType, string classNumber, UpdateClassStatusRequestModel body)
	{
		return PutStatusByClassTypeAsync(classType, classNumber, body, CancellationToken.None);
	}

	public virtual UpdateClassStatusResponseModel PutStatusByClassType(string classType, string classNumber, UpdateClassStatusRequestModel body)
	{
		return Task.Run(async () => await PutStatusByClassTypeAsync(classType, classNumber, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<UpdateClassStatusResponseModel> PutStatusByClassTypeAsync(string classType, string classNumber, UpdateClassStatusRequestModel body, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/status/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateClassStatusResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateClassStatusResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateClassStatusResponseModel updateClassStatusResponseModel = JsonConvert.DeserializeObject<UpdateClassStatusResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateClassStatusResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<ReceiptDetailsResponseModel> GetReceiptDetailsByClassTypeAsync(string classType, string classNumber, string statusCode)
	{
		return GetReceiptDetailsByClassTypeAsync(classType, classNumber, statusCode, CancellationToken.None);
	}

	public virtual ReceiptDetailsResponseModel GetReceiptDetailsByClassType(string classType, string classNumber, string statusCode)
	{
		return Task.Run(async () => await GetReceiptDetailsByClassTypeAsync(classType, classNumber, statusCode, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<ReceiptDetailsResponseModel> GetReceiptDetailsByClassTypeAsync(string classType, string classNumber, string statusCode, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/receipt-details/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<FilterTuple>)null, (IDictionary<string, string>)null, (int?)null, (int?)null, Array.Empty<string>());
		znodeApiGateway = znodeApiGateway + "&statusCode=" + statusCode;
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode2 = (int)response_.StatusCode;
			if (statusCode2 == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode2)
			{
			case 200:
				return (await ReadObjectResponseAsync<ReceiptDetailsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ReceiptDetailsResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ReceiptDetailsResponseModel receiptDetailsResponseModel = JsonConvert.DeserializeObject<ReceiptDetailsResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)receiptDetailsResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<ActiveClassResponseModel> PutClassNameByClassTypeAsync(string classType, string classNumber, string updatedClassName)
	{
		return PutClassNameByClassTypeAsync(classType, classNumber, updatedClassName, CancellationToken.None);
	}

	public virtual ActiveClassResponseModel PutClassNameByClassType(string classType, string classNumber, string updatedClassName)
	{
		return Task.Run(async () => await PutClassNameByClassTypeAsync(classType, classNumber, updatedClassName, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<ActiveClassResponseModel> PutClassNameByClassTypeAsync(string classType, string classNumber, string updatedClassName, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		if (updatedClassName == null)
		{
			throw new ArgumentNullException("updatedClassName");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/class-name/{classNumber}/{updatedClassName}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{updatedClassName}", Uri.EscapeDataString(ConvertToString(updatedClassName, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)updatedClassName), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ActiveClassResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ActiveClassResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ActiveClassResponseModel activeClassResponseModel = JsonConvert.DeserializeObject<ActiveClassResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)activeClassResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<UpdateEntityResponseModel> PutEntityFieldsByClassTypeAsync(string classType, string classNumber, UpdateEntityRequestModel body)
	{
		return PutEntityFieldsByClassTypeAsync(classType, classNumber, body, CancellationToken.None);
	}

	public virtual UpdateEntityResponseModel PutEntityFieldsByClassType(string classType, string classNumber, UpdateEntityRequestModel body)
	{
		return Task.Run(async () => await PutEntityFieldsByClassTypeAsync(classType, classNumber, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<UpdateEntityResponseModel> PutEntityFieldsByClassTypeAsync(string classType, string classNumber, UpdateEntityRequestModel body, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/entity-fields/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateEntityResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateEntityResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateEntityResponseModel updateEntityResponseModel = JsonConvert.DeserializeObject<UpdateEntityResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateEntityResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<CommerceCollectionClassDetailListResponseModel> GetMultipleClassDetailsByClassTypeAsync(string classType, string classNumbers)
	{
		return GetMultipleClassDetailsByClassTypeAsync(classType, classNumbers, CancellationToken.None);
	}

	public virtual CommerceCollectionClassDetailListResponseModel GetMultipleClassDetailsByClassType(string classType, string classNumbers)
	{
		return Task.Run(async () => await GetMultipleClassDetailsByClassTypeAsync(classType, classNumbers, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CommerceCollectionClassDetailListResponseModel> GetMultipleClassDetailsByClassTypeAsync(string classType, string classNumbers, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumbers == null)
		{
			throw new ArgumentNullException("classNumbers");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/multiple-class-details/{classNumbers}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumbers}", Uri.EscapeDataString(ConvertToString(classNumbers, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CommerceCollectionClassDetailListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CommerceCollectionClassDetailListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CommerceCollectionClassDetailListResponseModel commerceCollectionClassDetailListResponseModel = JsonConvert.DeserializeObject<CommerceCollectionClassDetailListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)commerceCollectionClassDetailListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<UpdateLineItemStatusResponseModel> PutLineItemStatusByClassTypeAsync(string classType, string classNumber, UpdateLineItemStatusRequestModel body)
	{
		return PutLineItemStatusByClassTypeAsync(classType, classNumber, body, CancellationToken.None);
	}

	public virtual UpdateLineItemStatusResponseModel PutLineItemStatusByClassType(string classType, string classNumber, UpdateLineItemStatusRequestModel body)
	{
		return Task.Run(async () => await PutLineItemStatusByClassTypeAsync(classType, classNumber, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<UpdateLineItemStatusResponseModel> PutLineItemStatusByClassTypeAsync(string classType, string classNumber, UpdateLineItemStatusRequestModel body, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/{classNumber}/line-item-status";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateLineItemStatusResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateLineItemStatusResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateLineItemStatusResponseModel updateLineItemStatusResponseModel = JsonConvert.DeserializeObject<UpdateLineItemStatusResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateLineItemStatusResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<GenerateFinalizeNumberResponseModel> PutGenerateFinalizeNumberByClassTypeAsync(string classType, string classNumber)
	{
		return PutGenerateFinalizeNumberByClassTypeAsync(classType, classNumber, CancellationToken.None);
	}

	public virtual GenerateFinalizeNumberResponseModel PutGenerateFinalizeNumberByClassType(string classType, string classNumber)
	{
		return Task.Run(async () => await PutGenerateFinalizeNumberByClassTypeAsync(classType, classNumber, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<GenerateFinalizeNumberResponseModel> PutGenerateFinalizeNumberByClassTypeAsync(string classType, string classNumber, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/generate-finalize-number/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)classNumber), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<GenerateFinalizeNumberResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new GenerateFinalizeNumberResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				GenerateFinalizeNumberResponseModel generateFinalizeNumberResponseModel = JsonConvert.DeserializeObject<GenerateFinalizeNumberResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)generateFinalizeNumberResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<EmailSendResponseModel> PostSendEmailByClassTypeAsync(string classType, string classNumber, string emailTemplate)
	{
		return PostSendEmailByClassTypeAsync(classType, classNumber, emailTemplate, CancellationToken.None);
	}

	public virtual EmailSendResponseModel PostSendEmailByClassType(string classType, string classNumber, string emailTemplate)
	{
		return Task.Run(async () => await PostSendEmailByClassTypeAsync(classType, classNumber, emailTemplate, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<EmailSendResponseModel> PostSendEmailByClassTypeAsync(string classType, string classNumber, string emailTemplate, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/send-email/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway + "?emailTemplate=" + emailTemplate;
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, (string)null, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<EmailSendResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new EmailSendResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				EmailSendResponseModel emailSendResponseModel = JsonConvert.DeserializeObject<EmailSendResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)emailSendResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<CustomDataBooleanResponse> PutLineItemCustomdataByClassNumberAsync(string classNumber, Guid lineItemId, string classType, CustomDataRequestModel body)
	{
		return PutLineItemCustomdataByClassNumberAsync(classNumber, lineItemId, classType, body, CancellationToken.None);
	}

	public virtual CustomDataBooleanResponse PutLineItemCustomdataByClassNumber(string classNumber, Guid lineItemId, string classType, CustomDataRequestModel body)
	{
		return Task.Run(async () => await PutLineItemCustomdataByClassNumberAsync(classNumber, lineItemId, classType, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomDataBooleanResponse> PutLineItemCustomdataByClassNumberAsync(string classNumber, Guid lineItemId, string classType, CustomDataRequestModel body, CancellationToken cancellationToken)
	{
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/{classNumber}/line-item-customdata/{lineItemId}";
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{lineItemId}", Uri.EscapeDataString(ConvertToString(lineItemId, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CustomDataBooleanResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CustomDataBooleanResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CustomDataBooleanResponse();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CustomDataBooleanResponse customDataBooleanResponse = JsonConvert.DeserializeObject<CustomDataBooleanResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customDataBooleanResponse, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IFlagsClient : IBaseClient
{
	[Obsolete]
	Task<OrderFlagListResponseModel> GetListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	OrderFlagListResponseModel GetList(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<OrderFlagListResponseModel> GetListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<OrderFlagDetailsResponseModel> GetOrderflagdetailsByCpOrderFlagIdAsync(int cpOrderFlagId);

	[Obsolete]
	OrderFlagDetailsResponseModel GetOrderflagdetailsByCpOrderFlagId(int cpOrderFlagId);

	[Obsolete]
	Task<OrderFlagDetailsResponseModel> GetOrderflagdetailsByCpOrderFlagIdAsync(int cpOrderFlagId, CancellationToken cancellationToken);

	[Obsolete]
	Task<CreateOrderFlagResponseModel> PostCreateAsync(CreateOrderFlagRequestModel body);

	[Obsolete]
	CreateOrderFlagResponseModel PostCreate(CreateOrderFlagRequestModel body);

	[Obsolete]
	Task<CreateOrderFlagResponseModel> PostCreateAsync(CreateOrderFlagRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<UpdateOrderFlagResponseModel> PutUpdateAsync(UpdateOrderFlagRequestModel body);

	[Obsolete]
	UpdateOrderFlagResponseModel PutUpdate(UpdateOrderFlagRequestModel body);

	[Obsolete]
	Task<UpdateOrderFlagResponseModel> PutUpdateAsync(UpdateOrderFlagRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> DeleteDeleteByCpOrderFlagIdsAsync(string cpOrderFlagIds);

	[Obsolete]
	BooleanResponseModel DeleteDeleteByCpOrderFlagIds(string cpOrderFlagIds);

	[Obsolete]
	Task<BooleanResponseModel> DeleteDeleteByCpOrderFlagIdsAsync(string cpOrderFlagIds, CancellationToken cancellationToken);

	[Obsolete]
	Task<UserGroupListForFlagResponseModel> GetAssociatedusergrouplistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	UserGroupListForFlagResponseModel GetAssociatedusergrouplist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<UserGroupListForFlagResponseModel> GetAssociatedusergrouplistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<UserGroupListForFlagResponseModel> GetUnassociatedusergrouplistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	UserGroupListForFlagResponseModel GetUnassociatedusergrouplist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<UserGroupListForFlagResponseModel> GetUnassociatedusergrouplistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PostAssociateusergroupAsync(FlagAndUserGroupRequestModel body);

	[Obsolete]
	BooleanResponseModel PostAssociateusergroup(FlagAndUserGroupRequestModel body);

	[Obsolete]
	Task<BooleanResponseModel> PostAssociateusergroupAsync(FlagAndUserGroupRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> DeleteUnassociateusergroupByUserGroupIdsAsync(string userGroupIds, int cpOrderFlagId);

	[Obsolete]
	BooleanResponseModel DeleteUnassociateusergroupByUserGroupIds(string userGroupIds, int cpOrderFlagId);

	[Obsolete]
	Task<BooleanResponseModel> DeleteUnassociateusergroupByUserGroupIdsAsync(string userGroupIds, int cpOrderFlagId, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FlagsClient : BaseClient, IFlagsClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public FlagsClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<OrderFlagListResponseModel> GetListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetListAsync(filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderFlagListResponseModel GetList(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetListAsync(filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderFlagListResponseModel> GetListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/flags/list";
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderFlagListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderFlagListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderFlagListResponseModel orderFlagListResponseModel = JsonConvert.DeserializeObject<OrderFlagListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderFlagListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<OrderFlagDetailsResponseModel> GetOrderflagdetailsByCpOrderFlagIdAsync(int cpOrderFlagId)
	{
		return GetOrderflagdetailsByCpOrderFlagIdAsync(cpOrderFlagId, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderFlagDetailsResponseModel GetOrderflagdetailsByCpOrderFlagId(int cpOrderFlagId)
	{
		return Task.Run(async () => await GetOrderflagdetailsByCpOrderFlagIdAsync(cpOrderFlagId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderFlagDetailsResponseModel> GetOrderflagdetailsByCpOrderFlagIdAsync(int cpOrderFlagId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/flags/orderflagdetails/{cpOrderFlagId}";
		znodeApiGateway = znodeApiGateway.Replace("{cpOrderFlagId}", Uri.EscapeDataString(ConvertToString(cpOrderFlagId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderFlagDetailsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderFlagDetailsResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderFlagDetailsResponseModel orderFlagDetailsResponseModel = JsonConvert.DeserializeObject<OrderFlagDetailsResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderFlagDetailsResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<CreateOrderFlagResponseModel> PostCreateAsync(CreateOrderFlagRequestModel body)
	{
		return PostCreateAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual CreateOrderFlagResponseModel PostCreate(CreateOrderFlagRequestModel body)
	{
		return Task.Run(async () => await PostCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<CreateOrderFlagResponseModel> PostCreateAsync(CreateOrderFlagRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/flags/create";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CreateOrderFlagResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CreateOrderFlagResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CreateOrderFlagResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CreateOrderFlagResponseModel createOrderFlagResponseModel = JsonConvert.DeserializeObject<CreateOrderFlagResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)createOrderFlagResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UpdateOrderFlagResponseModel> PutUpdateAsync(UpdateOrderFlagRequestModel body)
	{
		return PutUpdateAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual UpdateOrderFlagResponseModel PutUpdate(UpdateOrderFlagRequestModel body)
	{
		return Task.Run(async () => await PutUpdateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UpdateOrderFlagResponseModel> PutUpdateAsync(UpdateOrderFlagRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/flags/update";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateOrderFlagResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<UpdateOrderFlagResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateOrderFlagResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateOrderFlagResponseModel updateOrderFlagResponseModel = JsonConvert.DeserializeObject<UpdateOrderFlagResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateOrderFlagResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> DeleteDeleteByCpOrderFlagIdsAsync(string cpOrderFlagIds)
	{
		return DeleteDeleteByCpOrderFlagIdsAsync(cpOrderFlagIds, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel DeleteDeleteByCpOrderFlagIds(string cpOrderFlagIds)
	{
		return Task.Run(async () => await DeleteDeleteByCpOrderFlagIdsAsync(cpOrderFlagIds, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> DeleteDeleteByCpOrderFlagIdsAsync(string cpOrderFlagIds, CancellationToken cancellationToken)
	{
		if (cpOrderFlagIds == null)
		{
			throw new ArgumentNullException("cpOrderFlagIds");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/flags/delete/{cpOrderFlagIds}";
		znodeApiGateway = znodeApiGateway.Replace("{cpOrderFlagIds}", Uri.EscapeDataString(ConvertToString(cpOrderFlagIds, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).DeleteResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UserGroupListForFlagResponseModel> GetAssociatedusergrouplistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetAssociatedusergrouplistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual UserGroupListForFlagResponseModel GetAssociatedusergrouplist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetAssociatedusergrouplistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UserGroupListForFlagResponseModel> GetAssociatedusergrouplistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/flags/associatedusergrouplist";
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UserGroupListForFlagResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UserGroupListForFlagResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UserGroupListForFlagResponseModel userGroupListForFlagResponseModel = JsonConvert.DeserializeObject<UserGroupListForFlagResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)userGroupListForFlagResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UserGroupListForFlagResponseModel> GetUnassociatedusergrouplistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetUnassociatedusergrouplistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual UserGroupListForFlagResponseModel GetUnassociatedusergrouplist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetUnassociatedusergrouplistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UserGroupListForFlagResponseModel> GetUnassociatedusergrouplistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/flags/unassociatedusergrouplist";
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UserGroupListForFlagResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UserGroupListForFlagResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UserGroupListForFlagResponseModel userGroupListForFlagResponseModel = JsonConvert.DeserializeObject<UserGroupListForFlagResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)userGroupListForFlagResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PostAssociateusergroupAsync(FlagAndUserGroupRequestModel body)
	{
		return PostAssociateusergroupAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PostAssociateusergroup(FlagAndUserGroupRequestModel body)
	{
		return Task.Run(async () => await PostAssociateusergroupAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PostAssociateusergroupAsync(FlagAndUserGroupRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/flags/associateusergroup";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> DeleteUnassociateusergroupByUserGroupIdsAsync(string userGroupIds, int cpOrderFlagId)
	{
		return DeleteUnassociateusergroupByUserGroupIdsAsync(userGroupIds, cpOrderFlagId, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel DeleteUnassociateusergroupByUserGroupIds(string userGroupIds, int cpOrderFlagId)
	{
		return Task.Run(async () => await DeleteUnassociateusergroupByUserGroupIdsAsync(userGroupIds, cpOrderFlagId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> DeleteUnassociateusergroupByUserGroupIdsAsync(string userGroupIds, int cpOrderFlagId, CancellationToken cancellationToken)
	{
		if (userGroupIds == null)
		{
			throw new ArgumentNullException("userGroupIds");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/flags/unassociateusergroup/{userGroupIds}/{cpOrderFlagId}";
		znodeApiGateway = znodeApiGateway.Replace("{userGroupIds}", Uri.EscapeDataString(ConvertToString(userGroupIds, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{cpOrderFlagId}", Uri.EscapeDataString(ConvertToString(cpOrderFlagId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).DeleteResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IInvoiceClient : IBaseClient
{
	[Obsolete]
	Task<BooleanResponseModel> GetGenerateinvoiceByOrderIdsAsync(string orderIds);

	[Obsolete]
	BooleanResponseModel GetGenerateinvoiceByOrderIds(string orderIds);

	[Obsolete]
	Task<BooleanResponseModel> GetGenerateinvoiceByOrderIdsAsync(string orderIds, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class InvoiceClient : BaseClient, IInvoiceClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public InvoiceClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> GetGenerateinvoiceByOrderIdsAsync(string orderIds)
	{
		return GetGenerateinvoiceByOrderIdsAsync(orderIds, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel GetGenerateinvoiceByOrderIds(string orderIds)
	{
		return Task.Run(async () => await GetGenerateinvoiceByOrderIdsAsync(orderIds, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> GetGenerateinvoiceByOrderIdsAsync(string orderIds, CancellationToken cancellationToken)
	{
		if (orderIds == null)
		{
			throw new ArgumentNullException("orderIds");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/invoice/generateinvoice/{orderIds}";
		znodeApiGateway = znodeApiGateway.Replace("{orderIds}", Uri.EscapeDataString(ConvertToString(orderIds, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface ILineItemsClient : IBaseClient
{
	Task<AddLineItemsResponseModel> PostAddLineItemsByClassTypeAsync(string classType, AddLineItemsRequestModel body);

	AddLineItemsResponseModel PostAddLineItemsByClassType(string classType, AddLineItemsRequestModel body);

	Task<AddLineItemsResponseModel> PostAddLineItemsByClassTypeAsync(string classType, AddLineItemsRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<StatusResponseModel> PostCreateAsync(CreateLineItemsRequestModel body);

	[Obsolete]
	StatusResponseModel PostCreate(CreateLineItemsRequestModel body);

	[Obsolete]
	Task<StatusResponseModel> PostCreateAsync(CreateLineItemsRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<LineItemsResponseModel> GetOrderlineitemdetailsByLineItemIdAsync(Guid lineItemId);

	[Obsolete]
	LineItemsResponseModel GetOrderlineitemdetailsByLineItemId(Guid lineItemId);

	[Obsolete]
	Task<LineItemsResponseModel> GetOrderlineitemdetailsByLineItemIdAsync(Guid lineItemId, CancellationToken cancellationToken);

	[Obsolete]
	Task<LineItemsResetPriceResponseModel> PostResetpriceAsync(LineItemsResetPriceRequestModel body);

	[Obsolete]
	LineItemsResetPriceResponseModel PostResetprice(LineItemsResetPriceRequestModel body);

	[Obsolete]
	Task<LineItemsResetPriceResponseModel> PostResetpriceAsync(LineItemsResetPriceRequestModel body, CancellationToken cancellationToken);

	Task<LineItemsResetPriceResponseModel> PostResetLineItemPricesAsync(OrderItemsPriceResetRequestModel body);

	LineItemsResetPriceResponseModel PostResetLineItemPrices(OrderItemsPriceResetRequestModel body);

	Task<LineItemsResetPriceResponseModel> PostResetLineItemPricesAsync(OrderItemsPriceResetRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<UpdateQuantityResponseModel> PutQuantityAsync(UpdateQuantityMappingRequestModel body);

	[Obsolete]
	UpdateQuantityResponseModel PutQuantity(UpdateQuantityMappingRequestModel body);

	[Obsolete]
	Task<UpdateQuantityResponseModel> PutQuantityAsync(UpdateQuantityMappingRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<UpdateLineItemsStatusResponseModel> PutStatusAsync(UpdateLineItemsStatusMappingRequestModel body);

	[Obsolete]
	UpdateLineItemsStatusResponseModel PutStatus(UpdateLineItemsStatusMappingRequestModel body);

	[Obsolete]
	Task<UpdateLineItemsStatusResponseModel> PutStatusAsync(UpdateLineItemsStatusMappingRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<OrderLineItemsResponseModel> GetOrderlineitemlistByOrderIdAsync(Guid orderId);

	[Obsolete]
	OrderLineItemsResponseModel GetOrderlineitemlistByOrderId(Guid orderId);

	[Obsolete]
	Task<OrderLineItemsResponseModel> GetOrderlineitemlistByOrderIdAsync(Guid orderId, CancellationToken cancellationToken);

	[Obsolete]
	Task<UpdateLineItemsPriceResponseModel> PutPriceAsync(UpdateLineItemsPriceMappingRequestModel body);

	[Obsolete]
	UpdateLineItemsPriceResponseModel PutPrice(UpdateLineItemsPriceMappingRequestModel body);

	[Obsolete]
	Task<UpdateLineItemsPriceResponseModel> PutPriceAsync(UpdateLineItemsPriceMappingRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PostSendlineitemsByOrderIdAsync(Guid orderId, string lineItemIds);

	[Obsolete]
	BooleanResponseModel PostSendlineitemsByOrderId(Guid orderId, string lineItemIds);

	[Obsolete]
	Task<BooleanResponseModel> PostSendlineitemsByOrderIdAsync(Guid orderId, string lineItemIds, CancellationToken cancellationToken);

	[Obsolete]
	Task<OrderValidationResultResponseModel> GetValidateorderitemByOrderIdAsync(Guid orderId, Guid lineitemId);

	[Obsolete]
	OrderValidationResultResponseModel GetValidateorderitemByOrderId(Guid orderId, Guid lineitemId);

	[Obsolete]
	Task<OrderValidationResultResponseModel> GetValidateorderitemByOrderIdAsync(Guid orderId, Guid lineitemId, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PostDeleteAsync(DeleteLineItemsRequestModel body);

	[Obsolete]
	BooleanResponseModel PostDelete(DeleteLineItemsRequestModel body);

	[Obsolete]
	Task<BooleanResponseModel> PostDeleteAsync(DeleteLineItemsRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PostDuplicatelineitemAsync(DuplicateLineItemRequestModel body);

	[Obsolete]
	BooleanResponseModel PostDuplicatelineitem(DuplicateLineItemRequestModel body);

	[Obsolete]
	Task<BooleanResponseModel> PostDuplicatelineitemAsync(DuplicateLineItemRequestModel body, CancellationToken cancellationToken);

	Task<CustomDataBooleanResponse> PutBulkLineItemCustomdataByClassNumberAsync(string classNumber, string classType, IEnumerable<BulkUpdateCustomDataRequestModel> body);

	CustomDataBooleanResponse PutBulkLineItemCustomdataByClassNumber(string classNumber, string classType, IEnumerable<BulkUpdateCustomDataRequestModel> body);

	Task<CustomDataBooleanResponse> PutBulkLineItemCustomdataByClassNumberAsync(string classNumber, string classType, IEnumerable<BulkUpdateCustomDataRequestModel> body, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LineItemsClient : BaseClient, ILineItemsClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public LineItemsClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	public virtual Task<AddLineItemsResponseModel> PostAddLineItemsByClassTypeAsync(string classType, AddLineItemsRequestModel body)
	{
		return PostAddLineItemsByClassTypeAsync(classType, body, CancellationToken.None);
	}

	public virtual AddLineItemsResponseModel PostAddLineItemsByClassType(string classType, AddLineItemsRequestModel body)
	{
		return Task.Run(async () => await PostAddLineItemsByClassTypeAsync(classType, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<AddLineItemsResponseModel> PostAddLineItemsByClassTypeAsync(string classType, AddLineItemsRequestModel body, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/add-line-items";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<AddLineItemsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<AddLineItemsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new AddLineItemsResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				AddLineItemsResponseModel addLineItemsResponseModel = JsonConvert.DeserializeObject<AddLineItemsResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)addLineItemsResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<StatusResponseModel> PostCreateAsync(CreateLineItemsRequestModel body)
	{
		return PostCreateAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual StatusResponseModel PostCreate(CreateLineItemsRequestModel body)
	{
		return Task.Run(async () => await PostCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<StatusResponseModel> PostCreateAsync(CreateLineItemsRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/lineitems/create";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<StatusResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new StatusResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				StatusResponseModel statusResponseModel = JsonConvert.DeserializeObject<StatusResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)statusResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<LineItemsResponseModel> GetOrderlineitemdetailsByLineItemIdAsync(Guid lineItemId)
	{
		return GetOrderlineitemdetailsByLineItemIdAsync(lineItemId, CancellationToken.None);
	}

	[Obsolete]
	public virtual LineItemsResponseModel GetOrderlineitemdetailsByLineItemId(Guid lineItemId)
	{
		return Task.Run(async () => await GetOrderlineitemdetailsByLineItemIdAsync(lineItemId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<LineItemsResponseModel> GetOrderlineitemdetailsByLineItemIdAsync(Guid lineItemId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/lineitems/orderlineitemdetails/{lineItemId}";
		znodeApiGateway = znodeApiGateway.Replace("{lineItemId}", Uri.EscapeDataString(ConvertToString(lineItemId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<LineItemsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new LineItemsResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				LineItemsResponseModel lineItemsResponseModel = JsonConvert.DeserializeObject<LineItemsResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)lineItemsResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<LineItemsResetPriceResponseModel> PostResetpriceAsync(LineItemsResetPriceRequestModel body)
	{
		return PostResetpriceAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual LineItemsResetPriceResponseModel PostResetprice(LineItemsResetPriceRequestModel body)
	{
		return Task.Run(async () => await PostResetpriceAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<LineItemsResetPriceResponseModel> PostResetpriceAsync(LineItemsResetPriceRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/lineitems/resetprice";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<LineItemsResetPriceResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new LineItemsResetPriceResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				LineItemsResetPriceResponseModel lineItemsResetPriceResponseModel = JsonConvert.DeserializeObject<LineItemsResetPriceResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)lineItemsResetPriceResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<LineItemsResetPriceResponseModel> PostResetLineItemPricesAsync(OrderItemsPriceResetRequestModel body)
	{
		return PostResetLineItemPricesAsync(body, CancellationToken.None);
	}

	public virtual LineItemsResetPriceResponseModel PostResetLineItemPrices(OrderItemsPriceResetRequestModel body)
	{
		return Task.Run(async () => await PostResetLineItemPricesAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<LineItemsResetPriceResponseModel> PostResetLineItemPricesAsync(OrderItemsPriceResetRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/lineitems/reset-line-item-prices";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<LineItemsResetPriceResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new LineItemsResetPriceResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				LineItemsResetPriceResponseModel lineItemsResetPriceResponseModel = JsonConvert.DeserializeObject<LineItemsResetPriceResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)lineItemsResetPriceResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UpdateQuantityResponseModel> PutQuantityAsync(UpdateQuantityMappingRequestModel body)
	{
		return PutQuantityAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual UpdateQuantityResponseModel PutQuantity(UpdateQuantityMappingRequestModel body)
	{
		return Task.Run(async () => await PutQuantityAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UpdateQuantityResponseModel> PutQuantityAsync(UpdateQuantityMappingRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/lineitems/quantity";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateQuantityResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateQuantityResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateQuantityResponseModel updateQuantityResponseModel = JsonConvert.DeserializeObject<UpdateQuantityResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateQuantityResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UpdateLineItemsStatusResponseModel> PutStatusAsync(UpdateLineItemsStatusMappingRequestModel body)
	{
		return PutStatusAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual UpdateLineItemsStatusResponseModel PutStatus(UpdateLineItemsStatusMappingRequestModel body)
	{
		return Task.Run(async () => await PutStatusAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UpdateLineItemsStatusResponseModel> PutStatusAsync(UpdateLineItemsStatusMappingRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/lineitems/status";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateLineItemsStatusResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateLineItemsStatusResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateLineItemsStatusResponseModel updateLineItemsStatusResponseModel = JsonConvert.DeserializeObject<UpdateLineItemsStatusResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateLineItemsStatusResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<OrderLineItemsResponseModel> GetOrderlineitemlistByOrderIdAsync(Guid orderId)
	{
		return GetOrderlineitemlistByOrderIdAsync(orderId, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderLineItemsResponseModel GetOrderlineitemlistByOrderId(Guid orderId)
	{
		return Task.Run(async () => await GetOrderlineitemlistByOrderIdAsync(orderId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderLineItemsResponseModel> GetOrderlineitemlistByOrderIdAsync(Guid orderId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/lineitems/orderlineitemlist/{orderId}";
		znodeApiGateway = znodeApiGateway.Replace("{orderId}", Uri.EscapeDataString(ConvertToString(orderId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderLineItemsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderLineItemsResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderLineItemsResponseModel orderLineItemsResponseModel = JsonConvert.DeserializeObject<OrderLineItemsResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderLineItemsResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UpdateLineItemsPriceResponseModel> PutPriceAsync(UpdateLineItemsPriceMappingRequestModel body)
	{
		return PutPriceAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual UpdateLineItemsPriceResponseModel PutPrice(UpdateLineItemsPriceMappingRequestModel body)
	{
		return Task.Run(async () => await PutPriceAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UpdateLineItemsPriceResponseModel> PutPriceAsync(UpdateLineItemsPriceMappingRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/lineitems/price";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateLineItemsPriceResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateLineItemsPriceResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateLineItemsPriceResponseModel updateLineItemsPriceResponseModel = JsonConvert.DeserializeObject<UpdateLineItemsPriceResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateLineItemsPriceResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PostSendlineitemsByOrderIdAsync(Guid orderId, string lineItemIds)
	{
		return PostSendlineitemsByOrderIdAsync(orderId, lineItemIds, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PostSendlineitemsByOrderId(Guid orderId, string lineItemIds)
	{
		return Task.Run(async () => await PostSendlineitemsByOrderIdAsync(orderId, lineItemIds, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PostSendlineitemsByOrderIdAsync(Guid orderId, string lineItemIds, CancellationToken cancellationToken)
	{
		if (lineItemIds == null)
		{
			throw new ArgumentNullException("lineItemIds");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/lineitems/sendlineitems/{orderId}/{lineItemIds}";
		znodeApiGateway = znodeApiGateway.Replace("{orderId}", Uri.EscapeDataString(ConvertToString(orderId, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{lineItemIds}", Uri.EscapeDataString(ConvertToString(lineItemIds, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, (string)null, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<OrderValidationResultResponseModel> GetValidateorderitemByOrderIdAsync(Guid orderId, Guid lineitemId)
	{
		return GetValidateorderitemByOrderIdAsync(orderId, lineitemId, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderValidationResultResponseModel GetValidateorderitemByOrderId(Guid orderId, Guid lineitemId)
	{
		return Task.Run(async () => await GetValidateorderitemByOrderIdAsync(orderId, lineitemId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderValidationResultResponseModel> GetValidateorderitemByOrderIdAsync(Guid orderId, Guid lineitemId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/lineitems/validateorderitem/{orderId}/{lineitemId}";
		znodeApiGateway = znodeApiGateway.Replace("{orderId}", Uri.EscapeDataString(ConvertToString(orderId, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{lineitemId}", Uri.EscapeDataString(ConvertToString(lineitemId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderValidationResultResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderValidationResultResponseModel();
			case 401:
			{
				ObjectResponseResult<OrderValidationMessageResponse> objectResponseResult = await ReadObjectResponseAsync<OrderValidationMessageResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderValidationResultResponseModel orderValidationResultResponseModel = JsonConvert.DeserializeObject<OrderValidationResultResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderValidationResultResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PostDeleteAsync(DeleteLineItemsRequestModel body)
	{
		return PostDeleteAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PostDelete(DeleteLineItemsRequestModel body)
	{
		return Task.Run(async () => await PostDeleteAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PostDeleteAsync(DeleteLineItemsRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/lineitems/delete";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PostDuplicatelineitemAsync(DuplicateLineItemRequestModel body)
	{
		return PostDuplicatelineitemAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PostDuplicatelineitem(DuplicateLineItemRequestModel body)
	{
		return Task.Run(async () => await PostDuplicatelineitemAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PostDuplicatelineitemAsync(DuplicateLineItemRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/lineitems/duplicatelineitem";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<CustomDataBooleanResponse> PutBulkLineItemCustomdataByClassNumberAsync(string classNumber, string classType, IEnumerable<BulkUpdateCustomDataRequestModel> body)
	{
		return PutBulkLineItemCustomdataByClassNumberAsync(classNumber, classType, body, CancellationToken.None);
	}

	public virtual CustomDataBooleanResponse PutBulkLineItemCustomdataByClassNumber(string classNumber, string classType, IEnumerable<BulkUpdateCustomDataRequestModel> body)
	{
		return Task.Run(async () => await PutBulkLineItemCustomdataByClassNumberAsync(classNumber, classType, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomDataBooleanResponse> PutBulkLineItemCustomdataByClassNumberAsync(string classNumber, string classType, IEnumerable<BulkUpdateCustomDataRequestModel> body, CancellationToken cancellationToken)
	{
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/{classNumber}/bulk-line-item-customdata";
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CustomDataBooleanResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CustomDataBooleanResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CustomDataBooleanResponse();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CustomDataBooleanResponse customDataBooleanResponse = JsonConvert.DeserializeObject<CustomDataBooleanResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customDataBooleanResponse, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface ILogsClient : IBaseClient
{
	[Obsolete]
	Task<OrderLogListResponseModel> PostListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, OrderLogsRequestModel body);

	[Obsolete]
	OrderLogListResponseModel PostList(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, OrderLogsRequestModel body);

	[Obsolete]
	Task<OrderLogListResponseModel> PostListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, OrderLogsRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PostCreateAsync(CreateOrderLogRequestModel body);

	[Obsolete]
	BooleanResponseModel PostCreate(CreateOrderLogRequestModel body);

	[Obsolete]
	Task<BooleanResponseModel> PostCreateAsync(CreateOrderLogRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PutUpdateAsync(UpdateOrderLogRequestModel body);

	[Obsolete]
	BooleanResponseModel PutUpdate(UpdateOrderLogRequestModel body);

	[Obsolete]
	Task<BooleanResponseModel> PutUpdateAsync(UpdateOrderLogRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PostDeleteAsync(DeleteOrderLogRequestModel body);

	[Obsolete]
	BooleanResponseModel PostDelete(DeleteOrderLogRequestModel body);

	[Obsolete]
	Task<BooleanResponseModel> PostDeleteAsync(DeleteOrderLogRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> GetExportordernoteByOrderIdAsync(Guid orderId, string fileType, string viewFilter);

	[Obsolete]
	BooleanResponseModel GetExportordernoteByOrderId(Guid orderId, string fileType, string viewFilter);

	[Obsolete]
	Task<BooleanResponseModel> GetExportordernoteByOrderIdAsync(Guid orderId, string fileType, string viewFilter, CancellationToken cancellationToken);

	[Obsolete]
	Task<OrderLogFiltersListResponseModel> GetFilterlistByOrderIdAsync(Guid orderId, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	OrderLogFiltersListResponseModel GetFilterlistByOrderId(Guid orderId, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<OrderLogFiltersListResponseModel> GetFilterlistByOrderIdAsync(Guid orderId, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	Task<CreateLogsResponseModel> PostCreateLogAsync(CreateLogsRequestModel body);

	CreateLogsResponseModel PostCreateLog(CreateLogsRequestModel body);

	Task<CreateLogsResponseModel> PostCreateLogAsync(CreateLogsRequestModel body, CancellationToken cancellationToken);

	Task<NotesDetailsResponseModel> GetLogDetailsByClassTypeAsync(string classType, string classNumber, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	NotesDetailsResponseModel GetLogDetailsByClassType(string classType, string classNumber, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	Task<NotesDetailsResponseModel> GetLogDetailsByClassTypeAsync(string classType, string classNumber, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LogsClient : BaseClient, ILogsClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public LogsClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<OrderLogListResponseModel> PostListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, OrderLogsRequestModel body)
	{
		return PostListAsync(filter, sort, pageIndex, pageSize, body, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderLogListResponseModel PostList(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, OrderLogsRequestModel body)
	{
		return Task.Run(async () => await PostListAsync(filter, sort, pageIndex, pageSize, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderLogListResponseModel> PostListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, OrderLogsRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/logs/list";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderLogListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderLogListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderLogListResponseModel orderLogListResponseModel = JsonConvert.DeserializeObject<OrderLogListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderLogListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PostCreateAsync(CreateOrderLogRequestModel body)
	{
		return PostCreateAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PostCreate(CreateOrderLogRequestModel body)
	{
		return Task.Run(async () => await PostCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PostCreateAsync(CreateOrderLogRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/logs/create";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PutUpdateAsync(UpdateOrderLogRequestModel body)
	{
		return PutUpdateAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PutUpdate(UpdateOrderLogRequestModel body)
	{
		return Task.Run(async () => await PutUpdateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PutUpdateAsync(UpdateOrderLogRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/logs/update";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PostDeleteAsync(DeleteOrderLogRequestModel body)
	{
		return PostDeleteAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PostDelete(DeleteOrderLogRequestModel body)
	{
		return Task.Run(async () => await PostDeleteAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PostDeleteAsync(DeleteOrderLogRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/logs/delete";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> GetExportordernoteByOrderIdAsync(Guid orderId, string fileType, string viewFilter)
	{
		return GetExportordernoteByOrderIdAsync(orderId, fileType, viewFilter, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel GetExportordernoteByOrderId(Guid orderId, string fileType, string viewFilter)
	{
		return Task.Run(async () => await GetExportordernoteByOrderIdAsync(orderId, fileType, viewFilter, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> GetExportordernoteByOrderIdAsync(Guid orderId, string fileType, string viewFilter, CancellationToken cancellationToken)
	{
		if (fileType == null)
		{
			throw new ArgumentNullException("fileType");
		}
		if (viewFilter == null)
		{
			throw new ArgumentNullException("viewFilter");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/logs/exportordernote/{orderId}/{fileType}/{viewFilter}";
		znodeApiGateway = znodeApiGateway.Replace("{orderId}", Uri.EscapeDataString(ConvertToString(orderId, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{fileType}", Uri.EscapeDataString(ConvertToString(fileType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{viewFilter}", Uri.EscapeDataString(ConvertToString(viewFilter, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<OrderLogFiltersListResponseModel> GetFilterlistByOrderIdAsync(Guid orderId, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetFilterlistByOrderIdAsync(orderId, filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderLogFiltersListResponseModel GetFilterlistByOrderId(Guid orderId, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetFilterlistByOrderIdAsync(orderId, filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderLogFiltersListResponseModel> GetFilterlistByOrderIdAsync(Guid orderId, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/logs/filterlist/{orderId}";
		znodeApiGateway = znodeApiGateway.Replace("{orderId}", Uri.EscapeDataString(ConvertToString(orderId, CultureInfo.InvariantCulture)));
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderLogFiltersListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderLogFiltersListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderLogFiltersListResponseModel orderLogFiltersListResponseModel = JsonConvert.DeserializeObject<OrderLogFiltersListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderLogFiltersListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<CreateLogsResponseModel> PostCreateLogAsync(CreateLogsRequestModel body)
	{
		return PostCreateLogAsync(body, CancellationToken.None);
	}

	public virtual CreateLogsResponseModel PostCreateLog(CreateLogsRequestModel body)
	{
		return Task.Run(async () => await PostCreateLogAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CreateLogsResponseModel> PostCreateLogAsync(CreateLogsRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/create-log";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CreateLogsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CreateLogsResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CreateLogsResponseModel createLogsResponseModel = JsonConvert.DeserializeObject<CreateLogsResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)createLogsResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<NotesDetailsResponseModel> GetLogDetailsByClassTypeAsync(string classType, string classNumber, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetLogDetailsByClassTypeAsync(classType, classNumber, filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	public virtual NotesDetailsResponseModel GetLogDetailsByClassType(string classType, string classNumber, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetLogDetailsByClassTypeAsync(classType, classNumber, filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<NotesDetailsResponseModel> GetLogDetailsByClassTypeAsync(string classType, string classNumber, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/log-details/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<NotesDetailsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new NotesDetailsResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				NotesDetailsResponseModel notesDetailsResponseModel = JsonConvert.DeserializeObject<NotesDetailsResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)notesDetailsResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IOrderAndFlagsClient : IBaseClient
{
	[Obsolete]
	Task<OrderFlagListResponseModel> GetUnassociatedorderflaglistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	OrderFlagListResponseModel GetUnassociatedorderflaglist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<OrderFlagListResponseModel> GetUnassociatedorderflaglistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PostAddorderflagAsync(OrderFlagMappingRequestModel body);

	[Obsolete]
	BooleanResponseModel PostAddorderflag(OrderFlagMappingRequestModel body);

	[Obsolete]
	Task<BooleanResponseModel> PostAddorderflagAsync(OrderFlagMappingRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<UpdateOrderFlagStatusResponseModel> PutUpdateAsync(UpdateOrderFlagMappingRequestModel body);

	[Obsolete]
	UpdateOrderFlagStatusResponseModel PutUpdate(UpdateOrderFlagMappingRequestModel body);

	[Obsolete]
	Task<UpdateOrderFlagStatusResponseModel> PutUpdateAsync(UpdateOrderFlagMappingRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<OrderFlagListResponseModel> GetOrderdetailswithflagByOrderIdAsync(Guid orderId);

	[Obsolete]
	OrderFlagListResponseModel GetOrderdetailswithflagByOrderId(Guid orderId);

	[Obsolete]
	Task<OrderFlagListResponseModel> GetOrderdetailswithflagByOrderIdAsync(Guid orderId, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> DeleteDeleteByOrderFlagIdAsync(Guid orderFlagId);

	[Obsolete]
	BooleanResponseModel DeleteDeleteByOrderFlagId(Guid orderFlagId);

	[Obsolete]
	Task<BooleanResponseModel> DeleteDeleteByOrderFlagIdAsync(Guid orderFlagId, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderAndFlagsClient : BaseClient, IOrderAndFlagsClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public OrderAndFlagsClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<OrderFlagListResponseModel> GetUnassociatedorderflaglistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetUnassociatedorderflaglistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderFlagListResponseModel GetUnassociatedorderflaglist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetUnassociatedorderflaglistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderFlagListResponseModel> GetUnassociatedorderflaglistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orderandflags/unassociatedorderflaglist";
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderFlagListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderFlagListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderFlagListResponseModel orderFlagListResponseModel = JsonConvert.DeserializeObject<OrderFlagListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderFlagListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PostAddorderflagAsync(OrderFlagMappingRequestModel body)
	{
		return PostAddorderflagAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PostAddorderflag(OrderFlagMappingRequestModel body)
	{
		return Task.Run(async () => await PostAddorderflagAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PostAddorderflagAsync(OrderFlagMappingRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orderandflags/addorderflag";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UpdateOrderFlagStatusResponseModel> PutUpdateAsync(UpdateOrderFlagMappingRequestModel body)
	{
		return PutUpdateAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual UpdateOrderFlagStatusResponseModel PutUpdate(UpdateOrderFlagMappingRequestModel body)
	{
		return Task.Run(async () => await PutUpdateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UpdateOrderFlagStatusResponseModel> PutUpdateAsync(UpdateOrderFlagMappingRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orderandflags/update";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateOrderFlagStatusResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<UpdateOrderFlagStatusResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateOrderFlagStatusResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateOrderFlagStatusResponseModel updateOrderFlagStatusResponseModel = JsonConvert.DeserializeObject<UpdateOrderFlagStatusResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateOrderFlagStatusResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<OrderFlagListResponseModel> GetOrderdetailswithflagByOrderIdAsync(Guid orderId)
	{
		return GetOrderdetailswithflagByOrderIdAsync(orderId, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderFlagListResponseModel GetOrderdetailswithflagByOrderId(Guid orderId)
	{
		return Task.Run(async () => await GetOrderdetailswithflagByOrderIdAsync(orderId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderFlagListResponseModel> GetOrderdetailswithflagByOrderIdAsync(Guid orderId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orderandflags/orderdetailswithflag/{orderId}";
		znodeApiGateway = znodeApiGateway.Replace("{orderId}", Uri.EscapeDataString(ConvertToString(orderId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderFlagListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderFlagListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderFlagListResponseModel orderFlagListResponseModel = JsonConvert.DeserializeObject<OrderFlagListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderFlagListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> DeleteDeleteByOrderFlagIdAsync(Guid orderFlagId)
	{
		return DeleteDeleteByOrderFlagIdAsync(orderFlagId, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel DeleteDeleteByOrderFlagId(Guid orderFlagId)
	{
		return Task.Run(async () => await DeleteDeleteByOrderFlagIdAsync(orderFlagId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> DeleteDeleteByOrderFlagIdAsync(Guid orderFlagId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orderandflags/delete/{orderFlagId}";
		znodeApiGateway = znodeApiGateway.Replace("{orderFlagId}", Uri.EscapeDataString(ConvertToString(orderFlagId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).DeleteResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IOrderAndUsersClient : IBaseClient
{
	[Obsolete]
	Task<UsersInMyTeamListResponseModel> GetUsersinmyteamByUserIdAsync(int userId);

	[Obsolete]
	UsersInMyTeamListResponseModel GetUsersinmyteamByUserId(int userId);

	[Obsolete]
	Task<UsersInMyTeamListResponseModel> GetUsersinmyteamByUserIdAsync(int userId, CancellationToken cancellationToken);

	[Obsolete]
	Task<OrderUserGroupListResponseModel> GetUnassociatedusergrouplistByOrderIdAsync(Guid orderId);

	[Obsolete]
	OrderUserGroupListResponseModel GetUnassociatedusergrouplistByOrderId(Guid orderId);

	[Obsolete]
	Task<OrderUserGroupListResponseModel> GetUnassociatedusergrouplistByOrderIdAsync(Guid orderId, CancellationToken cancellationToken);

	[Obsolete]
	Task<OrderOwnerDetailsResponseModel> PostAssignownerandusergroupAsync(OrderOwnerDetailsRequestModel body);

	[Obsolete]
	OrderOwnerDetailsResponseModel PostAssignownerandusergroup(OrderOwnerDetailsRequestModel body);

	[Obsolete]
	Task<OrderOwnerDetailsResponseModel> PostAssignownerandusergroupAsync(OrderOwnerDetailsRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> DeleteDeleteByOrderUserGroupIdAsync(Guid orderUserGroupId);

	[Obsolete]
	BooleanResponseModel DeleteDeleteByOrderUserGroupId(Guid orderUserGroupId);

	[Obsolete]
	Task<BooleanResponseModel> DeleteDeleteByOrderUserGroupIdAsync(Guid orderUserGroupId, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderAndUsersClient : BaseClient, IOrderAndUsersClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public OrderAndUsersClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<UsersInMyTeamListResponseModel> GetUsersinmyteamByUserIdAsync(int userId)
	{
		return GetUsersinmyteamByUserIdAsync(userId, CancellationToken.None);
	}

	[Obsolete]
	public virtual UsersInMyTeamListResponseModel GetUsersinmyteamByUserId(int userId)
	{
		return Task.Run(async () => await GetUsersinmyteamByUserIdAsync(userId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UsersInMyTeamListResponseModel> GetUsersinmyteamByUserIdAsync(int userId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orderandusers/usersinmyteam/{userId}";
		znodeApiGateway = znodeApiGateway.Replace("{userId}", Uri.EscapeDataString(ConvertToString(userId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UsersInMyTeamListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UsersInMyTeamListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UsersInMyTeamListResponseModel usersInMyTeamListResponseModel = JsonConvert.DeserializeObject<UsersInMyTeamListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)usersInMyTeamListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<OrderUserGroupListResponseModel> GetUnassociatedusergrouplistByOrderIdAsync(Guid orderId)
	{
		return GetUnassociatedusergrouplistByOrderIdAsync(orderId, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderUserGroupListResponseModel GetUnassociatedusergrouplistByOrderId(Guid orderId)
	{
		return Task.Run(async () => await GetUnassociatedusergrouplistByOrderIdAsync(orderId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderUserGroupListResponseModel> GetUnassociatedusergrouplistByOrderIdAsync(Guid orderId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orderandusers/unassociatedusergrouplist/{orderId}";
		znodeApiGateway = znodeApiGateway.Replace("{orderId}", Uri.EscapeDataString(ConvertToString(orderId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderUserGroupListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderUserGroupListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderUserGroupListResponseModel orderUserGroupListResponseModel = JsonConvert.DeserializeObject<OrderUserGroupListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderUserGroupListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<OrderOwnerDetailsResponseModel> PostAssignownerandusergroupAsync(OrderOwnerDetailsRequestModel body)
	{
		return PostAssignownerandusergroupAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderOwnerDetailsResponseModel PostAssignownerandusergroup(OrderOwnerDetailsRequestModel body)
	{
		return Task.Run(async () => await PostAssignownerandusergroupAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderOwnerDetailsResponseModel> PostAssignownerandusergroupAsync(OrderOwnerDetailsRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orderandusers/assignownerandusergroup";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderOwnerDetailsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderOwnerDetailsResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderOwnerDetailsResponseModel orderOwnerDetailsResponseModel = JsonConvert.DeserializeObject<OrderOwnerDetailsResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderOwnerDetailsResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> DeleteDeleteByOrderUserGroupIdAsync(Guid orderUserGroupId)
	{
		return DeleteDeleteByOrderUserGroupIdAsync(orderUserGroupId, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel DeleteDeleteByOrderUserGroupId(Guid orderUserGroupId)
	{
		return Task.Run(async () => await DeleteDeleteByOrderUserGroupIdAsync(orderUserGroupId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> DeleteDeleteByOrderUserGroupIdAsync(Guid orderUserGroupId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orderandusers/delete/{orderUserGroupId}";
		znodeApiGateway = znodeApiGateway.Replace("{orderUserGroupId}", Uri.EscapeDataString(ConvertToString(orderUserGroupId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).DeleteResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IOrderClassButtonsClient : IBaseClient
{
	[Obsolete]
	Task<OrderResponseModel> GetListByOmsOrderStateIdAsync(int omsOrderStateId);

	[Obsolete]
	OrderResponseModel GetListByOmsOrderStateId(int omsOrderStateId);

	[Obsolete]
	Task<OrderResponseModel> GetListByOmsOrderStateIdAsync(int omsOrderStateId, CancellationToken cancellationToken);

	[Obsolete]
	Task<ActionButtonListResponseModel> GetOrderstatusbuttonlistByOmsOrderStateIdAsync(int omsOrderStateId);

	[Obsolete]
	ActionButtonListResponseModel GetOrderstatusbuttonlistByOmsOrderStateId(int omsOrderStateId);

	[Obsolete]
	Task<ActionButtonListResponseModel> GetOrderstatusbuttonlistByOmsOrderStateIdAsync(int omsOrderStateId, CancellationToken cancellationToken);

	[Obsolete]
	Task<ActionButtonDetailsResponseModel> GetButtondetailbyidByButtonIdAsync(int buttonId, string buttonType);

	[Obsolete]
	ActionButtonDetailsResponseModel GetButtondetailbyidByButtonId(int buttonId, string buttonType);

	[Obsolete]
	Task<ActionButtonDetailsResponseModel> GetButtondetailbyidByButtonIdAsync(int buttonId, string buttonType, CancellationToken cancellationToken);

	[Obsolete]
	Task<OrderStatusDetailResponseModel> GetOrderstatusbyidByOmsOrderStateIdAsync(int omsOrderStateId);

	[Obsolete]
	OrderStatusDetailResponseModel GetOrderstatusbyidByOmsOrderStateId(int omsOrderStateId);

	[Obsolete]
	Task<OrderStatusDetailResponseModel> GetOrderstatusbyidByOmsOrderStateIdAsync(int omsOrderStateId, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderClassButtonsClient : BaseClient, IOrderClassButtonsClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public OrderClassButtonsClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<OrderResponseModel> GetListByOmsOrderStateIdAsync(int omsOrderStateId)
	{
		return GetListByOmsOrderStateIdAsync(omsOrderStateId, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderResponseModel GetListByOmsOrderStateId(int omsOrderStateId)
	{
		return Task.Run(async () => await GetListByOmsOrderStateIdAsync(omsOrderStateId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderResponseModel> GetListByOmsOrderStateIdAsync(int omsOrderStateId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orderclassbuttons/list/{omsOrderStateId}";
		znodeApiGateway = znodeApiGateway.Replace("{omsOrderStateId}", Uri.EscapeDataString(ConvertToString(omsOrderStateId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderResponseModel orderResponseModel = JsonConvert.DeserializeObject<OrderResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<ActionButtonListResponseModel> GetOrderstatusbuttonlistByOmsOrderStateIdAsync(int omsOrderStateId)
	{
		return GetOrderstatusbuttonlistByOmsOrderStateIdAsync(omsOrderStateId, CancellationToken.None);
	}

	[Obsolete]
	public virtual ActionButtonListResponseModel GetOrderstatusbuttonlistByOmsOrderStateId(int omsOrderStateId)
	{
		return Task.Run(async () => await GetOrderstatusbuttonlistByOmsOrderStateIdAsync(omsOrderStateId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<ActionButtonListResponseModel> GetOrderstatusbuttonlistByOmsOrderStateIdAsync(int omsOrderStateId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orderclassbuttons/orderstatusbuttonlist/{omsOrderStateId}";
		znodeApiGateway = znodeApiGateway.Replace("{omsOrderStateId}", Uri.EscapeDataString(ConvertToString(omsOrderStateId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ActionButtonListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ActionButtonListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ActionButtonListResponseModel actionButtonListResponseModel = JsonConvert.DeserializeObject<ActionButtonListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)actionButtonListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<ActionButtonDetailsResponseModel> GetButtondetailbyidByButtonIdAsync(int buttonId, string buttonType)
	{
		return GetButtondetailbyidByButtonIdAsync(buttonId, buttonType, CancellationToken.None);
	}

	[Obsolete]
	public virtual ActionButtonDetailsResponseModel GetButtondetailbyidByButtonId(int buttonId, string buttonType)
	{
		return Task.Run(async () => await GetButtondetailbyidByButtonIdAsync(buttonId, buttonType, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<ActionButtonDetailsResponseModel> GetButtondetailbyidByButtonIdAsync(int buttonId, string buttonType, CancellationToken cancellationToken)
	{
		if (buttonType == null)
		{
			throw new ArgumentNullException("buttonType");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orderclassbuttons/buttondetailbyid/{buttonId}/{buttonType}";
		znodeApiGateway = znodeApiGateway.Replace("{buttonId}", Uri.EscapeDataString(ConvertToString(buttonId, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{buttonType}", Uri.EscapeDataString(ConvertToString(buttonType, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ActionButtonDetailsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ActionButtonDetailsResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ActionButtonDetailsResponseModel actionButtonDetailsResponseModel = JsonConvert.DeserializeObject<ActionButtonDetailsResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)actionButtonDetailsResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<OrderStatusDetailResponseModel> GetOrderstatusbyidByOmsOrderStateIdAsync(int omsOrderStateId)
	{
		return GetOrderstatusbyidByOmsOrderStateIdAsync(omsOrderStateId, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderStatusDetailResponseModel GetOrderstatusbyidByOmsOrderStateId(int omsOrderStateId)
	{
		return Task.Run(async () => await GetOrderstatusbyidByOmsOrderStateIdAsync(omsOrderStateId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderStatusDetailResponseModel> GetOrderstatusbyidByOmsOrderStateIdAsync(int omsOrderStateId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orderclassbuttons/orderstatusbyid/{omsOrderStateId}";
		znodeApiGateway = znodeApiGateway.Replace("{omsOrderStateId}", Uri.EscapeDataString(ConvertToString(omsOrderStateId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderStatusDetailResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderStatusDetailResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderStatusDetailResponseModel orderStatusDetailResponseModel = JsonConvert.DeserializeObject<OrderStatusDetailResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderStatusDetailResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IOrdersClient : IBaseClient
{
	[Obsolete]
	Task<OrderResponseModel> PostOrderListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, OrderDetailsRequestModel body);

	[Obsolete]
	OrderResponseModel PostOrderList(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, OrderDetailsRequestModel body);

	[Obsolete]
	Task<OrderResponseModel> PostOrderListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, OrderDetailsRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<StatusResponseModel> PostCreateAsync(CreateOrderRequestModel body);

	[Obsolete]
	StatusResponseModel PostCreate(CreateOrderRequestModel body);

	[Obsolete]
	Task<StatusResponseModel> PostCreateAsync(CreateOrderRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PutUpdateAsync(UpdateOrderRequestModel body);

	[Obsolete]
	BooleanResponseModel PutUpdate(UpdateOrderRequestModel body);

	[Obsolete]
	Task<BooleanResponseModel> PutUpdateAsync(UpdateOrderRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<OrderValidationMessageResponseModel> GetValidateorderByOrderIdAsync(Guid orderId);

	[Obsolete]
	OrderValidationMessageResponseModel GetValidateorderByOrderId(Guid orderId);

	[Obsolete]
	Task<OrderValidationMessageResponseModel> GetValidateorderByOrderIdAsync(Guid orderId, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PostCompleteorderAsync(CompleteOrderRequestModel body);

	[Obsolete]
	BooleanResponseModel PostCompleteorder(CompleteOrderRequestModel body);

	[Obsolete]
	Task<BooleanResponseModel> PostCompleteorderAsync(CompleteOrderRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<StatusResponseModel> PostDuplicateorderAsync(DuplicateOrderRequestModel body);

	[Obsolete]
	StatusResponseModel PostDuplicateorder(DuplicateOrderRequestModel body);

	[Obsolete]
	Task<StatusResponseModel> PostDuplicateorderAsync(DuplicateOrderRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<UnProcessedOrderListResponseModel> PutOwnerAsync(OrderOwnerDetailsRquestModel body);

	[Obsolete]
	UnProcessedOrderListResponseModel PutOwner(OrderOwnerDetailsRquestModel body);

	[Obsolete]
	Task<UnProcessedOrderListResponseModel> PutOwnerAsync(OrderOwnerDetailsRquestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<UnProcessedOrderListResponseModel> PutFollowersAsync(OrderFollowerRequestModel body);

	[Obsolete]
	UnProcessedOrderListResponseModel PutFollowers(OrderFollowerRequestModel body);

	[Obsolete]
	Task<UnProcessedOrderListResponseModel> PutFollowersAsync(OrderFollowerRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PutOrderstatusAsync(UpdateOrderStatusRequestModel body);

	[Obsolete]
	BooleanResponseModel PutOrderstatus(UpdateOrderStatusRequestModel body);

	[Obsolete]
	Task<BooleanResponseModel> PutOrderstatusAsync(UpdateOrderStatusRequestModel body, CancellationToken cancellationToken);

	Task<ReorderResponseModel> PostReorderByClassTypeAsync(string classType, ReorderRequestModel body);

	ReorderResponseModel PostReorderByClassType(string classType, ReorderRequestModel body);

	Task<ReorderResponseModel> PostReorderByClassTypeAsync(string classType, ReorderRequestModel body, CancellationToken cancellationToken);

	Task<CommerceCollectionClassDetailResponseModel> GetOrderTrackingDetailsByClassNumberAsync(string classNumber, string emailAddress);

	CommerceCollectionClassDetailResponseModel GetOrderTrackingDetailsByClassNumber(string classNumber, string emailAddress);

	Task<CommerceCollectionClassDetailResponseModel> GetOrderTrackingDetailsByClassNumberAsync(string classNumber, string emailAddress, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrdersClient : BaseClient, IOrdersClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public OrdersClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<OrderResponseModel> PostOrderListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, OrderDetailsRequestModel body)
	{
		return PostOrderListAsync(filter, sort, pageIndex, pageSize, body, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderResponseModel PostOrderList(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, OrderDetailsRequestModel body)
	{
		return Task.Run(async () => await PostOrderListAsync(filter, sort, pageIndex, pageSize, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderResponseModel> PostOrderListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, OrderDetailsRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orders/order-list";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderResponseModel orderResponseModel = JsonConvert.DeserializeObject<OrderResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<StatusResponseModel> PostCreateAsync(CreateOrderRequestModel body)
	{
		return PostCreateAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual StatusResponseModel PostCreate(CreateOrderRequestModel body)
	{
		return Task.Run(async () => await PostCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<StatusResponseModel> PostCreateAsync(CreateOrderRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orders/create";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<StatusResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<StatusResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new StatusResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				StatusResponseModel statusResponseModel = JsonConvert.DeserializeObject<StatusResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)statusResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PutUpdateAsync(UpdateOrderRequestModel body)
	{
		return PutUpdateAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PutUpdate(UpdateOrderRequestModel body)
	{
		return Task.Run(async () => await PutUpdateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PutUpdateAsync(UpdateOrderRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orders/update";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<OrderValidationMessageResponseModel> GetValidateorderByOrderIdAsync(Guid orderId)
	{
		return GetValidateorderByOrderIdAsync(orderId, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderValidationMessageResponseModel GetValidateorderByOrderId(Guid orderId)
	{
		return Task.Run(async () => await GetValidateorderByOrderIdAsync(orderId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderValidationMessageResponseModel> GetValidateorderByOrderIdAsync(Guid orderId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orders/validateorder/{orderId}";
		znodeApiGateway = znodeApiGateway.Replace("{orderId}", Uri.EscapeDataString(ConvertToString(orderId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderValidationMessageResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderValidationMessageResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderValidationMessageResponseModel orderValidationMessageResponseModel = JsonConvert.DeserializeObject<OrderValidationMessageResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderValidationMessageResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PostCompleteorderAsync(CompleteOrderRequestModel body)
	{
		return PostCompleteorderAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PostCompleteorder(CompleteOrderRequestModel body)
	{
		return Task.Run(async () => await PostCompleteorderAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PostCompleteorderAsync(CompleteOrderRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orders/completeorder";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<StatusResponseModel> PostDuplicateorderAsync(DuplicateOrderRequestModel body)
	{
		return PostDuplicateorderAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual StatusResponseModel PostDuplicateorder(DuplicateOrderRequestModel body)
	{
		return Task.Run(async () => await PostDuplicateorderAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<StatusResponseModel> PostDuplicateorderAsync(DuplicateOrderRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orders/duplicateorder";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<StatusResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<StatusResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new StatusResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				StatusResponseModel statusResponseModel = JsonConvert.DeserializeObject<StatusResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)statusResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UnProcessedOrderListResponseModel> PutOwnerAsync(OrderOwnerDetailsRquestModel body)
	{
		return PutOwnerAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual UnProcessedOrderListResponseModel PutOwner(OrderOwnerDetailsRquestModel body)
	{
		return Task.Run(async () => await PutOwnerAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UnProcessedOrderListResponseModel> PutOwnerAsync(OrderOwnerDetailsRquestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orders/owner";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UnProcessedOrderListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<UnProcessedOrderListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UnProcessedOrderListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UnProcessedOrderListResponseModel unProcessedOrderListResponseModel = JsonConvert.DeserializeObject<UnProcessedOrderListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)unProcessedOrderListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UnProcessedOrderListResponseModel> PutFollowersAsync(OrderFollowerRequestModel body)
	{
		return PutFollowersAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual UnProcessedOrderListResponseModel PutFollowers(OrderFollowerRequestModel body)
	{
		return Task.Run(async () => await PutFollowersAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UnProcessedOrderListResponseModel> PutFollowersAsync(OrderFollowerRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orders/followers";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UnProcessedOrderListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<UnProcessedOrderListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UnProcessedOrderListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UnProcessedOrderListResponseModel unProcessedOrderListResponseModel = JsonConvert.DeserializeObject<UnProcessedOrderListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)unProcessedOrderListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PutOrderstatusAsync(UpdateOrderStatusRequestModel body)
	{
		return PutOrderstatusAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PutOrderstatus(UpdateOrderStatusRequestModel body)
	{
		return Task.Run(async () => await PutOrderstatusAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PutOrderstatusAsync(UpdateOrderStatusRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orders/orderstatus";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<ReorderResponseModel> PostReorderByClassTypeAsync(string classType, ReorderRequestModel body)
	{
		return PostReorderByClassTypeAsync(classType, body, CancellationToken.None);
	}

	public virtual ReorderResponseModel PostReorderByClassType(string classType, ReorderRequestModel body)
	{
		return Task.Run(async () => await PostReorderByClassTypeAsync(classType, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<ReorderResponseModel> PostReorderByClassTypeAsync(string classType, ReorderRequestModel body, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/reorder";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ReorderResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<ReorderResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ReorderResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ReorderResponseModel reorderResponseModel = JsonConvert.DeserializeObject<ReorderResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)reorderResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<CommerceCollectionClassDetailResponseModel> GetOrderTrackingDetailsByClassNumberAsync(string classNumber, string emailAddress)
	{
		return GetOrderTrackingDetailsByClassNumberAsync(classNumber, emailAddress, CancellationToken.None);
	}

	public virtual CommerceCollectionClassDetailResponseModel GetOrderTrackingDetailsByClassNumber(string classNumber, string emailAddress)
	{
		return Task.Run(async () => await GetOrderTrackingDetailsByClassNumberAsync(classNumber, emailAddress, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CommerceCollectionClassDetailResponseModel> GetOrderTrackingDetailsByClassNumberAsync(string classNumber, string emailAddress, CancellationToken cancellationToken)
	{
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		if (emailAddress == null)
		{
			throw new ArgumentNullException("emailAddress");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/orders/order-tracking-details/{classNumber}/{emailAddress}";
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{emailAddress}", Uri.EscapeDataString(ConvertToString(emailAddress, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CommerceCollectionClassDetailResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CommerceCollectionClassDetailResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CommerceCollectionClassDetailResponseModel commerceCollectionClassDetailResponseModel = JsonConvert.DeserializeObject<CommerceCollectionClassDetailResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)commerceCollectionClassDetailResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IOrderTemplatesClient : IBaseClient
{
	Task<CreateOrderTemplateResponseModel> PostCreateOrderTemplatesAsync(CreateOrderTemplateRequestModel body);

	CreateOrderTemplateResponseModel PostCreateOrderTemplates(CreateOrderTemplateRequestModel body);

	Task<CreateOrderTemplateResponseModel> PostCreateOrderTemplatesAsync(CreateOrderTemplateRequestModel body, CancellationToken cancellationToken);

	Task<UpdateOrderTemplateResponseModel> PutUpdateOrderTemplatesAsync(UpdateOrderTemplateRequestModel body);

	UpdateOrderTemplateResponseModel PutUpdateOrderTemplates(UpdateOrderTemplateRequestModel body);

	Task<UpdateOrderTemplateResponseModel> PutUpdateOrderTemplatesAsync(UpdateOrderTemplateRequestModel body, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderTemplatesClient : BaseClient, IOrderTemplatesClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public OrderTemplatesClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	public virtual Task<CreateOrderTemplateResponseModel> PostCreateOrderTemplatesAsync(CreateOrderTemplateRequestModel body)
	{
		return PostCreateOrderTemplatesAsync(body, CancellationToken.None);
	}

	public virtual CreateOrderTemplateResponseModel PostCreateOrderTemplates(CreateOrderTemplateRequestModel body)
	{
		return Task.Run(async () => await PostCreateOrderTemplatesAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CreateOrderTemplateResponseModel> PostCreateOrderTemplatesAsync(CreateOrderTemplateRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/create-order-templates";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CreateOrderTemplateResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CreateOrderTemplateResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CreateOrderTemplateResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CreateOrderTemplateResponseModel createOrderTemplateResponseModel = JsonConvert.DeserializeObject<CreateOrderTemplateResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)createOrderTemplateResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<UpdateOrderTemplateResponseModel> PutUpdateOrderTemplatesAsync(UpdateOrderTemplateRequestModel body)
	{
		return PutUpdateOrderTemplatesAsync(body, CancellationToken.None);
	}

	public virtual UpdateOrderTemplateResponseModel PutUpdateOrderTemplates(UpdateOrderTemplateRequestModel body)
	{
		return Task.Run(async () => await PutUpdateOrderTemplatesAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<UpdateOrderTemplateResponseModel> PutUpdateOrderTemplatesAsync(UpdateOrderTemplateRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/update-order-templates";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateOrderTemplateResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<UpdateOrderTemplateResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateOrderTemplateResponseModel();
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateOrderTemplateResponseModel updateOrderTemplateResponseModel = JsonConvert.DeserializeObject<UpdateOrderTemplateResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateOrderTemplateResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IOrderTypesClient : IBaseClient
{
	[Obsolete]
	Task<OrderTypeListResponseModel> GetListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	OrderTypeListResponseModel GetList(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<OrderTypeListResponseModel> GetListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<CreateOrderTypeResponseModel> PostCreateAsync(CreateOrderTypeRequestModel body);

	[Obsolete]
	CreateOrderTypeResponseModel PostCreate(CreateOrderTypeRequestModel body);

	[Obsolete]
	Task<CreateOrderTypeResponseModel> PostCreateAsync(CreateOrderTypeRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<UpdateOrderTypeResponseModel> PutUpdateAsync(UpdateOrderTypeRequestModel body);

	[Obsolete]
	UpdateOrderTypeResponseModel PutUpdate(UpdateOrderTypeRequestModel body);

	[Obsolete]
	Task<UpdateOrderTypeResponseModel> PutUpdateAsync(UpdateOrderTypeRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> DeleteDeleteByOrderTypeIdAsync(string orderTypeId);

	[Obsolete]
	BooleanResponseModel DeleteDeleteByOrderTypeId(string orderTypeId);

	[Obsolete]
	Task<BooleanResponseModel> DeleteDeleteByOrderTypeIdAsync(string orderTypeId, CancellationToken cancellationToken);

	[Obsolete]
	Task<OrderTypeDetailResponseModel> GetOrdertypeByOrderTypeIdAsync(int orderTypeId);

	[Obsolete]
	OrderTypeDetailResponseModel GetOrdertypeByOrderTypeId(int orderTypeId);

	[Obsolete]
	Task<OrderTypeDetailResponseModel> GetOrdertypeByOrderTypeIdAsync(int orderTypeId, CancellationToken cancellationToken);

	[Obsolete]
	Task<OrderFlagListResponseModel> GetAssociatedorderflaglistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	OrderFlagListResponseModel GetAssociatedorderflaglist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<OrderFlagListResponseModel> GetAssociatedorderflaglistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<UserGroupListResponseModel> GetAssociatedusergrouplistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	UserGroupListResponseModel GetAssociatedusergrouplist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<UserGroupListResponseModel> GetAssociatedusergrouplistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<OrderFlagListResponseModel> GetUnassociatedorderflaglistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	OrderFlagListResponseModel GetUnassociatedorderflaglist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<OrderFlagListResponseModel> GetUnassociatedorderflaglistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<UserGroupListResponseModel> GetUnassociatedusergrouplistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	UserGroupListResponseModel GetUnassociatedusergrouplist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<UserGroupListResponseModel> GetUnassociatedusergrouplistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PostAssociateorderflagsAsync(ParameterOrderFlagRequestModel body);

	[Obsolete]
	BooleanResponseModel PostAssociateorderflags(ParameterOrderFlagRequestModel body);

	[Obsolete]
	Task<BooleanResponseModel> PostAssociateorderflagsAsync(ParameterOrderFlagRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PostAssociateusergroupsAsync(ParameterUserGroupRequestModel body);

	[Obsolete]
	BooleanResponseModel PostAssociateusergroups(ParameterUserGroupRequestModel body);

	[Obsolete]
	Task<BooleanResponseModel> PostAssociateusergroupsAsync(ParameterUserGroupRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PostUnassociateorderflagsByCpOrderFlagIdAsync(string cpOrderFlagId, string cpOrderTypeId);

	[Obsolete]
	BooleanResponseModel PostUnassociateorderflagsByCpOrderFlagId(string cpOrderFlagId, string cpOrderTypeId);

	[Obsolete]
	Task<BooleanResponseModel> PostUnassociateorderflagsByCpOrderFlagIdAsync(string cpOrderFlagId, string cpOrderTypeId, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PostUnassociateusergroupsByCpUserGroupIdAsync(string cpUserGroupId, string cpOrderTypeId);

	[Obsolete]
	BooleanResponseModel PostUnassociateusergroupsByCpUserGroupId(string cpUserGroupId, string cpOrderTypeId);

	[Obsolete]
	Task<BooleanResponseModel> PostUnassociateusergroupsByCpUserGroupIdAsync(string cpUserGroupId, string cpOrderTypeId, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderTypesClient : BaseClient, IOrderTypesClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public OrderTypesClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<OrderTypeListResponseModel> GetListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetListAsync(filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderTypeListResponseModel GetList(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetListAsync(filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderTypeListResponseModel> GetListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/ordertypes/list";
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderTypeListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderTypeListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderTypeListResponseModel orderTypeListResponseModel = JsonConvert.DeserializeObject<OrderTypeListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderTypeListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<CreateOrderTypeResponseModel> PostCreateAsync(CreateOrderTypeRequestModel body)
	{
		return PostCreateAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual CreateOrderTypeResponseModel PostCreate(CreateOrderTypeRequestModel body)
	{
		return Task.Run(async () => await PostCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<CreateOrderTypeResponseModel> PostCreateAsync(CreateOrderTypeRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/ordertypes/create";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CreateOrderTypeResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CreateOrderTypeResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CreateOrderTypeResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CreateOrderTypeResponseModel createOrderTypeResponseModel = JsonConvert.DeserializeObject<CreateOrderTypeResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)createOrderTypeResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UpdateOrderTypeResponseModel> PutUpdateAsync(UpdateOrderTypeRequestModel body)
	{
		return PutUpdateAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual UpdateOrderTypeResponseModel PutUpdate(UpdateOrderTypeRequestModel body)
	{
		return Task.Run(async () => await PutUpdateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UpdateOrderTypeResponseModel> PutUpdateAsync(UpdateOrderTypeRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/ordertypes/update";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateOrderTypeResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateOrderTypeResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateOrderTypeResponseModel updateOrderTypeResponseModel = JsonConvert.DeserializeObject<UpdateOrderTypeResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateOrderTypeResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> DeleteDeleteByOrderTypeIdAsync(string orderTypeId)
	{
		return DeleteDeleteByOrderTypeIdAsync(orderTypeId, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel DeleteDeleteByOrderTypeId(string orderTypeId)
	{
		return Task.Run(async () => await DeleteDeleteByOrderTypeIdAsync(orderTypeId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> DeleteDeleteByOrderTypeIdAsync(string orderTypeId, CancellationToken cancellationToken)
	{
		if (orderTypeId == null)
		{
			throw new ArgumentNullException("orderTypeId");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/ordertypes/delete/{orderTypeId}";
		znodeApiGateway = znodeApiGateway.Replace("{orderTypeId}", Uri.EscapeDataString(ConvertToString(orderTypeId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).DeleteResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<OrderTypeDetailResponseModel> GetOrdertypeByOrderTypeIdAsync(int orderTypeId)
	{
		return GetOrdertypeByOrderTypeIdAsync(orderTypeId, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderTypeDetailResponseModel GetOrdertypeByOrderTypeId(int orderTypeId)
	{
		return Task.Run(async () => await GetOrdertypeByOrderTypeIdAsync(orderTypeId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderTypeDetailResponseModel> GetOrdertypeByOrderTypeIdAsync(int orderTypeId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/ordertypes/ordertype/{orderTypeId}";
		znodeApiGateway = znodeApiGateway.Replace("{orderTypeId}", Uri.EscapeDataString(ConvertToString(orderTypeId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderTypeDetailResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderTypeDetailResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderTypeDetailResponseModel orderTypeDetailResponseModel = JsonConvert.DeserializeObject<OrderTypeDetailResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderTypeDetailResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<OrderFlagListResponseModel> GetAssociatedorderflaglistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetAssociatedorderflaglistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderFlagListResponseModel GetAssociatedorderflaglist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetAssociatedorderflaglistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderFlagListResponseModel> GetAssociatedorderflaglistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/ordertypes/associatedorderflaglist";
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderFlagListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderFlagListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderFlagListResponseModel orderFlagListResponseModel = JsonConvert.DeserializeObject<OrderFlagListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderFlagListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UserGroupListResponseModel> GetAssociatedusergrouplistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetAssociatedusergrouplistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual UserGroupListResponseModel GetAssociatedusergrouplist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetAssociatedusergrouplistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UserGroupListResponseModel> GetAssociatedusergrouplistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/ordertypes/associatedusergrouplist";
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UserGroupListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UserGroupListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UserGroupListResponseModel userGroupListResponseModel = JsonConvert.DeserializeObject<UserGroupListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)userGroupListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<OrderFlagListResponseModel> GetUnassociatedorderflaglistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetUnassociatedorderflaglistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderFlagListResponseModel GetUnassociatedorderflaglist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetUnassociatedorderflaglistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderFlagListResponseModel> GetUnassociatedorderflaglistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/ordertypes/unassociatedorderflaglist";
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderFlagListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderFlagListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderFlagListResponseModel orderFlagListResponseModel = JsonConvert.DeserializeObject<OrderFlagListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderFlagListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UserGroupListResponseModel> GetUnassociatedusergrouplistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetUnassociatedusergrouplistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual UserGroupListResponseModel GetUnassociatedusergrouplist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetUnassociatedusergrouplistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UserGroupListResponseModel> GetUnassociatedusergrouplistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/ordertypes/unassociatedusergrouplist";
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UserGroupListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UserGroupListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UserGroupListResponseModel userGroupListResponseModel = JsonConvert.DeserializeObject<UserGroupListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)userGroupListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PostAssociateorderflagsAsync(ParameterOrderFlagRequestModel body)
	{
		return PostAssociateorderflagsAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PostAssociateorderflags(ParameterOrderFlagRequestModel body)
	{
		return Task.Run(async () => await PostAssociateorderflagsAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PostAssociateorderflagsAsync(ParameterOrderFlagRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/ordertypes/associateorderflags";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PostAssociateusergroupsAsync(ParameterUserGroupRequestModel body)
	{
		return PostAssociateusergroupsAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PostAssociateusergroups(ParameterUserGroupRequestModel body)
	{
		return Task.Run(async () => await PostAssociateusergroupsAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PostAssociateusergroupsAsync(ParameterUserGroupRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/ordertypes/associateusergroups";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PostUnassociateorderflagsByCpOrderFlagIdAsync(string cpOrderFlagId, string cpOrderTypeId)
	{
		return PostUnassociateorderflagsByCpOrderFlagIdAsync(cpOrderFlagId, cpOrderTypeId, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PostUnassociateorderflagsByCpOrderFlagId(string cpOrderFlagId, string cpOrderTypeId)
	{
		return Task.Run(async () => await PostUnassociateorderflagsByCpOrderFlagIdAsync(cpOrderFlagId, cpOrderTypeId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PostUnassociateorderflagsByCpOrderFlagIdAsync(string cpOrderFlagId, string cpOrderTypeId, CancellationToken cancellationToken)
	{
		if (cpOrderFlagId == null)
		{
			throw new ArgumentNullException("cpOrderFlagId");
		}
		if (cpOrderTypeId == null)
		{
			throw new ArgumentNullException("cpOrderTypeId");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/ordertypes/unassociateorderflags/{cpOrderFlagId}/{cpOrderTypeId}";
		znodeApiGateway = znodeApiGateway.Replace("{cpOrderFlagId}", Uri.EscapeDataString(ConvertToString(cpOrderFlagId, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{cpOrderTypeId}", Uri.EscapeDataString(ConvertToString(cpOrderTypeId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, (string)null, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PostUnassociateusergroupsByCpUserGroupIdAsync(string cpUserGroupId, string cpOrderTypeId)
	{
		return PostUnassociateusergroupsByCpUserGroupIdAsync(cpUserGroupId, cpOrderTypeId, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PostUnassociateusergroupsByCpUserGroupId(string cpUserGroupId, string cpOrderTypeId)
	{
		return Task.Run(async () => await PostUnassociateusergroupsByCpUserGroupIdAsync(cpUserGroupId, cpOrderTypeId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PostUnassociateusergroupsByCpUserGroupIdAsync(string cpUserGroupId, string cpOrderTypeId, CancellationToken cancellationToken)
	{
		if (cpUserGroupId == null)
		{
			throw new ArgumentNullException("cpUserGroupId");
		}
		if (cpOrderTypeId == null)
		{
			throw new ArgumentNullException("cpOrderTypeId");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/ordertypes/unassociateusergroups/{cpUserGroupId}/{cpOrderTypeId}";
		znodeApiGateway = znodeApiGateway.Replace("{cpUserGroupId}", Uri.EscapeDataString(ConvertToString(cpUserGroupId, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{cpOrderTypeId}", Uri.EscapeDataString(ConvertToString(cpOrderTypeId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, (string)null, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IPaymentsClient : IBaseClient
{
	[Obsolete]
	Task<UpdateOrderPaymentResponseModel> GetPaymentdetailsbyorderidByOrderIdAsync(Guid orderId);

	[Obsolete]
	UpdateOrderPaymentResponseModel GetPaymentdetailsbyorderidByOrderId(Guid orderId);

	[Obsolete]
	Task<UpdateOrderPaymentResponseModel> GetPaymentdetailsbyorderidByOrderIdAsync(Guid orderId, CancellationToken cancellationToken);

	[Obsolete]
	Task<UpdateOrderPaymentResponseModel> PostValidatediscountAsync(OrderPaymentDetailsDiscountRequestModel body);

	[Obsolete]
	UpdateOrderPaymentResponseModel PostValidatediscount(OrderPaymentDetailsDiscountRequestModel body);

	[Obsolete]
	Task<UpdateOrderPaymentResponseModel> PostValidatediscountAsync(OrderPaymentDetailsDiscountRequestModel body, CancellationToken cancellationToken);

	Task<UpdateBillingDetailsResponseModel> PutPaymentsAsync(UpdateOrderPaymentRequestModel body);

	UpdateBillingDetailsResponseModel PutPayments(UpdateOrderPaymentRequestModel body);

	Task<UpdateBillingDetailsResponseModel> PutPaymentsAsync(UpdateOrderPaymentRequestModel body, CancellationToken cancellationToken);

	Task<CreatePaymentResponseModel> PostPaymentsAsync(CreateOrderPaymentRequestModel body);

	CreatePaymentResponseModel PostPayments(CreateOrderPaymentRequestModel body);

	Task<CreatePaymentResponseModel> PostPaymentsAsync(CreateOrderPaymentRequestModel body, CancellationToken cancellationToken);

	Task<PaymentHistoryResponseModel> GetPaymentTransactionHistoryByClassNumberAsync(string classNumber);

	PaymentHistoryResponseModel GetPaymentTransactionHistoryByClassNumber(string classNumber);

	Task<PaymentHistoryResponseModel> GetPaymentTransactionHistoryByClassNumberAsync(string classNumber, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PaymentsClient : BaseClient, IPaymentsClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public PaymentsClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<UpdateOrderPaymentResponseModel> GetPaymentdetailsbyorderidByOrderIdAsync(Guid orderId)
	{
		return GetPaymentdetailsbyorderidByOrderIdAsync(orderId, CancellationToken.None);
	}

	[Obsolete]
	public virtual UpdateOrderPaymentResponseModel GetPaymentdetailsbyorderidByOrderId(Guid orderId)
	{
		return Task.Run(async () => await GetPaymentdetailsbyorderidByOrderIdAsync(orderId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UpdateOrderPaymentResponseModel> GetPaymentdetailsbyorderidByOrderIdAsync(Guid orderId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/payments/paymentdetailsbyorderid/{orderId}";
		znodeApiGateway = znodeApiGateway.Replace("{orderId}", Uri.EscapeDataString(ConvertToString(orderId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateOrderPaymentResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateOrderPaymentResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 401:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateOrderPaymentResponseModel updateOrderPaymentResponseModel = JsonConvert.DeserializeObject<UpdateOrderPaymentResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateOrderPaymentResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UpdateOrderPaymentResponseModel> PostValidatediscountAsync(OrderPaymentDetailsDiscountRequestModel body)
	{
		return PostValidatediscountAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual UpdateOrderPaymentResponseModel PostValidatediscount(OrderPaymentDetailsDiscountRequestModel body)
	{
		return Task.Run(async () => await PostValidatediscountAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UpdateOrderPaymentResponseModel> PostValidatediscountAsync(OrderPaymentDetailsDiscountRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/payments/validatediscount";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateOrderPaymentResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<UpdateOrderPaymentResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateOrderPaymentResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateOrderPaymentResponseModel updateOrderPaymentResponseModel = JsonConvert.DeserializeObject<UpdateOrderPaymentResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateOrderPaymentResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<UpdateBillingDetailsResponseModel> PutPaymentsAsync(UpdateOrderPaymentRequestModel body)
	{
		return PutPaymentsAsync(body, CancellationToken.None);
	}

	public virtual UpdateBillingDetailsResponseModel PutPayments(UpdateOrderPaymentRequestModel body)
	{
		return Task.Run(async () => await PutPaymentsAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<UpdateBillingDetailsResponseModel> PutPaymentsAsync(UpdateOrderPaymentRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/payments";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateBillingDetailsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<UpdateBillingDetailsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateBillingDetailsResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateBillingDetailsResponseModel updateBillingDetailsResponseModel = JsonConvert.DeserializeObject<UpdateBillingDetailsResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateBillingDetailsResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<CreatePaymentResponseModel> PostPaymentsAsync(CreateOrderPaymentRequestModel body)
	{
		return PostPaymentsAsync(body, CancellationToken.None);
	}

	public virtual CreatePaymentResponseModel PostPayments(CreateOrderPaymentRequestModel body)
	{
		return Task.Run(async () => await PostPaymentsAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CreatePaymentResponseModel> PostPaymentsAsync(CreateOrderPaymentRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/payments";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CreatePaymentResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CreatePaymentResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CreatePaymentResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CreatePaymentResponseModel createPaymentResponseModel = JsonConvert.DeserializeObject<CreatePaymentResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)createPaymentResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<PaymentHistoryResponseModel> GetPaymentTransactionHistoryByClassNumberAsync(string classNumber)
	{
		return GetPaymentTransactionHistoryByClassNumberAsync(classNumber, CancellationToken.None);
	}

	public virtual PaymentHistoryResponseModel GetPaymentTransactionHistoryByClassNumber(string classNumber)
	{
		return Task.Run(async () => await GetPaymentTransactionHistoryByClassNumberAsync(classNumber, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<PaymentHistoryResponseModel> GetPaymentTransactionHistoryByClassNumberAsync(string classNumber, CancellationToken cancellationToken)
	{
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/payments/payment-transaction-history/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<PaymentHistoryResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new PaymentHistoryResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 401:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				PaymentHistoryResponseModel paymentHistoryResponseModel = JsonConvert.DeserializeObject<PaymentHistoryResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)paymentHistoryResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IQuickOrdersClient : IBaseClient
{
	[Obsolete]
	Task<QuickOrderCartResponse> PostQuickordercartitemsfromfileAsync();

	[Obsolete]
	QuickOrderCartResponse PostQuickordercartitemsfromfile();

	[Obsolete]
	Task<QuickOrderCartResponse> PostQuickordercartitemsfromfileAsync(CancellationToken cancellationToken);

	[Obsolete]
	Task<QuickViewDetailsResponseModel> GetQuickviewfororderdetailsByOrderIdAsync(Guid orderId);

	[Obsolete]
	QuickViewDetailsResponseModel GetQuickviewfororderdetailsByOrderId(Guid orderId);

	[Obsolete]
	Task<QuickViewDetailsResponseModel> GetQuickviewfororderdetailsByOrderIdAsync(Guid orderId, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class QuickOrdersClient : BaseClient, IQuickOrdersClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public QuickOrdersClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<QuickOrderCartResponse> PostQuickordercartitemsfromfileAsync()
	{
		return PostQuickordercartitemsfromfileAsync(CancellationToken.None);
	}

	[Obsolete]
	public virtual QuickOrderCartResponse PostQuickordercartitemsfromfile()
	{
		return Task.Run(async () => await PostQuickordercartitemsfromfileAsync(CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<QuickOrderCartResponse> PostQuickordercartitemsfromfileAsync(CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/quickorders/quickordercartitemsfromfile";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, (string)null, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<QuickOrderCartResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new QuickOrderCartResponse();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				QuickOrderCartResponse quickOrderCartResponse = JsonConvert.DeserializeObject<QuickOrderCartResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)quickOrderCartResponse, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<QuickViewDetailsResponseModel> GetQuickviewfororderdetailsByOrderIdAsync(Guid orderId)
	{
		return GetQuickviewfororderdetailsByOrderIdAsync(orderId, CancellationToken.None);
	}

	[Obsolete]
	public virtual QuickViewDetailsResponseModel GetQuickviewfororderdetailsByOrderId(Guid orderId)
	{
		return Task.Run(async () => await GetQuickviewfororderdetailsByOrderIdAsync(orderId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<QuickViewDetailsResponseModel> GetQuickviewfororderdetailsByOrderIdAsync(Guid orderId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/quickorders/quickviewfororderdetails/{orderId}";
		znodeApiGateway = znodeApiGateway.Replace("{orderId}", Uri.EscapeDataString(ConvertToString(orderId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<QuickViewDetailsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new QuickViewDetailsResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				QuickViewDetailsResponseModel quickViewDetailsResponseModel = JsonConvert.DeserializeObject<QuickViewDetailsResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)quickViewDetailsResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IReturnsClient : IBaseClient
{
	Task<ReturnCalculateSummaryResponseModel> PostCalculateReturnAsync(ReturnCalculateRequestModel body);

	ReturnCalculateSummaryResponseModel PostCalculateReturn(ReturnCalculateRequestModel body);

	Task<ReturnCalculateSummaryResponseModel> PostCalculateReturnAsync(ReturnCalculateRequestModel body, CancellationToken cancellationToken);

	Task<CreateReturnResponseModel> PostReturnsByOrderNumberAsync(string orderNumber, ReturnRequestModel body);

	CreateReturnResponseModel PostReturnsByOrderNumber(string orderNumber, ReturnRequestModel body);

	Task<CreateReturnResponseModel> PostReturnsByOrderNumberAsync(string orderNumber, ReturnRequestModel body, CancellationToken cancellationToken);

	Task<ValidationResponseModel> PostValidateReturnByClassNumberAsync(string classNumber, ReturnLineItemRequestModel body);

	ValidationResponseModel PostValidateReturnByClassNumber(string classNumber, ReturnLineItemRequestModel body);

	Task<ValidationResponseModel> PostValidateReturnByClassNumberAsync(string classNumber, ReturnLineItemRequestModel body, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReturnsClient : BaseClient, IReturnsClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public ReturnsClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	public virtual Task<ReturnCalculateSummaryResponseModel> PostCalculateReturnAsync(ReturnCalculateRequestModel body)
	{
		return PostCalculateReturnAsync(body, CancellationToken.None);
	}

	public virtual ReturnCalculateSummaryResponseModel PostCalculateReturn(ReturnCalculateRequestModel body)
	{
		return Task.Run(async () => await PostCalculateReturnAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<ReturnCalculateSummaryResponseModel> PostCalculateReturnAsync(ReturnCalculateRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/returns/calculate-return";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ReturnCalculateSummaryResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ReturnCalculateSummaryResponseModel returnCalculateSummaryResponseModel = JsonConvert.DeserializeObject<ReturnCalculateSummaryResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)returnCalculateSummaryResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<CreateReturnResponseModel> PostReturnsByOrderNumberAsync(string orderNumber, ReturnRequestModel body)
	{
		return PostReturnsByOrderNumberAsync(orderNumber, body, CancellationToken.None);
	}

	public virtual CreateReturnResponseModel PostReturnsByOrderNumber(string orderNumber, ReturnRequestModel body)
	{
		return Task.Run(async () => await PostReturnsByOrderNumberAsync(orderNumber, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CreateReturnResponseModel> PostReturnsByOrderNumberAsync(string orderNumber, ReturnRequestModel body, CancellationToken cancellationToken)
	{
		if (orderNumber == null)
		{
			throw new ArgumentNullException("orderNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/returns/{orderNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{orderNumber}", Uri.EscapeDataString(ConvertToString(orderNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CreateReturnResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CreateReturnResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CreateReturnResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CreateReturnResponseModel createReturnResponseModel = JsonConvert.DeserializeObject<CreateReturnResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)createReturnResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<ValidationResponseModel> PostValidateReturnByClassNumberAsync(string classNumber, ReturnLineItemRequestModel body)
	{
		return PostValidateReturnByClassNumberAsync(classNumber, body, CancellationToken.None);
	}

	public virtual ValidationResponseModel PostValidateReturnByClassNumber(string classNumber, ReturnLineItemRequestModel body)
	{
		return Task.Run(async () => await PostValidateReturnByClassNumberAsync(classNumber, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<ValidationResponseModel> PostValidateReturnByClassNumberAsync(string classNumber, ReturnLineItemRequestModel body, CancellationToken cancellationToken)
	{
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/returns/validate-return/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ValidationResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ValidationResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ValidationResponseModel validationResponseModel = JsonConvert.DeserializeObject<ValidationResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)validationResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface ISavedViewsClient : IBaseClient
{
	[Obsolete]
	Task<SavedViewDetailsResponseModel> GetSavedviewusergroupidByIdAsync(string id);

	[Obsolete]
	SavedViewDetailsResponseModel GetSavedviewusergroupidById(string id);

	[Obsolete]
	Task<SavedViewDetailsResponseModel> GetSavedviewusergroupidByIdAsync(string id, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PostShareviewtousergroupsAsync(SavedViewRequestModel body);

	[Obsolete]
	BooleanResponseModel PostShareviewtousergroups(SavedViewRequestModel body);

	[Obsolete]
	Task<BooleanResponseModel> PostShareviewtousergroupsAsync(SavedViewRequestModel body, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SavedViewsClient : BaseClient, ISavedViewsClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public SavedViewsClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<SavedViewDetailsResponseModel> GetSavedviewusergroupidByIdAsync(string id)
	{
		return GetSavedviewusergroupidByIdAsync(id, CancellationToken.None);
	}

	[Obsolete]
	public virtual SavedViewDetailsResponseModel GetSavedviewusergroupidById(string id)
	{
		return Task.Run(async () => await GetSavedviewusergroupidByIdAsync(id, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<SavedViewDetailsResponseModel> GetSavedviewusergroupidByIdAsync(string id, CancellationToken cancellationToken)
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/savedviews/savedviewusergroupid/{id}";
		znodeApiGateway = znodeApiGateway.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<SavedViewDetailsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new SavedViewDetailsResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				SavedViewDetailsResponseModel savedViewDetailsResponseModel = JsonConvert.DeserializeObject<SavedViewDetailsResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)savedViewDetailsResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PostShareviewtousergroupsAsync(SavedViewRequestModel body)
	{
		return PostShareviewtousergroupsAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PostShareviewtousergroups(SavedViewRequestModel body)
	{
		return Task.Run(async () => await PostShareviewtousergroupsAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PostShareviewtousergroupsAsync(SavedViewRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/savedviews/shareviewtousergroups";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IShippingsClient : IBaseClient
{
	Task<ShipmentResponseModel> PutOrderShipmentAsync(UpdateOrderShipmentRequestModel body);

	ShipmentResponseModel PutOrderShipment(UpdateOrderShipmentRequestModel body);

	Task<ShipmentResponseModel> PutOrderShipmentAsync(UpdateOrderShipmentRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<OrderShipmentResponseModel> GetShippingdetailsbyorderidByOrderIdAsync(Guid orderId);

	[Obsolete]
	OrderShipmentResponseModel GetShippingdetailsbyorderidByOrderId(Guid orderId);

	[Obsolete]
	Task<OrderShipmentResponseModel> GetShippingdetailsbyorderidByOrderIdAsync(Guid orderId, CancellationToken cancellationToken);

	Task<RemoveShippingResponseModel> DeleteRemoveShippingByClassNumberAsync(string classNumber);

	RemoveShippingResponseModel DeleteRemoveShippingByClassNumber(string classNumber);

	Task<RemoveShippingResponseModel> DeleteRemoveShippingByClassNumberAsync(string classNumber, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ShippingsClient : BaseClient, IShippingsClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public ShippingsClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	public virtual Task<ShipmentResponseModel> PutOrderShipmentAsync(UpdateOrderShipmentRequestModel body)
	{
		return PutOrderShipmentAsync(body, CancellationToken.None);
	}

	public virtual ShipmentResponseModel PutOrderShipment(UpdateOrderShipmentRequestModel body)
	{
		return Task.Run(async () => await PutOrderShipmentAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<ShipmentResponseModel> PutOrderShipmentAsync(UpdateOrderShipmentRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/shippings/order-shipment";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ShipmentResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<ShipmentResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ShipmentResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ShipmentResponseModel shipmentResponseModel = JsonConvert.DeserializeObject<ShipmentResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)shipmentResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<OrderShipmentResponseModel> GetShippingdetailsbyorderidByOrderIdAsync(Guid orderId)
	{
		return GetShippingdetailsbyorderidByOrderIdAsync(orderId, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderShipmentResponseModel GetShippingdetailsbyorderidByOrderId(Guid orderId)
	{
		return Task.Run(async () => await GetShippingdetailsbyorderidByOrderIdAsync(orderId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderShipmentResponseModel> GetShippingdetailsbyorderidByOrderIdAsync(Guid orderId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/shippings/shippingdetailsbyorderid/{orderId}";
		znodeApiGateway = znodeApiGateway.Replace("{orderId}", Uri.EscapeDataString(ConvertToString(orderId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderShipmentResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderShipmentResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderShipmentResponseModel orderShipmentResponseModel = JsonConvert.DeserializeObject<OrderShipmentResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderShipmentResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<RemoveShippingResponseModel> DeleteRemoveShippingByClassNumberAsync(string classNumber)
	{
		return DeleteRemoveShippingByClassNumberAsync(classNumber, CancellationToken.None);
	}

	public virtual RemoveShippingResponseModel DeleteRemoveShippingByClassNumber(string classNumber)
	{
		return Task.Run(async () => await DeleteRemoveShippingByClassNumberAsync(classNumber, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<RemoveShippingResponseModel> DeleteRemoveShippingByClassNumberAsync(string classNumber, CancellationToken cancellationToken)
	{
		if (classNumber == null)
		{
			throw new ArgumentNullException("classNumber");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/shippings/remove-shipping/{classNumber}";
		znodeApiGateway = znodeApiGateway.Replace("{classNumber}", Uri.EscapeDataString(ConvertToString(classNumber, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).DeleteResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<RemoveShippingResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new RemoveShippingResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				RemoveShippingResponseModel removeShippingResponseModel = JsonConvert.DeserializeObject<RemoveShippingResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)removeShippingResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IStatusButtonsClient : IBaseClient
{
	[Obsolete]
	Task<StatusButtonListResponseModel> GetListByOmsOrderStateIdAsync(int omsOrderStateId, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	StatusButtonListResponseModel GetListByOmsOrderStateId(int omsOrderStateId, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<StatusButtonListResponseModel> GetListByOmsOrderStateIdAsync(int omsOrderStateId, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<StatusButtonDetailsResponseModel> GetStatusbuttondetailsByCpOrderStatusButtonIdAsync(int cpOrderStatusButtonId);

	[Obsolete]
	StatusButtonDetailsResponseModel GetStatusbuttondetailsByCpOrderStatusButtonId(int cpOrderStatusButtonId);

	[Obsolete]
	Task<StatusButtonDetailsResponseModel> GetStatusbuttondetailsByCpOrderStatusButtonIdAsync(int cpOrderStatusButtonId, CancellationToken cancellationToken);

	[Obsolete]
	Task<CreateStatusButtonResponseModel> PostCreateAsync(CreateStatusButtonRequestModel body);

	[Obsolete]
	CreateStatusButtonResponseModel PostCreate(CreateStatusButtonRequestModel body);

	[Obsolete]
	Task<CreateStatusButtonResponseModel> PostCreateAsync(CreateStatusButtonRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<UpdateStatusButtonResponseModel> PutUpdateAsync(UpdateStatusButtonRequestModel body);

	[Obsolete]
	UpdateStatusButtonResponseModel PutUpdate(UpdateStatusButtonRequestModel body);

	[Obsolete]
	Task<UpdateStatusButtonResponseModel> PutUpdateAsync(UpdateStatusButtonRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> DeleteDeleteByCpOrderStatusButtonIdAsync(int cpOrderStatusButtonId);

	[Obsolete]
	BooleanResponseModel DeleteDeleteByCpOrderStatusButtonId(int cpOrderStatusButtonId);

	[Obsolete]
	Task<BooleanResponseModel> DeleteDeleteByCpOrderStatusButtonIdAsync(int cpOrderStatusButtonId, CancellationToken cancellationToken);

	[Obsolete]
	Task<StatusButtonResultDetailsResponseModel> GetDefaultdataByOmsOrderStateIdAsync(int omsOrderStateId);

	[Obsolete]
	StatusButtonResultDetailsResponseModel GetDefaultdataByOmsOrderStateId(int omsOrderStateId);

	[Obsolete]
	Task<StatusButtonResultDetailsResponseModel> GetDefaultdataByOmsOrderStateIdAsync(int omsOrderStateId, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> DeleteUnassociatestatusbuttonsByCpOrderStatusButtonIdAsync(string cpOrderStatusButtonId, int omsOrderStateId);

	[Obsolete]
	BooleanResponseModel DeleteUnassociatestatusbuttonsByCpOrderStatusButtonId(string cpOrderStatusButtonId, int omsOrderStateId);

	[Obsolete]
	Task<BooleanResponseModel> DeleteUnassociatestatusbuttonsByCpOrderStatusButtonIdAsync(string cpOrderStatusButtonId, int omsOrderStateId, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StatusButtonsClient : BaseClient, IStatusButtonsClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public StatusButtonsClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<StatusButtonListResponseModel> GetListByOmsOrderStateIdAsync(int omsOrderStateId, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetListByOmsOrderStateIdAsync(omsOrderStateId, filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual StatusButtonListResponseModel GetListByOmsOrderStateId(int omsOrderStateId, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetListByOmsOrderStateIdAsync(omsOrderStateId, filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<StatusButtonListResponseModel> GetListByOmsOrderStateIdAsync(int omsOrderStateId, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/statusbuttons/list/{omsOrderStateId}";
		znodeApiGateway = znodeApiGateway.Replace("{omsOrderStateId}", Uri.EscapeDataString(ConvertToString(omsOrderStateId, CultureInfo.InvariantCulture)));
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<StatusButtonListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new StatusButtonListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				StatusButtonListResponseModel statusButtonListResponseModel = JsonConvert.DeserializeObject<StatusButtonListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)statusButtonListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<StatusButtonDetailsResponseModel> GetStatusbuttondetailsByCpOrderStatusButtonIdAsync(int cpOrderStatusButtonId)
	{
		return GetStatusbuttondetailsByCpOrderStatusButtonIdAsync(cpOrderStatusButtonId, CancellationToken.None);
	}

	[Obsolete]
	public virtual StatusButtonDetailsResponseModel GetStatusbuttondetailsByCpOrderStatusButtonId(int cpOrderStatusButtonId)
	{
		return Task.Run(async () => await GetStatusbuttondetailsByCpOrderStatusButtonIdAsync(cpOrderStatusButtonId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<StatusButtonDetailsResponseModel> GetStatusbuttondetailsByCpOrderStatusButtonIdAsync(int cpOrderStatusButtonId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/statusbuttons/statusbuttondetails/{cpOrderStatusButtonId}";
		znodeApiGateway = znodeApiGateway.Replace("{cpOrderStatusButtonId}", Uri.EscapeDataString(ConvertToString(cpOrderStatusButtonId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<StatusButtonDetailsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new StatusButtonDetailsResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				StatusButtonDetailsResponseModel statusButtonDetailsResponseModel = JsonConvert.DeserializeObject<StatusButtonDetailsResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)statusButtonDetailsResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<CreateStatusButtonResponseModel> PostCreateAsync(CreateStatusButtonRequestModel body)
	{
		return PostCreateAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual CreateStatusButtonResponseModel PostCreate(CreateStatusButtonRequestModel body)
	{
		return Task.Run(async () => await PostCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<CreateStatusButtonResponseModel> PostCreateAsync(CreateStatusButtonRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/statusbuttons/create";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CreateStatusButtonResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CreateStatusButtonResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CreateStatusButtonResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CreateStatusButtonResponseModel createStatusButtonResponseModel = JsonConvert.DeserializeObject<CreateStatusButtonResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)createStatusButtonResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UpdateStatusButtonResponseModel> PutUpdateAsync(UpdateStatusButtonRequestModel body)
	{
		return PutUpdateAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual UpdateStatusButtonResponseModel PutUpdate(UpdateStatusButtonRequestModel body)
	{
		return Task.Run(async () => await PutUpdateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UpdateStatusButtonResponseModel> PutUpdateAsync(UpdateStatusButtonRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/statusbuttons/update";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateStatusButtonResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<UpdateStatusButtonResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateStatusButtonResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateStatusButtonResponseModel updateStatusButtonResponseModel = JsonConvert.DeserializeObject<UpdateStatusButtonResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateStatusButtonResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> DeleteDeleteByCpOrderStatusButtonIdAsync(int cpOrderStatusButtonId)
	{
		return DeleteDeleteByCpOrderStatusButtonIdAsync(cpOrderStatusButtonId, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel DeleteDeleteByCpOrderStatusButtonId(int cpOrderStatusButtonId)
	{
		return Task.Run(async () => await DeleteDeleteByCpOrderStatusButtonIdAsync(cpOrderStatusButtonId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> DeleteDeleteByCpOrderStatusButtonIdAsync(int cpOrderStatusButtonId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/statusbuttons/delete/{cpOrderStatusButtonId}";
		znodeApiGateway = znodeApiGateway.Replace("{cpOrderStatusButtonId}", Uri.EscapeDataString(ConvertToString(cpOrderStatusButtonId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).DeleteResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<StatusButtonResultDetailsResponseModel> GetDefaultdataByOmsOrderStateIdAsync(int omsOrderStateId)
	{
		return GetDefaultdataByOmsOrderStateIdAsync(omsOrderStateId, CancellationToken.None);
	}

	[Obsolete]
	public virtual StatusButtonResultDetailsResponseModel GetDefaultdataByOmsOrderStateId(int omsOrderStateId)
	{
		return Task.Run(async () => await GetDefaultdataByOmsOrderStateIdAsync(omsOrderStateId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<StatusButtonResultDetailsResponseModel> GetDefaultdataByOmsOrderStateIdAsync(int omsOrderStateId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/statusbuttons/defaultdata/{omsOrderStateId}";
		znodeApiGateway = znodeApiGateway.Replace("{omsOrderStateId}", Uri.EscapeDataString(ConvertToString(omsOrderStateId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<StatusButtonResultDetailsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new StatusButtonResultDetailsResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				StatusButtonResultDetailsResponseModel statusButtonResultDetailsResponseModel = JsonConvert.DeserializeObject<StatusButtonResultDetailsResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)statusButtonResultDetailsResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> DeleteUnassociatestatusbuttonsByCpOrderStatusButtonIdAsync(string cpOrderStatusButtonId, int omsOrderStateId)
	{
		return DeleteUnassociatestatusbuttonsByCpOrderStatusButtonIdAsync(cpOrderStatusButtonId, omsOrderStateId, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel DeleteUnassociatestatusbuttonsByCpOrderStatusButtonId(string cpOrderStatusButtonId, int omsOrderStateId)
	{
		return Task.Run(async () => await DeleteUnassociatestatusbuttonsByCpOrderStatusButtonIdAsync(cpOrderStatusButtonId, omsOrderStateId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> DeleteUnassociatestatusbuttonsByCpOrderStatusButtonIdAsync(string cpOrderStatusButtonId, int omsOrderStateId, CancellationToken cancellationToken)
	{
		if (cpOrderStatusButtonId == null)
		{
			throw new ArgumentNullException("cpOrderStatusButtonId");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/statusbuttons/unassociatestatusbuttons/{cpOrderStatusButtonId}/{omsOrderStateId}";
		znodeApiGateway = znodeApiGateway.Replace("{cpOrderStatusButtonId}", Uri.EscapeDataString(ConvertToString(cpOrderStatusButtonId, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{omsOrderStateId}", Uri.EscapeDataString(ConvertToString(omsOrderStateId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).DeleteResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IStatusesClient : IBaseClient
{
	[Obsolete]
	Task<StatusListResponseModel> GetStatuslistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	StatusListResponseModel GetStatuslist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<StatusListResponseModel> GetStatuslistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<StatusListResponseModel> GetStatuslistbyclasscodeByClassCodeAsync(string classCode, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	StatusListResponseModel GetStatuslistbyclasscodeByClassCode(string classCode, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<StatusListResponseModel> GetStatuslistbyclasscodeByClassCodeAsync(string classCode, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<StatusDetailsResponseModel> GetStatusdetailsByOmsOrderStateIdAsync(int omsOrderStateId);

	[Obsolete]
	StatusDetailsResponseModel GetStatusdetailsByOmsOrderStateId(int omsOrderStateId);

	[Obsolete]
	Task<StatusDetailsResponseModel> GetStatusdetailsByOmsOrderStateIdAsync(int omsOrderStateId, CancellationToken cancellationToken);

	[Obsolete]
	Task<CreateStatusResponseModel> PostCreatestatusAsync(CreateStatusRequestModel body);

	[Obsolete]
	CreateStatusResponseModel PostCreatestatus(CreateStatusRequestModel body);

	[Obsolete]
	Task<CreateStatusResponseModel> PostCreatestatusAsync(CreateStatusRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<UpdateStatusResponseModel> PutUpdatestatusAsync(UpdateStatusRequestModel body);

	[Obsolete]
	UpdateStatusResponseModel PutUpdatestatus(UpdateStatusRequestModel body);

	[Obsolete]
	Task<UpdateStatusResponseModel> PutUpdatestatusAsync(UpdateStatusRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> DeleteDeletestatusByOmsOrderStateIdsAsync(string omsOrderStateIds);

	[Obsolete]
	BooleanResponseModel DeleteDeletestatusByOmsOrderStateIds(string omsOrderStateIds);

	[Obsolete]
	Task<BooleanResponseModel> DeleteDeletestatusByOmsOrderStateIdsAsync(string omsOrderStateIds, CancellationToken cancellationToken);

	[Obsolete]
	Task<StatusClassListResponseModel> GetAssociatedclasslistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	StatusClassListResponseModel GetAssociatedclasslist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<StatusClassListResponseModel> GetAssociatedclasslistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<StatusClassListResponseModel> GetUnassociatedclasslistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	StatusClassListResponseModel GetUnassociatedclasslist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<StatusClassListResponseModel> GetUnassociatedclasslistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PostAssociateclassAsync(StatusClassRequestModel body);

	[Obsolete]
	BooleanResponseModel PostAssociateclass(StatusClassRequestModel body);

	[Obsolete]
	Task<BooleanResponseModel> PostAssociateclassAsync(StatusClassRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> DeleteUnassociateclassByCpOrderClassIdsAsync(string cpOrderClassIds, int omsOrderStateId);

	[Obsolete]
	BooleanResponseModel DeleteUnassociateclassByCpOrderClassIds(string cpOrderClassIds, int omsOrderStateId);

	[Obsolete]
	Task<BooleanResponseModel> DeleteUnassociateclassByCpOrderClassIdsAsync(string cpOrderClassIds, int omsOrderStateId, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> DeleteRemoveclassByCpOrderStatusAvailableToClassIdAsync(int cpOrderStatusAvailableToClassId);

	[Obsolete]
	BooleanResponseModel DeleteRemoveclassByCpOrderStatusAvailableToClassId(int cpOrderStatusAvailableToClassId);

	[Obsolete]
	Task<BooleanResponseModel> DeleteRemoveclassByCpOrderStatusAvailableToClassIdAsync(int cpOrderStatusAvailableToClassId, CancellationToken cancellationToken);

	Task<StateListResponseModel> GetClassStatusListByClassTypeAsync(string classType, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	StateListResponseModel GetClassStatusListByClassType(string classType, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	Task<StateListResponseModel> GetClassStatusListByClassTypeAsync(string classType, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StatusesClient : BaseClient, IStatusesClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public StatusesClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<StatusListResponseModel> GetStatuslistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetStatuslistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual StatusListResponseModel GetStatuslist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetStatuslistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<StatusListResponseModel> GetStatuslistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/statuses/statuslist";
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<StatusListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new StatusListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				StatusListResponseModel statusListResponseModel = JsonConvert.DeserializeObject<StatusListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)statusListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<StatusListResponseModel> GetStatuslistbyclasscodeByClassCodeAsync(string classCode, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetStatuslistbyclasscodeByClassCodeAsync(classCode, filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual StatusListResponseModel GetStatuslistbyclasscodeByClassCode(string classCode, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetStatuslistbyclasscodeByClassCodeAsync(classCode, filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<StatusListResponseModel> GetStatuslistbyclasscodeByClassCodeAsync(string classCode, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		if (classCode == null)
		{
			throw new ArgumentNullException("classCode");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/statuses/statuslistbyclasscode/{classCode}";
		znodeApiGateway = znodeApiGateway.Replace("{classCode}", Uri.EscapeDataString(ConvertToString(classCode, CultureInfo.InvariantCulture)));
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<StatusListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new StatusListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				StatusListResponseModel statusListResponseModel = JsonConvert.DeserializeObject<StatusListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)statusListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<StatusDetailsResponseModel> GetStatusdetailsByOmsOrderStateIdAsync(int omsOrderStateId)
	{
		return GetStatusdetailsByOmsOrderStateIdAsync(omsOrderStateId, CancellationToken.None);
	}

	[Obsolete]
	public virtual StatusDetailsResponseModel GetStatusdetailsByOmsOrderStateId(int omsOrderStateId)
	{
		return Task.Run(async () => await GetStatusdetailsByOmsOrderStateIdAsync(omsOrderStateId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<StatusDetailsResponseModel> GetStatusdetailsByOmsOrderStateIdAsync(int omsOrderStateId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/statuses/statusdetails/{omsOrderStateId}";
		znodeApiGateway = znodeApiGateway.Replace("{omsOrderStateId}", Uri.EscapeDataString(ConvertToString(omsOrderStateId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<StatusDetailsResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new StatusDetailsResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				StatusDetailsResponseModel statusDetailsResponseModel = JsonConvert.DeserializeObject<StatusDetailsResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)statusDetailsResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<CreateStatusResponseModel> PostCreatestatusAsync(CreateStatusRequestModel body)
	{
		return PostCreatestatusAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual CreateStatusResponseModel PostCreatestatus(CreateStatusRequestModel body)
	{
		return Task.Run(async () => await PostCreatestatusAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<CreateStatusResponseModel> PostCreatestatusAsync(CreateStatusRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/statuses/createstatus";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CreateStatusResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CreateStatusResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CreateStatusResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CreateStatusResponseModel createStatusResponseModel = JsonConvert.DeserializeObject<CreateStatusResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)createStatusResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UpdateStatusResponseModel> PutUpdatestatusAsync(UpdateStatusRequestModel body)
	{
		return PutUpdatestatusAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual UpdateStatusResponseModel PutUpdatestatus(UpdateStatusRequestModel body)
	{
		return Task.Run(async () => await PutUpdatestatusAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UpdateStatusResponseModel> PutUpdatestatusAsync(UpdateStatusRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/statuses/updatestatus";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateStatusResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<UpdateStatusResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateStatusResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateStatusResponseModel updateStatusResponseModel = JsonConvert.DeserializeObject<UpdateStatusResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateStatusResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> DeleteDeletestatusByOmsOrderStateIdsAsync(string omsOrderStateIds)
	{
		return DeleteDeletestatusByOmsOrderStateIdsAsync(omsOrderStateIds, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel DeleteDeletestatusByOmsOrderStateIds(string omsOrderStateIds)
	{
		return Task.Run(async () => await DeleteDeletestatusByOmsOrderStateIdsAsync(omsOrderStateIds, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> DeleteDeletestatusByOmsOrderStateIdsAsync(string omsOrderStateIds, CancellationToken cancellationToken)
	{
		if (omsOrderStateIds == null)
		{
			throw new ArgumentNullException("omsOrderStateIds");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/statuses/deletestatus/{omsOrderStateIds}";
		znodeApiGateway = znodeApiGateway.Replace("{omsOrderStateIds}", Uri.EscapeDataString(ConvertToString(omsOrderStateIds, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).DeleteResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<StatusClassListResponseModel> GetAssociatedclasslistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetAssociatedclasslistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual StatusClassListResponseModel GetAssociatedclasslist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetAssociatedclasslistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<StatusClassListResponseModel> GetAssociatedclasslistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/statuses/associatedclasslist";
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<StatusClassListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new StatusClassListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				StatusClassListResponseModel statusClassListResponseModel = JsonConvert.DeserializeObject<StatusClassListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)statusClassListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<StatusClassListResponseModel> GetUnassociatedclasslistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetUnassociatedclasslistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual StatusClassListResponseModel GetUnassociatedclasslist(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetUnassociatedclasslistAsync(filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<StatusClassListResponseModel> GetUnassociatedclasslistAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/statuses/unassociatedclasslist";
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<StatusClassListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new StatusClassListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				StatusClassListResponseModel statusClassListResponseModel = JsonConvert.DeserializeObject<StatusClassListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)statusClassListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PostAssociateclassAsync(StatusClassRequestModel body)
	{
		return PostAssociateclassAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PostAssociateclass(StatusClassRequestModel body)
	{
		return Task.Run(async () => await PostAssociateclassAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PostAssociateclassAsync(StatusClassRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/statuses/associateclass";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> DeleteUnassociateclassByCpOrderClassIdsAsync(string cpOrderClassIds, int omsOrderStateId)
	{
		return DeleteUnassociateclassByCpOrderClassIdsAsync(cpOrderClassIds, omsOrderStateId, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel DeleteUnassociateclassByCpOrderClassIds(string cpOrderClassIds, int omsOrderStateId)
	{
		return Task.Run(async () => await DeleteUnassociateclassByCpOrderClassIdsAsync(cpOrderClassIds, omsOrderStateId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> DeleteUnassociateclassByCpOrderClassIdsAsync(string cpOrderClassIds, int omsOrderStateId, CancellationToken cancellationToken)
	{
		if (cpOrderClassIds == null)
		{
			throw new ArgumentNullException("cpOrderClassIds");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/statuses/unassociateclass/{cpOrderClassIds}/{omsOrderStateId}";
		znodeApiGateway = znodeApiGateway.Replace("{cpOrderClassIds}", Uri.EscapeDataString(ConvertToString(cpOrderClassIds, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{omsOrderStateId}", Uri.EscapeDataString(ConvertToString(omsOrderStateId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).DeleteResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> DeleteRemoveclassByCpOrderStatusAvailableToClassIdAsync(int cpOrderStatusAvailableToClassId)
	{
		return DeleteRemoveclassByCpOrderStatusAvailableToClassIdAsync(cpOrderStatusAvailableToClassId, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel DeleteRemoveclassByCpOrderStatusAvailableToClassId(int cpOrderStatusAvailableToClassId)
	{
		return Task.Run(async () => await DeleteRemoveclassByCpOrderStatusAvailableToClassIdAsync(cpOrderStatusAvailableToClassId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> DeleteRemoveclassByCpOrderStatusAvailableToClassIdAsync(int cpOrderStatusAvailableToClassId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/statuses/removeclass/{cpOrderStatusAvailableToClassId}";
		znodeApiGateway = znodeApiGateway.Replace("{cpOrderStatusAvailableToClassId}", Uri.EscapeDataString(ConvertToString(cpOrderStatusAvailableToClassId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).DeleteResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	public virtual Task<StateListResponseModel> GetClassStatusListByClassTypeAsync(string classType, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetClassStatusListByClassTypeAsync(classType, filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	public virtual StateListResponseModel GetClassStatusListByClassType(string classType, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetClassStatusListByClassTypeAsync(classType, filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<StateListResponseModel> GetClassStatusListByClassTypeAsync(string classType, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/{classType}/class-status-list";
		znodeApiGateway = znodeApiGateway.Replace("{classType}", Uri.EscapeDataString(ConvertToString(classType, CultureInfo.InvariantCulture)));
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<StateListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new StateListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				StateListResponseModel stateListResponseModel = JsonConvert.DeserializeObject<StateListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)stateListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IUserGroupsClient : IBaseClient
{
	[Obsolete]
	Task<UserGroupDetailsListResponseModel> GetListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	UserGroupDetailsListResponseModel GetList(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<UserGroupDetailsListResponseModel> GetListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<CreateUserGroupResponseModel> PostCreateAsync(CreateUserGroupRequestModel body);

	[Obsolete]
	CreateUserGroupResponseModel PostCreate(CreateUserGroupRequestModel body);

	[Obsolete]
	Task<CreateUserGroupResponseModel> PostCreateAsync(CreateUserGroupRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<UpdateUserGroupResponseModel> PutUpdateAsync(UpdateUserGroupRequestModel body);

	[Obsolete]
	UpdateUserGroupResponseModel PutUpdate(UpdateUserGroupRequestModel body);

	[Obsolete]
	Task<UpdateUserGroupResponseModel> PutUpdateAsync(UpdateUserGroupRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> DeleteDeleteByCpUserGroupIdsAsync(string cpUserGroupIds);

	[Obsolete]
	BooleanResponseModel DeleteDeleteByCpUserGroupIds(string cpUserGroupIds);

	[Obsolete]
	Task<BooleanResponseModel> DeleteDeleteByCpUserGroupIdsAsync(string cpUserGroupIds, CancellationToken cancellationToken);

	[Obsolete]
	Task<UserGroupListForUsersResponseModel> GetAssociatedlistforusersAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	UserGroupListForUsersResponseModel GetAssociatedlistforusers(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<UserGroupListForUsersResponseModel> GetAssociatedlistforusersAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<UserGroupListForUsersResponseModel> GetUnassociatedlistforusersAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	UserGroupListForUsersResponseModel GetUnassociatedlistforusers(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	[Obsolete]
	Task<UserGroupListForUsersResponseModel> GetUnassociatedlistforusersAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	[Obsolete]
	Task<UpdateUserInGroupResponseModel> PutPriorityAsync(UpdateUserInGroupRequestModel body);

	[Obsolete]
	UpdateUserInGroupResponseModel PutPriority(UpdateUserInGroupRequestModel body);

	[Obsolete]
	Task<UpdateUserInGroupResponseModel> PutPriorityAsync(UpdateUserInGroupRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PostAssociatetousersAsync(UsersAndUserGroupsRequestModel body);

	[Obsolete]
	BooleanResponseModel PostAssociatetousers(UsersAndUserGroupsRequestModel body);

	[Obsolete]
	Task<BooleanResponseModel> PostAssociatetousersAsync(UsersAndUserGroupsRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> DeleteUnassociatetousersByCpUserGroupIdsAsync(string cpUserGroupIds, int userId);

	[Obsolete]
	BooleanResponseModel DeleteUnassociatetousersByCpUserGroupIds(string cpUserGroupIds, int userId);

	[Obsolete]
	Task<BooleanResponseModel> DeleteUnassociatetousersByCpUserGroupIdsAsync(string cpUserGroupIds, int userId, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UserGroupsClient : BaseClient, IUserGroupsClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public UserGroupsClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<UserGroupDetailsListResponseModel> GetListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetListAsync(filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual UserGroupDetailsListResponseModel GetList(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetListAsync(filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UserGroupDetailsListResponseModel> GetListAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/usergroups/list";
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UserGroupDetailsListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UserGroupDetailsListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UserGroupDetailsListResponseModel userGroupDetailsListResponseModel = JsonConvert.DeserializeObject<UserGroupDetailsListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)userGroupDetailsListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<CreateUserGroupResponseModel> PostCreateAsync(CreateUserGroupRequestModel body)
	{
		return PostCreateAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual CreateUserGroupResponseModel PostCreate(CreateUserGroupRequestModel body)
	{
		return Task.Run(async () => await PostCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<CreateUserGroupResponseModel> PostCreateAsync(CreateUserGroupRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/usergroups/create";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<CreateUserGroupResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CreateUserGroupResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CreateUserGroupResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CreateUserGroupResponseModel createUserGroupResponseModel = JsonConvert.DeserializeObject<CreateUserGroupResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)createUserGroupResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UpdateUserGroupResponseModel> PutUpdateAsync(UpdateUserGroupRequestModel body)
	{
		return PutUpdateAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual UpdateUserGroupResponseModel PutUpdate(UpdateUserGroupRequestModel body)
	{
		return Task.Run(async () => await PutUpdateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UpdateUserGroupResponseModel> PutUpdateAsync(UpdateUserGroupRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/usergroups/update";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateUserGroupResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<UpdateUserGroupResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateUserGroupResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateUserGroupResponseModel updateUserGroupResponseModel = JsonConvert.DeserializeObject<UpdateUserGroupResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateUserGroupResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> DeleteDeleteByCpUserGroupIdsAsync(string cpUserGroupIds)
	{
		return DeleteDeleteByCpUserGroupIdsAsync(cpUserGroupIds, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel DeleteDeleteByCpUserGroupIds(string cpUserGroupIds)
	{
		return Task.Run(async () => await DeleteDeleteByCpUserGroupIdsAsync(cpUserGroupIds, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> DeleteDeleteByCpUserGroupIdsAsync(string cpUserGroupIds, CancellationToken cancellationToken)
	{
		if (cpUserGroupIds == null)
		{
			throw new ArgumentNullException("cpUserGroupIds");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/usergroups/delete/{cpUserGroupIds}";
		znodeApiGateway = znodeApiGateway.Replace("{cpUserGroupIds}", Uri.EscapeDataString(ConvertToString(cpUserGroupIds, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).DeleteResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UserGroupListForUsersResponseModel> GetAssociatedlistforusersAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetAssociatedlistforusersAsync(filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual UserGroupListForUsersResponseModel GetAssociatedlistforusers(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetAssociatedlistforusersAsync(filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UserGroupListForUsersResponseModel> GetAssociatedlistforusersAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/usergroups/associatedlistforusers";
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UserGroupListForUsersResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UserGroupListForUsersResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UserGroupListForUsersResponseModel userGroupListForUsersResponseModel = JsonConvert.DeserializeObject<UserGroupListForUsersResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)userGroupListForUsersResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UserGroupListForUsersResponseModel> GetUnassociatedlistforusersAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetUnassociatedlistforusersAsync(filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	[Obsolete]
	public virtual UserGroupListForUsersResponseModel GetUnassociatedlistforusers(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetUnassociatedlistforusersAsync(filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UserGroupListForUsersResponseModel> GetUnassociatedlistforusersAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/usergroups/unassociatedlistforusers";
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, sort, pageIndex, pageSize, Array.Empty<string>());
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UserGroupListForUsersResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UserGroupListForUsersResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UserGroupListForUsersResponseModel userGroupListForUsersResponseModel = JsonConvert.DeserializeObject<UserGroupListForUsersResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)userGroupListForUsersResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<UpdateUserInGroupResponseModel> PutPriorityAsync(UpdateUserInGroupRequestModel body)
	{
		return PutPriorityAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual UpdateUserInGroupResponseModel PutPriority(UpdateUserInGroupRequestModel body)
	{
		return Task.Run(async () => await PutPriorityAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UpdateUserInGroupResponseModel> PutPriorityAsync(UpdateUserInGroupRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/usergroups/priority";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UpdateUserInGroupResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<UpdateUserInGroupResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UpdateUserInGroupResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UpdateUserInGroupResponseModel updateUserInGroupResponseModel = JsonConvert.DeserializeObject<UpdateUserInGroupResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)updateUserInGroupResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PostAssociatetousersAsync(UsersAndUserGroupsRequestModel body)
	{
		return PostAssociatetousersAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PostAssociatetousers(UsersAndUserGroupsRequestModel body)
	{
		return Task.Run(async () => await PostAssociatetousersAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PostAssociatetousersAsync(UsersAndUserGroupsRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/usergroups/associatetousers";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> DeleteUnassociatetousersByCpUserGroupIdsAsync(string cpUserGroupIds, int userId)
	{
		return DeleteUnassociatetousersByCpUserGroupIdsAsync(cpUserGroupIds, userId, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel DeleteUnassociatetousersByCpUserGroupIds(string cpUserGroupIds, int userId)
	{
		return Task.Run(async () => await DeleteUnassociatetousersByCpUserGroupIdsAsync(cpUserGroupIds, userId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> DeleteUnassociatetousersByCpUserGroupIdsAsync(string cpUserGroupIds, int userId, CancellationToken cancellationToken)
	{
		if (cpUserGroupIds == null)
		{
			throw new ArgumentNullException("cpUserGroupIds");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/usergroups/unassociatetousers/{cpUserGroupIds}/{userId}";
		znodeApiGateway = znodeApiGateway.Replace("{cpUserGroupIds}", Uri.EscapeDataString(ConvertToString(cpUserGroupIds, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{userId}", Uri.EscapeDataString(ConvertToString(userId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).DeleteResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IUserProfilesClient : IBaseClient
{
	[Obsolete]
	Task<UserProfileCpRoleListResponseModel> PostListAsync(UserProfileCpRoleListRequestModel body);

	[Obsolete]
	UserProfileCpRoleListResponseModel PostList(UserProfileCpRoleListRequestModel body);

	[Obsolete]
	Task<UserProfileCpRoleListResponseModel> PostListAsync(UserProfileCpRoleListRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<BooleanResponseModel> PostSaveddelegateAsync(CreateUserProfileCpRoleRequestModel body);

	[Obsolete]
	BooleanResponseModel PostSaveddelegate(CreateUserProfileCpRoleRequestModel body);

	[Obsolete]
	Task<BooleanResponseModel> PostSaveddelegateAsync(CreateUserProfileCpRoleRequestModel body, CancellationToken cancellationToken);

	[Obsolete]
	Task<OrderProductCatalogProfileResponseModel> GetProfiledetailsByUserIdAsync(int userId, int portalId);

	[Obsolete]
	OrderProductCatalogProfileResponseModel GetProfiledetailsByUserId(int userId, int portalId);

	[Obsolete]
	Task<OrderProductCatalogProfileResponseModel> GetProfiledetailsByUserIdAsync(int userId, int portalId, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UserProfilesClient : BaseClient, IUserProfilesClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public UserProfilesClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<UserProfileCpRoleListResponseModel> PostListAsync(UserProfileCpRoleListRequestModel body)
	{
		return PostListAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual UserProfileCpRoleListResponseModel PostList(UserProfileCpRoleListRequestModel body)
	{
		return Task.Run(async () => await PostListAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<UserProfileCpRoleListResponseModel> PostListAsync(UserProfileCpRoleListRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/userprofiles/list";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<UserProfileCpRoleListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<UserProfileCpRoleListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new UserProfileCpRoleListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				UserProfileCpRoleListResponseModel userProfileCpRoleListResponseModel = JsonConvert.DeserializeObject<UserProfileCpRoleListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)userProfileCpRoleListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<BooleanResponseModel> PostSaveddelegateAsync(CreateUserProfileCpRoleRequestModel body)
	{
		return PostSaveddelegateAsync(body, CancellationToken.None);
	}

	[Obsolete]
	public virtual BooleanResponseModel PostSaveddelegate(CreateUserProfileCpRoleRequestModel body)
	{
		return Task.Run(async () => await PostSaveddelegateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<BooleanResponseModel> PostSaveddelegateAsync(CreateUserProfileCpRoleRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/userprofiles/saveddelegate";
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject((object)body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<BooleanResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new BooleanResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				BooleanResponseModel booleanResponseModel = JsonConvert.DeserializeObject<BooleanResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)booleanResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<OrderProductCatalogProfileResponseModel> GetProfiledetailsByUserIdAsync(int userId, int portalId)
	{
		return GetProfiledetailsByUserIdAsync(userId, portalId, CancellationToken.None);
	}

	[Obsolete]
	public virtual OrderProductCatalogProfileResponseModel GetProfiledetailsByUserId(int userId, int portalId)
	{
		return Task.Run(async () => await GetProfiledetailsByUserIdAsync(userId, portalId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<OrderProductCatalogProfileResponseModel> GetProfiledetailsByUserIdAsync(int userId, int portalId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/userprofiles/profiledetails/{userId}/{portalId}";
		znodeApiGateway = znodeApiGateway.Replace("{userId}", Uri.EscapeDataString(ConvertToString(userId, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{portalId}", Uri.EscapeDataString(ConvertToString(portalId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<OrderProductCatalogProfileResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new OrderProductCatalogProfileResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				OrderProductCatalogProfileResponseModel orderProductCatalogProfileResponseModel = JsonConvert.DeserializeObject<OrderProductCatalogProfileResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)orderProductCatalogProfileResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IUserRolesAndPermissionsClient : IBaseClient
{
	[Obsolete]
	Task<RoleAndPermissionListResponseModel> GetRoleandpermissionsdetailsByUserIdAsync(int userId);

	[Obsolete]
	RoleAndPermissionListResponseModel GetRoleandpermissionsdetailsByUserId(int userId);

	[Obsolete]
	Task<RoleAndPermissionListResponseModel> GetRoleandpermissionsdetailsByUserIdAsync(int userId, CancellationToken cancellationToken);

	[Obsolete]
	Task<ItemLevelPermissionResponseModel> GetItemlevelpermissionsByOrderIdAsync(Guid orderId, int orderStateId);

	[Obsolete]
	ItemLevelPermissionResponseModel GetItemlevelpermissionsByOrderId(Guid orderId, int orderStateId);

	[Obsolete]
	Task<ItemLevelPermissionResponseModel> GetItemlevelpermissionsByOrderIdAsync(Guid orderId, int orderStateId, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UserRolesAndPermissionsClient : BaseClient, IUserRolesAndPermissionsClient, IBaseClient
{
	protected struct ObjectResponseResult<T>
	{
		public T Object { get; }

		public string Text { get; }

		public ObjectResponseResult(T responseObject, string responseText)
		{
			Object = responseObject;
			Text = responseText;
		}
	}

	private Lazy<JsonSerializerSettings> _settings;

	protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

	public bool ReadResponseAsString { get; set; }

	public UserRolesAndPermissionsClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	[Obsolete]
	public virtual Task<RoleAndPermissionListResponseModel> GetRoleandpermissionsdetailsByUserIdAsync(int userId)
	{
		return GetRoleandpermissionsdetailsByUserIdAsync(userId, CancellationToken.None);
	}

	[Obsolete]
	public virtual RoleAndPermissionListResponseModel GetRoleandpermissionsdetailsByUserId(int userId)
	{
		return Task.Run(async () => await GetRoleandpermissionsdetailsByUserIdAsync(userId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<RoleAndPermissionListResponseModel> GetRoleandpermissionsdetailsByUserIdAsync(int userId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/userrolesandpermissions/roleandpermissionsdetails/{userId}";
		znodeApiGateway = znodeApiGateway.Replace("{userId}", Uri.EscapeDataString(ConvertToString(userId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<RoleAndPermissionListResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new RoleAndPermissionListResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				RoleAndPermissionListResponseModel roleAndPermissionListResponseModel = JsonConvert.DeserializeObject<RoleAndPermissionListResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)roleAndPermissionListResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	[Obsolete]
	public virtual Task<ItemLevelPermissionResponseModel> GetItemlevelpermissionsByOrderIdAsync(Guid orderId, int orderStateId)
	{
		return GetItemlevelpermissionsByOrderIdAsync(orderId, orderStateId, CancellationToken.None);
	}

	[Obsolete]
	public virtual ItemLevelPermissionResponseModel GetItemlevelpermissionsByOrderId(Guid orderId, int orderStateId)
	{
		return Task.Run(async () => await GetItemlevelpermissionsByOrderIdAsync(orderId, orderStateId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	[Obsolete]
	public virtual async Task<ItemLevelPermissionResponseModel> GetItemlevelpermissionsByOrderIdAsync(Guid orderId, int orderStateId, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/commerceapi/v1/userrolesandpermissions/itemlevelpermissions/{orderId}/{orderStateId}";
		znodeApiGateway = znodeApiGateway.Replace("{orderId}", Uri.EscapeDataString(ConvertToString(orderId, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{orderStateId}", Uri.EscapeDataString(ConvertToString(orderStateId, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).GetResourceFromEndpointAsync(znodeApiGateway, status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			Dictionary<string, IEnumerable<string>> dictionary = response_.Headers.ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>((KeyValuePair<string, IEnumerable<string>> h_) => h_.Key, (KeyValuePair<string, IEnumerable<string>> h_) => h_.Value);
			if (response_.Content != null && response_.Content.Headers != null)
			{
				foreach (KeyValuePair<string, IEnumerable<string>> header in response_.Content.Headers)
				{
					dictionary[header.Key] = header.Value;
				}
			}
			int statusCode = (int)response_.StatusCode;
			if (statusCode == 401 && dictionary.ContainsKey("Is-JWT-Authorization") && dictionary["Is-JWT-Authorization"].FirstOrDefault().ToString() == "true")
			{
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			switch (statusCode)
			{
			case 200:
				return (await ReadObjectResponseAsync<ItemLevelPermissionResponseModel>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ItemLevelPermissionResponseModel();
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ItemLevelPermissionResponseModel itemLevelPermissionResponseModel = JsonConvert.DeserializeObject<ItemLevelPermissionResponseModel>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)itemLevelPermissionResponseModel, status, response_);
				throw new ZnodeException(status.ErrorCode, status.ErrorMessage, status.StatusCode);
			}
			}
		}
		finally
		{
			if (disposeResponse_)
			{
				response_.Dispose();
			}
		}
	}

	protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
	{
		if (response == null || response.Content == null)
		{
			return new ObjectResponseResult<T>(default(T), string.Empty);
		}
		if (ReadResponseAsString)
		{
			string text = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				T responseObject = JsonConvert.DeserializeObject<T>(text, JsonSerializerSettings);
				return new ObjectResponseResult<T>(responseObject, text);
			}
			catch (JsonException)
			{
				_ = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
				throw;
			}
		}
		try
		{
			using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using StreamReader streamReader = new StreamReader(stream);
			JsonTextReader val = new JsonTextReader((TextReader)streamReader);
			try
			{
				T responseObject2 = JsonSerializer.Create(JsonSerializerSettings).Deserialize<T>((JsonReader)(object)val);
				return new ObjectResponseResult<T>(responseObject2, string.Empty);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (JsonException)
		{
			_ = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
			throw;
		}
	}

	private string ConvertToString(object value, CultureInfo cultureInfo)
	{
		if (value == null)
		{
			return "";
		}
		if (value is Enum)
		{
			string name = Enum.GetName(value.GetType(), value);
			if (name != null)
			{
				FieldInfo declaredField = value.GetType().GetTypeInfo().GetDeclaredField(name);
				if (declaredField != null && declaredField.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute enumMemberAttribute)
				{
					if (enumMemberAttribute.Value == null)
					{
						return name;
					}
					return enumMemberAttribute.Value;
				}
				string text = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}
		else
		{
			if (value is bool)
			{
				return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
			}
			if (value is byte[])
			{
				return Convert.ToBase64String((byte[])value);
			}
			if (value.GetType().IsArray)
			{
				IEnumerable<object> source = ((Array)value).OfType<object>();
				return string.Join(",", source.Select((object o) => ConvertToString(o, cultureInfo)));
			}
		}
		string text2 = Convert.ToString(value, cultureInfo);
		if (text2 != null)
		{
			return text2;
		}
		return "";
	}
}
