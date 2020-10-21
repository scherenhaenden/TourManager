import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-property-input-formular',
  templateUrl: './property-input-formular.component.html',
  styleUrls: ['./property-input-formular.component.less']
})
export class PropertyInputFormularComponent implements OnInit {

  @Input() propertyName = '';
  @Input() propertyValue = '';
  @Input() type = '';
  @Output() propertyValueEmit: EventEmitter<string> =   new EventEmitter();

  constructor() { }

  ngOnInit(): void {
  }

  public updateValue($event: any): void {

    this.propertyValueEmit.emit(this.propertyValue);
  }

  public getType(): string {

    if(this.type !== '' ) {

      if(this.type === 'string') {

        return 'text';

      }

      //FIXME: Check this later
      console.log('unknown type', this.type);
      return this.type;

      
     

    }

    

    return 'text';
    

  }
}
