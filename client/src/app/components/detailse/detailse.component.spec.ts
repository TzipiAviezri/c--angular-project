import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailseComponent } from './detailse.component';

describe('DetailseComponent', () => {
  let component: DetailseComponent;
  let fixture: ComponentFixture<DetailseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DetailseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
