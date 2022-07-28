
//*************************************************************************************
//   !!! Generated by the fmp-cli.  DO NOT EDIT!
//*************************************************************************************

using System.Threading.Tasks;
using XTC.FMP.LIB.MVCS;

namespace XTC.FMP.MOD.File.LIB.Bridge
{
    /// <summary>
    /// Bucket的视图桥接层（协议部分）
    /// 处理UI的事件
    /// </summary>
    public interface IBucketViewProtoBridge : View.Facade.Bridge
    {

        /// <summary>
        /// 处理Make的提交
        /// </summary>
        Task<Error> OnMakeSubmit(IDTO _dto);


        /// <summary>
        /// 处理List的提交
        /// </summary>
        Task<Error> OnListSubmit(IDTO _dto);


        /// <summary>
        /// 处理Remove的提交
        /// </summary>
        Task<Error> OnRemoveSubmit(IDTO _dto);


        /// <summary>
        /// 处理Get的提交
        /// </summary>
        Task<Error> OnGetSubmit(IDTO _dto);


        /// <summary>
        /// 处理Find的提交
        /// </summary>
        Task<Error> OnFindSubmit(IDTO _dto);


        /// <summary>
        /// 处理Search的提交
        /// </summary>
        Task<Error> OnSearchSubmit(IDTO _dto);


        /// <summary>
        /// 处理Update的提交
        /// </summary>
        Task<Error> OnUpdateSubmit(IDTO _dto);


        /// <summary>
        /// 处理ResetToken的提交
        /// </summary>
        Task<Error> OnResetTokenSubmit(IDTO _dto);


        /// <summary>
        /// 处理GenerateManifest的提交
        /// </summary>
        Task<Error> OnGenerateManifestSubmit(IDTO _dto);


        /// <summary>
        /// 处理Clean的提交
        /// </summary>
        Task<Error> OnCleanSubmit(IDTO _dto);


    }
}
