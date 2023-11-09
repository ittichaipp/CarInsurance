using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarInsurance.Model
{
    public class InsuranceForm
    {
        
        public int Id { set; get; }
        
        [Display(Name = "ประเภทของรถ"), Required(ErrorMessage = "กรุณากรอก {0} ")]
        public string TypeCar { set; get;} 
        
        [Display(Name = "ชั้นประกัน"), Required(ErrorMessage = "กรุณากรอก {0} ")]
        
        public string Level { set; get; }
        
        [Display(Name = "ชื่อ"), Required(ErrorMessage = "กรุณากรอก {0} "), RegularExpression(@"^[ก-ฮะ-็เ-ไ่-๋a-zA-Z]{2,50}$", ErrorMessage = "กรุณากรอก {0} ใหม่ต้องเป็นตัวอักษรนะจ๊ะ")]
        public string FirstName { set; get; }
        
        [Display(Name = "นามสกุล"), Required(ErrorMessage = "กรุณากรอก {0} "), RegularExpression(@"^[ก-ฮะ-็เ-ไ่-๋a-zA-Z]{2,50}$", ErrorMessage = "กรุณากรอก {0} ใหม่ต้องเป็นตัวอักษรนะจ๊ะ")]
        public string LastName { set; get; }
        
        [Display(Name = "เบอร์โทรศัพท์"), Required(ErrorMessage = "กรุณากรอก {0} "), RegularExpression(@"^[0-9]{9,10}$", ErrorMessage = "กรุณากรอก {0} ใหม่ต้องเป็นตัวเลขนะจ๊ะ")]
        public string Tel { set; get; }
        
        [Display(Name = "อีเมล์"), Required(ErrorMessage = "กรุณากรอก {0} "), RegularExpression(@"^[a-zA-Z]{1,20}@exim.go.th$", ErrorMessage = "กรุณากรอก {0} ใหม่ต้องเป็นอีเมล์นะจ๊ะ")]
        //[EmailAddress]
        public string Email { set; get; }
        public int Total { set; get; }
    }
}
