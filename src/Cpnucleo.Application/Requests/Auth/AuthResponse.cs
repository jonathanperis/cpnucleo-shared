﻿namespace Cpnucleo.Application.Requests.Auth;

public class AuthResponse
{
    public string Token { get; set; }
    public RecursoDTO Recurso { get; set; }
    public OperationResult Status { get; set; }
}