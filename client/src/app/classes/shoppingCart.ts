import { itemCart } from "./itemCart";

export class shoppingCart{
    constructor(
        public  itemsCart?: Array<itemCart> , 
        public  sum?: number
    ){

    }
}