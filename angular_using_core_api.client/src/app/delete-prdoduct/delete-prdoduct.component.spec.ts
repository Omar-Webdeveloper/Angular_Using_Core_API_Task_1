import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeletePrdoductComponent } from './delete-prdoduct.component';

describe('DeletePrdoductComponent', () => {
  let component: DeletePrdoductComponent;
  let fixture: ComponentFixture<DeletePrdoductComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DeletePrdoductComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DeletePrdoductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
