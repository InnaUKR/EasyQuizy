import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TestsRoutingModule } from './tests-routing.module';
import { TestDescriptionComponent } from './test-description/test-description.component';
import { QuestionsComponent } from './questions/questions.component';
import {MatListModule} from '@angular/material/list';
import {MatCheckboxModule} from '@angular/material/checkbox';
import { MatRadioModule } from '@angular/material';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SingleQuestionComponent } from './single-question/single-question.component';
import { RezultComponent } from './rezult/rezult.component';


@NgModule({
  declarations: [TestDescriptionComponent, QuestionsComponent, SingleQuestionComponent, RezultComponent],
  imports: [
    CommonModule,
    TestsRoutingModule,
    MatListModule,
    MatCheckboxModule,
    MatRadioModule,
    FormsModule, 
    ReactiveFormsModule
  ]
})
export class TestsModule { }
