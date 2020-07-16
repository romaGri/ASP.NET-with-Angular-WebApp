import { Component, OnInit } from '@angular/core';

import { Order } from '../../shared/models/order';
@Component({
  selector: 'section-orders',
  templateUrl: './section-orders.component.html',
  styleUrls: ['./section-orders.component.css']
})


export class SectionOrdersComponent implements OnInit {

  constructor() { }

  orders: Order[] = [
    {
      id: 1, customer:
        { id: 1, name: 'TAFT', email: 'mailexample@example.com', state: 'CO' },
      total: 5600, placed: new Date(2020, 7, 12,), fulfilled: new Date(2020, 7, 13)
    },
    {
      id: 2, customer:
        { id: 2, name: 'TAFT', email: 'mailexample@example.com', state: 'CO' },
      total: 5600, placed: new Date(2020, 7, 12,), fulfilled: new Date(2020, 7, 13)
    },
    {
      id: 3, customer:
        { id: 3, name: 'TAFT', email: 'mailexample@example.com', state: 'CO' },
      total: 5600, placed: new Date(2020, 7, 12,), fulfilled: new Date(2020, 7, 13)
    },
    {
      id: 4, customer:
        { id: 4, name: 'TAFT', email: 'mailexample@example.com', state: 'CO' },
      total: 5600, placed: new Date(2020, 7, 12,), fulfilled: new Date(2020, 7, 13)
    },
    {
      id: 5, customer:
        { id: 5, name: 'TAFT', email: 'mailexample@example.com', state: 'CO' },
      total: 5600, placed: new Date(2020, 7, 12,), fulfilled: new Date(2020, 7, 13)
    },
    {id: 6, customer: 
      {id: 6, name:'TAFT', email: 'mailexample@example.com', state: 'CO'},
      total: 5600, placed: new Date(2020, 7, 12,), fulfilled: new Date(2020 ,7, 13)},


  ];

  ngOnInit(): void {
  }

}
