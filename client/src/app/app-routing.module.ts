import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ByCategoryComponent } from './components/by-category/by-category.component';
import { CategoriesComponent } from './components/categories/categories.component';
import { DetailseComponent } from './components/detailse/detailse.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { ProductsComponent } from './components/products/products.component';
import { RegisterComponent } from './components/register/register.component';
import { ShopingCartComponent } from './components/shoping-cart/shoping-cart.component';

const routes: Routes = [
  {path: "home", component: HomeComponent, children: [
    {path: "byCategory/:{idCategory}" , component: ByCategoryComponent , children:[
      { path: "details/:{idProduct}", component: DetailseComponent }
    ]}     
    ]
  },
  { path: "login", component: LoginComponent },
  { path: "register", component: RegisterComponent },
  { path: "products", component: ProductsComponent },
  { path: "categories", component: CategoriesComponent },
  { path: "shopingCart", component: ShopingCartComponent },
  { path: "", component: HomeComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
