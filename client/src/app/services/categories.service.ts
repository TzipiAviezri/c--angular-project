import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { category } from '../classes/category';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {
  listCategories: Array<category> = []
  baseURL: string = "https://localhost:44382/Api/Category/"

  constructor(public HttpClient: HttpClient) {
    this.getAll().subscribe(
      x=> {this.listCategories = x}
    )
   }

  getAll(): Observable<Array<category>> {
    return this.HttpClient.get<Array<category>>(`${this.baseURL}getAll`)
  }
  AddOrEdit(category: category): Observable<Array<category>> {
    return this.HttpClient.post<Array<category>>(`${this.baseURL}/AddOrEdit/${category}`, category)
  }

}
