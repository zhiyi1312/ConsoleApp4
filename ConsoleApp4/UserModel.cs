using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class UserModel
    {
        /// <summary>
        /// 选中
        /// </summary>
        public bool IsChecked { get; set; }
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public string ADDTIME { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string USER_NAME { get; set; }
        /// <summary>
        /// 货柜名称
        /// </summary>
        public string LOGIN_NAME { get; set; }
        /// <summary>
        /// 长度
        /// </summary>
        public string PWD { get; set; }
        /// <summary>
        /// 宽度
        /// </summary>
        public string CARD_NO { get; set; }
        /// <summary>
        /// 行数
        /// </summary>
        public string USER_STATUS { get; set; }
        /// <summary>
        /// 列数
        /// </summary>
        public string USER_ROLE { get; set; }
        /// <summary>
        /// 编号
        /// </summary>
        public string USER_FINGER { get; set; }
        /// <summary>
        /// <summary>
        /// 状态
        /// </summary>
        public string USER_FACE { get; set; }


        public UserModel()
        {

        }
    }
}
