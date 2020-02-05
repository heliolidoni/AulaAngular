namespace ApiRobustas.Domain.ValueObjects
{
    public class Email
    {
        public Email(string email)
        {
            this.EnderecoEmail = email;
        }

        public string EnderecoEmail { get; set; }
    }
}
