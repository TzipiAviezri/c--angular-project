import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { product } from 'src/app/classes/product';
import { ProductService } from 'src/app/services/product.service';
import { ShoppingCartService } from 'src/app/services/shopping-cart.service';

@Component({
  selector: 'app-by-category',
  templateUrl: './by-category.component.html',
  styleUrls: ['./by-category.component.css']
})
export class ByCategoryComponent implements OnInit {
  
  listProduct: Array<product> | undefined

  constructor(public active: ActivatedRoute ,  public productServ: ProductService, 
    public shoppingCartServic: ShoppingCartService, public router: Router ) { }
    
  ngOnInit(): void {
    this.listProduct =  this.productServ.productsByIdCategory(Number(this.active.params.subscribe(x=> x.idCategory)))
  }
  details(item: product) {
    this.productServ.currentProduct = item
    this.router.navigate(['/home/details'])
    console.log(item)
  }
  addToCart(item: product) {
    this.shoppingCartServic.AddToCart(item)
    console.log(item.amount)
  }

}
