import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Customer } from '../../models/customer.model';
import { SimpleDate } from '../../models/simple-date.model';
import { CustomerService } from '../../services/customer.service';

@Component({
  selector: 'app-create-customer-dialog',
  templateUrl: './create-customer-dialog.component.html',
  styleUrls: ['./create-customer-dialog.component.css']
})
export class CreateCustomerDialogComponent implements OnInit {


  formGroup: FormGroup;
  titleAlert: string;
  constructor(
    private formBuilder: FormBuilder,
    private readonly customerService: CustomerService,
  ) { }

  ngOnInit() {
    this.createForm();
  }

  private createForm(): void {
    this.formGroup = this.formBuilder.group({
      'gender' : [null, [Validators.required]],
      'firstname' : [null, [Validators.required]],
      'lastname' : [null, [Validators.required]],
      'birthdate' : null,
      'comment' : null,
    });
  }

  onSubmit(): void {

    const customer: Customer = {
      gender: +this.formGroup.value.gender,
      firstname: this.formGroup.value.firstname,
      lastname: this.formGroup.value.lastname,
      comment: this.formGroup.value.comment,
      birthdate: this.getBirthdate(this.formGroup.value.birthdate)
    };

    this.customerService.CreateCustomer(customer)
      .subscribe();
  }
  private getBirthdate(date: Date): SimpleDate {
    if (!date) {
      return null;
    }
    return {
      year: date.getFullYear(),
      month: date.getMonth(),
      day: date.getDay()
    };
  }
}
