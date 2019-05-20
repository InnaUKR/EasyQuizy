import { Component } from '@angular/core';
import { Category } from './shared/models/category';
import { CategoriesService } from './shared/services/categories.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'ui-client';


  ngOnInit() {
   
  }
    
}

