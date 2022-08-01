
using Microsoft.AspNetCore.Components;
using XTC.FMP.LIB.MVCS;
using XTC.FMP.MOD.File.LIB.Proto;
using XTC.FMP.MOD.File.LIB.Bridge;
using XTC.FMP.MOD.File.LIB.MVCS;

namespace XTC.FMP.MOD.File.LIB.Razor
{
    public partial class ObjectComponent
    {
        public class ObjectUiBridge : IObjectUiBridge
        {

            public ObjectUiBridge(ObjectComponent _razor)
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


            public void RefreshPrepare(IDTO _dto)
            {
                var dto = _dto as ObjectPrepareResponseDTO;
                razor_.__debugPrepare = dto?.Value.ToString();
            }

            public void RefreshFlush(IDTO _dto)
            {
                var dto = _dto as UuidResponseDTO;
                razor_.__debugFlush = dto?.Value.ToString();
            }

            public void RefreshGet(IDTO _dto)
            {
                var dto = _dto as ObjectGetResponseDTO;
                razor_.__debugGet = dto?.Value.ToString();
            }

            public void RefreshFind(IDTO _dto)
            {
                var dto = _dto as ObjectFindResponseDTO;
                razor_.__debugFind = dto?.Value.ToString();
            }

            public void RefreshRemove(IDTO _dto)
            {
                var dto = _dto as UuidResponseDTO;
                razor_.__debugRemove = dto?.Value.ToString();
            }

            public void RefreshList(IDTO _dto)
            {
                var dto = _dto as ObjectListResponseDTO;
                razor_.__debugList = dto?.Value.ToString();
            }

            public void RefreshSearch(IDTO _dto)
            {
                var dto = _dto as ObjectSearchResponseDTO;
                razor_.__debugSearch = dto?.Value.ToString();
            }

            public void RefreshPublish(IDTO _dto)
            {
                var dto = _dto as ObjectPublishResponseDTO;
                razor_.__debugPublish = dto?.Value.ToString();
            }

            public void RefreshPreview(IDTO _dto)
            {
                var dto = _dto as ObjectPreviewResponseDTO;
                razor_.__debugPreview = dto?.Value.ToString();
            }

            public void RefreshRetract(IDTO _dto)
            {
                var dto = _dto as UuidResponseDTO;
                razor_.__debugRetract = dto?.Value.ToString();
            }

            public void RefreshConvertFromBase64(IDTO _dto)
            {
                var dto = _dto as ObjectConvertFromBase64ResponseDTO;
                razor_.__debugConvertFromBase64 = dto?.Value.ToString();
            }

            public void RefreshConvertFromUrl(IDTO _dto)
            {
                var dto = _dto as ObjectConvertFromUrlResponseDTO;
                razor_.__debugConvertFromUrl = dto?.Value.ToString();
            }


            private ObjectComponent razor_;
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }

        private async Task __debugClick()
        {
            var bridge = (getFacade()?.getViewBridge() as IObjectViewBridge);
            if (null == bridge)
            {
                logger_?.Error("bridge is null");
                return;
            }

            var reqPrepare = new ObjectPrepareRequest();
            var dtoPrepare = new ObjectPrepareRequestDTO(reqPrepare);
            logger_?.Trace("invoke OnPrepareSubmit");
            await bridge.OnPrepareSubmit(dtoPrepare);

            var reqFlush = new ObjectFlushRequest();
            var dtoFlush = new ObjectFlushRequestDTO(reqFlush);
            logger_?.Trace("invoke OnFlushSubmit");
            await bridge.OnFlushSubmit(dtoFlush);

            var reqGet = new ObjectGetRequest();
            var dtoGet = new ObjectGetRequestDTO(reqGet);
            logger_?.Trace("invoke OnGetSubmit");
            await bridge.OnGetSubmit(dtoGet);

            var reqFind = new ObjectFindRequest();
            var dtoFind = new ObjectFindRequestDTO(reqFind);
            logger_?.Trace("invoke OnFindSubmit");
            await bridge.OnFindSubmit(dtoFind);

            var reqRemove = new ObjectRemoveRequest();
            var dtoRemove = new ObjectRemoveRequestDTO(reqRemove);
            logger_?.Trace("invoke OnRemoveSubmit");
            await bridge.OnRemoveSubmit(dtoRemove);

            var reqList = new ObjectListRequest();
            var dtoList = new ObjectListRequestDTO(reqList);
            logger_?.Trace("invoke OnListSubmit");
            await bridge.OnListSubmit(dtoList);

            var reqSearch = new ObjectSearchRequest();
            var dtoSearch = new ObjectSearchRequestDTO(reqSearch);
            logger_?.Trace("invoke OnSearchSubmit");
            await bridge.OnSearchSubmit(dtoSearch);

            var reqPublish = new ObjectPublishRequest();
            var dtoPublish = new ObjectPublishRequestDTO(reqPublish);
            logger_?.Trace("invoke OnPublishSubmit");
            await bridge.OnPublishSubmit(dtoPublish);

            var reqPreview = new ObjectPreviewRequest();
            var dtoPreview = new ObjectPreviewRequestDTO(reqPreview);
            logger_?.Trace("invoke OnPreviewSubmit");
            await bridge.OnPreviewSubmit(dtoPreview);

            var reqRetract = new ObjectRetractRequest();
            var dtoRetract = new ObjectRetractRequestDTO(reqRetract);
            logger_?.Trace("invoke OnRetractSubmit");
            await bridge.OnRetractSubmit(dtoRetract);

            var reqConvertFromBase64 = new ObjectConvertFromBase64Request();
            var dtoConvertFromBase64 = new ObjectConvertFromBase64RequestDTO(reqConvertFromBase64);
            logger_?.Trace("invoke OnConvertFromBase64Submit");
            await bridge.OnConvertFromBase64Submit(dtoConvertFromBase64);

            var reqConvertFromUrl = new ObjectConvertFromUrlRequest();
            var dtoConvertFromUrl = new ObjectConvertFromUrlRequestDTO(reqConvertFromUrl);
            logger_?.Trace("invoke OnConvertFromUrlSubmit");
            await bridge.OnConvertFromUrlSubmit(dtoConvertFromUrl);

        }


        private string? __debugPrepare;

        private string? __debugFlush;

        private string? __debugGet;

        private string? __debugFind;

        private string? __debugRemove;

        private string? __debugList;

        private string? __debugSearch;

        private string? __debugPublish;

        private string? __debugPreview;

        private string? __debugRetract;

        private string? __debugConvertFromBase64;

        private string? __debugConvertFromUrl;

    }
}
