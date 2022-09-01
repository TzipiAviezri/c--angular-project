import { Injectable } from '@angular/core';
import { product } from '../classes/product';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { CategoriesService } from './categories.service';
import { category } from '../classes/category';
@Injectable({
  providedIn: 'root'
})
export class ProductService {
  currentProduct: product = {}
  listProduct: Array<product> = []
  baseURL: string = "https://localhost:44382/Api/Product/"
  product: Array<product> = []


  constructor(public HttpClient: HttpClient, public categoryService: CategoriesService) {
    this.getAll().subscribe(
      x => { this.listProduct = x }
    )
  }

  getAll(): Observable<Array<product>> {
    return this.HttpClient.get<Array<product>>(`${this.baseURL}GetAll`)
  }
  GetById(idSeason: string): Observable<Array<product>> {
    return this.HttpClient.get<Array<product>>((`${this.baseURL}/GetBySeasonId/${idSeason}`))
  }
  AddOrEdit(product: product): Observable<Array<product>> {
    return this.HttpClient.post<Array<product>>(`${this.baseURL}/AddOrEdit/${product}`, product)
  }

  Delete(Flower: product): Observable<Array<product>> {
    return this.HttpClient.delete<Array<product>>(`${this.baseURL}/Delete/${product}`)
  }

  DecAmount(id: number) {
    return this.HttpClient.post<boolean>(`${this.baseURL}/DecAmount/${id}`, id)
  }
  IncAmount(id: number) {
    return this.HttpClient.post(`${this.baseURL}/IncAmount/${id}`, id)
  }
  productsByIdCategory(id:number) : Array<category> | undefined{
      return this.listProduct.filter(x=> x.idCategory == id)
      
  }
}