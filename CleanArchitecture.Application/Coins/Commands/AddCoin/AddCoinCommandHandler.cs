﻿using CleanArchitecture.Application.Common;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Coins;
using ErrorOr;
using MediatR;

namespace CleanArchitecture.Application.Coins.Commands.AddCoin;

public class AddCoinCommandHandler : IRequestHandler<AddCoinCommand, ErrorOr<Coin>>
{
    private readonly ICoinsRepository _gymsRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AddCoinCommandHandler(
        ICoinsRepository gymsRepository,
        IUnitOfWork unitOfWork)
    {
        _gymsRepository = gymsRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<Coin>> Handle(AddCoinCommand command, CancellationToken cancellationToken)
    {
        //var coin = new Coin(
        //    name: command.Name,
        //    symbol: command.Symbol);
        var coin = new Coin();

        await _gymsRepository.AddCoinAsync(coin);
        await _unitOfWork.CommitChangesAsync();

        return coin;
    }
}