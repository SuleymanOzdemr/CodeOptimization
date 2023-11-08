namespace Example_1
{
    public interface IRepository<T>
    {
        void Add(T item);
        IEnumerable<T> GetAll();
    }

    public class CustomerRepository : IRepository<Customer>, ICustomerActions
    {
        private List<Customer> customers;

        public CustomerRepository()
        {
            customers = new List<Customer>();
        }


        public void Add(Customer customer)
        {
            if (customers.Any(c => c.Id == customer.Id))
            {
                throw new Exception("Dublicate ID");
            }
            customers.Add(customer);
        }

        public IEnumerable<Customer> GetAll()
        {
            return customers.ToList();
        }

        public void ArchiveCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        
    }
}
