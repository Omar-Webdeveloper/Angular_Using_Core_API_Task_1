import { Component } from '@angular/core';
import { BackEndWithFrontEndService } from '../Service/back-end-with-front-end.service';

@Component({
  selector: 'app-show-all-categories',
  standalone: false,
  templateUrl: './show-all-categories.component.html',
  styleUrl: './show-all-categories.component.css'
})
export class ShowAllCategoriesComponent {
  constructor(private _Service: BackEndWithFrontEndService) { }
  ngOnInit() {
    this.Get_Categories();
  }

  Categories: any = [];



  Get_Categories() {
    
    this._Service.Get_Categories().subscribe((data: any) => {
      this.Categories = data;
      console.log(this.Categories);
    });

  }




}
