import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MainNavComponent } from './main-nav/main-nav.component';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';




@NgModule({
  declarations: [MainNavComponent],
  imports: [
    CommonModule,
    BrowserModule,
    RouterModule
  ],
  exports:[
    MainNavComponent    
  ]
})
export class SharedComponentsModule { }
