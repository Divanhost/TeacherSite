import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SectionNotFoundComponent }   from '../app/sections/section-not-found/section-not-found.component';
import { SectionHomeComponent }   from '../app/sections/section-home/section-home.component';
import { SectionAboutComponent }   from '../app/sections/section-about/section-about.component';
import { SectionSubjectComponent }   from '../app/sections/section-subject/section-subject.component';
import { SectionEditorComponent }   from '../app/sections/section-editor/section-editor.component';
import { SectionFeedComponent }   from '../app/sections/section-feed/section-feed.component';


const appRoutes: Routes =[
  { path: '', component: SectionHomeComponent},
  { path: 'home',redirectTo:'',pathMatch:'full'},
  { path: 'about', component: SectionAboutComponent},
  { path: 'subject', component: SectionSubjectComponent},
  { path: 'editor', component:SectionEditorComponent},
  { path: 'feed', component: SectionFeedComponent},
  { path: '**', component: SectionNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(appRoutes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
