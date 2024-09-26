namespace Click_Integration.Models.Complate
{
    public class CompleteRequest
    {
        public long ClickTransId { get; set; }        // CLICK tizimidagi to'lov ID si
        public int ServiceId { get; set; }            // Xizmat ID si
        public long ClickPaydocId { get; set; }       // CLICK tizimidagi to'lov raqami
        public int MerchantTransId { get; set; }   // Buyurtma yoki billing ID si
        public int MerchantPrepareId { get; set; }    // Prepare bosqichida olingan to'lov ID si
        public float Amount { get; set; }             // To'lov summasi
        public int Action { get; set; } = 1;          // Harakat turi: 1 - Complete uchun
        public int Error { get; set; }                // To'lov holati (0 - muvaffaqiyatli, xato bo'lsa xato kodi)
        public string ErrorNote { get; set; }         // Xato haqida izoh
        public string SignTime { get; set; }          // To'lov vaqti (YYYY-MM-DD HH:mm:ss formatida)
        public string SignString { get; set; }        // So'rov haqiqiyligini tasdiqlovchi MD5 hash
    }

}
