import { Component, OnInit } from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';
import { Test } from '../../shared/models/test'
import { CategoriesService } from 'src/app/shared/services/categories.service';

@Component({
  selector: 'app-category-tests-list',
  templateUrl: './category-tests-list.component.html',
  styleUrls: ['./category-tests-list.component.scss']
})
export class CategoryTestsListComponent implements OnInit {
  public id: number;
  public testsList: Test[];

  constructor(
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private categoriesService: CategoriesService
  ) { }

  ngOnInit() {
    this.id = +this.activatedRoute.snapshot.params['id'];
    this.testsList = this.categoriesService.getTestsByCategoryId(this.id);
  }
  openTestyById(id){
    this.router.navigate(['/test', id]);
  }

}
