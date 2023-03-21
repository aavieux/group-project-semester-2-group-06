using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public class StockChange
{
    private int id;
    private int productId;
    private DateTime date;
    private int change;
    private int isRestock;
    public StockChange(int id, int productid, DateTime date, int change, int isRestock)
    {
        this.id = id;
        this.productId = id;
        this.date = date;
        this.change = change;
        this.isRestock = isRestock;
    }
}
