import { Component } from '@angular/core';
import { BackEndWithFrontEndService } from '../Service/back-end-with-front-end.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-add-product',
  standalone: false,
  templateUrl: './add-product.component.html',
  styleUrl: './add-product.component.css'
})
export class AddProductComponent {
  constructor(
    private _Service: BackEndWithFrontEndService,
    private _route: ActivatedRoute // Ensure it's declared as private
  ) { }

  ngOnInit() {
  }
  afterAddingProduct(data: any) {
    this._Service.Post_Product(data).subscribe(() => { alert("Addes Like You the Moon ")});
  }
}
