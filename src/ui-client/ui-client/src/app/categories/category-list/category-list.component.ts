import { Component, OnInit } from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';
import {Category} from '../../shared/models/category';
import { CategoriesService } from 'src/app/shared/services/categories.service';

@Component({
  selector: 'app-category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.scss']
})
export class CategoryListComponent implements OnInit {
  breakpoint: number = 3;
  categoryList: Category[];

  constructor(
    private route:ActivatedRoute,
    private router:Router,
    public categoriesService: CategoriesService
  ) { }

  ngOnInit() {
    this.categoryList = this.categoriesService.getAllCategories();
  }

  openCategoryById(id) {
    this.router.navigate(['/category', id]);
  }

}
