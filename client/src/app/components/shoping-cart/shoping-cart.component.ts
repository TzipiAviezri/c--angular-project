import { Component, OnInit } from '@angular/core';
import { itemCart } from 'src/app/classes/itemCart';
import { product } from 'src/app/classes/product';
import { ShoppingCartService } from 'src/app/services/shopping-cart.service';

@Component({
  selector: 'app-shoping-cart',
  templateUrl: './shoping-cart.component.html',
  styleUrls: ['./shoping-cart.component.css']
})
export class ShopingCartComponent implements OnInit {
  cartListProduct: Array<itemCart> = this.shopingCartService.shoppingCart.itemsCart!
  
  
    constructor(public shopingCartService:ShoppingCartService) { }
  
  ngOnInit(): void {

  }
  
  delete(item:itemCart){
  this.shopingCartService.delete(item.idProduct!)
  }
  inc(item:itemCart){
     this.shopingCartService.inc(item.idProduct!)
  }
  dec(item:itemCart){
    this.shopingCartService.Dec(item.idProduct!)
  }
  finish(){
    
  }
sum(){
}
}
