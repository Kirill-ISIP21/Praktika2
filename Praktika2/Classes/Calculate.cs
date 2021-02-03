using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika2
{
    class Calculate
    {
        public Calculate(int rozes, int tulpanes)
        {
        this.rozes = rozes;
        this.tulpanes = tulpanes;
        }

       public int rozes { get; set; }
       public int tulpanes { get; set; }
       public string allPrice()
       {
          int priceRoz = rozes * 50;
          int priceTulp = tulpanes * 30;
            if (priceRoz > priceTulp)
                {
                    return $"У цветочницы с розами выручка больше: {priceRoz}, а с тюльпанами: {priceTulp}";
                }
                else if (priceRoz < priceTulp)
                {
                    return $"У цветочницы с тюльпанами  выручка больше: {priceTulp}, а с розами: {priceRoz}";
                }
            else
            {
                return $"Выручка у обеих цветочниц одинаковая {priceRoz}";
            }
       }
    }
}
