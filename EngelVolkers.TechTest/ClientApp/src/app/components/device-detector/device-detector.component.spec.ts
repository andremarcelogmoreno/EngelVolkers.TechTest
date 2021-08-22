import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DeviceDetectorComponent  } from './device-detector.component';

describe('DeviceDetectorComponent ', () => {
  let fixture: ComponentFixture<DeviceDetectorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [DeviceDetectorComponent  ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DeviceDetectorComponent);
    fixture.detectChanges();
  });
  
});
