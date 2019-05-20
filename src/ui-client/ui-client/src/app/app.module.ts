import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { MatIconModule } from '@angular/material';
import { MatToolbarModule, MatButtonModule, MatSidenavModule, MatInputModule, MatCardModule, MatGridListModule, MatListModule } from '@angular/material';
import { LayoutModule } from '@angular/cdk/layout';

import { AppComponent } from './app.component';
import { FooterComponent } from './footer/footer.component';
import { SidenavComponent } from './sidenav/sidenav.component';
//import { SingleQuestionComponent } from './questions/single-question/single-question.component';
//import { CategoryComponent } from './categories/';

@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    SidenavComponent,
   // SingleQuestionComponent,
    //CategoryComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatToolbarModule,
    
    MatListModule,
    MatIconModule,


    //MatMenuModule,

    MatSidenavModule,
    LayoutModule,
    MatButtonModule, 
    MatInputModule,
    MatCardModule,
    MatGridListModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
