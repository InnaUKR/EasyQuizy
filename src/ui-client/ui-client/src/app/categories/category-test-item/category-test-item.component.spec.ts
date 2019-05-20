import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CategoryTestItemComponent } from './category-test-item.component';

describe('CategoryTestItemComponent', () => {
  let component: CategoryTestItemComponent;
  let fixture: ComponentFixture<CategoryTestItemComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CategoryTestItemComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CategoryTestItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
