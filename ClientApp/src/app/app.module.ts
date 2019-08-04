import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CardComponent } from './card/card.component';
import { CardholderComponent } from './cardholder/cardholder.component';
import { DoclistComponent } from './doclist/doclist.component';
import { FeedComponent } from './feed/feed.component';
import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';
import { InnerheaderComponent } from './innerheader/innerheader.component';
import { LinkgroupComponent } from './linkgroup/linkgroup.component';
import { NbarComponent } from './nbar/nbar.component';
import { PostComponent } from './post/post.component';
import { SectionHomeComponent } from './sections/section-home/section-home.component';
import { SectionAboutComponent } from '././sections/section-about/section-about.component';
import { SectionSubjectComponent } from '././sections/section-subject/section-subject.component';
import { SectionEditorComponent } from '././sections/section-editor/section-editor.component';
import { SectionFeedComponent } from './sections/section-feed/section-feed.component';
import { SectionNotFoundComponent } from '././sections/section-not-found/section-not-found.component';

@NgModule({
  declarations: [
    AppComponent,
    CardComponent,
    CardholderComponent,
    DoclistComponent,
    FeedComponent,
    FooterComponent,
    HeaderComponent,
    InnerheaderComponent,
    LinkgroupComponent,
    NbarComponent,
    PostComponent,
    SectionHomeComponent,
    SectionAboutComponent,
    SectionSubjectComponent,
    SectionEditorComponent,
    SectionFeedComponent,
    SectionNotFoundComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
