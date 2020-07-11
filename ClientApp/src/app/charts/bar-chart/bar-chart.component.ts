import { Component, OnInit } from '@angular/core';

const SIMPLE_BARCHART_DATA: any[] = [
  { data: [33, 56, 43, 75, 32, 13, 55], label: 'Q1' },
  { data: [73, 46, 63, 35, 52, 63, 25], label: 'Q2' },
];

const SIMPLE_BARCHART_LABELS: string[] = ['W1', 'W2', 'W3', 'W4', 'W5', 'W6', 'W7'];


@Component({
  selector: 'bar-chart',
  templateUrl: './bar-chart.component.html',
  styleUrls: ['./bar-chart.component.css']
})
export class BarChartComponent implements OnInit {

  constructor() { }

  public barChartData: any[] = SIMPLE_BARCHART_DATA;
  public barChartLabels: string[] = SIMPLE_BARCHART_LABELS;
  public barChartLegend ='false';
  public barChartType = 'bar';
  public barChartOptions: any = {
    scaleShowVerticalsLines: 'false',
    responsive: 'true'
  };


  ngOnInit(): void {
  }

}
