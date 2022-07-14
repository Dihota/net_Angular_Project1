import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FooterComponent } from './Component/footer/footer.component';
import { LoguinComponent } from './Component/loguin/loguin.component';

const routes: Routes = [
  //Define la ruta de inicio de la pagina 
  {path: '', component: LoguinComponent}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
