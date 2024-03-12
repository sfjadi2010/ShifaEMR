using Ardalis.Result;
using Ardalis.SharedKernel;

namespace ShifaEMR.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
