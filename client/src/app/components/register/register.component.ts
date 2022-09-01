import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CardDetails } from 'src/app/classes/cardDetailse';
import { customer } from 'src/app/classes/customer';
import { CustomerService } from 'src/app/services/customer.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  currentUser: customer = this.customerService.currentUser
  cardDetails: CardDetails = {}
  constructor(public customerService: CustomerService, public router: Router) { }

  ngOnInit(): void { }


  login(){
    this.currentUser.cardDetails = this.cardDetails.num + "^" + this.cardDetails.valid + "^" + this.cardDetails.pin
    debugger
     this.currentUser  = new customer(this.currentUser.id , this.currentUser.password, this.currentUser.name , this.currentUser.cardDetails) 
    this.customerService.Add(this.currentUser).subscribe( x => {
      this.router.navigate(['/home'])  
    }, e=> {alert ();})
  }
}
