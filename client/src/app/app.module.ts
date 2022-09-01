import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { TopNavComponent } from './components/top-nav/top-nav.component';
import { ProductsComponent } from './components/products/products.component';
import { CategoriesComponent } from './components/categories/categories.component';
import { ShopingCartComponent } from './components/shoping-cart/shoping-cart.component';
import { HomeComponent } from './components/home/home.component';
import { RegisterComponent } from './components/register/register.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CustomerService } from './services/customer.service';
import { HttpClientModule } from '@angular/common/http';
import { DetailseComponent } from './components/detailse/detailse.component';
import { ProductService } from './services/product.service';
import { CategoriesService } from './services/categories.service';
import { ByCategoryComponent } from './components/by-category/by-category.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    TopNavComponent,
    ProductsComponent,
    CategoriesComponent,
    ShopingCartComponent,
    HomeComponent,
    RegisterComponent,
    DetailseComponent,
    ByCategoryComponent
  ],
  imports: [
    BrowserModule, AppRoutingModule, FormsModule, HttpClientModule, ReactiveFormsModule , NgModule
  ],
  providers: [CustomerService, ProductService , CategoriesService],
  bootstrap: [AppComponent]
})

@NgModule({
  declarations: [
    AppComponent, 
  ],
  imports: [
    BrowserModule,
    AppRoutingModule, FormsModule , NgModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
