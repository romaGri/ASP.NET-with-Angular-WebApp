import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'pie-chart',
  templateUrl: './pie-chart.component.html',
  styleUrls: ['./pie-chart.component.css']
})
export class PieChartComponent implements OnInit {

  constructor() { }

  public pieChartData: number[] = [250, 430 , 120];
  public pieChartLabels: string[] = ['BrGTU', 'Logistic', 'Service'];
  public pieChartColors: any[] = [
    {
      backgroundColor: ['#D33514','#E2F100','#00C2F1'],
      borderColor: '#111'
    }
  ];
  public pieChartType = 'pie';
  ngOnInit(): void {
  }

}
