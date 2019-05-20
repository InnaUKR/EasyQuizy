import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RezultComponent } from './rezult.component';

describe('RezultComponent', () => {
  let component: RezultComponent;
  let fixture: ComponentFixture<RezultComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RezultComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RezultComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
