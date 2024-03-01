using Aplicacion.Dominio;
using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalities.Sellers;
    public class SellerEndPoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/Api/Sellers", ([FromServices] ISellerService sellerService) => 
            {
                return Results.Ok(sellerService.GetSellers());
            });

            
            app.MapPost("/Api/Sellers", ([FromServices] ISellerService sellerService, SellerCommandDto sellerDto) =>
            {
                sellerService.CreateSeller(sellerDto);
                return Results.Ok();
            });

            app.MapDelete("/Api/Sellers", ([FromServices] ISellerService sellerService, Guid SellerId) =>
            {
                sellerService.DeleteSeller(SellerId);
                return Results.Ok();
            });
        }


    }
            