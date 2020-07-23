import { Component, OnInit } from '@angular/core';
import { Server } from '../../shared/models/server';


const SIMPLE_SERVERS_LIST = [
  { id: 1, name: 'serv name', isEnabled: true },
  { id: 2, name: 'serv name', isEnabled: false },
  { id: 3, name: 'serv name', isEnabled: true },
  { id: 4, name: 'serv name', isEnabled: true },
];

@Component({
  selector: 'section-helth',
  templateUrl: './section-helth.component.html',
  styleUrls: ['./section-helth.component.css']
})
export class SectionHelthComponent implements OnInit {

  constructor() { }

  servers: Server[] = SIMPLE_SERVERS_LIST;


  ngOnInit(): void {
  }

}
