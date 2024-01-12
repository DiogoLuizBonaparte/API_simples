namespace API.Model
{
    public interface IEmpoyeeRepository
    {
        void Add(Employee employee);
        List<Employee> get();
    }
}
