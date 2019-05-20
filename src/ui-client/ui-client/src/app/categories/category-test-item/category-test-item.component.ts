import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-category-test-item',
  templateUrl: './category-test-item.component.html',
  styleUrls: ['./category-test-item.component.scss']
})
export class CategoryTestItemComponent implements OnInit {
  @Input() test: number
  constructor() { }

  ngOnInit() {
  }

}
