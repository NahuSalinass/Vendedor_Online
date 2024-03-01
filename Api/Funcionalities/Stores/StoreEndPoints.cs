using Aplicacion.Dominio;
using Carter;

using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalities.Stores;

    public class StoreEndPoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/Api/Stores", ([FromServices] IStoreService storeService) => 
            {
                return Results.Ok(storeService.GetStores());
            });

            app.MapPost("/Api/Store{StoreId}/Seller/{SellerId}", ([FromServices] IStoreService storeService, Guid StoreId, Guid SellerId) =>
            {
                storeService.AgregarVendedor(StoreId, SellerId);

                return Results.Ok();
            });
            
        }

        
    }
            