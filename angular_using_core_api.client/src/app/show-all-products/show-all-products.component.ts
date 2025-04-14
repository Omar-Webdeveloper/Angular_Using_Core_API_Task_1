import { Component } from '@angular/core';
import { BackEndWithFrontEndService } from '../Service/back-end-with-front-end.service';

@Component({
  selector: 'app-show-all-products',
  standalone: false,
  templateUrl: './show-all-products.component.html',
  styleUrl: './show-all-products.component.css'
})
export class ShowAllProductsComponent {
  constructor(private _Service: BackEndWithFrontEndService) { }
  ngOnInit() {
    this.Get_Products();
  }
  Products: any = [];
  Get_Products() {
    this._Service.Get_Products().subscribe((data: any) => {
      this.Products = data;
      console.log(this.Products);
    });
  }
}
