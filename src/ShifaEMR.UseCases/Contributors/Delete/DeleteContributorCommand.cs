using Ardalis.Result;
using Ardalis.SharedKernel;

namespace ShifaEMR.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
