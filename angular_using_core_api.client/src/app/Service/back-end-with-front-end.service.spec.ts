import { TestBed } from '@angular/core/testing';

import { BackEndWithFrontEndService } from './back-end-with-front-end.service';

describe('BackEndWithFrontEndService', () => {
  let service: BackEndWithFrontEndService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BackEndWithFrontEndService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
