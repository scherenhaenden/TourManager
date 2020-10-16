import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-property-input-formular',
  templateUrl: './property-input-formular.component.html',
  styleUrls: ['./property-input-formular.component.less']
})
export class PropertyInputFormularComponent implements OnInit {

  @Input() propertyName = '';
  @Input() propertyValue = '';
  @Output() propertyValueEmit: EventEmitter<string> =   new EventEmitter();

  constructor() { }

  ngOnInit(): void {
  }

  public updateValue($event: any): void {

    this.propertyValueEmit.emit(this.propertyValue);
  }
}