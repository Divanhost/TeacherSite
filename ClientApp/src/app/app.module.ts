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
    PostComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
