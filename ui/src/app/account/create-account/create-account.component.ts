import { Component } from '@angular/core';
import {FormBuilder, Validators} from "@angular/forms";
import {AccountService} from "../account.service";

@Component({
  selector: 'app-create-account',
  templateUrl: './create-account.component.html',
  styleUrls: ['./create-account.component.scss']
})
export class CreateAccountComponent {

  registerForm = this.formBuilder.group({
    companyName: ['', Validators.required],
    email: ['', [Validators.required, Validators.email]],
  })
  constructor(private formBuilder: FormBuilder,
              private service: AccountService) { }

  registerCompany(): void {
    if(this.registerForm.invalid){
      return;
    }
    const { companyName, email } = this.registerForm.value;

    this.service.sendRegistrationEmail(email!, companyName!).subscribe();
  }
}
