import { TestBed } from '@angular/core/testing';

import { Google.TranslationService } from './google.translation.service';

describe('Google.TranslationService', () => {
  let service: Google.TranslationService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Google.TranslationService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
