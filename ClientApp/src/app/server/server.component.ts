import { Component, OnInit, Input } from '@angular/core';
import { Server } from '../shared/models/server';

@Component({
  selector: 'server',
  templateUrl: './server.component.html',
  styleUrls: ['./server.component.css']
})
export class ServerComponent implements OnInit {

  constructor() { }

  color : string;
  buttonText : string;

  @Input() serverInput : Server;

  ngOnInit(): void {
    this.setServerAction(this.serverInput.isEnabled);
  }

  setServerAction(isEnabled : boolean){
    if(isEnabled){
      this.serverInput.isEnabled = true;
      this.color = '#66BBA6';
      this.buttonText = 'Shut Down';
    } else {
      this.serverInput.isEnabled = false;
      this.color = '#ff6b6b';
      this.buttonText = 'Start';
    }
  }

  toggleStatus(onlineStatus: boolean){
    console.log(this.serverInput.name, ':', onlineStatus);
    this.setServerAction(!onlineStatus);
  }

  

}
