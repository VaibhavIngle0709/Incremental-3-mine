import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailsteamComponent } from './detailsteam.component';

describe('DetailsteamComponent', () => {
  let component: DetailsteamComponent;
  let fixture: ComponentFixture<DetailsteamComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailsteamComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DetailsteamComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
