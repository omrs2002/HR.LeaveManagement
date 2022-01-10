//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"

namespace HR.LeaveManagement.MVC.Contracts
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IClient
    {
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<LeaveAllocationDto>> LeaveAllocationsAllAsync(bool? isLoggedInUser);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<LeaveAllocationDto>> LeaveAllocationsAllAsync(bool? isLoggedInUser, System.Threading.CancellationToken cancellationToken);

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BaseCommandResponse> LeaveAllocationsPOSTAsync(CreateLeaveAllocationDto body);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BaseCommandResponse> LeaveAllocationsPOSTAsync(CreateLeaveAllocationDto body, System.Threading.CancellationToken cancellationToken);

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task LeaveAllocationsPUTAsync(UpdateLeaveAllocationDto body);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task LeaveAllocationsPUTAsync(UpdateLeaveAllocationDto body, System.Threading.CancellationToken cancellationToken);

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<LeaveAllocationDto> LeaveAllocationsGETAsync(int id);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<LeaveAllocationDto> LeaveAllocationsGETAsync(int id, System.Threading.CancellationToken cancellationToken);

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task LeaveAllocationsDELETEAsync(int id);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task LeaveAllocationsDELETEAsync(int id, System.Threading.CancellationToken cancellationToken);

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<LeaveRequestListDto>> LeaveRequestsAllAsync(bool? isLoggedInUser);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<LeaveRequestListDto>> LeaveRequestsAllAsync(bool? isLoggedInUser, System.Threading.CancellationToken cancellationToken);

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BaseCommandResponse> LeaveRequestsPOSTAsync(CreateLeaveRequestDto body);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<BaseCommandResponse> LeaveRequestsPOSTAsync(CreateLeaveRequestDto body, System.Threading.CancellationToken cancellationToken);

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<LeaveRequestDto> LeaveRequestsGETAsync(int id);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<LeaveRequestDto> LeaveRequestsGETAsync(int id, System.Threading.CancellationToken cancellationToken);

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task LeaveRequestsPUTAsync(int id, UpdateLeaveRequestDto body);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task LeaveRequestsPUTAsync(int id, UpdateLeaveRequestDto body, System.Threading.CancellationToken cancellationToken);

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task LeaveRequestsDELETEAsync(int id);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task LeaveRequestsDELETEAsync(int id, System.Threading.CancellationToken cancellationToken);

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ChangeapprovalAsync(int id, ChangeLeaveRequestApprovalDto body);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task ChangeapprovalAsync(int id, ChangeLeaveRequestApprovalDto body, System.Threading.CancellationToken cancellationToken);

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<LeaveTypeDto>> LeaveTypesAllAsync();

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<LeaveTypeDto>> LeaveTypesAllAsync(System.Threading.CancellationToken cancellationToken);

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task LeaveTypesPOSTAsync(CreateLeaveTypeDto body);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task LeaveTypesPOSTAsync(CreateLeaveTypeDto body, System.Threading.CancellationToken cancellationToken);

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task LeaveTypesPUTAsync(LeaveTypeDto body);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task LeaveTypesPUTAsync(LeaveTypeDto body, System.Threading.CancellationToken cancellationToken);

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<LeaveTypeDto> LeaveTypesGETAsync(int id);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<LeaveTypeDto> LeaveTypesGETAsync(int id, System.Threading.CancellationToken cancellationToken);

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task LeaveTypesDELETEAsync(int id);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task LeaveTypesDELETEAsync(int id, System.Threading.CancellationToken cancellationToken);

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseCommandResponse
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Success { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("errors")]
        public System.Collections.Generic.ICollection<string> Errors { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ChangeLeaveRequestApprovalDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("approved")]
        public bool Approved { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateLeaveAllocationDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("leaveTypeId")]
        public int LeaveTypeId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateLeaveRequestDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public System.DateTimeOffset StartDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("endDate")]
        public System.DateTimeOffset EndDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("leaveTypeId")]
        public int LeaveTypeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("requestComments")]
        public string RequestComments { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateLeaveTypeDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("defaultDays")]
        public int DefaultDays { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class LeaveAllocationDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("numberOfDays")]
        public int NumberOfDays { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("leaveType")]
        public LeaveTypeDto LeaveType { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("employeeId")]
        public string EmployeeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("leaveTypeId")]
        public int LeaveTypeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("period")]
        public int Period { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class LeaveRequestDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public System.DateTimeOffset StartDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("endDate")]
        public System.DateTimeOffset EndDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("requestingEmployeeId")]
        public string RequestingEmployeeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("leaveType")]
        public LeaveTypeDto LeaveType { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("leaveTypeId")]
        public int LeaveTypeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("dateRequested")]
        public System.DateTimeOffset DateRequested { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("requestComments")]
        public string RequestComments { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("dateActioned")]
        public System.DateTimeOffset? DateActioned { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("approved")]
        public bool? Approved { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("cancelled")]
        public bool Cancelled { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class LeaveRequestListDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("requestingEmployeeId")]
        public string RequestingEmployeeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("leaveType")]
        public LeaveTypeDto LeaveType { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("dateRequested")]
        public System.DateTimeOffset DateRequested { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public System.DateTimeOffset StartDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("endDate")]
        public System.DateTimeOffset EndDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("approved")]
        public bool? Approved { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class LeaveTypeDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("defaultDays")]
        public int DefaultDays { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateLeaveAllocationDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("numberOfDays")]
        public int NumberOfDays { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("leaveTypeId")]
        public int LeaveTypeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("period")]
        public int Period { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateLeaveRequestDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public System.DateTimeOffset StartDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("endDate")]
        public System.DateTimeOffset EndDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("leaveTypeId")]
        public int LeaveTypeId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("requestComments")]
        public string RequestComments { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("cancelled")]
        public bool Cancelled { get; set; }

    }



    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ApiException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException)
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + ((response == null) ? "(null)" : response.Substring(0, response.Length >= 512 ? 512 : response.Length)), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ApiException<TResult> : ApiException
    {
        public TResult Result { get; private set; }

        public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016