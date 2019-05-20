import { Component, OnInit } from '@angular/core';
import { Category } from '../shared/models/category';
import { CategoriesService } from '../shared/services/categories.service';

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.sass']
})
export class SidenavComponent implements OnInit {
  public categoryList: Category[];
  constructor(
    private categoriesService: CategoriesService
  ) { }

  ngOnInit() {
    this.categoryList = this.categoriesService.getAllCategories();
  }

}
