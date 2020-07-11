import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SectionHelthComponent } from './section-helth.component';

describe('SectionHelthComponent', () => {
  let component: SectionHelthComponent;
  let fixture: ComponentFixture<SectionHelthComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SectionHelthComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SectionHelthComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
