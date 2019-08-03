import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LinkgroupComponent } from './linkgroup.component';

describe('LinkgroupComponent', () => {
  let component: LinkgroupComponent;
  let fixture: ComponentFixture<LinkgroupComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LinkgroupComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LinkgroupComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
