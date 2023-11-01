using Backend.Application.Data;
using MediatR;
using ErrorOr;


namespace Backend.Application.Security;

public class RegisterUser
{
    public record Command(int Id) : IRequest<ErrorOr<Response>>;

    public record Response(int Id);

    public class CommandHandler : IRequestHandler<Command, ErrorOr<Response>>
    {
        private readonly IBackendDBContext _context;
        public CommandHandler(IBackendDBContext context) => _context = context;

        public async Task<ErrorOr<Response>> Handle(Command request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}