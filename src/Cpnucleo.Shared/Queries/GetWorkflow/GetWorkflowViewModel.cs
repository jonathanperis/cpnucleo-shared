namespace Cpnucleo.Shared.Queries.GetWorkflow;

public sealed record GetWorkflowViewModel(OperationResult OperationResult, WorkflowDto? Workflow = default) : BaseQuery;