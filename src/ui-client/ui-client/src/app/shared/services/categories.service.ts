import { Injectable } from '@angular/core';
import { Category } from '../models/category';
import { Test } from '../models/test';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {
  categoriesList: Category[] = [
    {id:1, title: 'Программирование на C#', description: 'Тест проверяет знание языка программирования C#, акцентируя внимание на мотивации его конструкций и «подводных камнях» их применения.', img:'https://stepik.org/media/cache/images/courses/4143/cover_yTDYKMv/b6aef393839359a5cee4f6cf708006d8.png'},
    {id:2, title: 'C++', description: 'анный базовый курс повествует об основных средствах языка C++. Особое внимание уделяется обсуждению базовых принципов работы программ, а также процессу их компиляции. Курс далеко не исчерпывающий и покрывает лишь небольшую часть стандарта языка C++, однако мы постарались рассказать о наиболее важных возможностях этого языка.', img:'https://stepik.org/media/cache/images/courses/7/cover/d8851c5645ff85265fab55e0261653f6.png'},
    {id:3, title: 'Python: основы и применение', description: 'Курс посвящен базовым принципам языка Python и программирования в целом. Он хорошо подойдет тем, кто уже может писать простейшие программы на Python или тем, кто до этого программировал на других языках.', img:'https://stepik.org/media/cache/images/courses/512/cover/3d87c826a50de28f601334ad1ed28140.jpg'},
    {id:4, title: 'Базы данных', description: 'Data Structures - Niema Moshiri and Liz Izhikevich - 2016', img:'https://stepik.org/media/cache/images/courses/3203/cover/ea4748a2d17e74d340a25632a3f00d4f.jpg'},
    {id:5, title: 'JavaScript для начинающих', description: 'В данном курсе рассмотрены основы программирования на JavaScript а также некоторые инструменты и модели данных, необходимые для практического использования JavaScript.', img:'https://stepik.org/media/cache/images/courses/2223/cover_CjHmdwG/086357ce75cc9410abf16f8d2f0e824a.png'},
    {id:6, title: 'Web-технологии', description: 'Тест проверяет знание языка программирования C#, акцентируя внимание на мотивации его конструкций и «подводных камнях» их применения.', img:'https://stepik.org/media/cache/images/courses/154/cover/c2f8c6d2e5cb22ddff5ebb5c27a84ee2.png'},
    {id:7, title: 'JavaScript', description: 'анный базовый курс повествует об основных средствах языка C++. Особое внимание уделяется обсуждению базовых принципов работы программ, а также процессу их компиляции. Курс далеко не исчерпывающий и покрывает лишь небольшую часть стандарта языка C++, однако мы постарались рассказать о наиболее важных возможностях этого языка.', img:'https://stepik.org/media/cache/images/courses/1751/cover/665aa9c51d6127411cbecb35ba28e908.png'},
    {id:8, title: 'Линейная алгебра', description: 'Data Structures - Niema Moshiri and Liz Izhikevich - 2016', img:'https://stepik.org/media/cache/images/courses/2461/cover/5d9a810edcc141f80e661acc8666d816.png'},
    {id:9, title: 'Нейронные сети', description: 'В данном курсе рассмотрены основы программирования на JavaScript а также некоторые инструменты и модели данных, необходимые для практического использования JavaScript.', img:'https://stepik.org/media/cache/images/courses/401/cover/83b2346452fb9b1b2b920e3f3fe05b16.png'}
  ];
  testsList: Test[] = [
    {id:1, title: 'Основы SQL', description: 'Тест проверяет знание языка программирования C#, акцентируя внимание на мотивации его конструкций и «подводных камнях» их применения.', img:'https://stepik.org/media/cache/images/courses/51562/cover_8oe6HLQ/112ebb91680491df52d39db3c9126f4b.png'},
    {id:2, title: 'Основы проектирование', description: 'анный базовый курс повествует об основных средствах языка C++. Особое внимание уделяется обсуждению базовых принципов работы программ, а также процессу их компиляции. Курс далеко не исчерпывающий и покрывает лишь небольшую часть стандарта языка C++, однако мы постарались рассказать о наиболее важных возможностях этого языка.', img:'https://stepik.org/media/cache/images/courses/1240/cover/63775f675b8184901eb121b8091c823b.jpg'},
    {id:3, title: 'Нереляционные базы данных', description: 'Курс посвящен базовым принципам языка Python и программирования в целом. Он хорошо подойдет тем, кто уже может писать простейшие программы на Python или тем, кто до этого программировал на других языках.', img:'https://stepik.org/media/cache/images/courses/2586/cover/a59931ab9945859f0d702c1b647ddb6b.png'},
    {id:4, title: 'Базы данных', description: 'Data Structures - Niema Moshiri and Liz Izhikevich - 2016', img:'https://stepik.org/media/cache/images/courses/30058/cover/02c5fb8318b2eb6a97c2ef825d6a363e.png'},
    {id:5, title: 'Epic SQL', description: 'В данном курсе рассмотрены основы программирования на JavaScript а также некоторые инструменты и модели данных, необходимые для практического использования JavaScript.', img:'https://stepik.org/media/cache/images/courses/7432/cover/2cab3ae9b9fdd43c95d440aa3a8980fd.png'},
  ];
  constructor() { }

  getAllCategories(): Category[] {
    return this.categoriesList;
  }
  
  getTestsByCategoryId(id){
    return this.testsList;
  }
}
