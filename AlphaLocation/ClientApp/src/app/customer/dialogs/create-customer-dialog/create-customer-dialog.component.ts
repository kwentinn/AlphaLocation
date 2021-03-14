import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Customer } from '../../models/customer.model';
import { SimpleDate } from '../../models/simple-date.model';
import { CustomerService } from '../../services/customer.service';
import { MatDialogRef } from '@angular/material/dialog';

// Depending on whether rollup is used, moment needs to be imported differently.
// Since Moment.js doesn't have a default export, we normally need to import using the `* as`
// syntax. However, rollup creates a synthetic default module and we thus need to import it using
// the `default as` syntax.
import * as _moment from 'moment';

const moment = _moment;

@Component({
  selector: 'app-create-customer-dialog',
  templateUrl: './create-customer-dialog.component.html',
  styleUrls: ['./create-customer-dialog.component.css']
})
export class CreateCustomerDialogComponent implements OnInit {

  @Output()
  public customerCreated = new EventEmitter();

  formGroup: FormGroup;
  titleAlert: string;

  constructor(
    private formBuilder: FormBuilder,
    private readonly customerService: CustomerService,
    private readonly dialogRef: MatDialogRef<CreateCustomerDialogComponent>,
  ) { }

  ngOnInit() {
    this.createForm();
  }

  private createForm(): void {
    this.formGroup = this.formBuilder.group({
      'gender': [null, [Validators.required]],
      'firstname': [null, [Validators.required]],
      'lastname': [null, [Validators.required]],
      'birthdate': null,
      'comment': null,
    });
  }

  submit(): void {

    const customer: Customer = {
      gender: +this.formGroup.value.gender,
      firstname: this.formGroup.value.firstname,
      lastname: this.formGroup.value.lastname,
      comment: this.formGroup.value.comment,
      birthdate: this.getBirthdate(this.formGroup.value.birthdate)
    };

    this.customerService.CreateCustomer(customer)
      .subscribe({ next: _ => this.emitCustomerCreatedEvent() });
  }
  emitCustomerCreatedEvent(): void {
    this.dialogRef.close(null);
    this.customerCreated.emit('customer-created');
  }
  private getBirthdate(date: Date): SimpleDate {
    if (!date) {
      return null;
    }
    const momentDate = moment(date);
    return {
      year: momentDate.year(),
      month: momentDate.month() + 1,
      day: momentDate.day()
    };
  }
}
