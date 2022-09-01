import { Injectable } from '@angular/core';
import { itemCart } from '../classes/itemCart';
import { product } from '../classes/product';
import { shoppingCart } from '../classes/shoppingCart';
import { ProductService } from './product.service';

@Injectable({
  providedIn: 'root'
})
export class ShoppingCartService {
  shoppingCart: shoppingCart = {}

  constructor(public productService: ProductService) {
    this.shoppingCart.itemsCart = []
  }

  AddToCart(item: product) {
    this.productService.DecAmount(item.id!)
    var helpItem = this.shoppingCart.itemsCart!.find(x => x.idProduct == item.id)
    
    if (helpItem != undefined)
      helpItem.amount!++
    else
      this.shoppingCart.itemsCart!.push(new itemCart(item.id, item.prodName, 1, item.price))
  }
  inc(id: number) {
    let item = this.shoppingCart.itemsCart?.find(x => x.idProduct == id)!
    item.amount!++
    this.productService.DecAmount(id)
  }
  delete(id: number) {
    this.shoppingCart.itemsCart!.splice(this.shoppingCart.itemsCart!.findIndex(x => x.idProduct == id))

  }
  Dec(id: number) {
    this.productService.IncAmount(id)
    let item: itemCart = this.shoppingCart.itemsCart?.find(x=> x.idProduct == id)!
    if (item.amount == 1)
      this.delete(id)
    else item.amount!--    
  }
}
