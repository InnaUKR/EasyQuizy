import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { from } from 'rxjs';


const routes: Routes = [
  { path: "", pathMatch: "full", redirectTo: "category" },
  {
    path: 'category',
    loadChildren: './categories/categories.module#CategoriesModule'
  },
  {
    path: 'test',
    loadChildren: './tests/tests.module#TestsModule'
  },
  { path: '**', redirectTo: "category" }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }


