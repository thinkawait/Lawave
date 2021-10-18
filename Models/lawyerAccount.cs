using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lawave.Models
{
    public class lawyerAccount
    {
        [Key]//主鍵 PK
        [Display(Name = "編號")]//顯示名稱
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//自動生成編號
        public int Id { get; set; }

        [Required]//必填
        [MaxLength(200)]//限制最大字數，未設定為Max
        [Display(Name = "Mail")]//顯示名稱
        public string mail { get; set; }

        [MaxLength(200)]//限制最大字數，未設定為Max
        [Display(Name = "密碼")]//顯示名稱
        public string password { get; set; }

        [Display(Name = "是否為社群登入")]//顯示名稱
        public bool isCommunity { get; set; }

        [Display(Name = "社群ID")]//顯示名稱
        public string googleID { get; set; }

        [MaxLength(200)]//限制最大字數，未設定為Max
        [Display(Name = "姓")]//顯示名稱
        public string firstName { get; set; }

        [MaxLength(200)]//限制最大字數，未設定為Max
        [Display(Name = "名字")]//顯示名稱
        public string LastName { get; set; }


        [Display(Name = "大頭貼")]//顯示名稱
        public string shot { get; set; }

        [Display(Name = "驗證圖片")]//顯示名稱
        public string verifyPhoto { get; set; }

        [Display(Name = "是否公開個人資訊")]//顯示名稱
        public bool isPublic { get; set; }

        [MaxLength(200)]//限制最大字數，未設定為Max
        [Display(Name = "事務所")]//顯示名稱
        public string office { get; set; }

        [MaxLength(30)]//限制最大字數，未設定為Max
        [Display(Name = "phone")]//顯示名稱
        public string phone { get; set; }

        //[MaxLength()]//限制最大字數，未設定為Max
        [Display(Name = "名言")]//顯示名稱
        public string saying { get; set; }

        //[MaxLength()]//限制最大字數，未設定為Max
        [Display(Name = "律師介紹")]//顯示名稱
        public string introduction { get; set; }

        //[MaxLength()]//限制最大字數，未設定為Max
        [Display(Name = "工作經歷")]//顯示名稱
        public string experience { get; set; }

        //[MaxLength()]//限制最大字數，未設定為Max
        [Display(Name = "學歷")]//顯示名稱
        public string education { get; set; }

        //[MaxLength()]//限制最大字數，未設定為Max
        [Display(Name = "專業")]//顯示名稱
        public string professional { get; set; }

        //[MaxLength()]//限制最大字數，未設定為Max
        [Display(Name = "費用")]//顯示名稱
        public string cost { get; set; }

        [Display(Name = "驗證狀態")]//顯示名稱
        public bool isCertification { get; set; }

        [Display(Name = "建立時間")]
        public DateTime InitDate { get; set; }


        [JsonIgnore]
        public virtual ICollection<lawyerGoodAtType> lawyerGoodAtType { get; set; }

        [JsonIgnore]
        public virtual ICollection<lawyerArea> lawyerArea { get; set; }

        [JsonIgnore]
        public virtual ICollection<lawyerBlacklist> lawyerBlacklist { get; set; }

        [JsonIgnore]
        public virtual ICollection<publicCollection> PublicCollection { get; set; }

        [JsonIgnore]
        public virtual ICollection<appointmentlist> appointmentlist { get; set; }
    }
}