using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantSingleDataUploadResponse.
    /// </summary>
    public class ZhimaMerchantSingleDataUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 公用回传参数（非必填），这个字段由商户传入，系统透传给商户。
        /// </summary>
        [JsonProperty("biz_ext_params")]
        [XmlElement("biz_ext_params")]
        public string BizExtParams { get; set; }

        /// <summary>
        /// 每次上传都会生成一个任务号 。
        /// </summary>
        [JsonProperty("task_id")]
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
