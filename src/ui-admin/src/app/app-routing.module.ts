
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { UsersComponent } from './sections/users/users.component';
import { CategoriesComponent } from './sections/categories/categories.component';
import { QuizzesComponent } from './sections/quizzes/quizzes.component';

const routes: Routes = [
  {path: 'users', component: UsersComponent},
  {path: 'categories', component: CategoriesComponent},
  {path: 'quizzes', component: QuizzesComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
