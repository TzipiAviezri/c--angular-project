import { Injectable } from '@angular/core';
import { customer } from '../classes/customer';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class CustomerService {
  listCustomer: Array<customer> = []
  currentUser: customer = { cardDetails: "" }
  baseURL: string = "https://localhost:44382/Api/Customer/"
  constructor(public HttpClient: HttpClient) {
    this.getAll().subscribe(
      x => {this.listCustomer = x},
      e => {alert(e.message)}
    )
  }
  getAll(): Observable<Array<customer>> {
    return this.HttpClient.get<Array<customer>>(`${this.baseURL}GetAll`)
  }
  CheckIfExist(name: string, pin: number): Observable<customer> {
    return this.HttpClient.get<customer>(`${this.baseURL}CheckIfExist/${name}/${pin}`)
  }
  Add(customer: customer): Observable<boolean> {
    return this.HttpClient.put<boolean>(`${this.baseURL}Add`, customer)
  }


}
