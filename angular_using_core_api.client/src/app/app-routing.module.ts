import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ShowAllCategoriesComponent } from './show-all-categories/show-all-categories.component';
import { EditcategoryComponent } from './editcategory/editcategory.component';
import { ShowAllProductsComponent } from './show-all-products/show-all-products.component';
import { PrdoductDetalisComponent } from './prdoduct-detalis/prdoduct-detalis.component';
import { EditPrdoductComponent } from './edit-prdoduct/edit-prdoduct.component';
import { DeletePrdoductComponent } from './delete-prdoduct/delete-prdoduct.component';
import { AddProductComponent } from './add-product/add-product.component';

const routes: Routes = [
  { path: 'AllCategories', component: ShowAllCategoriesComponent  },

  { path: 'AllCategories/:id', component: EditcategoryComponent },
  { path: 'AllProducts', component: ShowAllProductsComponent },
  { path: 'AddProduct', component: AddProductComponent },
  { path: 'ProductDetalis/:id', component: PrdoductDetalisComponent },
  { path: 'EditPrdoduct/:id', component: EditPrdoductComponent },
  { path: 'DeletePrdoduct/:id', component: DeletePrdoductComponent }

  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
