import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SectionSubjectComponent } from './section-subject.component';

describe('SectionSubjectComponent', () => {
  let component: SectionSubjectComponent;
  let fixture: ComponentFixture<SectionSubjectComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SectionSubjectComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SectionSubjectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
