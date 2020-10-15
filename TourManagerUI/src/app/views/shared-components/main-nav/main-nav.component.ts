import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-main-nav',
  templateUrl: './main-nav.component.html',
  styleUrls: ['./main-nav.component.less']
})
export class MainNavComponent implements OnInit {


  public currentState: StateButtons = StateButtons.UserInformation;
  public StateOfButtons = StateButtons;

  

  constructor() { }

  ngOnInit(): void {
  }

  public initialStateButtons(): void {

  }

  public menuClicked(stateCliked: StateButtons): void {

    this.currentState = stateCliked;

  }
}

export enum StateButtons {
  UserInformation, 
  Summary, 
  Venues, 
  Days
  
}
