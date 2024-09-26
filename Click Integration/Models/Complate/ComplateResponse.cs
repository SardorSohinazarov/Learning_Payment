namespace Click_Integration.Models.Complate
{
    public class CompleteResponse
    {
        public long ClickTransId { get; set; }        // CLICK tizimidagi to'lov ID si
        public string MerchantTransId { get; set; }   // Buyurtma yoki billing ID si
        public string MerchantConfirmId { get; set; }   // To'lovni yakunlash uchun tranzaksiya ID si (null bo'lishi mumkin)
        public int Error { get; set; }                // To'lov holati (0 - muvaffaqiyatli, xato bo'lsa xato kodi)
        public string ErrorNote { get; set; }         // Xato haqida izoh
    }
}
