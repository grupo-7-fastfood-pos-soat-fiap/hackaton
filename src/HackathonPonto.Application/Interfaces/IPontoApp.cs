﻿using GenericPack.Messaging;
using HackathonPonto.Application.InputModels;
using HackathonPonto.Application.ViewModels;

namespace HackathonPonto.Application.Interfaces
{
    public interface IPontoApp : IDisposable
    {
        Task<CommandResult> Add(string cpf);
        Task<PontoViewModel> GetById(Guid id);
        Task<dynamic> GetDayByUser(DateOnly data, string cpf);
        Task<dynamic> GetMonthYearByUser(int mes, int ano, string cpf);
    }
}
