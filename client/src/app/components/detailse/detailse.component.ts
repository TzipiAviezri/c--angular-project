import { Component, OnInit } from '@angular/core';
import { product } from 'src/app/classes/product';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-detailse',
  templateUrl: './detailse.component.html',
  styleUrls: ['./detailse.component.css']
})
export class DetailseComponent implements OnInit {

  constructor(public productService: ProductService) { }

  ngOnInit(): void {
    console.log("detils")
    debugger
  }

}
