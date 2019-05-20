import { Component, OnInit } from '@angular/core';
import { Answer } from 'src/app/shared/models/answer';
import { FormBuilder, FormGroup, FormArray, FormControl } from '@angular/forms';
import { Question } from 'src/app/shared/models/question';
import { UserAnswer } from 'src/app/shared/models/userAnswer';
import {ActivatedRoute, Router} from '@angular/router';
import { QuestionsService } from 'src/app/shared/services/questions.service';

@Component({
  selector: 'app-questions',
  templateUrl: './questions.component.html',
  styleUrls: ['./questions.component.scss']
})
export class QuestionsComponent implements OnInit {
  public id: number;
  public test_id: number;
  public questionsList: Question[];
  public userAnswersList: UserAnswer[];
  public currentQuestion: Question;
  public arr: number=0;
  public chosenAnswers: number[];
  public questionsForm: FormGroup;
  
  constructor(
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private questionsService: QuestionsService
  ) { }
  
  
  ngOnInit() {
    this.id = this.activatedRoute.snapshot.params['question_id'];
    this.test_id = this.activatedRoute.snapshot.params['test_id'];
    this.questionsList = this.questionsService.getQuestions(this.test_id)
    this.currentQuestion = this.questionsList[this.id-1];
      this.questionsForm = new FormGroup({
        answers: new FormControl()
      });
  }

  setDefaultValues() {
    if (this.currentQuestion.userAnswer && this.currentQuestion.userAnswer.answer_ids) {
      const answer = this.currentQuestion.userAnswer.answer_ids[0];
      this.questionsForm.patchValue({answers: answer});
    } else{
      this.questionsForm.patchValue({answers: new FormControl()});
    }
  }

  changeCurrentQuestionById(id){
    this.currentQuestion.userAnswer= new UserAnswer();
    const ids = this.questionsForm.get('answers').value;
    if (ids != null){
      this.currentQuestion.userAnswer.question_id = this.id;
      this.currentQuestion.userAnswer.answer_ids= [this.questionsForm.get('answers').value];
    }
    this.id = id;
    this.currentQuestion = this.questionsList[this.id-1];
    this.setDefaultValues();
    this.router.navigate(['/test', this.test_id,'questions', id]);
  }
}
