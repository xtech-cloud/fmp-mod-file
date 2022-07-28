
using Microsoft.AspNetCore.Components;
using XTC.FMP.LIB.MVCS;
using XTC.FMP.MOD.File.LIB.Proto;
using XTC.FMP.MOD.File.LIB.Bridge;
using XTC.FMP.MOD.File.LIB.MVCS;

namespace XTC.FMP.MOD.File.LIB.Razor
{
    public partial class BucketComponent
    {
        public class BucketUiBridge : IBucketUiBridge
        {

            public BucketUiBridge(BucketComponent _razor)
            {
                razor_ = _razor;
            }

            public void Alert(string _code, string _message)
            {
                if (null == razor_.messageService_)
                    return;
                Task.Run(async () =>
                {
                    await razor_.messageService_.Success(_message);
                }); 
            }


            public void RefreshMake(IDTO _dto)
            {
                var dto = _dto as UuidResponseDTO;
                razor_.__debugMake = dto?.message.ToString();
            }

            public void RefreshList(IDTO _dto)
            {
                var dto = _dto as BucketListResponseDTO;
                razor_.__debugList = dto?.message.ToString();
            }

            public void RefreshRemove(IDTO _dto)
            {
                var dto = _dto as UuidResponseDTO;
                razor_.__debugRemove = dto?.message.ToString();
            }

            public void RefreshGet(IDTO _dto)
            {
                var dto = _dto as BucketGetResponseDTO;
                razor_.__debugGet = dto?.message.ToString();
            }

            public void RefreshFind(IDTO _dto)
            {
                var dto = _dto as BucketFindResponseDTO;
                razor_.__debugFind = dto?.message.ToString();
            }

            public void RefreshSearch(IDTO _dto)
            {
                var dto = _dto as BucketSearchResponseDTO;
                razor_.__debugSearch = dto?.message.ToString();
            }

            public void RefreshUpdate(IDTO _dto)
            {
                var dto = _dto as UuidResponseDTO;
                razor_.__debugUpdate = dto?.message.ToString();
            }

            public void RefreshResetToken(IDTO _dto)
            {
                var dto = _dto as UuidResponseDTO;
                razor_.__debugResetToken = dto?.message.ToString();
            }

            public void RefreshGenerateManifest(IDTO _dto)
            {
                var dto = _dto as BucketGenerateManifestResponseDTO;
                razor_.__debugGenerateManifest = dto?.message.ToString();
            }

            public void RefreshClean(IDTO _dto)
            {
                var dto = _dto as UuidResponseDTO;
                razor_.__debugClean = dto?.message.ToString();
            }


            private BucketComponent razor_;
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }

        private async Task __debugClick()
        {
            var bridge = (getFacade()?.getViewBridge() as IBucketViewBridge);
            if (null == bridge)
            {
                logger_?.Error("bridge is null");
                return;
            }

            var reqMake = new BucketMakeRequest();
            var dtoMake = new BucketMakeRequestDTO(reqMake);
            logger_?.Trace("invoke OnMakeSubmit");
            await bridge.OnMakeSubmit(dtoMake);

            var reqList = new BucketListRequest();
            var dtoList = new BucketListRequestDTO(reqList);
            logger_?.Trace("invoke OnListSubmit");
            await bridge.OnListSubmit(dtoList);

            var reqRemove = new BucketRemoveRequest();
            var dtoRemove = new BucketRemoveRequestDTO(reqRemove);
            logger_?.Trace("invoke OnRemoveSubmit");
            await bridge.OnRemoveSubmit(dtoRemove);

            var reqGet = new BucketGetRequest();
            var dtoGet = new BucketGetRequestDTO(reqGet);
            logger_?.Trace("invoke OnGetSubmit");
            await bridge.OnGetSubmit(dtoGet);

            var reqFind = new BucketFindRequest();
            var dtoFind = new BucketFindRequestDTO(reqFind);
            logger_?.Trace("invoke OnFindSubmit");
            await bridge.OnFindSubmit(dtoFind);

            var reqSearch = new BucketSearchRequest();
            var dtoSearch = new BucketSearchRequestDTO(reqSearch);
            logger_?.Trace("invoke OnSearchSubmit");
            await bridge.OnSearchSubmit(dtoSearch);

            var reqUpdate = new BucketUpdateRequest();
            var dtoUpdate = new BucketUpdateRequestDTO(reqUpdate);
            logger_?.Trace("invoke OnUpdateSubmit");
            await bridge.OnUpdateSubmit(dtoUpdate);

            var reqResetToken = new BucketResetTokenRequest();
            var dtoResetToken = new BucketResetTokenRequestDTO(reqResetToken);
            logger_?.Trace("invoke OnResetTokenSubmit");
            await bridge.OnResetTokenSubmit(dtoResetToken);

            var reqGenerateManifest = new BucketGenerateManifestRequest();
            var dtoGenerateManifest = new BucketGenerateManifestRequestDTO(reqGenerateManifest);
            logger_?.Trace("invoke OnGenerateManifestSubmit");
            await bridge.OnGenerateManifestSubmit(dtoGenerateManifest);

            var reqClean = new BucketCleanRequest();
            var dtoClean = new BucketCleanRequestDTO(reqClean);
            logger_?.Trace("invoke OnCleanSubmit");
            await bridge.OnCleanSubmit(dtoClean);

        }


        private string? __debugMake;

        private string? __debugList;

        private string? __debugRemove;

        private string? __debugGet;

        private string? __debugFind;

        private string? __debugSearch;

        private string? __debugUpdate;

        private string? __debugResetToken;

        private string? __debugGenerateManifest;

        private string? __debugClean;

    }
}
