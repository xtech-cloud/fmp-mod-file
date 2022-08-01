
using Grpc.Core;
using System.Threading.Tasks;
using XTC.FMP.MOD.File.LIB.Proto;
using HttpStatusCode = System.Net.HttpStatusCode;

namespace XTC.FMP.MOD.File.App.Service
{
    public class BucketService : BucketServiceBase
    {
        private readonly BucketDAO bucketDAO_;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <remarks>
        /// 支持多个参数，均为自动注入，注入点位于MyProgram.PreBuild
        /// </remarks>
        /// <param name="_yourDAO">自动注入的数据操作对象</param>
        public BucketService(BucketDAO _bucketDAO)
        {
            bucketDAO_ = _bucketDAO;
        }

        public override async Task<UuidResponse> Make(BucketMakeRequest _request, ServerCallContext _context)
        {
            try
            {
                ArgumentChecker.CheckRequiredString(_request.Name, "Name");
                ArgumentChecker.CheckRequiredNumber((int)_request.Capacity, "Capacity");

                var bucket = await bucketDAO_.GetWithNameAsync(_request.Name);
                if (null != bucket)
                {
                    return new UuidResponse
                    {
                        Status = new LIB.Proto.Status() { Code = -HttpStatusCode.Found.GetHashCode(), Message = "bucket exists" },
                    };
                }

                bucket = new BucketEntity();
                bucket.Uuid = Guid.NewGuid();
                bucket.Name = _request.Name;
                bucket.Remark = _request.Remark;
                bucket.TotalSize = _request.Capacity;
                bucket.UsedSize = 0;
                if (null != _request.Storage)
                {
                    bucket.Storage = new Storage();
                    bucket.Storage.AccessKey = _request.Storage.AccessKey;
                    bucket.Storage.AccessSecret = _request.Storage.AccessSecret;
                    bucket.Storage.Address = _request.Storage.Address;
                    bucket.Storage.Driver = _request.Storage.Driver;
                    bucket.Storage.Mode = _request.Storage.Mode;
                    bucket.Storage.Scope = _request.Storage.Scope;
                    bucket.Storage.Url = _request.Storage.Url;
                }
                await bucketDAO_.CreateAsync(bucket);
                return new UuidResponse
                {
                    Status = new LIB.Proto.Status(),
                    Uuid = bucket.Uuid.ToString(),
                };
            }
            catch (ArgumentRequiredException ex)
            {
                return new UuidResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.BadRequest.GetHashCode(), Message = ex.Message },
                };
            }
            catch (Exception ex)
            {
                return new UuidResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.InternalServerError.GetHashCode(), Message = ex.Message },
                };
            }
        }

        public override async Task<UuidResponse> Update(BucketUpdateRequest _request, ServerCallContext _context)
        {
            try
            {
                ArgumentChecker.CheckRequiredString(_request.Uuid, "Uuid");

                var bucket = await bucketDAO_.GetAsync(_request.Uuid);
                if (null == bucket)
                {
                    return new UuidResponse
                    {
                        Status = new LIB.Proto.Status() { Code = -HttpStatusCode.NotFound.GetHashCode(), Message = "not found" },
                    };
                }

                if (!string.IsNullOrWhiteSpace(_request.Name))
                    bucket.Name = _request.Name;
                if (!string.IsNullOrWhiteSpace(_request.Remark))
                    bucket.Remark = _request.Remark;
                if (0 != _request.Capacity)
                    bucket.TotalSize = _request.Capacity;

                if (null != _request.Storage)
                {
                    if (null == bucket.Storage)
                        bucket.Storage = new Storage();

                    if (!string.IsNullOrWhiteSpace(_request.Storage.AccessKey))
                        bucket.Storage.AccessKey = _request.Storage.AccessKey;
                    if (!string.IsNullOrWhiteSpace(_request.Storage.AccessSecret))
                        bucket.Storage.AccessSecret = _request.Storage.AccessSecret;
                    if (!string.IsNullOrWhiteSpace(_request.Storage.Address))
                        bucket.Storage.Address = _request.Storage.Address;
                    if (!string.IsNullOrWhiteSpace(_request.Storage.Driver))
                        bucket.Storage.Driver = _request.Storage.Driver;
                    if (!string.IsNullOrWhiteSpace(_request.Storage.Mode))
                        bucket.Storage.Mode = _request.Storage.Mode;
                    if (!string.IsNullOrWhiteSpace(_request.Storage.Scope))
                        bucket.Storage.Scope = _request.Storage.Scope;
                    if (!string.IsNullOrWhiteSpace(_request.Storage.Url))
                        bucket.Storage.Scope = _request.Storage.Url;
                }
                await bucketDAO_.UpdateAsync(_request.Uuid, bucket);
                return new UuidResponse
                {
                    Status = new LIB.Proto.Status(),
                    Uuid = bucket.Uuid.ToString(),
                };
            }
            catch (ArgumentRequiredException ex)
            {
                return new UuidResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.BadRequest.GetHashCode(), Message = ex.Message },
                };
            }
            catch (Exception ex)
            {
                return new UuidResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.InternalServerError.GetHashCode(), Message = ex.Message },
                };
            }

        }

        public override async Task<BucketListResponse> List(BucketListRequest _request, ServerCallContext _context)
        {
            try
            {
                ArgumentChecker.CheckRequiredNumber((int)_request.Count, "Count");
                var result = await bucketDAO_.ListAsync((int)_request.Offset, (int)_request.Count);
                var rsp = new BucketListResponse();
                rsp.Status = new LIB.Proto.Status();
                rsp.Total = (ulong)await bucketDAO_.CountAsync();
                foreach (var e in result)
                {
                    rsp.Entity.Add(bucketDAO_.ToProtoEntity(e));
                }
                return rsp;
            }
            catch (ArgumentRequiredException ex)
            {
                return new BucketListResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.BadRequest.GetHashCode(), Message = ex.Message },
                };
            }
            catch (Exception ex)
            {
                return new BucketListResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.InternalServerError.GetHashCode(), Message = ex.Message },
                };
            }
        }

        public override async Task<BucketGetResponse> Get(BucketGetRequest _request, ServerCallContext _context)
        {
            try
            {
                ArgumentChecker.CheckRequiredString(_request.Uuid, "Uuid");
                var result = await bucketDAO_.GetAsync(_request.Uuid);
                if (null == result)
                {
                    return new BucketGetResponse
                    {
                        Status = new LIB.Proto.Status() { Code = -HttpStatusCode.NotFound.GetHashCode(), Message = "not found" },
                    };
                }

                var rsp = new BucketGetResponse();
                rsp.Status = new LIB.Proto.Status();
                rsp.Entity = bucketDAO_.ToProtoEntity(result);
                return rsp;
            }
            catch (ArgumentRequiredException ex)
            {
                return new BucketGetResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.BadRequest.GetHashCode(), Message = ex.Message },
                };
            }
            catch (Exception ex)
            {
                return new BucketGetResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.InternalServerError.GetHashCode(), Message = ex.Message },
                };
            }
        }

        public override async Task<BucketFindResponse> Find(BucketFindRequest _request, ServerCallContext _context)
        {
            try
            {
                ArgumentChecker.CheckRequiredString(_request.Name, "Name");

                var result = await bucketDAO_.GetWithNameAsync(_request.Name);
                if (null == result)
                {
                    return new BucketFindResponse
                    {
                        Status = new LIB.Proto.Status() { Code = -HttpStatusCode.NotFound.GetHashCode(), Message = "not found" },
                    };
                }
                return new BucketFindResponse
                {
                    Status = new LIB.Proto.Status(),
                    Entity = bucketDAO_.ToProtoEntity(result),
                };
            }
            catch (ArgumentRequiredException ex)
            {
                return new BucketFindResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.BadRequest.GetHashCode(), Message = ex.Message },
                };
            }
            catch (Exception ex)
            {
                return new BucketFindResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.InternalServerError.GetHashCode(), Message = ex.Message },
                };
            }
        }

        public override async Task<BucketSearchResponse> Search(BucketSearchRequest _request, ServerCallContext _context)
        {
            try
            {
                ArgumentChecker.CheckRequiredNumber((int)_request.Count, "Count");
                if (string.IsNullOrWhiteSpace(_request.Name) && string.IsNullOrWhiteSpace(_request.Remark))
                {
                    return new BucketSearchResponse
                    {
                        Status = new LIB.Proto.Status(),
                    };
                }

                var result = await bucketDAO_.SearchAsync((int)_request.Offset, (int)_request.Count, _request.Name, _request.Remark);
                var rsp = new BucketSearchResponse();
                rsp.Status = new LIB.Proto.Status();
                rsp.Total = (ulong)result.Count;
                foreach (var e in result)
                {
                    rsp.Entity.Add(bucketDAO_.ToProtoEntity(e));
                }
                return rsp;
            }
            catch (ArgumentRequiredException ex)
            {
                return new BucketSearchResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.BadRequest.GetHashCode(), Message = ex.Message },
                };
            }
            catch (Exception ex)
            {
                return new BucketSearchResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.InternalServerError.GetHashCode(), Message = ex.Message },
                };
            }
        }

        public override async Task<UuidResponse> Remove(BucketRemoveRequest _request, ServerCallContext _context)
        {
            try
            {
                ArgumentChecker.CheckRequiredString(_request.Uuid, "Uuid");

                var result = await bucketDAO_.GetAsync(_request.Uuid);
                if(null == result)
                {
                    return new UuidResponse
                    {
                        Status = new LIB.Proto.Status { Code = -HttpStatusCode.NotFound.GetHashCode(), Message = "not found" },
                    };
                }

                await bucketDAO_.RemoveAsync(_request.Uuid);

                return new UuidResponse
                {
                    Status = new LIB.Proto.Status(),
                    Uuid = _request.Uuid,
                };
            }
            catch (ArgumentRequiredException ex)
            {
                return new UuidResponse {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.BadRequest.GetHashCode(), Message = ex.Message },
                };
            }
            catch (Exception ex)
            {
                return new UuidResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.InternalServerError.GetHashCode(), Message = ex.Message },
                };
            }
        }
    }
}
