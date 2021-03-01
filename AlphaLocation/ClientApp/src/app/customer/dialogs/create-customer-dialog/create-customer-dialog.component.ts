import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-create-customer-dialog',
  templateUrl: './create-customer-dialog.component.html',
  styleUrls: ['./create-customer-dialog.component.css']
})
export class CreateCustomerDialogComponent implements OnInit {


  formGroup: FormGroup;
  constructor(private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.createForm();
  }
  private createForm(): void {
    this.formGroup = this.formBuilder.group({
      'gender' : [null, [Validators.required]],
      'firstname' : [null, [Validators.required]],
      'lastname' : [null, [Validators.required]],
      'comment' : [null],
    });
  }

}
