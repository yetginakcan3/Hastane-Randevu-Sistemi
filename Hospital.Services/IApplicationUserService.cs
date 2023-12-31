namespace Hospital.Services
{
    public interface IApplicationUserService
    {
        string? GetAll(int pageNumber, int pageSize);
    }
}