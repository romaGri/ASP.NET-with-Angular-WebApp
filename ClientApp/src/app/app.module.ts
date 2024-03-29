import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { appRoutes } from './routes'
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { NavbarComponent } from './navbar/navbar.component';
import { SectionSalesComponent } from './sections/section-sales/section-sales.component';
import { SectionOrdersComponent } from './sections/section-orders/section-orders.component';
import { SectionHelthComponent } from './sections/section-helth/section-helth.component';
import { from } from 'rxjs';
import { BarChartComponent } from './charts/bar-chart/bar-chart.component';
import { LineChartComponent } from './charts/line-chart/line-chart.component';
import { PieChartComponent } from './charts/pie-chart/pie-chart.component';
import { ChartsModule } from 'ng2-charts';
import { ServerComponent } from './server/server.component';
@NgModule({
    imports: [BrowserModule, FormsModule, RouterModule.forRoot(appRoutes), ChartsModule],
    declarations: [AppComponent, SidebarComponent, NavbarComponent, SectionSalesComponent, SectionOrdersComponent, SectionHelthComponent, BarChartComponent, LineChartComponent, PieChartComponent, ServerComponent],
    bootstrap: [AppComponent]
})
export class AppModule { }