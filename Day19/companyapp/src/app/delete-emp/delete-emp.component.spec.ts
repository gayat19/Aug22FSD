import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteEmpComponent } from './delete-emp.component';

describe('DeleteEmpComponent', () => {
  let component: DeleteEmpComponent;
  let fixture: ComponentFixture<DeleteEmpComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DeleteEmpComponent]
    });
    fixture = TestBed.createComponent(DeleteEmpComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
