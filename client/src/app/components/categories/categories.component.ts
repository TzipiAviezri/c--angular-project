import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { category } from 'src/app/classes/category';
import { CategoriesService } from 'src/app/services/categories.service';


@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.css']
})
export class CategoriesComponent implements OnInit {

  constructor(public categoryService: CategoriesService) { }

  categoryList: Array<category> = [];
  categoryForm: FormGroup  = new FormGroup({})

  ngOnInit(): void {
    this.categoryService.getAll().subscribe(x => { this.categoryList = x })
    this.createForm();
  }
  createForm() {
    this.categoryForm = new FormGroup({
    name: new FormControl([Validators.required, Validators.pattern("^[A-Z]{1}[a-z]+$"), Validators.minLength(2)])
    })}
  save() {

  }
}






//     
//     this.fillForm();
//   }

//   fillForm()
//   {
//     //formGroup: אובייקט המשקף את מבנה הטופס בקוד
//     //מקבל אובייקט המכיל שדות עבור כל השדות שיופיעו בטופס
//     //formControl: אובייקט המייצג שדה שמופיע בטופס
//     //מקבל ערך ברירת מחדל ומערך עם בדיקות התקינות לשדה זה

//     if (!this.isEdit)
//     {
//       this.studentForm = new FormGroup({
//         studentName:new FormControl("", [Validators.required, Validators.minLength(2),
//           Validators.pattern("^[A-Z]{1}[a-z]+$"),
//            this.myinvalid.bind(this)]),
//         marksAvg:new FormControl(0, [Validators.min(50)]),
//         //כאשר קיים אובייקט בתוך אובייקט
//         //נייצג אותו ע"י formGroup
//         address:new FormGroup({
//           street:new FormControl(),
//           city:new FormControl()
//         })
//       });
//     }
//     else{
//       this.studentForm = new FormGroup({
//         studentName:new FormControl(this.currentStudent.studentName, [Validators.required, Validators.minLength(2),
//           Validators.pattern("^[A-Z]{1}[a-z]+$"),
//            this.myinvalid.bind(this)]),
//         marksAvg:new FormControl(this.currentStudent.marksAvg, [Validators.min(50)]),
//         //כאשר קיים אובייקט בתוך אובייקט
//         //נייצג אותו ע"י formGroup
//         address:new FormGroup({
//           street:new FormControl(this.currentStudent.address.street),
//           city:new FormControl(this.currentStudent.address.city)
//         })
//       });
//     }

//   }

//   //פונ' אלו נדרשות כדי לאפשר ל html
//   //לגשת לבדיקות התקינות שהוגדרו עבור שדה זה
//   get studentName()
//   {
//     return this.studentForm.get("studentName");
//   }

//   get marksAvg()
//   {
//     return this.studentForm.get("marksAvg");
//   }

//   onSave()
//   {
//     //value: תכונה זו מכילה את כל הנתונים של הטופס
//     //לכן רצוי לתת לאובייקט המשקף את הטופס
//     //שמות של שדות התואמים לאובייקט המקורי
//     let newStudent = this.studentForm.value;
//     if (!this.isEdit)
//       this.studentServ.addStudent(newStudent);
//     else{
//       this.studentServ.updateStudent(newStudent, this.currentStudent.id);
//       this.isEdit = false;
//       this.fillForm();
//       this.students = this.studentServ.getList();
//     }
//   }

//   //פונ' זו מבצעת בדיקת תקינות מותאמת אישית
//   myinvalid(control: FormControl)
//   {
//     if (this.nameList.find(x=> x == control.value))
//     //if (control.value == "abcd")
//     //invalidname: שם של בדיקת התקינות כפי שתופיע ב html
//     //השם אינו שמור
//       return {invalidname:true};
//     else
//       return null;
//   }

//   //[0-9]{9} -> /d{9}
//   // /w{15}
//   // /w+([-.']/w+)*@/w+([-.]/w+)/.(com|gov.il|co.il)

//   onEdit(id)
//   {
//     this.currentStudent = this.students.find(x => x.id == id );
//     if (this.currentStudent != null)
//     {
//       this.isEdit = true;
//       this.fillForm();
//     }
//   }

// }



