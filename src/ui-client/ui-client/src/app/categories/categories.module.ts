import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CategoriesRoutingModule } from './categories-routing.module';
import { CategoryListComponent } from './category-list/category-list.component';
import { CategoryItemComponent } from './category-item/category-item.component';

import {MatGridListModule} from '@angular/material/grid-list';
import {MatCardModule} from '@angular/material/card';
import { CategoryTestsListComponent } from './category-tests-list/category-tests-list.component';
import { CategoriesComponent } from './categories.component';
import { CategoryTestItemComponent } from './category-test-item/category-test-item.component';

@NgModule({
  declarations: [CategoryListComponent, CategoryItemComponent, CategoryTestsListComponent, CategoriesComponent, CategoryTestItemComponent],
  imports: [
    CommonModule,
    CategoriesRoutingModule,
    MatGridListModule,
    MatCardModule
  ]
})
export class CategoriesModule { }
