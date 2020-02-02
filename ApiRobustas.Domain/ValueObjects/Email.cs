namespace ApiRobustas.Domain.ValueObjects
{
    public class Email
    {
        private string email;

        public Email(string email)
        {
            this.email = email;
        }

        public string EnderecoEmail { get; private set; }
    }
}
