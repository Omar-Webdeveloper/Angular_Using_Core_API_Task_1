import { Component } from '@angular/core';
import { BackEndWithFrontEndService } from '../Service/back-end-with-front-end.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-edit-prdoduct',
  standalone: false,
  templateUrl: './edit-prdoduct.component.html',
  styleUrl: './edit-prdoduct.component.css'
})
export class EditPrdoductComponent {
  constructor(
    private _Service: BackEndWithFrontEndService,
    private _route: ActivatedRoute // Ensure it's declared as private
  ) { }

  ngOnInit() {
  }
  id: any;
  afterEditingProduct(data: any) {
    this.id = this._route.snapshot.paramMap.get('id'); // Access 'id' from route parameters
    this._Service.Put_Product(this.id, data).subscribe(() => {alert("hello your gienus") });

  }
}
