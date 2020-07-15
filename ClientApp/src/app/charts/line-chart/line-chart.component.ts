import { Component, OnInit } from '@angular/core';
import { LINE_CHART_COLORS } from '../../shared/chart.colors'

const LINE_CHART_SIMPLE_DATA: any[] = [
  { data: [32, 45, 64, 23, 54, 12], label: 'Analysis' },
  { data: [42, 38, 61, 33, 24, 52], label: 'Recognition' },
  { data: [39, 34, 54, 27, 64, 42], label: 'Forecasting' }
];

const LINE_CHART_LABELS: string[] = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun'];

@Component({
  selector: 'line-chart',
  templateUrl: './line-chart.component.html',
  styleUrls: ['./line-chart.component.css']
})
export class LineChartComponent implements OnInit {

  constructor() { }

  lineChartData = LINE_CHART_SIMPLE_DATA;
  lineChartLabels = LINE_CHART_LABELS;
  lineChartOptions: any[] = [
    {
      responsive: 'true',
      maintainAspectRatio: 'false'
    }
  ];
  lineChartLegend: 'true';
  lineChartColors: any[] = LINE_CHART_COLORS;

  lineChartType = 'line';


  ngOnInit(): void {
  }

}
