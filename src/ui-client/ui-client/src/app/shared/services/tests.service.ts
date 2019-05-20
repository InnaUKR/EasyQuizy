import { Injectable } from '@angular/core';
import { Test } from '../models/test';

@Injectable({
  providedIn: 'root'
})
export class TestsService {
  test: Test = {
    id: 1,
    title: 'Базы данных',
    description: "Тест базы данных проверяет умение создания систем обработки структурированных данных, подходы к обработке информации, развитие моделей данных и систем управления данными.\
                  Основу курса составляет изучение и применение в типовых ситуациях средств SQL для обработки данных в SQL-СУБД. Выполнение практических задач в рамках курса предполагает использование СУБД MySQL.\
                  Помимо базовой части курса рассматриваются вопросы работы с SQL-базами данных в приложениях, описывается концепция ORM и вводятся определения, описываются области применения NoSQL-систем.",
    img: 'https://stepik.org/media/cache/images/courses/30058/cover/02c5fb8318b2eb6a97c2ef825d6a363e.png'
  }
  constructor() { }

  getTestById(id): Test{
    return this.test;
  }
}
