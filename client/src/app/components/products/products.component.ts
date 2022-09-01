import { Component, OnInit } from '@angular/core';
import { product } from 'src/app/classes/product';
import { category } from 'src/app/classes/category';
import { CategoriesService } from 'src/app/services/categories.service';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  constructor(public categoryService: CategoriesService,public productService: ProductService) { }

  currentProduct: product = {}
  categoryList: Array<category>= [];

  ngOnInit(): void {
    this.categoryService.getAll().subscribe(  
  x =>{ this.categoryList = x}, e => {alert(e.message)})
}
  addProduct() {
   this.productService.AddOrEdit(this.currentProduct);
  }
}
