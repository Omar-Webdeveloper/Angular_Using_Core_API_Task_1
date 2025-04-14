import { Component } from '@angular/core';
import { BackEndWithFrontEndService } from '../Service/back-end-with-front-end.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-delete-prdoduct',
  standalone: false,
  templateUrl: './delete-prdoduct.component.html',
  styleUrl: './delete-prdoduct.component.css'
})
export class DeletePrdoductComponent {
  constructor(
    private _Service: BackEndWithFrontEndService,
    private _route: ActivatedRoute // Ensure it's declared as private
  ) { }

  ngOnInit() {
    this.afterDeletingProduct();
  }
  id: any;
  afterDeletingProduct() {
    this.id = this._route.snapshot.paramMap.get('id'); // Access 'id' from route parameters
    this._Service.Delete_Product(this.id).subscribe(() => { alert("hello your gienus it didn't  show") } );
  }
}
