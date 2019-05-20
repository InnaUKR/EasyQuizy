import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CategoryTestsListComponent } from './category-tests-list.component';

describe('CategoryTestsListComponent', () => {
  let component: CategoryTestsListComponent;
  let fixture: ComponentFixture<CategoryTestsListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CategoryTestsListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CategoryTestsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
