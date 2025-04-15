import { Component } from '@angular/core';
import { BackEndWithFrontEndService } from '../Service/back-end-with-front-end.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-prdoduct-detalis',
  standalone: false,
  templateUrl: './prdoduct-detalis.component.html',
  styleUrl: './prdoduct-detalis.component.css'
})
export class PrdoductDetalisComponent {
  Product: any; // Define the Product property to hold the product details

  constructor(
    private _Service: BackEndWithFrontEndService,
    private _route: ActivatedRoute // Ensure it's declared as private
  ) { }

  ngOnInit() {
    this.My_Product(); // Initialize the product data
  }
  id:any
  My_Product() {
    this.id = this._route.snapshot.paramMap.get('id');
    if (this.id) {
      this._Service.Get_ProductsBasedOnID(this.id).subscribe({
        next: (data: any) => {
          this.Product = data;
          console.log(this.Product);
        },
        error: (error: any) => {
          console.error('Error fetching product details:', error);
        },
        complete: () => {
          console.log('Product fetch request completed successfully.');
        }
      });
    } else {
      console.error('No product ID found in the route!');
    }
  }
}
