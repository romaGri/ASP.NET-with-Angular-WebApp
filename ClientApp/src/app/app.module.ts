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
@NgModule({
    imports: [BrowserModule, FormsModule, RouterModule.forRoot(appRoutes)],
    declarations: [AppComponent, SidebarComponent, NavbarComponent, SectionSalesComponent, SectionOrdersComponent, SectionHelthComponent],
    bootstrap: [AppComponent]
})
export class AppModule { }