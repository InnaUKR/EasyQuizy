import { Component, OnInit } from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';
import { TestsService } from 'src/app/shared/services/tests.service';
import { Test } from 'src/app/shared/models/test';

@Component({
  selector: 'app-test-description',
  templateUrl: './test-description.component.html',
  styleUrls: ['./test-description.component.scss']
})
export class TestDescriptionComponent implements OnInit {
  public test_id: number;
  public test: Test;
  constructor(
    private activatedRoute:ActivatedRoute,
    private router:Router,
    private testsService: TestsService
  ) { }

  ngOnInit() {
    this.test_id= this.activatedRoute.snapshot.params['test_id'];
    this.test = this.testsService.getTestById(this.test_id);
  }

  startTest(){
    this.router.navigate(['/test', this.test_id,'questions', 1]);
  }

}
