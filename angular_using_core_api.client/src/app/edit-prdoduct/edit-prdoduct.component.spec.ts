import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditPrdoductComponent } from './edit-prdoduct.component';

describe('EditPrdoductComponent', () => {
  let component: EditPrdoductComponent;
  let fixture: ComponentFixture<EditPrdoductComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditPrdoductComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditPrdoductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
