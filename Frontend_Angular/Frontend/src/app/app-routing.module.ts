import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FooterComponent } from './Component/footer/footer.component';
import { LoguinComponent } from './Component/loguin/loguin.component';
import { RegistroComponent } from './pages/registro/registro.component';

const routes: Routes = [
  //Define la ruta de inicio de la pagina 
  {path: '', component: LoguinComponent},
  {path: 'registro' , component: RegistroComponent}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
