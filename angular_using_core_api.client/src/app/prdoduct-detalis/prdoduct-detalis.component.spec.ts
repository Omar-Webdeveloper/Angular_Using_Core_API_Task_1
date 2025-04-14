import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PrdoductDetalisComponent } from './prdoduct-detalis.component';

describe('PrdoductDetalisComponent', () => {
  let component: PrdoductDetalisComponent;
  let fixture: ComponentFixture<PrdoductDetalisComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [PrdoductDetalisComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PrdoductDetalisComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
