﻿using System;

namespace ApiRobustas.Domain.Arguments.Plataforma
{
    public class AdicionarPlataformaResponse
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Message { get; set; }
    }
}
