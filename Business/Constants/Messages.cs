﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {

        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendş";
        public static string ProductCountOfCategoryError = "Ürün sayısı fazla";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductNameAlreadyExists = "Bu isimde başka bir ürün var";

        public static string CategoryLimitExceded = "Kategori limiti aşıldı";
    }
}
