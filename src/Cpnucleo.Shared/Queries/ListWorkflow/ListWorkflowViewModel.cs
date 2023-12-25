namespace Cpnucleo.Shared.Queries.ListWorkflow;

public sealed record ListWorkflowViewModel(OperationResult OperationResult, List<WorkflowDto>? Workflows = default) : BaseQuery;