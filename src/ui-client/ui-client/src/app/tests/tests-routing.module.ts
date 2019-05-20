import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {TestDescriptionComponent} from './test-description/test-description.component'
import { QuestionsComponent } from './questions/questions.component';
import { RezultComponent } from './rezult/rezult.component';

const routes: Routes = [
  { path: '',
  children: [
    {
      path: ':test_id',
      component: TestDescriptionComponent
    },
    {
      path: ':test_id/result',
      component: RezultComponent
    },
    {
      path: ':test_id/questions/:question_id',
      component: QuestionsComponent,
    }
  ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TestsRoutingModule { }
