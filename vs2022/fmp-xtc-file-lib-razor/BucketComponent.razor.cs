
using Microsoft.AspNetCore.Components;
using XTC.FMP.LIB.MVCS;
using XTC.FMP.MOD.File.LIB.Proto;
using XTC.FMP.MOD.File.LIB.Bridge;
using XTC.FMP.MOD.File.LIB.MVCS;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel;
using AntDesign;

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
                    await razor_.messageService_.Error(_message);
                    razor_.createLoading = false;
                    razor_.StateHasChanged();
                });
            }


            public void RefreshMake(IDTO _dto)
            {
                //var dto = _dto as UuidResponseDTO;
                razor_.createLoading = false;
                razor_.visibleCreateModal = false;
                razor_.StateHasChanged();

                Task.Run(async () =>
                {
                    await razor_.listAll();
                });
            }

            public void RefreshList(IDTO _dto)
            {
                var dto = _dto as BucketListResponseDTO;
                if (null == dto)
                    return;

                razor_.tableTotal = (int)dto.Value.Total;
                razor_.tableModel.Clear();
                foreach (var entity in dto.Value.Entity)
                {

                    razor_.tableModel.Add(new TableModel
                    {
                        Uuid = entity.Uuid,
                        Name = entity.Name,
                        Remark = entity.Remark,
                        TotalSize = Utility.StorageToString(entity.TotalSize),
                        UsedSize = Utility.StorageToString(entity.UsedSize),
                    });
                }
                razor_.StateHasChanged();
            }

            public void RefreshRemove(IDTO _dto)
            {
                var dto = _dto as UuidResponseDTO;
                if (null == dto)
                    return;
                razor_.tableModel.RemoveAll((_item) =>
                {
                    return _item.Uuid?.Equals(dto.Value.Uuid) ?? false;
                });
            }

            public void RefreshGet(IDTO _dto)
            {
                var dto = _dto as BucketGetResponseDTO;
            }

            public void RefreshFind(IDTO _dto)
            {
                var dto = _dto as BucketFindResponseDTO;
            }

            public void RefreshSearch(IDTO _dto)
            {
                var dto = _dto as BucketSearchResponseDTO;
            }

            public void RefreshUpdate(IDTO _dto)
            {
                var dto = _dto as UuidResponseDTO;
            }

            public void RefreshResetToken(IDTO _dto)
            {
                var dto = _dto as UuidResponseDTO;
            }

            public void RefreshGenerateManifest(IDTO _dto)
            {
                var dto = _dto as BucketGenerateManifestResponseDTO;
            }

            public void RefreshClean(IDTO _dto)
            {
                var dto = _dto as UuidResponseDTO;
            }

            private BucketComponent razor_;
        }


        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            searchFormData[SearchField.Name.GetHashCode()] = new FormValue { Text = "名称", Value = "" };
            searchFormData[SearchField.Remark.GetHashCode()] = new FormValue { Text = "备注", Value = "" };

            await listAll();
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


        #region Search
        private class FormValue
        {
            public string? Text { get; set; }
            public string? Value { get; set; }
        }

        private bool searchLoading = false;
        private AntDesign.Internal.IForm? searchForm;
        private Dictionary<int, FormValue> searchFormData = new();
        private bool searchExpand = false;

        private enum SearchField
        {
            Name,
            Remark,
        }

        private async void onSearchSubmit(EditContext _context)
        {
            searchLoading = true;
        }

        private async void onSearchResetClick()
        {
            searchForm?.Reset();
            await listAll();
        }
        #endregion

        #region Create Modal
        private class CreateModel
        {
            [Required]
            public string? Name { get; set; }
            [Required]
            public int Capacity { get; set; }
            public string? Remark { get; set; }
        }

        private bool visibleCreateModal = false;
        private bool createLoading = false;
        private AntDesign.Internal.IForm? createForm;
        private CreateModel createModel = new();

        private void onCreateClick()
        {
            visibleCreateModal = true;
        }

        private void onCreateModalOk()
        {
            createForm?.Submit();
        }

        private void onCreateModalCancel()
        {
            visibleCreateModal = false;
        }

        private async void onCreateSubmit(EditContext _context)
        {
            createLoading = true;
            var bridge = (getFacade()?.getViewBridge() as IBucketViewBridge);
            if (null == bridge)
            {
                logger_?.Error("bridge is null");
                return;
            }
            var model = _context.Model as CreateModel;
            if (null == model)
            {
                logger_?.Error("model is null");
                return;
            }
            var req = new BucketMakeRequest();
            req.Name = model.Name;
            req.Capacity = ((ulong)model.Capacity) * 1024L;
            req.Remark = model.Remark ?? "";
            BucketMakeRequestDTO dto = new BucketMakeRequestDTO(req);
            Error err = await bridge.OnMakeSubmit(dto);
            if (null != err)
            {
                logger_?.Error(err.getMessage());
            }
        }


        #endregion

        #region Table
        private class TableModel
        {
            public string? Uuid { get; set; }

            [DisplayName("名称")]
            public string? Name { get; set; }

            [DisplayName("备注")]
            public string? Remark { get; set; }
            [DisplayName("总容量")]
            public string? TotalSize { get; set; }
            [DisplayName("已用容量")]
            public string? UsedSize { get; set; }
        }


        private List<TableModel> tableModel = new();
        private int tableTotal = 0;
        private int tablePageIndex = 1;
        private int tablePageSize = 50;

        private async Task listAll()
        {
            var bridge = (getFacade()?.getViewBridge() as IBucketViewBridge);
            if (null == bridge)
            {
                logger_?.Error("bridge is null");
                return;
            }
            var req = new BucketListRequest();
            req.Offset = (tablePageIndex-1) * tablePageSize;
            req.Count = tablePageSize;
            var dto = new BucketListRequestDTO(req);
            Error err = await bridge.OnListSubmit(dto);
            if (!Error.IsOK(err))
            {
                logger_?.Error(err.getMessage());
            }
        }

        private async Task onConfirmDelete(string? _uuid)
        {
            if (string.IsNullOrEmpty(_uuid))
                return;

            var bridge = (getFacade()?.getViewBridge() as IBucketViewBridge);
            if (null == bridge)
            {
                logger_?.Error("bridge is null");
                return;
            }
            var req = new BucketRemoveRequest();
            req.Uuid = _uuid;
            var dto = new BucketRemoveRequestDTO(req);
            Error err = await bridge.OnRemoveSubmit(dto);
            if (!Error.IsOK(err))
            {
                logger_?.Error(err.getMessage());
            }
        }

        private void onCancelDelete()
        {
            //Nothing to do
        }

        private async void onPageIndexChanged(PaginationEventArgs args)
        {
            tablePageIndex = args.Page;
            await listAll();
        }
        #endregion
    }
}
