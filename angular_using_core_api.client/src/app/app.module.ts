import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ShowAllCategoriesComponent } from './show-all-categories/show-all-categories.component';
import { EditcategoryComponent } from './editcategory/editcategory.component';
import { ShowAllProductsComponent } from './show-all-products/show-all-products.component';
import { PrdoductDetalisComponent } from './prdoduct-detalis/prdoduct-detalis.component';
import { EditPrdoductComponent } from './edit-prdoduct/edit-prdoduct.component';
import { DeletePrdoductComponent } from './delete-prdoduct/delete-prdoduct.component';
import { AddProductComponent } from './add-product/add-product.component';

@NgModule({
  declarations: [
    AppComponent,
    ShowAllCategoriesComponent,
    EditcategoryComponent,
    ShowAllProductsComponent,
    PrdoductDetalisComponent,
    EditPrdoductComponent,
    DeletePrdoductComponent,
    AddProductComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule,FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
