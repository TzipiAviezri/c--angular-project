import { Component, Input, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { customer } from 'src/app/classes/customer';
import { CustomerService } from 'src/app/services/customer.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {
  loginCustomer: customer = {}

  constructor(public customerService: CustomerService, public router: Router) { }

  ngOnInit(): void {
  }

  login() {
    this.customerService.CheckIfExist(this.customerService.currentUser.name!, this.customerService.currentUser.password!).subscribe(
      (x) => {
      if (x != null) {
        this.customerService.currentUser = x
        this.router.navigate(['/home'])
      }
      else {
        this.router.navigate(["/register"])
      }
    }, (err) => { alert(err.message) })
  }
}

