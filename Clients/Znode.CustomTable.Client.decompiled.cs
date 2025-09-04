using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
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
using Newtonsoft.Json.Linq;
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
[assembly: AssemblyCopyright("2024")]
[assembly: AssemblyDescription("Znode10.CustomTable.Client")]
[assembly: AssemblyFileVersion("10.0.0.0")]
[assembly: AssemblyInformationalVersion("10.0.0-rc-01+af7d6254df53a38a8cb62d0ff7be63656b07d7b4")]
[assembly: AssemblyProduct("Znode.CustomTable.Client")]
[assembly: AssemblyTitle("Znode.CustomTable.Client")]
[assembly: AssemblyVersion("10.0.0.0")]
[module: RefSafetyRules(11)]
namespace Znode.Engine.CustomTable.Client;

[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public interface ICustomTableClient : IBaseClient
{
	Task<CustomTableDetailListResponse> GetCustomTablesAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	CustomTableDetailListResponse GetCustomTables(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	Task<CustomTableDetailListResponse> GetCustomTablesAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	Task<CustomTableDetailResponse> PostCustomTablesAsync(CreateCustomTableDetailRequestModel body);

	CustomTableDetailResponse PostCustomTables(CreateCustomTableDetailRequestModel body);

	Task<CustomTableDetailResponse> PostCustomTablesAsync(CreateCustomTableDetailRequestModel body, CancellationToken cancellationToken);

	Task<CustomTableDetailResponse> PutCustomTablesByTableKeyAsync(string tableKey, EditCustomTableRequestModel body);

	CustomTableDetailResponse PutCustomTablesByTableKey(string tableKey, EditCustomTableRequestModel body);

	Task<CustomTableDetailResponse> PutCustomTablesByTableKeyAsync(string tableKey, EditCustomTableRequestModel body, CancellationToken cancellationToken);

	Task<CustomTableDetailResponse> GetCustomTablesByTableKeyAsync(string tableKey);

	CustomTableDetailResponse GetCustomTablesByTableKey(string tableKey);

	Task<CustomTableDetailResponse> GetCustomTablesByTableKeyAsync(string tableKey, CancellationToken cancellationToken);

	Task<TrueFalseResponse> DeleteCustomTablesByTableKeysAsync(string tableKeys);

	TrueFalseResponse DeleteCustomTablesByTableKeys(string tableKeys);

	Task<TrueFalseResponse> DeleteCustomTablesByTableKeysAsync(string tableKeys, CancellationToken cancellationToken);

	Task<TrueFalseResponse> GetRecordExistsByTableKeyAsync(string tableKey);

	TrueFalseResponse GetRecordExistsByTableKey(string tableKey);

	Task<TrueFalseResponse> GetRecordExistsByTableKeyAsync(string tableKey, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableClient : BaseClient, ICustomTableClient, IBaseClient
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

	public CustomTableClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	public virtual Task<CustomTableDetailListResponse> GetCustomTablesAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetCustomTablesAsync(filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	public virtual CustomTableDetailListResponse GetCustomTables(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetCustomTablesAsync(filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomTableDetailListResponse> GetCustomTablesAsync(IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-tables";
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
				return (await ReadObjectResponseAsync<CustomTableDetailListResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CustomTableDetailListResponse();
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CustomTableDetailListResponse customTableDetailListResponse = JsonConvert.DeserializeObject<CustomTableDetailListResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customTableDetailListResponse, status, response_);
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

	public virtual Task<CustomTableDetailResponse> PostCustomTablesAsync(CreateCustomTableDetailRequestModel body)
	{
		return PostCustomTablesAsync(body, CancellationToken.None);
	}

	public virtual CustomTableDetailResponse PostCustomTables(CreateCustomTableDetailRequestModel body)
	{
		return Task.Run(async () => await PostCustomTablesAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomTableDetailResponse> PostCustomTablesAsync(CreateCustomTableDetailRequestModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-tables";
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
				return (await ReadObjectResponseAsync<CustomTableDetailResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CustomTableDetailResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
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
				CustomTableDetailResponse customTableDetailResponse = JsonConvert.DeserializeObject<CustomTableDetailResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customTableDetailResponse, status, response_);
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

	public virtual Task<CustomTableDetailResponse> PutCustomTablesByTableKeyAsync(string tableKey, EditCustomTableRequestModel body)
	{
		return PutCustomTablesByTableKeyAsync(tableKey, body, CancellationToken.None);
	}

	public virtual CustomTableDetailResponse PutCustomTablesByTableKey(string tableKey, EditCustomTableRequestModel body)
	{
		return Task.Run(async () => await PutCustomTablesByTableKeyAsync(tableKey, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomTableDetailResponse> PutCustomTablesByTableKeyAsync(string tableKey, EditCustomTableRequestModel body, CancellationToken cancellationToken)
	{
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-tables/{tableKey}";
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
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
				return (await ReadObjectResponseAsync<CustomTableDetailResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CustomTableDetailResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
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
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CustomTableDetailResponse customTableDetailResponse = JsonConvert.DeserializeObject<CustomTableDetailResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customTableDetailResponse, status, response_);
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

	public virtual Task<CustomTableDetailResponse> GetCustomTablesByTableKeyAsync(string tableKey)
	{
		return GetCustomTablesByTableKeyAsync(tableKey, CancellationToken.None);
	}

	public virtual CustomTableDetailResponse GetCustomTablesByTableKey(string tableKey)
	{
		return Task.Run(async () => await GetCustomTablesByTableKeyAsync(tableKey, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomTableDetailResponse> GetCustomTablesByTableKeyAsync(string tableKey, CancellationToken cancellationToken)
	{
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-tables/{tableKey}";
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
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
				return (await ReadObjectResponseAsync<CustomTableDetailResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CustomTableDetailResponse();
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CustomTableDetailResponse customTableDetailResponse = JsonConvert.DeserializeObject<CustomTableDetailResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customTableDetailResponse, status, response_);
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

	public virtual Task<TrueFalseResponse> DeleteCustomTablesByTableKeysAsync(string tableKeys)
	{
		return DeleteCustomTablesByTableKeysAsync(tableKeys, CancellationToken.None);
	}

	public virtual TrueFalseResponse DeleteCustomTablesByTableKeys(string tableKeys)
	{
		return Task.Run(async () => await DeleteCustomTablesByTableKeysAsync(tableKeys, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<TrueFalseResponse> DeleteCustomTablesByTableKeysAsync(string tableKeys, CancellationToken cancellationToken)
	{
		if (tableKeys == null)
		{
			throw new ArgumentNullException("tableKeys");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-tables/{tableKeys}";
		znodeApiGateway = znodeApiGateway.Replace("{tableKeys}", Uri.EscapeDataString(ConvertToString(tableKeys, CultureInfo.InvariantCulture)));
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
				return (await ReadObjectResponseAsync<TrueFalseResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				TrueFalseResponse trueFalseResponse = JsonConvert.DeserializeObject<TrueFalseResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)trueFalseResponse, status, response_);
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

	public virtual Task<TrueFalseResponse> GetRecordExistsByTableKeyAsync(string tableKey)
	{
		return GetRecordExistsByTableKeyAsync(tableKey, CancellationToken.None);
	}

	public virtual TrueFalseResponse GetRecordExistsByTableKey(string tableKey)
	{
		return Task.Run(async () => await GetRecordExistsByTableKeyAsync(tableKey, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<TrueFalseResponse> GetRecordExistsByTableKeyAsync(string tableKey, CancellationToken cancellationToken)
	{
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-tables/{tableKey}/record-exists";
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
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
				return (await ReadObjectResponseAsync<TrueFalseResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				TrueFalseResponse trueFalseResponse = JsonConvert.DeserializeObject<TrueFalseResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)trueFalseResponse, status, response_);
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
public interface ICustomTableDataClient : IBaseClient
{
	Task<CustomTableDataListResponse> GetRecordsByTableKeyAsync(string tableKey, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	CustomTableDataListResponse GetRecordsByTableKey(string tableKey, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	Task<CustomTableDataListResponse> GetRecordsByTableKeyAsync(string tableKey, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	Task<CustomTableFieldDataResponse> GetCustomTableDataByTableKeyAsync(string tableKey, int rowId);

	CustomTableFieldDataResponse GetCustomTableDataByTableKey(string tableKey, int rowId);

	Task<CustomTableFieldDataResponse> GetCustomTableDataByTableKeyAsync(string tableKey, int rowId, CancellationToken cancellationToken);

	Task<TrueFalseResponse> DeleteCustomTableDataByTableKeyAsync(string tableKey, int rowId);

	TrueFalseResponse DeleteCustomTableDataByTableKey(string tableKey, int rowId);

	Task<TrueFalseResponse> DeleteCustomTableDataByTableKeyAsync(string tableKey, int rowId, CancellationToken cancellationToken);

	Task<CustomTableFieldDataResponse> PostCustomTableDataAsync(CustomTableCreateFieldDataModel body);

	CustomTableFieldDataResponse PostCustomTableData(CustomTableCreateFieldDataModel body);

	Task<CustomTableFieldDataResponse> PostCustomTableDataAsync(CustomTableCreateFieldDataModel body, CancellationToken cancellationToken);

	Task<CustomTableFieldDataResponse> PutCustomTableDataAsync(CustomTableUpdateFieldDataModel body);

	CustomTableFieldDataResponse PutCustomTableData(CustomTableUpdateFieldDataModel body);

	Task<CustomTableFieldDataResponse> PutCustomTableDataAsync(CustomTableUpdateFieldDataModel body, CancellationToken cancellationToken);

	Task<ImportCustomTableResponse> GetTableTemplateByTableKeyAsync(string tableKey);

	ImportCustomTableResponse GetTableTemplateByTableKey(string tableKey);

	Task<ImportCustomTableResponse> GetTableTemplateByTableKeyAsync(string tableKey, CancellationToken cancellationToken);

	Task<ExportResponse> GetExportByTableKeyAsync(string tableKey);

	ExportResponse GetExportByTableKey(string tableKey);

	Task<ExportResponse> GetExportByTableKeyAsync(string tableKey, CancellationToken cancellationToken);

	Task<CustomTableStringResponse> GetDownloadByTableNameAsync(string tableName);

	CustomTableStringResponse GetDownloadByTableName(string tableName);

	Task<CustomTableStringResponse> GetDownloadByTableNameAsync(string tableName, CancellationToken cancellationToken);

	Task<TrueFalseResponse> PostImportAsync(ImportCustomTableModel body);

	TrueFalseResponse PostImport(ImportCustomTableModel body);

	Task<TrueFalseResponse> PostImportAsync(ImportCustomTableModel body, CancellationToken cancellationToken);

	Task<CustomTableDataResponse> GetCustomTableDataByTableKeyAsync(string tableKey, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	CustomTableDataResponse GetCustomTableDataByTableKey(string tableKey, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	Task<CustomTableDataResponse> GetCustomTableDataByTableKeyAsync(string tableKey, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	Task<TrueFalseResponse> DeleteCustomTableDataByTableKeyAsync(string tableKey, IEnumerable<FilterTuple> filter);

	TrueFalseResponse DeleteCustomTableDataByTableKey(string tableKey, IEnumerable<FilterTuple> filter);

	Task<TrueFalseResponse> DeleteCustomTableDataByTableKeyAsync(string tableKey, IEnumerable<FilterTuple> filter, CancellationToken cancellationToken);

	Task<CustomTableBulkDeleteResponse> DeleteBulkByTableKeyAsync(string tableKey, string columnName, string columnValue);

	CustomTableBulkDeleteResponse DeleteBulkByTableKey(string tableKey, string columnName, string columnValue);

	Task<CustomTableBulkDeleteResponse> DeleteBulkByTableKeyAsync(string tableKey, string columnName, string columnValue, CancellationToken cancellationToken);

	Task<TrueFalseResponse> DeleteBulkByTableKeyAsync(string tableKey, string rowIds);

	TrueFalseResponse DeleteBulkByTableKey(string tableKey, string rowIds);

	Task<TrueFalseResponse> DeleteBulkByTableKeyAsync(string tableKey, string rowIds, CancellationToken cancellationToken);

	Task<CustomTableBulkResponse> PostBulkInsertByTableKeyAsync(string tableKey, object body);

	CustomTableBulkResponse PostBulkInsertByTableKey(string tableKey, object body);

	Task<CustomTableBulkResponse> PostBulkInsertByTableKeyAsync(string tableKey, object body, CancellationToken cancellationToken);

	Task<CustomTableBulkResponse> PostInsertByTableKeyAsync(string tableKey, object body);

	CustomTableBulkResponse PostInsertByTableKey(string tableKey, object body);

	Task<CustomTableBulkResponse> PostInsertByTableKeyAsync(string tableKey, object body, CancellationToken cancellationToken);

	Task<CustomTableBulkResponse> PutBulkUpdateByTableKeyAsync(string tableKey, object body);

	CustomTableBulkResponse PutBulkUpdateByTableKey(string tableKey, object body);

	Task<CustomTableBulkResponse> PutBulkUpdateByTableKeyAsync(string tableKey, object body, CancellationToken cancellationToken);

	Task<object> GetRowsByTableKeyAsync(string tableKey, int rowId);

	object GetRowsByTableKey(string tableKey, int rowId);

	Task<object> GetRowsByTableKeyAsync(string tableKey, int rowId, CancellationToken cancellationToken);

	Task<object> GetUniqueByTableKeyAsync(string tableKey, string uniqueValues);

	object GetUniqueByTableKey(string tableKey, string uniqueValues);

	Task<object> GetUniqueByTableKeyAsync(string tableKey, string uniqueValues, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableDataClient : BaseClient, ICustomTableDataClient, IBaseClient
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

	public CustomTableDataClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	public virtual Task<CustomTableDataListResponse> GetRecordsByTableKeyAsync(string tableKey, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetRecordsByTableKeyAsync(tableKey, filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	public virtual CustomTableDataListResponse GetRecordsByTableKey(string tableKey, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetRecordsByTableKeyAsync(tableKey, filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomTableDataListResponse> GetRecordsByTableKeyAsync(string tableKey, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-data/{tableKey}/records";
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
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
				return (await ReadObjectResponseAsync<CustomTableDataListResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CustomTableDataListResponse();
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CustomTableDataListResponse customTableDataListResponse = JsonConvert.DeserializeObject<CustomTableDataListResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customTableDataListResponse, status, response_);
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

	public virtual Task<CustomTableFieldDataResponse> GetCustomTableDataByTableKeyAsync(string tableKey, int rowId)
	{
		return GetCustomTableDataByTableKeyAsync(tableKey, rowId, CancellationToken.None);
	}

	public virtual CustomTableFieldDataResponse GetCustomTableDataByTableKey(string tableKey, int rowId)
	{
		return Task.Run(async () => await GetCustomTableDataByTableKeyAsync(tableKey, rowId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomTableFieldDataResponse> GetCustomTableDataByTableKeyAsync(string tableKey, int rowId, CancellationToken cancellationToken)
	{
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-data/{tableKey}/{rowId}";
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{rowId}", Uri.EscapeDataString(ConvertToString(rowId, CultureInfo.InvariantCulture)));
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
				return (await ReadObjectResponseAsync<CustomTableFieldDataResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CustomTableFieldDataResponse();
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CustomTableFieldDataResponse customTableFieldDataResponse = JsonConvert.DeserializeObject<CustomTableFieldDataResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customTableFieldDataResponse, status, response_);
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

	public virtual Task<TrueFalseResponse> DeleteCustomTableDataByTableKeyAsync(string tableKey, int rowId)
	{
		return DeleteCustomTableDataByTableKeyAsync(tableKey, rowId, CancellationToken.None);
	}

	public virtual TrueFalseResponse DeleteCustomTableDataByTableKey(string tableKey, int rowId)
	{
		return Task.Run(async () => await DeleteCustomTableDataByTableKeyAsync(tableKey, rowId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<TrueFalseResponse> DeleteCustomTableDataByTableKeyAsync(string tableKey, int rowId, CancellationToken cancellationToken)
	{
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-data/{tableKey}/{rowId}";
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{rowId}", Uri.EscapeDataString(ConvertToString(rowId, CultureInfo.InvariantCulture)));
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
				return (await ReadObjectResponseAsync<TrueFalseResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 404:
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
				TrueFalseResponse trueFalseResponse = JsonConvert.DeserializeObject<TrueFalseResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)trueFalseResponse, status, response_);
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

	public virtual Task<CustomTableFieldDataResponse> PostCustomTableDataAsync(CustomTableCreateFieldDataModel body)
	{
		return PostCustomTableDataAsync(body, CancellationToken.None);
	}

	public virtual CustomTableFieldDataResponse PostCustomTableData(CustomTableCreateFieldDataModel body)
	{
		return Task.Run(async () => await PostCustomTableDataAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomTableFieldDataResponse> PostCustomTableDataAsync(CustomTableCreateFieldDataModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-data";
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
				return (await ReadObjectResponseAsync<CustomTableFieldDataResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CustomTableFieldDataResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CustomTableFieldDataResponse();
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
				CustomTableFieldDataResponse customTableFieldDataResponse = JsonConvert.DeserializeObject<CustomTableFieldDataResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customTableFieldDataResponse, status, response_);
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

	public virtual Task<CustomTableFieldDataResponse> PutCustomTableDataAsync(CustomTableUpdateFieldDataModel body)
	{
		return PutCustomTableDataAsync(body, CancellationToken.None);
	}

	public virtual CustomTableFieldDataResponse PutCustomTableData(CustomTableUpdateFieldDataModel body)
	{
		return Task.Run(async () => await PutCustomTableDataAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomTableFieldDataResponse> PutCustomTableDataAsync(CustomTableUpdateFieldDataModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-data";
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
				return (await ReadObjectResponseAsync<CustomTableFieldDataResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CustomTableFieldDataResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CustomTableFieldDataResponse();
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
				CustomTableFieldDataResponse customTableFieldDataResponse = JsonConvert.DeserializeObject<CustomTableFieldDataResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customTableFieldDataResponse, status, response_);
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

	public virtual Task<ImportCustomTableResponse> GetTableTemplateByTableKeyAsync(string tableKey)
	{
		return GetTableTemplateByTableKeyAsync(tableKey, CancellationToken.None);
	}

	public virtual ImportCustomTableResponse GetTableTemplateByTableKey(string tableKey)
	{
		return Task.Run(async () => await GetTableTemplateByTableKeyAsync(tableKey, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<ImportCustomTableResponse> GetTableTemplateByTableKeyAsync(string tableKey, CancellationToken cancellationToken)
	{
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-data/{tableKey}/table-template";
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
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
				return (await ReadObjectResponseAsync<ImportCustomTableResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ImportCustomTableResponse();
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ImportCustomTableResponse importCustomTableResponse = JsonConvert.DeserializeObject<ImportCustomTableResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)importCustomTableResponse, status, response_);
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

	public virtual Task<ExportResponse> GetExportByTableKeyAsync(string tableKey)
	{
		return GetExportByTableKeyAsync(tableKey, CancellationToken.None);
	}

	public virtual ExportResponse GetExportByTableKey(string tableKey)
	{
		return Task.Run(async () => await GetExportByTableKeyAsync(tableKey, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<ExportResponse> GetExportByTableKeyAsync(string tableKey, CancellationToken cancellationToken)
	{
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-data/{tableKey}/export";
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
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
				return (await ReadObjectResponseAsync<ExportResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new ExportResponse();
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				ExportResponse exportResponse = JsonConvert.DeserializeObject<ExportResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)exportResponse, status, response_);
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

	public virtual Task<CustomTableStringResponse> GetDownloadByTableNameAsync(string tableName)
	{
		return GetDownloadByTableNameAsync(tableName, CancellationToken.None);
	}

	public virtual CustomTableStringResponse GetDownloadByTableName(string tableName)
	{
		return Task.Run(async () => await GetDownloadByTableNameAsync(tableName, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomTableStringResponse> GetDownloadByTableNameAsync(string tableName, CancellationToken cancellationToken)
	{
		if (tableName == null)
		{
			throw new ArgumentNullException("tableName");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-data/{tableName}/download";
		znodeApiGateway = znodeApiGateway.Replace("{tableName}", Uri.EscapeDataString(ConvertToString(tableName, CultureInfo.InvariantCulture)));
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
				return (await ReadObjectResponseAsync<CustomTableStringResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CustomTableStringResponse();
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CustomTableStringResponse customTableStringResponse = JsonConvert.DeserializeObject<CustomTableStringResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customTableStringResponse, status, response_);
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

	public virtual Task<TrueFalseResponse> PostImportAsync(ImportCustomTableModel body)
	{
		return PostImportAsync(body, CancellationToken.None);
	}

	public virtual TrueFalseResponse PostImport(ImportCustomTableModel body)
	{
		return Task.Run(async () => await PostImportAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<TrueFalseResponse> PostImportAsync(ImportCustomTableModel body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-data/import";
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
				return (await ReadObjectResponseAsync<TrueFalseResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new TrueFalseResponse();
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				TrueFalseResponse trueFalseResponse = JsonConvert.DeserializeObject<TrueFalseResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)trueFalseResponse, status, response_);
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

	public virtual Task<CustomTableDataResponse> GetCustomTableDataByTableKeyAsync(string tableKey, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetCustomTableDataByTableKeyAsync(tableKey, filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	public virtual CustomTableDataResponse GetCustomTableDataByTableKey(string tableKey, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetCustomTableDataByTableKeyAsync(tableKey, filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomTableDataResponse> GetCustomTableDataByTableKeyAsync(string tableKey, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-data/{tableKey}";
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
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
				return (await ReadObjectResponseAsync<CustomTableDataResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CustomTableDataResponse();
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CustomTableDataResponse customTableDataResponse = JsonConvert.DeserializeObject<CustomTableDataResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customTableDataResponse, status, response_);
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

	public virtual Task<TrueFalseResponse> DeleteCustomTableDataByTableKeyAsync(string tableKey, IEnumerable<FilterTuple> filter)
	{
		return DeleteCustomTableDataByTableKeyAsync(tableKey, filter, CancellationToken.None);
	}

	public virtual TrueFalseResponse DeleteCustomTableDataByTableKey(string tableKey, IEnumerable<FilterTuple> filter)
	{
		return Task.Run(async () => await DeleteCustomTableDataByTableKeyAsync(tableKey, filter, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<TrueFalseResponse> DeleteCustomTableDataByTableKeyAsync(string tableKey, IEnumerable<FilterTuple> filter, CancellationToken cancellationToken)
	{
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		if (filter == null)
		{
			throw new ArgumentNullException("filter");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-data/{tableKey}";
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
		znodeApiGateway += ((BaseClient)this).BuildEndpointQueryString((IEnumerable<string>)null, filter, (IDictionary<string, string>)null, (int?)null, (int?)null, Array.Empty<string>());
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
				return (await ReadObjectResponseAsync<TrueFalseResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new TrueFalseResponse();
			case 404:
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
				TrueFalseResponse trueFalseResponse = JsonConvert.DeserializeObject<TrueFalseResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)trueFalseResponse, status, response_);
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

	public virtual Task<CustomTableBulkDeleteResponse> DeleteBulkByTableKeyAsync(string tableKey, string columnName, string columnValue)
	{
		return DeleteBulkByTableKeyAsync(tableKey, columnName, columnValue, CancellationToken.None);
	}

	public virtual CustomTableBulkDeleteResponse DeleteBulkByTableKey(string tableKey, string columnName, string columnValue)
	{
		return Task.Run(async () => await DeleteBulkByTableKeyAsync(tableKey, columnName, columnValue, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomTableBulkDeleteResponse> DeleteBulkByTableKeyAsync(string tableKey, string columnName, string columnValue, CancellationToken cancellationToken)
	{
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		if (columnName == null)
		{
			throw new ArgumentNullException("columnName");
		}
		if (columnValue == null)
		{
			throw new ArgumentNullException("columnValue");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-data/{tableKey}/{columnName}/{columnValue}/bulk";
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{columnName}", Uri.EscapeDataString(ConvertToString(columnName, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{columnValue}", Uri.EscapeDataString(ConvertToString(columnValue, CultureInfo.InvariantCulture)));
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
				return (await ReadObjectResponseAsync<CustomTableBulkDeleteResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CustomTableBulkDeleteResponse();
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CustomTableBulkDeleteResponse customTableBulkDeleteResponse = JsonConvert.DeserializeObject<CustomTableBulkDeleteResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customTableBulkDeleteResponse, status, response_);
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

	public virtual Task<TrueFalseResponse> DeleteBulkByTableKeyAsync(string tableKey, string rowIds)
	{
		return DeleteBulkByTableKeyAsync(tableKey, rowIds, CancellationToken.None);
	}

	public virtual TrueFalseResponse DeleteBulkByTableKey(string tableKey, string rowIds)
	{
		return Task.Run(async () => await DeleteBulkByTableKeyAsync(tableKey, rowIds, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<TrueFalseResponse> DeleteBulkByTableKeyAsync(string tableKey, string rowIds, CancellationToken cancellationToken)
	{
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		if (rowIds == null)
		{
			throw new ArgumentNullException("rowIds");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-data/{tableKey}/{rowIds}/bulk";
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{rowIds}", Uri.EscapeDataString(ConvertToString(rowIds, CultureInfo.InvariantCulture)));
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
				return (await ReadObjectResponseAsync<TrueFalseResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new TrueFalseResponse();
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				TrueFalseResponse trueFalseResponse = JsonConvert.DeserializeObject<TrueFalseResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)trueFalseResponse, status, response_);
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

	public virtual Task<CustomTableBulkResponse> PostBulkInsertByTableKeyAsync(string tableKey, object body)
	{
		return PostBulkInsertByTableKeyAsync(tableKey, body, CancellationToken.None);
	}

	public virtual CustomTableBulkResponse PostBulkInsertByTableKey(string tableKey, object body)
	{
		return Task.Run(async () => await PostBulkInsertByTableKeyAsync(tableKey, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomTableBulkResponse> PostBulkInsertByTableKeyAsync(string tableKey, object body, CancellationToken cancellationToken)
	{
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-data/{tableKey}/bulk-insert";
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject(body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
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
				return (await ReadObjectResponseAsync<CustomTableBulkResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CustomTableBulkResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CustomTableBulkResponse();
			case 207:
				return (await ReadObjectResponseAsync<CustomTableBulkResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
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
				CustomTableBulkResponse customTableBulkResponse = JsonConvert.DeserializeObject<CustomTableBulkResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customTableBulkResponse, status, response_);
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

	public virtual Task<CustomTableBulkResponse> PostInsertByTableKeyAsync(string tableKey, object body)
	{
		return PostInsertByTableKeyAsync(tableKey, body, CancellationToken.None);
	}

	public virtual CustomTableBulkResponse PostInsertByTableKey(string tableKey, object body)
	{
		return Task.Run(async () => await PostInsertByTableKeyAsync(tableKey, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomTableBulkResponse> PostInsertByTableKeyAsync(string tableKey, object body, CancellationToken cancellationToken)
	{
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-data/{tableKey}/insert";
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PostResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject(body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
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
				return (await ReadObjectResponseAsync<CustomTableBulkResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CustomTableBulkResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 400:
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
				CustomTableBulkResponse customTableBulkResponse = JsonConvert.DeserializeObject<CustomTableBulkResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customTableBulkResponse, status, response_);
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

	public virtual Task<CustomTableBulkResponse> PutBulkUpdateByTableKeyAsync(string tableKey, object body)
	{
		return PutBulkUpdateByTableKeyAsync(tableKey, body, CancellationToken.None);
	}

	public virtual CustomTableBulkResponse PutBulkUpdateByTableKey(string tableKey, object body)
	{
		return Task.Run(async () => await PutBulkUpdateByTableKeyAsync(tableKey, body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomTableBulkResponse> PutBulkUpdateByTableKeyAsync(string tableKey, object body, CancellationToken cancellationToken)
	{
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-data/{tableKey}/bulk-update";
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
		HttpResponseMessage response_ = null;
		bool disposeResponse_ = true;
		try
		{
			ApiStatus status = new ApiStatus();
			response_ = await ((BaseClient)this).PutResourceToEndpointAsync(znodeApiGateway, JsonConvert.SerializeObject(body), status, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
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
				return (await ReadObjectResponseAsync<CustomTableBulkResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 207:
				return (await ReadObjectResponseAsync<CustomTableBulkResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CustomTableBulkResponse();
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
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
				CustomTableBulkResponse customTableBulkResponse = JsonConvert.DeserializeObject<CustomTableBulkResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customTableBulkResponse, status, response_);
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

	public virtual Task<object> GetRowsByTableKeyAsync(string tableKey, int rowId)
	{
		return GetRowsByTableKeyAsync(tableKey, rowId, CancellationToken.None);
	}

	public virtual object GetRowsByTableKey(string tableKey, int rowId)
	{
		return Task.Run(async () => await GetRowsByTableKeyAsync(tableKey, rowId, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<object> GetRowsByTableKeyAsync(string tableKey, int rowId, CancellationToken cancellationToken)
	{
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-data/{tableKey}/rows/{rowId}";
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{rowId}", Uri.EscapeDataString(ConvertToString(rowId, CultureInfo.InvariantCulture)));
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
				return (await ReadObjectResponseAsync<object>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new object();
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				object obj = JsonConvert.DeserializeObject<object>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus(obj, status, response_);
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

	public virtual Task<object> GetUniqueByTableKeyAsync(string tableKey, string uniqueValues)
	{
		return GetUniqueByTableKeyAsync(tableKey, uniqueValues, CancellationToken.None);
	}

	public virtual object GetUniqueByTableKey(string tableKey, string uniqueValues)
	{
		return Task.Run(async () => await GetUniqueByTableKeyAsync(tableKey, uniqueValues, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<object> GetUniqueByTableKeyAsync(string tableKey, string uniqueValues, CancellationToken cancellationToken)
	{
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		if (uniqueValues == null)
		{
			throw new ArgumentNullException("uniqueValues");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-data/{tableKey}/unique/{uniqueValues}";
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{uniqueValues}", Uri.EscapeDataString(ConvertToString(uniqueValues, CultureInfo.InvariantCulture)));
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
				return (await ReadObjectResponseAsync<object>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new object();
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			case 404:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult3 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult3.Object.ErrorCode, objectResponseResult3.Object.ErrorMessage);
			}
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult2 = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult2.Object.ErrorCode, objectResponseResult2.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				object obj = JsonConvert.DeserializeObject<object>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus(obj, status, response_);
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
public interface ICustomTableFieldClient : IBaseClient
{
	Task<CustomTableFieldListResponse> GetCustomTableFieldsByTableKeyAsync(string tableKey, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	CustomTableFieldListResponse GetCustomTableFieldsByTableKey(string tableKey, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize);

	Task<CustomTableFieldListResponse> GetCustomTableFieldsByTableKeyAsync(string tableKey, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken);

	Task<CustomTableFieldListResponse> PostCustomTableFieldsAsync(IEnumerable<CreateCustomTableFieldRequest> body);

	CustomTableFieldListResponse PostCustomTableFields(IEnumerable<CreateCustomTableFieldRequest> body);

	Task<CustomTableFieldListResponse> PostCustomTableFieldsAsync(IEnumerable<CreateCustomTableFieldRequest> body, CancellationToken cancellationToken);

	Task<CustomTableFieldListResponse> PutCustomTableFieldsAsync(IEnumerable<EditCustomTableFieldRequest> body);

	CustomTableFieldListResponse PutCustomTableFields(IEnumerable<EditCustomTableFieldRequest> body);

	Task<CustomTableFieldListResponse> PutCustomTableFieldsAsync(IEnumerable<EditCustomTableFieldRequest> body, CancellationToken cancellationToken);

	Task<TrueFalseResponse> DeleteCustomTableFieldsByFieldCodeAsync(string fieldCode, string tableKey);

	TrueFalseResponse DeleteCustomTableFieldsByFieldCode(string fieldCode, string tableKey);

	Task<TrueFalseResponse> DeleteCustomTableFieldsByFieldCodeAsync(string fieldCode, string tableKey, CancellationToken cancellationToken);
}
[GeneratedCode("NSwag", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableFieldClient : BaseClient, ICustomTableFieldClient, IBaseClient
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

	public CustomTableFieldClient()
	{
		_settings = new Lazy<JsonSerializerSettings>((Func<JsonSerializerSettings>)CreateSerializerSettings);
	}

	private JsonSerializerSettings CreateSerializerSettings()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	public virtual Task<CustomTableFieldListResponse> GetCustomTableFieldsByTableKeyAsync(string tableKey, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return GetCustomTableFieldsByTableKeyAsync(tableKey, filter, sort, pageIndex, pageSize, CancellationToken.None);
	}

	public virtual CustomTableFieldListResponse GetCustomTableFieldsByTableKey(string tableKey, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize)
	{
		return Task.Run(async () => await GetCustomTableFieldsByTableKeyAsync(tableKey, filter, sort, pageIndex, pageSize, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomTableFieldListResponse> GetCustomTableFieldsByTableKeyAsync(string tableKey, IEnumerable<FilterTuple> filter, IDictionary<string, string> sort, int? pageIndex, int? pageSize, CancellationToken cancellationToken)
	{
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-fields/{tableKey}";
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
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
				return (await ReadObjectResponseAsync<CustomTableFieldListResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CustomTableFieldListResponse();
			case 500:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CustomTableFieldListResponse customTableFieldListResponse = JsonConvert.DeserializeObject<CustomTableFieldListResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customTableFieldListResponse, status, response_);
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

	public virtual Task<CustomTableFieldListResponse> PostCustomTableFieldsAsync(IEnumerable<CreateCustomTableFieldRequest> body)
	{
		return PostCustomTableFieldsAsync(body, CancellationToken.None);
	}

	public virtual CustomTableFieldListResponse PostCustomTableFields(IEnumerable<CreateCustomTableFieldRequest> body)
	{
		return Task.Run(async () => await PostCustomTableFieldsAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomTableFieldListResponse> PostCustomTableFieldsAsync(IEnumerable<CreateCustomTableFieldRequest> body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-fields";
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
				return (await ReadObjectResponseAsync<CustomTableFieldListResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CustomTableFieldListResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CustomTableFieldListResponse();
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
				CustomTableFieldListResponse customTableFieldListResponse = JsonConvert.DeserializeObject<CustomTableFieldListResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customTableFieldListResponse, status, response_);
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

	public virtual Task<CustomTableFieldListResponse> PutCustomTableFieldsAsync(IEnumerable<EditCustomTableFieldRequest> body)
	{
		return PutCustomTableFieldsAsync(body, CancellationToken.None);
	}

	public virtual CustomTableFieldListResponse PutCustomTableFields(IEnumerable<EditCustomTableFieldRequest> body)
	{
		return Task.Run(async () => await PutCustomTableFieldsAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<CustomTableFieldListResponse> PutCustomTableFieldsAsync(IEnumerable<EditCustomTableFieldRequest> body, CancellationToken cancellationToken)
	{
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-fields";
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
				return (await ReadObjectResponseAsync<CustomTableFieldListResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 201:
				return (await ReadObjectResponseAsync<CustomTableFieldListResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 204:
				return new CustomTableFieldListResponse();
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
			case 400:
			{
				ObjectResponseResult<ZnodeErrorDetail> objectResponseResult = await ReadObjectResponseAsync<ZnodeErrorDetail>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				throw new ZnodeException(objectResponseResult.Object.ErrorCode, objectResponseResult.Object.ErrorMessage);
			}
			default:
			{
				string text = ((response_.Content != null) ? (await response_.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false)) : null);
				CustomTableFieldListResponse customTableFieldListResponse = JsonConvert.DeserializeObject<CustomTableFieldListResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)customTableFieldListResponse, status, response_);
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

	public virtual Task<TrueFalseResponse> DeleteCustomTableFieldsByFieldCodeAsync(string fieldCode, string tableKey)
	{
		return DeleteCustomTableFieldsByFieldCodeAsync(fieldCode, tableKey, CancellationToken.None);
	}

	public virtual TrueFalseResponse DeleteCustomTableFieldsByFieldCode(string fieldCode, string tableKey)
	{
		return Task.Run(async () => await DeleteCustomTableFieldsByFieldCodeAsync(fieldCode, tableKey, CancellationToken.None)).GetAwaiter().GetResult();
	}

	public virtual async Task<TrueFalseResponse> DeleteCustomTableFieldsByFieldCodeAsync(string fieldCode, string tableKey, CancellationToken cancellationToken)
	{
		if (fieldCode == null)
		{
			throw new ArgumentNullException("fieldCode");
		}
		if (tableKey == null)
		{
			throw new ArgumentNullException("tableKey");
		}
		string znodeApiGateway = ZnodeAdminSettings.ZnodeApiGateway;
		znodeApiGateway += "/v1/custom-table-fields/{fieldCode}/{tableKey}";
		znodeApiGateway = znodeApiGateway.Replace("{fieldCode}", Uri.EscapeDataString(ConvertToString(fieldCode, CultureInfo.InvariantCulture)));
		znodeApiGateway = znodeApiGateway.Replace("{tableKey}", Uri.EscapeDataString(ConvertToString(tableKey, CultureInfo.InvariantCulture)));
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
				return (await ReadObjectResponseAsync<TrueFalseResponse>(response_, dictionary, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Object;
			case 404:
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
				TrueFalseResponse trueFalseResponse = JsonConvert.DeserializeObject<TrueFalseResponse>(text, JsonSerializerSettings);
				((BaseClient)this).UpdateApiStatus((object)trueFalseResponse, status, response_);
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
public class CreateCustomTableDetailRequestModel
{
	public int CreatedBy { get; set; }

	[Required(AllowEmptyStrings = true)]
	[StringLength(100)]
	[RegularExpression("^[A-Za-z][a-zA-Z0-9]*$")]
	public string TableKey { get; set; }

	[Required(AllowEmptyStrings = true)]
	[StringLength(100)]
	public string TableName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateCustomTableFieldRequest
{
	public int CreatedBy { get; set; }

	[Required(AllowEmptyStrings = true)]
	[StringLength(10)]
	public string FieldType { get; set; }

	[Required(AllowEmptyStrings = true)]
	[StringLength(100)]
	[RegularExpression("^[a-zA-Z0-9]*$")]
	public string FieldCode { get; set; }

	[Required(AllowEmptyStrings = true)]
	[StringLength(100)]
	public string FieldName { get; set; }

	public int DisplayOrder { get; set; }

	public int TableId { get; set; }

	public string TableKey { get; set; }

	public bool IsUniqueConstraint { get; set; }

	public string FieldLength { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableBulkDataModel
{
	public string UniqueColumnValue { get; set; }

	public bool IsSuccess { get; set; }

	public string ErrorMessage { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableBulkDeleteResponse
{
	public CustomTableBulkDataModel Model { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableBulkResponse
{
	public ICollection<CustomTableBulkDataModel> CustomTableBulkDataModels { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableCreateFieldDataModel
{
	public int TableId { get; set; }

	public string TableKey { get; set; }

	public ICollection<CustomTableFieldModel> CustomTableFieldDataList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableDataListResponse
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public int TableId { get; set; }

	public IDictionary<string, JToken> Data { get; set; }

	public ICollection<CustomTableFieldModel> CustomTableFields { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableDataResponse
{
	public IDictionary<string, JToken> Data { get; set; }

	public ZnodePaginationDetail PaginationDetail { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableDetailListResponse
{
	public ZnodePaginationDetail PaginationDetail { get; set; }

	public ICollection<CustomTableDetailModel> CustomTableDetailList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableDetailModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public int TableId { get; set; }

	public string TableKey { get; set; }

	public string TableName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableDetailResponse
{
	public CustomTableDetailModel CustomTableDetailModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableFieldDataModel
{
	public int? ErrorCode { get; set; }

	public string ErrorMessage { get; set; }

	public bool HasError { get; set; }

	public HttpStatusCode StatusCode { get; set; }

	public int Id { get; set; }

	public int TableId { get; set; }

	public string TableKey { get; set; }

	public ICollection<CustomTableFieldModel> CustomTableFieldDataList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableFieldDataResponse
{
	public CustomTableFieldDataModel CustomTableFieldData { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableFieldListResponse
{
	public int? ErrorCode { get; set; }

	public string ErrorMessage { get; set; }

	public bool HasError { get; set; }

	public HttpStatusCode StatusCode { get; set; }

	public ICollection<CustomTableFieldModel> CustomTableFieldsList { get; set; }

	public int TableId { get; set; }

	public string TableKey { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableFieldModel
{
	public int? ErrorCode { get; set; }

	public string ErrorMessage { get; set; }

	public bool HasError { get; set; }

	public HttpStatusCode StatusCode { get; set; }

	public int FieldId { get; set; }

	public int TableId { get; set; }

	public string TableKey { get; set; }

	public string FieldType { get; set; }

	public string FieldCode { get; set; }

	public string FieldName { get; set; }

	public int DisplayOrder { get; set; }

	public object FieldValue { get; set; }

	public bool IsUniqueConstraint { get; set; }

	public string FieldLength { get; set; }

	public string FieldValidationMessages { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableStringResponse
{
	public byte[] Response { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableUpdateFieldDataModel
{
	public int Id { get; set; }

	public int TableId { get; set; }

	public string TableKey { get; set; }

	public ICollection<CustomTableFieldModel> CustomTableFieldDataList { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DownloadModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public ICollection<object> TemplateData { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EditCustomTableFieldRequest
{
	public int ModifiedBy { get; set; }

	public int FieldId { get; set; }

	[Required(AllowEmptyStrings = true)]
	[StringLength(10)]
	public string FieldType { get; set; }

	[Required(AllowEmptyStrings = true)]
	[StringLength(100)]
	[RegularExpression("^[a-zA-Z0-9]*$")]
	public string FieldCode { get; set; }

	[Required(AllowEmptyStrings = true)]
	[StringLength(100)]
	public string FieldName { get; set; }

	public int DisplayOrder { get; set; }

	public int TableId { get; set; }

	public string TableKey { get; set; }

	public bool IsUniqueConstraint { get; set; }

	public string FieldLength { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EditCustomTableRequestModel
{
	public int ModifiedBy { get; set; }

	public int TableId { get; set; }

	[Required(AllowEmptyStrings = true)]
	[StringLength(100)]
	public string TableName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ExportModel
{
	public string Message { get; set; }

	public bool HasError { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ExportResponse
{
	public ExportModel ExportMessageModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ImportCustomTableModel
{
	public int CreatedBy { get; set; }

	public DateTime CreatedDate { get; set; }

	public int ModifiedBy { get; set; }

	public DateTime ModifiedDate { get; set; }

	public string TableKey { get; set; }

	public string FileName { get; set; }

	public string ImportType { get; set; }

	public byte[] ImportData { get; set; }

	public int UserId { get; set; }

	public string TouchPointName { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ImportCustomTableResponse
{
	public DownloadModel DownloadModel { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TrueFalseResponse
{
	public bool IsSuccess { get; set; }
}
[GeneratedCode("NJsonSchema", "10.0.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ZnodeErrorDetail
{
	public int? ErrorCode { get; set; }

	public string ErrorMessage { get; set; }

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
