

namespace Mentor_Mashup.API;
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();

			// Register Swagger generator service
			//builder.Services.AddEndpointsApiExplorer(); \\ https://stackoverflow.com/questions/71932980/what-is-addendpointsapiexplorer-in-asp-net-core-6/71933535#71933535
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			// Configure the HTTP request pipeline.

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

		app.Run();
		}
	}

