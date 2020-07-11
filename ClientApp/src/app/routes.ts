import { Routes } from '@angular/router';
import { SectionSalesComponent } from './sections/section-sales/section-sales.component';
import { SectionOrdersComponent } from './sections/section-orders/section-orders.component';
import { SectionHelthComponent } from './sections/section-helth/section-helth.component';

export const appRoutes: Routes = [
    { path: 'sales', component: SectionSalesComponent },
    { path: 'orders', component: SectionOrdersComponent },
    { path: 'helth', component: SectionHelthComponent },

    //def path
    { path: '', redirectTo: '/sales', pathMatch: 'full' }

]; 