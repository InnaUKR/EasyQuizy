import { Injectable } from '@angular/core';
import { Answer } from '../models/answer';
import { Question } from '../models/question';

@Injectable({
  providedIn: 'root'
})
export class QuestionsService {
  answersList1: Answer[] = [
    {id: 1, content: 'столбец в таблице, набор возможных значений атрибута'},
    {id: 2, content: 'строка в таблице, набор значений атрибутов'},
    {id: 3, content: 'машинный строй из двух или большего числа транспортных средств'},
    {id: 4, content: 'набор допустимых значений атрибута'}
  ];

  answersList2: Answer[] = [
    {id: 1, content: 'Ограничения целостности'},
    {id: 2, content: 'Манипуляционная часть'},
    {id: 3, content: 'Процедурная часть'},
    {id: 4, content: 'Структурная часть'}
  ];

  answersList3: Answer[] = [
  {id: 1, content: 'Нет'},
  {id: 2, content: 'Да'}
  ];
 
  answersList4: Answer[] = [
  {id: 1, content: 'Существует вычислимая функция, позволяющая для каждого значения X получить значение Y'},
  {id: 2, content: 'Каждому значению X соответствует одно или несколько значений Y'},
  {id: 3, content: 'Любому значению Х соответствует ровно одно значение Y'}
  ];

  answersList5: Answer[] = [
    {id: 1, content: 'Транзитивные'},
    {id: 2, content: 'Вероятностные'},
    {id: 3, content: 'Нефункциональные'}
  ];

  questionsList: Question[] =[
    {id: 1, text: 'Что такое кортеж в терминологии баз данных?', answersList: this.answersList1},
    {id: 2, text: 'Укажите, пожалуйста, какое из описаний не относится к определению модели данных?', answersList: this.answersList2},
    {id: 3, text: 'Укажите, пожалуйста, могут ли в реляционной БД храниться данные, тип которых не определен?', answersList: this.answersList3},
    {id: 4, text: 'Пусть дано отношение R, в котором имеются атрибуты X и Y. Укажите, пожалуйста, какие требования соответствуют определению функциональной зависимости?', answersList: this.answersList4},
    {id: 5, text: 'Укажите, пожалуйста, какие классы функциональных зависимостей между атрибутами отношений исключаются при приведении схемы БД к третьей нормальной форме?', answersList: this.answersList5}
  ];

  constructor() { }
  getQuestions(test_id): Question[]{
    return this.questionsList;
  }

}
