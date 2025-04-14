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
    this.id = this._route.snapshot.paramMap.get('id'); // Access 'id' from route parameters
    if (this.id) { // Check if 'id' exists to prevent potential errors
      this._Service.Get_ProductsBasedOnID(this.id).subscribe(
        (data: any) => {
          this.Product = data; // Assign the fetched data to the Product property
          console.log(this.Product); // Log the product data
        },
        (error: any) => {
          console.error('Error fetching product details:', error); // Handle errors gracefully
        }
      );
    } else {
      console.error('No product ID found in the route!');
    }
  }
}
