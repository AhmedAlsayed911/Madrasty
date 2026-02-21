using System.Net;

namespace Madrasty.Core.Bases
{
    public class ResponseHandler
    {
        public ResponseHandler()
        {

        }

        public Response<T> Deleted<T>(string? message = null)
        {
            return new Response<T>
            {
                StatusCode = HttpStatusCode.OK,
                Succeeded = true,
                Message = message ?? "Deleted Successfully"
            };
        }

        public Response<T> Success<T>(T entity, object meta = null)
        {
            return new Response<T>
            {
                Data = entity,
                StatusCode = HttpStatusCode.OK,
                Succeeded = true,
                Message = "Successfully",
                Meta = meta
            };
        }

        public Response<T> Unauthorized<T>()
        {
            return new Response<T>
            {
                StatusCode = HttpStatusCode.Unauthorized,
                Succeeded = true,
                Message = "Unauthorized"
            };
        }

        public Response<T> BadRequest<T>(string? message = null)
        {
            return new Response<T>
            {
                StatusCode = HttpStatusCode.BadRequest,
                Succeeded = true,
                Message = message == null ? "Bad Request" : message
            };
        }

        public Response<T> NotFound<T>(string message = null)
        {
            return new Response<T>
            {
                StatusCode = HttpStatusCode.NotFound,
                Succeeded = true,
                Message = message == null ? "Not Found" : message
            };
        }

        public Response<T> Created<T>(T entity, object meta = null)
        {
            return new Response<T>
            {
                Data = entity,
                StatusCode = HttpStatusCode.OK,
                Succeeded = true,
                Message = "Created Successfully",
                Meta = meta
            };
        }

        public Response<T> UnprocessableEntity<T>(string message = null)
        {
            return new Response<T>()
            {
                StatusCode = HttpStatusCode.UnprocessableEntity,
                Succeeded = false,
                Message = message ?? "UnprocessableEntity"
            };
        }
    }
}
